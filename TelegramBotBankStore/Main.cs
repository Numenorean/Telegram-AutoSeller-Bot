using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using Authorization.Logic;
using Authorization.Logic.DbContext;
using Authorization.LogicUsersPermission;
using Authorization.UsersPermission.Forms;
using CommonWrapper;
using FlatUI;
using Info.Blockchain.API.Client;
using Info.Blockchain.API.Models;
using Info.Blockchain.API.Wallet;
using log4net;
using log4net.Config;
using QiwiApi;
using QiwiApi.Models;
using QiwiApi.Models.Enums;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramBotBankStore.Domain;
using TelegramBotBankStore.Domain.DbContext;
using TelegramBotBankStore.Languages;
using TelegramBotBankStore.Properties;
using Yandex.Money.Api.Sdk.Requests;
using Yandex.Money.Api.Sdk.Responses;
using Yandex.Money.Api.Sdk.Utils;

namespace TelegramBotBankStore
{
	// Token: 0x02000023 RID: 35
	public partial class Main : Form
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002312 File Offset: 0x00000512
		private decimal _discountBTC
		{
			get
			{
				return Settings.Default.DiscountBTC;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000231E File Offset: 0x0000051E
		private decimal _discountLTC
		{
			get
			{
				return Settings.Default.DiscountLTC;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000232A File Offset: 0x0000052A
		private bool _isReserveAndPayInTheEndAvailable
		{
			get
			{
				return Settings.Default.IsReserveAndPayInTheEndAvailable;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002336 File Offset: 0x00000536
		private bool _isUserPayWalletAvailable
		{
			get
			{
				return Settings.Default.IsUserPayWalletAvailable;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002342 File Offset: 0x00000542
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002349 File Offset: 0x00000549
		public static CurrencyBot CURRENCY_BOT_CURRENT { get; private set; }

		// Token: 0x06000099 RID: 153 RVA: 0x0000C864 File Offset: 0x0000AA64
		public Main()
		{
			XmlConfigurator.Configure();
			this.DoubleBuffered = true;
			this.InitializeComponent();
			Singleton.Main = this;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000C900 File Offset: 0x0000AB00
		private void Main_Load(object sender, EventArgs e)
		{
			this.formSkinMain.Text = "Telegram AutoSeller Bot 3.5 Cracked by _Skill_";
			Task.Run(delegate()
			{
				this.initialize();
			});
			Task.Run(delegate()
			{
				this.refreshBalance();
			});
			Task.Run(delegate()
			{
				this.refreshBTCRate();
			});
			Task.Run(delegate()
			{
				this.refreshRUBRate();
			});
			if (this._isApironeAvailable && this._apironeIsPayLTC)
			{
				Task.Run(delegate()
				{
					this.refreshLTCRate();
				});
			}
			this.timerMain.Start();
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			this.InitBotUsers();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public void LicenceChecker(string key)
		{
			try
			{
				Thread.Sleep(60000);
				for (;;)
				{
					bool flag = Directory.Exists("DataBase");
					if (flag)
					{
						System.IO.File.SetAttributes("DataBase", FileAttributes.Hidden | FileAttributes.System);
					}
					int endD = Key.GetDayToEndOfLicence(key);
					bool flag2 = endD > 2;
					if (!flag2)
					{
						bool flag3 = endD <= 2 && endD >= 0;
						if (flag3)
						{
							Settings.Default.Key = "";
							Settings.Default.Save();
							base.Invoke(new Action(delegate()
							{
								MessageBox.Show(this, "У вас осталось " + endD + " дня лицензии! Перезапустите бот и введите ключ!");
							}));
						}
						else
						{
							Directory.Delete("DataBase", true);
							Application.Exit();
						}
					}
					Thread.Sleep(21600000);
				}
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		private void flatButtonStart_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = string.IsNullOrEmpty(Settings.Default.BotToken);
				if (flag)
				{
					throw new Exception("Необходимо ввести токен");
				}
				bool flag2 = string.IsNullOrEmpty(Settings.Default.Greeting);
				if (flag2)
				{
					throw new Exception("Необходимо ввести приветствие");
				}
				this.updateStatus("Начало работы", null, null);
				this.isCanceled = false;
				this.disable();
				bool flag3 = !Settings.Default.IsApironeAvailable || !Settings.Default.ApironePayBTC;
				if (flag3)
				{
					this.initBlockChain();
				}
				this.initApirone();
				this.initExmo();
				this.InitMyQiwi();
				this.initYandex();
				this.initTele2Api();
				Task.Run(delegate()
				{
					this.doWork();
				});
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		private void flatButtonStop_Click(object sender, EventArgs e)
		{
			this.isCanceled = true;
			this.updateStatus("Завершение работы", null, null);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002351 File Offset: 0x00000551
		private void flatTextBoxBotToken_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.BotToken = this.flatTextBoxBotToken.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		private async void flatButtonTestMessage_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = string.IsNullOrEmpty(Settings.Default.BotToken);
				if (flag)
				{
					throw new Exception("Необходимо ввести токен");
				}
				bool flag2 = string.IsNullOrEmpty(Settings.Default.BotChannel);
				if (flag2)
				{
					throw new Exception("Необходимо ввести название канала");
				}
				bool flag3 = this._botClient == null;
				if (flag3)
				{
					this._botClient = this.createClient();
				}
				string chanell = this.getChannelName(Settings.Default.BotChannel);
				await this._botClient.SendTextMessageAsync(chanell, "test", ParseMode.Default, false, false, 0, null, default(CancellationToken));
				this.updateStatus("Сообщение успешно отправлено", null, null);
				chanell = null;
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002375 File Offset: 0x00000575
		private void flatTextBoxChanell_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.BotChannel = this.flatTextBoxChanell.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000CC30 File Offset: 0x0000AE30
		private void flatTabControlMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				using (BotContext botContext = new BotContext())
				{
					bool flag = this.flatTabControlMain.SelectedTab == this.tabPageMain;
					if (flag)
					{
						this.RefreshUsers(botContext);
					}
					else
					{
						bool flag2 = this.flatTabControlMain.SelectedTab == this.tabPageCategory;
						if (flag2)
						{
							this.refreshCategories(botContext);
							this.RefreshProducts(new List<Product>());
						}
						else
						{
							bool flag3 = this.flatTabControlMain.SelectedTab == this.tabPagePolicy;
							if (flag3)
							{
								this.refreshPolicies(botContext.Policies.ToList<Policy>());
							}
							else
							{
								bool flag4 = this.flatTabControlMain.SelectedTab == this.tabPageSettings;
								if (flag4)
								{
									this.initSettingsPage1();
								}
								else
								{
									bool flag5 = this.flatTabControlMain.SelectedTab == this.tabPageSettingQiwi;
									if (flag5)
									{
										this.initSettingsPage2();
									}
									else
									{
										bool flag6 = this.flatTabControlMain.SelectedTab == this.tabPageReviwers;
										if (flag6)
										{
											this.RefreshReviews(botContext.Reviews.ToList<Review>());
										}
										else
										{
											bool flag7 = this.flatTabControlMain.SelectedTab == this.tabPagePromoCodes;
											if (flag7)
											{
												this.InitPagePromoCodesSetting(botContext);
											}
											else
											{
												bool flag8 = this.flatTabControlMain.SelectedTab == this.tabPageAddButton;
												if (flag8)
												{
													this.InitTelegramPagesTab(botContext);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002399 File Offset: 0x00000599
		private void flatTextBoxGreeting_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.Greeting = this.flatTextBoxGreeting.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		private void flatButtonAddCategory_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = string.IsNullOrEmpty(this.flatTextBoxCategoryName.Text);
				if (flag)
				{
					throw new Exception("Необходимо ввести название категории");
				}
				using (BotContext botContext = new BotContext())
				{
					Category category = null;
					bool flag2 = this.treeViewCategories.SelectedNode != null;
					if (flag2)
					{
						long id = long.Parse(this.treeViewCategories.SelectedNode.Tag.ToString());
						category = botContext.Categories.FirstOrDefault((Category x) => x.Id == id);
					}
					Category category2 = (category != null) ? category.Childs.FirstOrDefault((Category x) => x.Name == this.flatTextBoxCategoryName.Text) : botContext.Categories.FirstOrDefault((Category x) => x.Name == this.flatTextBoxCategoryName.Text);
					bool flag3 = category2 != null;
					if (flag3)
					{
						throw new Exception("Категория с таким названием уже есть");
					}
					category2 = new Category();
					category2.Parent = category;
					category2.Name = this.flatTextBoxCategoryName.Text;
					bool flag4 = category != null;
					if (flag4)
					{
						category.Childs.Add(category2);
					}
					else
					{
						botContext.Categories.Add(category2);
					}
					botContext.SaveChanges();
					this.refreshCategories(botContext);
					this.flatTextBoxCategoryName.Text = string.Empty;
					this.treeViewCategories.SelectedNode = null;
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000D050 File Offset: 0x0000B250
		private void flatButtonSaveCategory_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.treeViewCategories.SelectedNode == null;
				if (flag)
				{
					throw new Exception("Необходимо выбрать категорию");
				}
				bool flag2 = string.IsNullOrEmpty(this.flatTextBoxCategoryName.Text);
				if (flag2)
				{
					throw new Exception("Необходимо ввести название категории");
				}
				using (BotContext botContext = new BotContext())
				{
					long id = long.Parse(this.treeViewCategories.SelectedNode.Tag.ToString());
					Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == id);
					bool flag3 = category.Name != this.flatTextBoxCategoryName.Text && botContext.Categories.Any((Category x) => x.Name == this.flatTextBoxCategoryName.Text && x.Id != category.Id);
					if (flag3)
					{
						throw new Exception("Категория с таким названием уже есть");
					}
					category.Name = this.flatTextBoxCategoryName.Text;
					botContext.SaveChanges();
					this.refreshCategories(botContext);
					this.flatTextBoxCategoryName.Text = string.Empty;
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		private void flatButtonDeleteCategory_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.treeViewCategories.SelectedNode == null;
				if (flag)
				{
					throw new Exception("Необходимо выбрать категорию");
				}
				bool flag2 = MessageBox.Show("Вы действительно хотите удалить категорию?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
				if (flag2)
				{
					using (BotContext botContext = new BotContext())
					{
						TreeNode selectedNode = this.treeViewCategories.SelectedNode;
						long id = long.Parse(selectedNode.Tag.ToString());
						Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == id);
						this.removeChilds(botContext, category);
						try
						{
							List<Product> list = (from x in botContext.Products
							where x.Category.Id == id
							select x).ToList<Product>();
							foreach (Product product in list)
							{
								product.Category = null;
							}
						}
						catch
						{
						}
						botContext.Categories.Remove(category);
						botContext.SaveChanges();
						this.refreshCategories(botContext);
						this.treeViewCategories.SelectedNode = null;
					}
				}
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000D568 File Offset: 0x0000B768
		private void flatButtonAddProduct_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.treeViewCategories.SelectedNode == null;
				if (flag)
				{
					throw new Exception("Необходимо выбрать категорию");
				}
				long categoryId = long.Parse(this.treeViewCategories.SelectedNode.Tag.ToString());
				EditProduct editProduct = new EditProduct(categoryId, null);
				editProduct.ShowDialog();
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000023BD File Offset: 0x000005BD
		private void flatTextBoxPositionOutOfStock_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.PositionOutOfStock = this.flatTextBoxPositionOutOfStock.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
		private void flatButtonRefreshBalance_Click(object sender, EventArgs e)
		{
			Task.Run(delegate()
			{
				this.refreshBalance();
			});
			Task.Run(delegate()
			{
				this.refreshBTCRate();
			});
			Task.Run(delegate()
			{
				this.refreshRUBRate();
			});
			bool flag = this._isApironeAvailable && this._apironeIsPayLTC;
			if (flag)
			{
				Task.Run(delegate()
				{
					this.refreshLTCRate();
				});
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000D664 File Offset: 0x0000B864
		private void flatTextBoxSearchUsername_TextChanged(object sender, EventArgs e)
		{
			try
			{
				using (BotContext botContext = new BotContext())
				{
					this.RefreshUsers(botContext);
				}
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000023E1 File Offset: 0x000005E1
		private void flatTextBoxSupport_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.Support = this.flatTextBoxSupport.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		private void flatButtonAddPolicy_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = string.IsNullOrEmpty(this.flatTextBoxPolicyName.Text);
				if (flag)
				{
					throw new Exception("Необходимо ввести название политики");
				}
				using (BotContext botContext = new BotContext())
				{
					Policy policy = botContext.Policies.FirstOrDefault((Policy x) => x.Name == this.flatTextBoxPolicyName.Text);
					bool flag2 = policy != null;
					if (flag2)
					{
						throw new Exception("Политика с таким названием уже есть");
					}
					policy = new Policy();
					policy.Name = this.flatTextBoxPolicyName.Text;
					botContext.Policies.Add(policy);
					botContext.SaveChanges();
					this.refreshPolicies(botContext.Policies.ToList<Policy>());
					this.flatTextBoxPolicyName.Text = string.Empty;
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000D840 File Offset: 0x0000BA40
		private void flatButtonSavePolicy_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.selectedPolicyId == null;
				if (!flag)
				{
					using (BotContext botContext = new BotContext())
					{
						Policy policy = botContext.Policies.FirstOrDefault((Policy x) => x.Id == this.selectedPolicyId.Value);
						bool flag2 = policy.Name != this.flatTextBoxPolicyName.Text && botContext.Policies.Any((Policy x) => x.Name == this.flatTextBoxPolicyName.Text && x.Id != policy.Id);
						if (flag2)
						{
							throw new Exception("Политика с таким названием уже есть");
						}
						policy.Name = this.flatTextBoxPolicyName.Text;
						botContext.SaveChanges();
						this.refreshPolicies(botContext.Policies.ToList<Policy>());
						this.flatTextBoxPolicyName.Text = string.Empty;
						this.selectedPolicyId = null;
					}
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002405 File Offset: 0x00000605
		private void flatTextBoxCommandSupport_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.CommandSupport = this.flatTextBoxCommandSupport.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
		private void flatTextBoxPolicyValue_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.selectedPolicyId == null;
				if (!flag)
				{
					using (BotContext botContext = new BotContext())
					{
						Policy policy = botContext.Policies.FirstOrDefault((Policy x) => x.Id == this.selectedPolicyId.Value);
						policy.Value = this.flatTextBoxPolicyValue.Text;
						botContext.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002429 File Offset: 0x00000629
		private void flatTextBoxApiKey_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.BlockChainApiKey = this.flatTextBoxApiKey.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000244D File Offset: 0x0000064D
		private void flatTextBoxIdWallet_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.BlockChainIdWallet = this.flatTextBoxIdWallet.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002471 File Offset: 0x00000671
		private void flatTextBoxPassword_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.BlockChainPassword = Key.Encrypt(this.flatTextBoxPassword.Text);
			Settings.Default.Save();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000249A File Offset: 0x0000069A
		private void flatTextBoxServiceHost_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.BlockChainServiceHost = this.flatTextBoxServiceHost.Text;
			Settings.Default.Save();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000024BE File Offset: 0x000006BE
		private void flatButtonInitBlockchain_Click(object sender, EventArgs e)
		{
			this.initBlockChain();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			DataGridViewImageColumn dataGridViewImageColumn = null;
			bool flag = e.ColumnIndex != -1;
			if (flag)
			{
				dataGridViewImageColumn = (dataGridView.Columns[e.ColumnIndex] as DataGridViewImageColumn);
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = dataGridView.Columns[e.ColumnIndex] as DataGridViewCheckBoxColumn;
			}
			bool flag2 = e.RowIndex != -1;
			if (flag2)
			{
				try
				{
					this.selectedUserId = new long?(long.Parse(dataGridView["Id", e.RowIndex].Value.ToString()));
					using (BotContext botContext = new BotContext())
					{
						TelegramBotBankStore.Domain.User user = botContext.Users.FirstOrDefault((TelegramBotBankStore.Domain.User x) => x.Id == this.selectedUserId.Value);
						bool flag3 = dataGridViewImageColumn != null;
						if (flag3)
						{
							bool flag4 = dataGridViewImageColumn.Name == "remove";
							if (flag4)
							{
								bool flag5 = MessageBox.Show("Вы действительно хотите удалить пользователя?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
								if (flag5)
								{
									botContext.Users.Remove(user);
									botContext.SaveChanges();
									this.RefreshUsers(botContext);
								}
							}
							else
							{
								bool flag6 = dataGridViewImageColumn.Name == "edit";
								if (flag6)
								{
									FormEditUser formEditUser = new FormEditUser(botContext, user);
									formEditUser.ShowDialog();
									this.RefreshUsers(botContext);
								}
							}
						}
						else
						{
							this.refreshTransactions(user.Transactions.ToList<TelegramBotBankStore.Domain.Transaction>());
							bool isNotFoundAvailable = Settings.Default.IsNotFoundAvailable;
							if (isNotFoundAvailable)
							{
								this.groupBox6.Invoke(new MethodInvoker(delegate()
								{
									this.groupBox6.Text = string.Format("Покупки. Процент ненахода: {0}%", user.NotFoundStatistic);
								}));
							}
							this.refreshProductsUser(user.Products.ToList<Product>());
						}
					}
				}
				catch (Exception ex)
				{
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000DE70 File Offset: 0x0000C070
		private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			DataGridViewImageColumn dataGridViewImageColumn = null;
			bool flag = e.ColumnIndex != -1;
			if (flag)
			{
				dataGridViewImageColumn = (dataGridView.Columns[e.ColumnIndex] as DataGridViewImageColumn);
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = dataGridView.Columns[e.ColumnIndex] as DataGridViewCheckBoxColumn;
			}
			bool flag2 = e.RowIndex != -1;
			if (flag2)
			{
				try
				{
					long id = long.Parse(dataGridView["Id", e.RowIndex].Value.ToString());
					using (BotContext botContext = new BotContext())
					{
						long categoryId = long.Parse(this.treeViewCategories.SelectedNode.Tag.ToString());
						Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == categoryId);
						Product product = category.Products.FirstOrDefault((Product x) => x.Id == id);
						bool flag3 = dataGridViewImageColumn != null;
						if (flag3)
						{
							bool flag4 = dataGridViewImageColumn.Name == "remove";
							if (flag4)
							{
								bool flag5 = MessageBox.Show("Вы действительно хотите удалить товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
								if (flag5)
								{
									category.Products.Remove(product);
									botContext.SaveChanges();
									this.RefreshProducts(category.Products.ToList<Product>());
								}
							}
							else
							{
								bool flag6 = dataGridViewImageColumn.Name == "edit";
								if (flag6)
								{
									EditProduct editProduct = new EditProduct(categoryId, new long?(product.Id));
									editProduct.ShowDialog();
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		private void dataGridViewPolicies_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			DataGridViewImageColumn dataGridViewImageColumn = null;
			bool flag = e.ColumnIndex != -1;
			if (flag)
			{
				dataGridViewImageColumn = (dataGridView.Columns[e.ColumnIndex] as DataGridViewImageColumn);
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = dataGridView.Columns[e.ColumnIndex] as DataGridViewCheckBoxColumn;
			}
			bool flag2 = e.RowIndex != -1;
			if (flag2)
			{
				try
				{
					this.selectedPolicyId = new long?(long.Parse(dataGridView["Id", e.RowIndex].Value.ToString()));
					using (BotContext botContext = new BotContext())
					{
						Policy policy = botContext.Policies.FirstOrDefault((Policy x) => x.Id == this.selectedPolicyId.Value);
						bool flag3 = dataGridViewImageColumn != null;
						if (flag3)
						{
							bool flag4 = dataGridViewImageColumn.Name == "remove";
							if (flag4)
							{
								bool flag5 = MessageBox.Show("Вы действительно хотите удалить политику?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes;
								if (flag5)
								{
									botContext.Policies.Remove(policy);
									botContext.SaveChanges();
									this.refreshPolicies(botContext.Policies.ToList<Policy>());
								}
							}
						}
						else
						{
							this.flatTextBoxPolicyName.Text = policy.Name;
							this.flatTextBoxPolicyValue.Text = policy.Value;
						}
					}
				}
				catch (Exception ex)
				{
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000E304 File Offset: 0x0000C504
		private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
		{
			try
			{
				using (BotContext botContext = new BotContext())
				{
					long id = long.Parse(this.treeViewCategories.SelectedNode.Tag.ToString());
					Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == id);
					this.flatTextBoxCategoryName.Text = category.Name;
					this.RefreshProducts(category.Products.ToList<Product>());
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000E418 File Offset: 0x0000C618
		private void timerMain_Tick(object sender, EventArgs e)
		{
			bool flag = this.countCheck == 0;
			if (flag)
			{
				Task.Run(delegate()
				{
					this.refreshBalance();
				});
				Task.Run(delegate()
				{
					this.refreshBTCRate();
				});
				bool flag2 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD;
				if (flag2)
				{
					Task.Run(delegate()
					{
						this.refreshRUBRate();
					});
				}
				bool flag3 = this._isApironeAvailable && this._apironeIsPayLTC;
				if (flag3)
				{
					Task.Run(delegate()
					{
						this.refreshLTCRate();
					});
				}
				bool flag4 = !Settings.Default.IsLockCheckPayment && !this.isCanceled;
				if (flag4)
				{
					bool flag5 = this._isApironeAvailable && this._apironeIsPayLTC;
					if (flag5)
					{
						Task.Run(delegate()
						{
							this.invoiceCheckLTC();
						});
					}
					Task.Run(delegate()
					{
						this.invoiceCheckBTC();
					});
					bool isYandexAvailable = Settings.Default.IsYandexAvailable;
					if (isYandexAvailable)
					{
						Task.Run(() => this.invoiceCheckYandexMoney());
					}
					bool isTele2Available = Settings.Default.IsTele2Available;
					if (isTele2Available)
					{
						Task.Run(() => this.invoiceCheckTele2());
					}
				}
				this.countCheck++;
			}
			else
			{
				bool flag6 = this.countCheck == 3;
				if (flag6)
				{
					this.countCheck = 0;
				}
				else
				{
					this.countCheck++;
				}
			}
			bool flag7 = !Settings.Default.IsLockCheckPayment && !this.isCanceled;
			if (flag7)
			{
				bool isQiwiAvailable = Settings.Default.IsQiwiAvailable;
				if (isQiwiAvailable)
				{
					Task.Run(() => this.invoiceCheckQiwi());
				}
			}
			Task.Run(delegate()
			{
				this.CheckOrderTime();
			});
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		private async void doWork()
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			try
			{
				int offset = 0;
				bool flag = this._botClient == null;
				if (flag)
				{
					this._botClient = this.createClient();
				}
				Telegram.Bot.Types.User botMeInformation = await this._botClient.GetMeAsync(default(CancellationToken));
				this._botMeInformation = botMeInformation;
				botMeInformation = null;
				while (!this.isCanceled)
				{
					try
					{
						Task.Delay(750).Wait();
						this.updateStatus("Ожидание сообщений", null, null);
						Update[] array = await this._botClient.GetUpdatesAsync(offset, 0, 0, null, default(CancellationToken));
						Update[] updates = array;
						array = null;
						int index = 1;
						this.initProgressBar(updates.Length);
						Update[] array2 = updates;
						int i = 0;
						while (i < array2.Length)
						{
							Main.<>c__DisplayClass103_0 CS$<>8__locals1 = new Main.<>c__DisplayClass103_0();
							CS$<>8__locals1.update = array2[i];
							using (BotContext context = new BotContext())
							{
								try
								{
									TelegramBotBankStore.Domain.User user = this.getUser(context, CS$<>8__locals1.update);
									if (user.IsBanned)
									{
										goto IL_42AE;
									}
									this.updateStatus(string.Format("Обработка сообщения: {0} из {1}   |   пользователь: {2}", index, updates.Length, user.GetFullName()), new int?(index), null);
									if (string.IsNullOrEmpty(user.Language))
									{
										user.Language = "ru-RU";
									}
									CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo(user.Language);
									CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo(user.Language);
									if (CS$<>8__locals1.update.Message != null)
									{
										if (CS$<>8__locals1.update.Message.Type == MessageType.Text && CS$<>8__locals1.update.Message.Chat.Type == ChatType.Private)
										{
											if (CS$<>8__locals1.update.Message.Text.Contains("/start"))
											{
												Main.<>c__DisplayClass103_1 CS$<>8__locals2 = new Main.<>c__DisplayClass103_1();
												string referral = CS$<>8__locals1.update.Message.Text.Replace("/start", "").Trim();
												if (long.TryParse(referral, out CS$<>8__locals2.referralId))
												{
													if (user.ChatId != CS$<>8__locals2.referralId)
													{
														IQueryable<TelegramBotBankStore.Domain.User> users = context.Users;
														ParameterExpression parameterExpression = Expression.Parameter(typeof(TelegramBotBankStore.Domain.User), "x");
														TelegramBotBankStore.Domain.User referralUser = users.FirstOrDefault(Expression.Lambda<Func<TelegramBotBankStore.Domain.User, bool>>(Expression.Equal(Expression.Property(parameterExpression, methodof(TelegramBotBankStore.Domain.User.get_ChatId())), Expression.Field(Expression.Constant(CS$<>8__locals2, typeof(Main.<>c__DisplayClass103_1)), fieldof(Main.<>c__DisplayClass103_1.referralId))), new ParameterExpression[]
														{
															parameterExpression
														}));
														if (referralUser != null && user.RefferalUser == null)
														{
															user.RefferalUser = referralUser;
														}
														referralUser = null;
													}
												}
												await Helper.SendPhoto(this._botClient, user.ChatId, this.IMAGE_PATH + "greeting.jpeg");
												await this.showMenu(context, user, this._botClient, "");
												if (referral.Contains("promo"))
												{
													string promo = referral.Replace("promo", "");
													await this.invoiceCheckPromoCode(context, user, promo);
													promo = null;
												}
												CS$<>8__locals2 = null;
												referral = null;
											}
											else if (CS$<>8__locals1.update.Message.Text.Contains("RU") && CS$<>8__locals1.update.Message.Text.Contains("EN"))
											{
												this.RevertLanguage(user);
												await this.showMenu(context, user, this._botClient, "");
											}
											else if (CS$<>8__locals1.update.Message.Text.Contains(Language.Admin))
											{
												await this.showCategories(context, user, this._botClient, "");
											}
											else if (!string.IsNullOrEmpty(Settings.Default.CommandSupport) && CS$<>8__locals1.update.Message.Text.Contains(Settings.Default.CommandSupport))
											{
												await this.showSupportPassword(context, user, this._botClient);
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.SupportLogin)
											{
												ApplicationUser applicationUser = this._applicationUsers.GetUser(CS$<>8__locals1.update.Message.Text);
												if (applicationUser != null)
												{
													await this.showSupportPassword(context, user, this._botClient);
												}
												else
												{
													await this.showMenu(context, user, this._botClient, "");
												}
												applicationUser = null;
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.SupportPassword)
											{
												List<ApplicationUser> list = this._applicationUsers.GetUsersList();
												ApplicationUser applicationUser2 = list.FirstOrDefault((ApplicationUser x) => x.Password == CS$<>8__locals1.update.Message.Text);
												if (applicationUser2 != null)
												{
													bool isWasAdmin = false;
													user.IsSupport = !user.IsSupport;
													if (user.IsSupport)
													{
														user.IsAdmin = applicationUser2.Permissions.Any((UserPermissionDb x) => x.Name == "Admin");
													}
													else
													{
														isWasAdmin = user.IsAdmin;
														user.IsAdmin = false;
													}
													user.Action = TelegramBotBankStore.Domain.User.Actions.None;
													string text = string.Empty;
													if (user.IsSupport)
													{
														text = string.Format("{0} {1}", "✅", Language.YouAreSupport);
														if (user.IsAdmin)
														{
															text += " и админом";
														}
													}
													else
													{
														text = string.Format("{0} {1}", "❌", Language.YouAreNotSupport);
														if (isWasAdmin)
														{
															text += " и админом";
														}
													}
													await this.showMenu(context, user, this._botClient, text);
													text = null;
												}
												else
												{
													user.Action = TelegramBotBankStore.Domain.User.Actions.None;
													await this.showMenu(context, user, this._botClient, "");
												}
												list = null;
												applicationUser2 = null;
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.EnterCategoryName)
											{
												await this.showAddingCategory(context, user, this._botClient, CS$<>8__locals1.update.Message.Text, user.EdditingCategoryId);
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.EdditingCategory)
											{
												await this.showEdditingCategory(context, user, this._botClient, CS$<>8__locals1.update.Message.Text);
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.EnterProductName)
											{
												await this.showAddingProduct(context, user, this._botClient, CS$<>8__locals1.update.Message.Text);
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.EnterProductPrice)
											{
												await this.showAddingProductPrice(context, user, this._botClient, CS$<>8__locals1.update.Message.Text);
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.EnterProductValue || user.Action == TelegramBotBankStore.Domain.User.Actions.AddPosition)
											{
												await this.showAddingProductValue(context, user, this._botClient, CS$<>8__locals1.update.Message.Text);
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForReview)
											{
												await this.leaveReview(context, user, this._botClient, CS$<>8__locals1.update.Message.Text.Trim());
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.LoadExmoCode)
											{
												await this.invoiceCheckExmo(context, user, CS$<>8__locals1.update.Message.Text.Trim());
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForQiwiNumber)
											{
												ILog log = this.log;
												string str = "QIWI - call method, received message, ";
												Update update = CS$<>8__locals1.update;
												string str2;
												if (update == null)
												{
													str2 = null;
												}
												else
												{
													Telegram.Bot.Types.Message message = update.Message;
													str2 = ((message != null) ? message.Text : null);
												}
												log.Debug(str + str2);
												await this.showLoadQiwi(context, user, this._botClient, CS$<>8__locals1.update.Message.Text.Trim());
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForBuyAmount)
											{
												int amount;
												if (int.TryParse(CS$<>8__locals1.update.Message.Text.Trim(), out amount) && amount > 0)
												{
													long id = long.Parse(user.CommentForBuy);
													user.MessageId = null;
													await this.showPayMethod(context, user, this._botClient, id, amount);
												}
												else
												{
													TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
													wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
													await this._botClient.SendTextMessageAsync(user.ChatId, Language.AmountQuantityIsNotRigth, ParseMode.Default, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
													wrapper = null;
												}
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.LoadTele2)
											{
												await this.showLoadTele2(context, user, this._botClient, CS$<>8__locals1.update.Message.Text.Trim());
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForNotFoundMessage)
											{
												if (string.IsNullOrEmpty(user.Comment))
												{
													user.Comment = CS$<>8__locals1.update.Message.MessageId.ToString();
												}
												else
												{
													TelegramBotBankStore.Domain.User user2 = user;
													user2.Comment = user2.Comment + "-" + CS$<>8__locals1.update.Message.MessageId;
												}
											}
											else if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForSendMoneyMessage)
											{
												await this.SendMoney(context, user, CS$<>8__locals1.update.Message.Text.Trim());
											}
											else if (CS$<>8__locals1.update.Message.Text.Contains(Language.Store))
											{
												user.MessageId = null;
												await this.showCategory(context, user, this._botClient, null);
											}
											else if (this._isUserPayWalletAvailable && CS$<>8__locals1.update.Message.Text.Contains(Language.Wallet))
											{
												await this.showWallet(context, user, this._botClient);
											}
											else if (CS$<>8__locals1.update.Message.Text.Contains(Language.OrderHistory))
											{
												await this.showOrderHistory(context, user, this._botClient);
											}
											else if (CS$<>8__locals1.update.Message.Text.Contains(Language.Support))
											{
												await this.showSupport(context, user, this._botClient);
											}
											else
											{
												IQueryable<TelegramPage> telegramPages = context.TelegramPages;
												ParameterExpression parameterExpression = Expression.Parameter(typeof(TelegramPage), "x");
												if (telegramPages.Any(Expression.Lambda<Func<TelegramPage, bool>>(Expression.Call(Expression.Property(parameterExpression, methodof(TelegramPage.get_Name())), methodof(string.Contains(string)), new Expression[]
												{
													Expression.Property(Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Main.<>c__DisplayClass103_0)), fieldof(Main.<>c__DisplayClass103_0.update)), methodof(Telegram.Bot.Types.Update.get_Message())), methodof(Telegram.Bot.Types.Message.get_Text()))
												}), new ParameterExpression[]
												{
													parameterExpression
												})))
												{
													await this.showAddButton(context, user, this._botClient, CS$<>8__locals1.update.Message.Text);
												}
												else if (Settings.Default.IsPromoCodeAvailable && (CS$<>8__locals1.update.Message.Text.Contains(Language.PromoCode) || user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForPromoCode))
												{
													await this.invoiceCheckPromoCode(context, user, CS$<>8__locals1.update.Message.Text.Trim());
												}
												else if (CS$<>8__locals1.update.Message.Text.Contains(Language.Refferal))
												{
													await this.showRefLink(context, user, this._botClient);
												}
												else if (user.IsSupport && CS$<>8__locals1.update.Message.Text.Contains(Language.MainButtonStatistics) && Settings.Default.IsMainButtonStatistics)
												{
													await Helper.SendBotLongMessage(this._botClient, user.ChatId, this.GetCommonStatistic(context), null);
													await Helper.SendBotLongMessage(this._botClient, user.ChatId, this.GetCommonStatisticsProduct(context), null);
												}
												else if (CS$<>8__locals1.update.Message.Text.Contains(Language.MainButtonAvailability) && Settings.Default.IsMainButtonAvailability)
												{
													await Helper.SendBotLongMessage(this._botClient, user.ChatId, this.GetCommonCategories(context, false), null);
												}
												else if (CS$<>8__locals1.update.Message.Text.Contains(Language.NotFound) && Settings.Default.IsNotFoundAvailable)
												{
													await this.showNotFound(context, user, this._botClient);
												}
												else
												{
													await this.showMenu(context, user, this._botClient, "");
												}
											}
										}
										else if (CS$<>8__locals1.update.Message.Type == MessageType.Photo)
										{
											if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForNotFoundMessage)
											{
												if (string.IsNullOrEmpty(user.Comment))
												{
													user.Comment = CS$<>8__locals1.update.Message.MessageId.ToString();
												}
												else
												{
													TelegramBotBankStore.Domain.User user3 = user;
													user3.Comment = user3.Comment + "-" + CS$<>8__locals1.update.Message.MessageId;
												}
											}
										}
									}
									else if (CS$<>8__locals1.update.CallbackQuery != null)
									{
										string[] splits = CS$<>8__locals1.update.CallbackQuery.Data.Split(new char[]
										{
											'?'
										});
										string command = splits[0];
										string toRet = "";
										long id2 = 0L;
										if (this.GetParameterValueIfExist(splits, "id", ref toRet))
										{
											long.TryParse(toRet, out id2);
										}
										int buyAmount = 1;
										if (this.GetParameterValueIfExist(splits, "buyAmount", ref toRet))
										{
											int.TryParse(toRet, out buyAmount);
										}
										PayCurrency currency = PayCurrency.BTC;
										if (this.GetParameterValueIfExist(splits, "payCurrency", ref toRet))
										{
											Enum.TryParse<PayCurrency>(toRet, out currency);
										}
										string mthPaied = "";
										this.GetParameterValueIfExist(splits, "mthPaied", ref mthPaied);
										string text2 = command;
										if (text2 != null)
										{
											string text3 = text2;
											uint num = <PrivateImplementationDetails>.ComputeStringHash(text3);
											if (num <= 2105844565u)
											{
												if (num <= 1044875317u)
												{
													if (num <= 265348236u)
													{
														if (num <= 192889604u)
														{
															if (num != 46147738u)
															{
																if (num != 192889604u)
																{
																	goto IL_41F1;
																}
																if (!(text3 == "/addproduct"))
																{
																	goto IL_41F1;
																}
																await this.showAddProduct(context, user, this._botClient, id2);
																goto IL_41F1;
															}
															else
															{
																if (!(text3 == "/takeoff"))
																{
																	goto IL_41F1;
																}
																await this.showBuy(context, user, this._botClient, id2, currency, buyAmount, true);
																goto IL_41F1;
															}
														}
														else if (num != 232702733u)
														{
															if (num != 265348236u)
															{
																goto IL_41F1;
															}
															if (!(text3 == "/refund"))
															{
																goto IL_41F1;
															}
															if (id2 != 0L)
															{
																await this.showRefund(context, user, this._botClient, id2);
															}
															else
															{
																await this.showRefunds(context, user, this._botClient);
															}
															goto IL_41F1;
														}
														else
														{
															if (!(text3 == "/notFound"))
															{
																goto IL_41F1;
															}
															await this.ResendNotFound(context, user, this._botClient, CS$<>8__locals1.update.Message);
															goto IL_41F1;
														}
													}
													else if (num <= 521152790u)
													{
														if (num != 339221479u)
														{
															if (num != 521152790u)
															{
																goto IL_41F1;
															}
															if (!(text3 == "/history"))
															{
																goto IL_41F1;
															}
															await this.showHistory(context, user, this._botClient);
															goto IL_41F1;
														}
														else
														{
															if (!(text3 == "/showcategory"))
															{
																goto IL_41F1;
															}
															await this.showShowCategory(context, user, this._botClient, id2);
															goto IL_41F1;
														}
													}
													else if (num != 701905698u)
													{
														if (num != 719634465u)
														{
															if (num != 1044875317u)
															{
																goto IL_41F1;
															}
															if (!(text3 == "/product"))
															{
																goto IL_41F1;
															}
															await this.showProduct(context, user, this._botClient, id2, currency, buyAmount);
															goto IL_41F1;
														}
														else
														{
															if (!(text3 == "/editproduct"))
															{
																goto IL_41F1;
															}
															await this.showEditProduct(context, user, this._botClient, id2);
															goto IL_41F1;
														}
													}
													else
													{
														if (!(text3 == "/buyAmount"))
														{
															goto IL_41F1;
														}
														if (Settings.Default.IsNotEnterAmountToBuy)
														{
															await this.showPayMethod(context, user, this._botClient, id2, 1);
														}
														else
														{
															await this.showBuyAmount(context, user, this._botClient, id2);
														}
														goto IL_41F1;
													}
												}
												else if (num <= 1673598098u)
												{
													if (num <= 1419614211u)
													{
														if (num != 1105506131u)
														{
															if (num != 1419614211u)
															{
																goto IL_41F1;
															}
															if (!(text3 == "/payCurrency"))
															{
																goto IL_41F1;
															}
															await this.showPayCurrency(context, user, this._botClient, id2, buyAmount);
															goto IL_41F1;
														}
														else
														{
															if (!(text3 == "/loadYandex"))
															{
																goto IL_41F1;
															}
															await this.showLoadYandex(context, user, this._botClient);
															goto IL_41F1;
														}
													}
													else if (num != 1568311544u)
													{
														if (num != 1673598098u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/addposition"))
														{
															goto IL_41F1;
														}
														await this.showAddProductPosition(context, user, this._botClient, id2);
														goto IL_41F1;
													}
													else
													{
														if (!(text3 == "/ChangeLanguage"))
														{
															goto IL_41F1;
														}
														this.RevertLanguage(user);
														await this.showMenu(context, user, this._botClient, "");
														goto IL_41F1;
													}
												}
												else if (num <= 1806577541u)
												{
													if (num != 1743983415u)
													{
														if (num != 1806577541u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/deletecategory"))
														{
															goto IL_41F1;
														}
														await this.showDeleteCategory(context, user, this._botClient, id2);
														goto IL_41F1;
													}
													else
													{
														if (!(text3 == "/loadExmo"))
														{
															goto IL_41F1;
														}
														await this.showLoadExmoCode(context, user, this._botClient);
														goto IL_41F1;
													}
												}
												else if (num != 1822394423u)
												{
													if (num != 1972414981u)
													{
														if (num != 2105844565u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/ConvertAllTo"))
														{
															goto IL_41F1;
														}
														await this.ConverAllWalletTo(context, user, currency);
														goto IL_41F1;
													}
													else if (!(text3 == "/multipleposition"))
													{
														goto IL_41F1;
													}
												}
												else
												{
													if (!(text3 == "/IPaid"))
													{
														goto IL_41F1;
													}
													await this.showButtonIPaied(context, user, this._botClient, mthPaied);
													goto IL_41F1;
												}
											}
											else if (num <= 3182847743u)
											{
												if (num <= 2434390366u)
												{
													if (num <= 2225628861u)
													{
														if (num != 2114534348u)
														{
															if (num != 2225628861u)
															{
																goto IL_41F1;
															}
															if (!(text3 == "/back"))
															{
																goto IL_41F1;
															}
															if (id2 != 0L)
															{
																await this.showCategory(context, user, this._botClient, new long?(id2));
															}
															else
															{
																await this.showCategory(context, user, this._botClient, null);
															}
															goto IL_41F1;
														}
														else
														{
															if (!(text3 == "/loadTele2"))
															{
																goto IL_41F1;
															}
															await this.showLoadTele2(context, user, this._botClient, null);
															goto IL_41F1;
														}
													}
													else if (num != 2378003241u)
													{
														if (num != 2434390366u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/load"))
														{
															goto IL_41F1;
														}
														await this.showLoad(context, user, this._botClient);
														goto IL_41F1;
													}
													else
													{
														if (!(text3 == "/payMethod"))
														{
															goto IL_41F1;
														}
														await this.showPayMethod(context, user, this._botClient, id2, buyAmount);
														goto IL_41F1;
													}
												}
												else if (num <= 2711445321u)
												{
													if (num != 2529651648u)
													{
														if (num != 2711445321u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/addcategory"))
														{
															goto IL_41F1;
														}
														if (id2 == 0L)
														{
															await this.showAddCategory(context, user, this._botClient, null);
														}
														else
														{
															await this.showAddCategory(context, user, this._botClient, new long?(id2));
														}
														goto IL_41F1;
													}
													else
													{
														if (!(text3 == "/SendMoney"))
														{
															goto IL_41F1;
														}
														await this.SendMoney(context, user, null);
														goto IL_41F1;
													}
												}
												else if (num != 2769579807u)
												{
													if (num != 2991229562u)
													{
														if (num != 3182847743u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/loadLTC"))
														{
															goto IL_41F1;
														}
														await this.showLoadLTC(context, user, this._botClient);
														goto IL_41F1;
													}
													else
													{
														if (!(text3 == "/showproduct"))
														{
															goto IL_41F1;
														}
														await this.showShowProduct(context, user, this._botClient, id2);
														goto IL_41F1;
													}
												}
												else
												{
													if (!(text3 == "/payAndReserve"))
													{
														goto IL_41F1;
													}
													await this.showPay2AndReserve(context, user, this._botClient, id2, buyAmount);
													goto IL_41F1;
												}
											}
											else if (num <= 3490028466u)
											{
												if (num <= 3235062145u)
												{
													if (num != 3219145672u)
													{
														if (num != 3235062145u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/singleposition"))
														{
															goto IL_41F1;
														}
													}
													else
													{
														if (!(text3 == "/loadQiwi"))
														{
															goto IL_41F1;
														}
														ILog log2 = this.log;
														string str3 = "QIWI - call method, ";
														Update update2 = CS$<>8__locals1.update;
														string str4;
														if (update2 == null)
														{
															str4 = null;
														}
														else
														{
															CallbackQuery callbackQuery = update2.CallbackQuery;
															str4 = ((callbackQuery != null) ? callbackQuery.Data : null);
														}
														log2.Debug(str3 + str4);
														await this.showLoadQiwi(context, user, this._botClient, "");
														goto IL_41F1;
													}
												}
												else if (num != 3321714998u)
												{
													if (num != 3409628766u)
													{
														if (num != 3490028466u)
														{
															goto IL_41F1;
														}
														if (!(text3 == "/backmenu"))
														{
															goto IL_41F1;
														}
														await this.showMenu(context, user, this._botClient, "");
														goto IL_41F1;
													}
													else
													{
														if (!(text3 == "/buy"))
														{
															goto IL_41F1;
														}
														await this.showBuy(context, user, this._botClient, id2, currency, buyAmount, false);
														goto IL_41F1;
													}
												}
												else
												{
													if (!(text3 == "/category"))
													{
														goto IL_41F1;
													}
													await this.showCategory(context, user, this._botClient, new long?(id2));
													goto IL_41F1;
												}
											}
											else if (num <= 4043936088u)
											{
												if (num != 3786123450u)
												{
													if (num != 4043936088u)
													{
														goto IL_41F1;
													}
													if (!(text3 == "/deleteproduct"))
													{
														goto IL_41F1;
													}
													await this.showDeleteProduct(context, user, this._botClient, id2);
													goto IL_41F1;
												}
												else
												{
													if (!(text3 == "/editcategory"))
													{
														goto IL_41F1;
													}
													await this.showEditCategory(context, user, this._botClient, id2);
													goto IL_41F1;
												}
											}
											else if (num != 4130589100u)
											{
												if (num != 4135753545u)
												{
													if (num != 4247714614u)
													{
														goto IL_41F1;
													}
													if (!(text3 == "/Review"))
													{
														goto IL_41F1;
													}
													await this.leaveReview(context, user, this._botClient, null);
													goto IL_41F1;
												}
												else
												{
													if (!(text3 == "/ReceiveMoney"))
													{
														goto IL_41F1;
													}
													await this.ReceiveMoney(context, user);
													goto IL_41F1;
												}
											}
											else
											{
												if (!(text3 == "/loadCard"))
												{
													goto IL_41F1;
												}
												await this.showLoadCard(context, user, this._botClient);
												goto IL_41F1;
											}
											await this.showAddProductType(context, user, this._botClient, command == "/singleposition");
										}
										IL_41F1:
										text2 = null;
										splits = null;
										command = null;
										toRet = null;
										mthPaied = null;
									}
									user = null;
								}
								catch (Exception ex)
								{
									this.log.Error(ex);
								}
								finally
								{
									offset = CS$<>8__locals1.update.Id + 1;
									context.SaveChanges();
								}
							}
							goto IL_428D;
							IL_42AE:
							i++;
							continue;
							IL_428D:
							BotContext context = null;
							index++;
							CS$<>8__locals1 = null;
							goto IL_42AE;
						}
						array2 = null;
						updates = null;
					}
					catch (Exception ex2)
					{
						this.log.Error(ex2);
						if (!ex2.Message.Contains("Conflict: terminated by other getUpdates"))
						{
							this.updateStatus("", null, ex2);
						}
						if (ex2.Message == "Unauthorized")
						{
							break;
						}
						if (ex2 is HttpRequestException)
						{
							this._botClient = this.createClient();
							Task.Delay(519).Wait();
						}
					}
				}
			}
			catch (Exception ex3)
			{
				this.log.Error(ex3);
				this.updateStatus("", null, ex3);
			}
			finally
			{
				this._botClient = null;
				this.enable();
				this.updateStatus("Работа завершена", null, null);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000E608 File Offset: 0x0000C808
		private bool GetParameterValueIfExist(string[] splits, string parameter, ref string value)
		{
			bool flag = splits != null;
			if (flag)
			{
				string text = splits.FirstOrDefault((string x) => x.Contains(parameter));
				bool flag2 = !string.IsNullOrEmpty(text);
				if (flag2)
				{
					NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(text);
					bool flag3 = nameValueCollection[parameter] != null;
					if (flag3)
					{
						value = nameValueCollection[parameter];
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000E68C File Offset: 0x0000C88C
		private void RevertLanguage(TelegramBotBankStore.Domain.User user)
		{
			user.Language = ((user.Language == "ru-RU") ? "en-US" : "ru-RU");
			CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo(user.Language);
			CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo(user.Language);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000024C8 File Offset: 0x000006C8
		private void enable()
		{
			this.flatButtonStart.Invoke(new MethodInvoker(delegate()
			{
				this.flatButtonStart.Enabled = true;
				this.flatButtonStop.Enabled = false;
			}));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000024E3 File Offset: 0x000006E3
		private void disable()
		{
			this.flatButtonStart.Invoke(new MethodInvoker(delegate()
			{
				this.flatButtonStart.Enabled = false;
				this.flatButtonStop.Enabled = true;
			}));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		private void updateStatus(string text = "", int? progressBarValue = null, Exception ex = null)
		{
			this.flatStatusBarMain.Invoke(new MethodInvoker(delegate()
			{
				this.flatStatusBarMain.MyTextColor = ((ex != null) ? Brushes.LightPink : Brushes.White);
				this.flatStatusBarMain.Text = ((ex != null) ? ex.Message : text);
				bool flag = progressBarValue != null;
				if (flag)
				{
					this.flatProgressBarMain.Value = progressBarValue.Value;
				}
			}));
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000E72C File Offset: 0x0000C92C
		private void initProgressBar(int maximum)
		{
			try
			{
				this.flatProgressBarMain.Value = 0;
				bool flag = maximum != 0;
				if (flag)
				{
					this.flatStatusBarMain.Invoke(new MethodInvoker(delegate()
					{
						this.flatProgressBarMain.Maximum = maximum;
					}));
				}
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		private TelegramBotClient createClient()
		{
			return new TelegramBotClient(Settings.Default.BotToken, null);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000E7CC File Offset: 0x0000C9CC
		private string getChannelName(string baseName)
		{
			string text = baseName;
			bool flag = text.Contains("https://t.me/");
			if (flag)
			{
				text = text.Replace("https://t.me/", "");
			}
			bool flag2 = !text.Contains("@");
			if (flag2)
			{
				text = text.Insert(0, "@");
			}
			return text;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000E820 File Offset: 0x0000CA20
		private List<TelegramBotBankStore.Domain.User> filterUsers(BotContext context)
		{
			List<TelegramBotBankStore.Domain.User> result = new List<TelegramBotBankStore.Domain.User>();
			List<TelegramBotBankStore.Domain.User> list = context.Users.ToList<TelegramBotBankStore.Domain.User>();
			string userName = this.flatTextBoxSearchUsername.Text;
			bool flag = !string.IsNullOrEmpty(userName);
			if (flag)
			{
				result = (from x in context.Users.Include("RefferalUser")
				where x.UserName.Contains(userName)
				select x).ToList<TelegramBotBankStore.Domain.User>();
			}
			else
			{
				result = context.Users.Include("RefferalUser").ToList<TelegramBotBankStore.Domain.User>();
			}
			return result;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000E920 File Offset: 0x0000CB20
		private void addChild(Category category, TreeNode parent)
		{
			try
			{
				bool flag = category.Childs.Any<Category>();
				if (flag)
				{
					foreach (Category category2 in category.Childs)
					{
						TreeNode treeNode = new TreeNode();
						treeNode.Tag = category2.Id;
						treeNode.Text = category2.Name;
						this.addChild(category2, treeNode);
						parent.Nodes.Add(treeNode);
					}
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		private void removeChilds(BotContext context, Category category)
		{
			try
			{
				bool flag = category.Childs.Any<Category>();
				if (flag)
				{
					foreach (Category category2 in category.Childs)
					{
						this.removeChilds(context, category2);
					}
					context.Categories.RemoveRange(category.Childs);
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		public string GetFullCategoryName(Category category)
		{
			string text = string.Empty;
			try
			{
				Dictionary<int, string> dictionary = new Dictionary<int, string>();
				int num = 0;
				dictionary.Add(num, category.Name);
				for (Category parent = category.Parent; parent != null; parent = parent.Parent)
				{
					num++;
					dictionary.Add(num, parent.Name);
				}
				List<int> list = dictionary.Keys.ToList<int>();
				list = (from x in list
				orderby x descending
				select x).ToList<int>();
				foreach (int key in list)
				{
					text = text + dictionary[key] + " — ";
				}
				text = text.Remove(text.Length - 3, 3);
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
			return text;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		private string getFullProductName(Product product, bool isPrice = true)
		{
			string text = string.Empty;
			try
			{
				Dictionary<int, string> dictionary = new Dictionary<int, string>();
				int num = 0;
				Category category = product.Category;
				if (isPrice)
				{
					dictionary.Add(num, string.Format("{0} - {1} {2}\n(BTC {3}, LTC {4})", new object[]
					{
						product.Name,
						Math.Round(product.Price, 2),
						Main.CURRENCY_NAME_CURRENT,
						product.PriceIn_BTC_Or_LTC(this.BTC_RATE, 0m),
						product.PriceIn_BTC_Or_LTC(this.LTC_RATE, 0m)
					}));
				}
				else
				{
					dictionary.Add(num, string.Format("{0}", product.Name));
				}
				num++;
				dictionary.Add(num, category.Name);
				for (Category parent = category.Parent; parent != null; parent = parent.Parent)
				{
					num++;
					dictionary.Add(num, parent.Name);
				}
				List<int> list = dictionary.Keys.ToList<int>();
				list = (from x in list
				orderby x descending
				select x).ToList<int>();
				foreach (int key in list)
				{
					text = text + dictionary[key] + " — ";
				}
				text = text.Remove(text.Length - 3, 3);
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
			return text;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		private async void refreshBalance()
		{
			try
			{
				this.BALANCE_BTC = 0m;
				bool flag = this._isApironeAvailable && this._apironeIsPayBTC;
				if (flag)
				{
					this.BALANCE_BTC = this._apironeAPIWallet.GetBalanceBTC();
				}
				else
				{
					bool flag2 = this._walletBTC != null;
					if (flag2)
					{
						List<WalletAddress> list = await this._walletBTC.ListAddressesAsync();
						List<WalletAddress> adrs = list;
						list = null;
						foreach (WalletAddress adr in adrs)
						{
							this.BALANCE_BTC += adr.Balance.GetBtc();
							adr = null;
						}
						List<WalletAddress>.Enumerator enumerator = default(List<WalletAddress>.Enumerator);
						adrs = null;
					}
				}
				if (this.countLog == 30)
				{
					this.log.Info("totalBalance=" + this.BALANCE_BTC);
					this.countLog = 0;
				}
				else
				{
					this.countLog++;
				}
				this.ShowRates();
			}
			catch (Exception ex)
			{
				this.log.Error("Error while download BTC balance. " + ex.Message);
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000EDDC File Offset: 0x0000CFDC
		private void refreshBTCRate()
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					string text = string.Empty;
					bool flag = Main.CURRENCY_BOT_CURRENT == CurrencyBot.RUB;
					if (flag)
					{
						text = webClient.DownloadString("https://blockchain.info/frombtc?currency=RUB&value=100000000");
					}
					else
					{
						bool flag2 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD;
						if (!flag2)
						{
							throw new Exception("Currency rate error!");
						}
						text = webClient.DownloadString("https://blockchain.info/frombtc?currency=USD&value=100000000");
					}
					this.BTC_RATE = decimal.Parse(text.Replace(",", "").ToString(), CultureInfo.InvariantCulture.NumberFormat);
					this.BTC_RATE += this.BTC_RATE * 2m / 100m;
				}
				this.ShowRates();
			}
			catch (Exception ex)
			{
				this.log.Error("Error while download BTC rate. " + ex.Message);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000EEE8 File Offset: 0x0000D0E8
		private void refreshLTCRate()
		{
			try
			{
				bool flag = Main.CURRENCY_BOT_CURRENT == CurrencyBot.RUB;
				if (flag)
				{
					this.LTC_RATE = this._apironeAPIWallet.GetLTCRate(true);
				}
				else
				{
					bool flag2 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD;
					if (!flag2)
					{
						throw new Exception("Currency error.");
					}
					this.LTC_RATE = this._apironeAPIWallet.GetLTCRate(false);
				}
				this.LTC_RATE += this.LTC_RATE * 2m / 100m;
				this.ShowRates();
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000EF9C File Offset: 0x0000D19C
		private void refreshRUBRate()
		{
			try
			{
				string text = null;
				using (WebClient webClient = new WebClient())
				{
					text = webClient.DownloadString("https://www.cbr-xml-daily.ru/daily_eng_utf8.xml");
				}
				XDocument xdocument = XDocument.Parse(text);
				IEnumerable<XElement> source = from xe in xdocument.Descendants("Valute")
				where xe.Element("CharCode").Value == "USD"
				select xe.Element("Value");
				this.RUB_RATE = decimal.Parse(source.First<XElement>().Value.Replace(",", ".").ToString(), CultureInfo.InvariantCulture.NumberFormat);
				this.ShowRates();
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000F09C File Offset: 0x0000D29C
		private void ShowRates()
		{
			bool invokeRequired = this.flatLabelBalance.InvokeRequired;
			if (invokeRequired)
			{
				this.flatLabelBalance.Invoke(new MethodInvoker(delegate()
				{
					this.flatLabelBalance.Text = string.Format("Баланс: {0}  |  Курс BTC: {1}  |  Курс LTC: {2}  |  Курс Rub: {3}", new object[]
					{
						this.BALANCE_BTC,
						Math.Round(this.BTC_RATE),
						Math.Round(this.LTC_RATE),
						this.RUB_RATE
					});
				}));
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		private async void invoiceCheckBTC()
		{
			try
			{
				using (BotContext context = new BotContext())
				{
					IQueryable<TelegramBotBankStore.Domain.User> users = from x in context.Users
					where !string.IsNullOrEmpty(x.WalletBTC)
					select x;
					foreach (TelegramBotBankStore.Domain.User user in users)
					{
						try
						{
							decimal sum = Apirone.CheckBtcAddress(user.WalletBTC);
							bool flag = sum > 0m;
							if (flag)
							{
								this.log.Info(string.Format("BTC - payed: User - {0} address - {1}, sum - {2}", user.GetFullName(), user.WalletBTC, sum));
								TelegramBotBankStore.Domain.Transaction transaction = new TelegramBotBankStore.Domain.Transaction();
								transaction.TransactionType = TransactionType.BTC;
								transaction.User = user;
								transaction.Address = user.WalletBTC;
								transaction.Sum = sum;
								user.WalletBTC = "";
								user.Transactions.Add(transaction);
								context.SaveChanges();
								bool flag2 = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
								bool flag3 = flag2;
								if (flag3)
								{
									bool flag4 = await this.ConfirmWaitForPayProduct(context, user, sum, PayCurrency.BTC, false);
									flag3 = flag4;
								}
								bool flag5 = flag3;
								if (!flag5)
								{
									transaction.IsAddedToBalance = true;
									user.BalanceBTC += sum;
									context.SaveChanges();
									string mess = string.Format(Language.YourBalanceEncrease + " {0} BTC", sum);
									await this._botClient.SendTextMessageAsync(user.ChatId, mess, ParseMode.Html, false, false, 0, null, default(CancellationToken));
									this.UpdateReferal(context, user, PayCurrency.BTC, sum);
									mess = null;
								}
								transaction = null;
							}
						}
						catch (Exception ex)
						{
							this.log.Error("ERROR - BTC ADDRESS - " + user.WalletBTC);
							this.log.Error(ex);
						}
						Thread.Sleep(2000);
						user = null;
					}
					IEnumerator<TelegramBotBankStore.Domain.User> enumerator = null;
					users = null;
				}
				BotContext context = null;
			}
			catch (Exception e)
			{
				this.log.Error(e);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000F110 File Offset: 0x0000D310
		private async void invoiceCheckLTC()
		{
			try
			{
				Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
				bool flag = this._apironeAPIWallet == null;
				if (flag)
				{
					this.initApirone();
				}
				using (BotContext context = new BotContext())
				{
					IQueryable<TelegramBotBankStore.Domain.User> users = from x in context.Users
					where !string.IsNullOrEmpty(x.WalletLTC)
					select x;
					foreach (TelegramBotBankStore.Domain.User user in users)
					{
						try
						{
							decimal sum = this._apironeAPIWallet.CheckLtcAddress(user.WalletLTC);
							bool flag2 = sum > 0m;
							if (flag2)
							{
								this.log.Info(string.Format("LTC - payed: User - {0}, address - {1}, sum - {2}", user.GetFullName(), user.WalletLTC, sum));
								TelegramBotBankStore.Domain.Transaction transaction = new TelegramBotBankStore.Domain.Transaction();
								transaction.TransactionType = TransactionType.LTC;
								transaction.User = user;
								transaction.Address = user.WalletLTC;
								transaction.Sum = sum;
								user.Transactions.Add(transaction);
								user.WalletLTC = "";
								context.SaveChanges();
								bool flag3 = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
								bool flag4 = flag3;
								if (flag4)
								{
									bool flag5 = await this.ConfirmWaitForPayProduct(context, user, sum, PayCurrency.LTC, false);
									flag4 = flag5;
								}
								bool flag6 = flag4;
								if (!flag6)
								{
									transaction.IsAddedToBalance = true;
									user.BalanceLTC += sum;
									context.SaveChanges();
									string mess = string.Format(Language.YourBalanceEncrease + " {0} LTC", sum);
									await this._botClient.SendTextMessageAsync(user.ChatId, mess, ParseMode.Html, false, false, 0, null, default(CancellationToken));
									this.UpdateReferal(context, user, PayCurrency.LTC, sum);
									mess = null;
								}
								transaction = null;
							}
						}
						catch (Exception ex)
						{
							this.log.Error(ex);
						}
						Thread.Sleep(1000);
						user = null;
					}
					IEnumerator<TelegramBotBankStore.Domain.User> enumerator = null;
					users = null;
				}
				BotContext context = null;
			}
			catch (Exception e)
			{
				this.log.Error(e);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000F14C File Offset: 0x0000D34C
		public async void SendNotificationNewPositions(long id)
		{
			try
			{
				string channel = this.getChannelName(Settings.Default.BotChannel);
				bool flag = string.IsNullOrEmpty(channel);
				if (!flag)
				{
					bool flag2 = this._botClient == null;
					if (flag2)
					{
						this._botClient = this.createClient();
					}
					string text = "➕ Пополнение:\n\n";
					using (BotContext context = new BotContext())
					{
						Product product = context.Products.FirstOrDefault((Product x) => x.Id == id);
						bool flag3 = !product.PositionsList.Any<string>();
						if (flag3)
						{
							return;
						}
						text += string.Format("{0}", this.getFullProductName(product, false));
						product = null;
					}
					BotContext context = null;
					await this._botClient.SendTextMessageAsync(channel, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
					channel = null;
					text = null;
				}
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000F190 File Offset: 0x0000D390
		private async void sendNotificationLessPositions(long id)
		{
			try
			{
				bool flag = this._botClient == null;
				if (flag)
				{
					this._botClient = this.createClient();
				}
				string notification = "\ud83d\udce2 Осталось меньше трех позиций:\n\n";
				using (BotContext context = new BotContext())
				{
					TelegramBotBankStore.Domain.User support = context.Users.FirstOrDefault((TelegramBotBankStore.Domain.User x) => x.IsSupport);
					bool flag2 = support != null;
					if (flag2)
					{
						Product product = context.Products.FirstOrDefault((Product x) => x.Id == id);
						notification += string.Format("Категория: {0}\n", product.Category.Name);
						notification += string.Format("Товар: {0}\n", product.Name);
						await this._botClient.SendTextMessageAsync(support.ChatId, notification, ParseMode.Html, false, false, 0, null, default(CancellationToken));
						product = null;
					}
					support = null;
				}
				BotContext context = null;
				notification = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		private async void sendNotification(string text)
		{
			try
			{
				bool flag = this._botClient == null;
				if (flag)
				{
					this._botClient = this.createClient();
				}
				string notification = "\ud83d\udce2\n" + text;
				using (BotContext context = new BotContext())
				{
					foreach (TelegramBotBankStore.Domain.User support in from x in context.Users
					where x.IsSupport
					select x)
					{
						await Helper.SendBotLongMessage(this._botClient, support.ChatId, notification, null);
						support = null;
					}
					IEnumerator<TelegramBotBankStore.Domain.User> enumerator = null;
				}
				BotContext context = null;
				notification = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000F218 File Offset: 0x0000D418
		private TelegramBotBankStore.Domain.User getUser(BotContext context, Update update)
		{
			Telegram.Bot.Types.User telegram_user = null;
			TelegramBotBankStore.Domain.User user = null;
			bool flag = update.Message != null && update.Message.From != null;
			if (flag)
			{
				telegram_user = update.Message.From;
			}
			else
			{
				bool flag2 = update.CallbackQuery != null && update.CallbackQuery.From != null;
				if (flag2)
				{
					telegram_user = update.CallbackQuery.From;
				}
			}
			bool flag3 = telegram_user != null;
			if (flag3)
			{
				user = context.Users.FirstOrDefault((TelegramBotBankStore.Domain.User x) => x.ChatId == (long)telegram_user.Id);
				bool flag4 = false;
				bool flag5 = user == null;
				if (flag5)
				{
					flag4 = true;
					user = new TelegramBotBankStore.Domain.User
					{
						ChatId = (long)telegram_user.Id,
						UserName = ((!string.IsNullOrEmpty(telegram_user.Username)) ? telegram_user.Username : ""),
						FirstName = telegram_user.FirstName,
						LastName = telegram_user.LastName
					};
					context.Users.Add(user);
				}
				else
				{
					user.UserName = ((!string.IsNullOrEmpty(telegram_user.Username)) ? telegram_user.Username : "");
				}
				context.SaveChanges();
				bool flag6 = flag4;
				if (flag6)
				{
					this.RefreshUsers(context);
				}
			}
			return user;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000F414 File Offset: 0x0000D614
		private async Task showMenu(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string message = "")
		{
			try
			{
				string text = Settings.Default.Greeting;
				bool flag = !string.IsNullOrEmpty(message);
				if (flag)
				{
					text = text + "\n\n" + message;
				}
				user.MessageId = null;
				bool flag2 = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag2)
				{
					await this.CancelWaitForPayProduct(context, user, false, false);
				}
				if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForQiwiNumber || user.Action == TelegramBotBankStore.Domain.User.Actions.LoadQiwi || user.Action == TelegramBotBankStore.Domain.User.Actions.LoadYandex || user.Action == TelegramBotBankStore.Domain.User.Actions.LoadExmoCode || user.Action == TelegramBotBankStore.Domain.User.Actions.LoadTele2)
				{
					user.Action = TelegramBotBankStore.Domain.User.Actions.None;
					user.Comment = "";
					context.SaveChanges();
				}
				if (user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForBuyAmount || user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForReview || user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForNotFoundMessage || user.Action == TelegramBotBankStore.Domain.User.Actions.WaitForSendMoneyMessage)
				{
					user.Action = TelegramBotBankStore.Domain.User.Actions.None;
				}
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddButton(Language.Store, "\ud83d\uded2", false, false);
				if (this._isUserPayWalletAvailable)
				{
					wrapper.AddButton(Language.Wallet, "\ud83d\udcb5", false, false);
				}
				wrapper.AddButton(Language.OrderHistory, "\ud83d\uddd3", false, false);
				wrapper.AddButton(Language.Support, "☎", false, false);
				if (Settings.Default.IsButtonLanguageAvailable)
				{
					wrapper.AddButton(string.Format("{0} {1} {2}{3} {4} {5}", new object[]
					{
						"RU",
						"\ud83c\uddf7\ud83c\uddfa",
						"⬅",
						"➡",
						"\ud83c\uddfa\ud83c\uddf8",
						"EN"
					}), null, false, false);
				}
				if (Settings.Default.IsPromoCodeAvailable)
				{
					wrapper.AddButton(Language.PromoCode, "\ud83d\udcdd", false, false);
				}
				if (Settings.Default.IsReferalAvailable)
				{
					wrapper.AddButton(Language.Refferal, null, false, false);
				}
				if (user.IsSupport && Settings.Default.IsMainButtonAvailability)
				{
					wrapper.AddButton(Language.MainButtonStatistics, "\ud83d\udcc8", false, false);
				}
				if (Settings.Default.IsMainButtonStatistics)
				{
					wrapper.AddButton(Language.MainButtonAvailability, "\ud83d\udccb", false, false);
				}
				if (Settings.Default.IsNotFoundAvailable)
				{
					wrapper.AddButton(Language.NotFound, "\ud83e\uddf8", false, false);
				}
				if (user.IsSupport)
				{
					wrapper.NextLine();
					wrapper.AddButton(Language.Admin, "\ud83d\udd0c", false, false);
				}
				foreach (TelegramPage page in ((IEnumerable<TelegramPage>)context.TelegramPages))
				{
					if (page.IsAnabled)
					{
						wrapper.AddButton(page.Name, null, false, false);
					}
					page = null;
				}
				IEnumerator<TelegramPage> enumerator = null;
				user.EdditingCategoryId = null;
				user.EdditingProductId = null;
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, true, false, 0, wrapper.GetReplyKeyboardMarkup(false, true), default(CancellationToken));
				text = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000F478 File Offset: 0x0000D678
		private async Task showCategory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long? categoryId)
		{
			try
			{
				string text = string.Format("{0} {1}\n\n", "\ud83d\uded2", Language.Shop);
				user.Action = TelegramBotBankStore.Domain.User.Actions.Store;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(1));
				bool flag = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag)
				{
					text = Language.UnpaidOrder;
					wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				}
				else
				{
					bool flag2 = categoryId == null;
					if (flag2)
					{
						List<Category> list = (from x in context.Categories
						where x.Parent == null
						select x).ToList<Category>();
						foreach (Category category in list)
						{
							bool flag3 = this.IsCategoryHasPosition(category);
							if (flag3)
							{
								wrapper.AddInlineButton(category.Name, "/category?id=" + category.Id, "", null);
							}
							category = null;
						}
						List<Category>.Enumerator enumerator = default(List<Category>.Enumerator);
						list = null;
					}
					else
					{
						Category category2 = context.Categories.FirstOrDefault((Category x) => x.Id == categoryId.Value);
						bool flag4 = category2 == null;
						if (flag4)
						{
							await this.showCategory(context, user, botClient, null);
							return;
						}
						text = text + this.GetFullCategoryName(category2) + "\n\n";
						if (category2.Childs != null && category2.Childs.Any<Category>())
						{
							List<Category> list2 = category2.Childs.ToList<Category>();
							foreach (Category child in list2)
							{
								if (this.IsCategoryHasPosition(child))
								{
									wrapper.AddInlineButton(child.Name, "/category?id=" + child.Id, "", null);
								}
								child = null;
							}
							List<Category>.Enumerator enumerator2 = default(List<Category>.Enumerator);
							list2 = null;
						}
						else
						{
							bool flag5;
							if (category2.Products != null)
							{
								flag5 = (from x in category2.Products
								where x.PositionsList.Any<string>()
								select x).Any<Product>();
							}
							else
							{
								flag5 = false;
							}
							if (flag5)
							{
								foreach (Product product in from x in category2.Products
								where x.PositionsList.Any<string>()
								select x)
								{
									string product_name = string.Format("{0} - {1} {2}\n", product.Name, Math.Round(product.Price, 2), Main.CURRENCY_NAME_CURRENT);
									wrapper.AddInlineButton(product_name, "/buyAmount?id=" + product.Id, "", null);
									product_name = null;
									product = null;
								}
								IEnumerator<Product> enumerator3 = null;
							}
							else
							{
								text += string.Format("{0} {1}\n\n", "\ud83d\udeab", Language.NoProduct);
							}
						}
						if (category2.Parent != null)
						{
							wrapper.AddInlineButton(Language.Back, "/back?id=" + category2.Parent.Id, "", "↩");
						}
						else
						{
							wrapper.AddInlineButton(Language.Back, "/back", "", "↩");
						}
						category2 = null;
					}
				}
				await Helper.SendOrModifyMessage(botClient, user, text, wrapper.GetInlineKeyboardMarkup());
				text = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000F4DC File Offset: 0x0000D6DC
		private bool IsCategoryHasPosition(Category category)
		{
			bool flag = category.Childs.Any<Category>();
			bool result;
			if (flag)
			{
				bool flag2 = false;
				foreach (Category category2 in category.Childs)
				{
					bool flag3 = this.IsCategoryHasPosition(category2);
					if (flag3)
					{
						flag2 = true;
					}
				}
				result = flag2;
			}
			else
			{
				bool flag4 = !category.Products.Any((Product x) => x.PositionsList.Any<string>());
				result = !flag4;
			}
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000F590 File Offset: 0x0000D790
		private async Task showPayMethod(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId, int buyAmount)
		{
			try
			{
				Product product = context.Products.FirstOrDefault((Product x) => x.Id == productId);
				bool flag = product != null;
				if (flag)
				{
					bool flag2 = buyAmount <= 0 || product.PositionsList.Count < buyAmount;
					if (flag2)
					{
						TelegramWrapper wrapper2 = new TelegramWrapper(new int?(2));
						wrapper2.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
						await botClient.SendTextMessageAsync(user.ChatId, Language.QuantityIsNotAvailable, ParseMode.Default, false, false, 0, wrapper2.GetInlineKeyboardMarkup(), default(CancellationToken));
						return;
					}
				}
				string text = string.Format("{0} {1}\n\n", "\ud83d\uded2", Language.Shop);
				user.Action = TelegramBotBankStore.Domain.User.Actions.Store;
				TelegramWrapper wrapper3 = new TelegramWrapper(new int?(1));
				if (this._isUserPayWalletAvailable && this._isReserveAndPayInTheEndAvailable)
				{
					wrapper3.AddInlineButton(Language.PayFromWallet, string.Concat(new object[]
					{
						"/payCurrency?id=",
						productId,
						"?buyAmount=",
						buyAmount
					}), "", null);
					wrapper3.AddInlineButton(Language.PayWithReserve, string.Concat(new object[]
					{
						"/product?id=",
						productId,
						"?buyAmount=",
						buyAmount,
						"?payCurrency=",
						PayCurrency.None.ToString()
					}), "", null);
					await Helper.SendOrModifyMessage(botClient, user, text, wrapper3.GetInlineKeyboardMarkup());
				}
				else if (this._isUserPayWalletAvailable)
				{
					await this.showPayCurrency(context, user, botClient, productId, buyAmount);
				}
				else if (this._isReserveAndPayInTheEndAvailable)
				{
					await this.showProduct(context, user, botClient, productId, PayCurrency.None, buyAmount);
				}
				product = null;
				text = null;
				wrapper3 = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		private async Task showPayCurrency(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId, int buyAmount)
		{
			try
			{
				string text = string.Format("{0} {1}\n\n", "\ud83d\uded2", Language.Shop);
				user.Action = TelegramBotBankStore.Domain.User.Actions.Store;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				string buttonBTC = "BTC";
				bool flag = this._discountBTC > 0m;
				if (flag)
				{
					buttonBTC += string.Format(" ({0} {1}%)", Language.Discount, this._discountBTC);
				}
				wrapper.AddInlineButton(Main.CURRENCY_NAME_CURRENT, string.Concat(new object[]
				{
					"/product?id=",
					productId,
					"?payCurrency=",
					PayCurrency.RUB.ToString(),
					"?buyAmount=",
					buyAmount
				}), "", "\ud83d\udcb5");
				wrapper.AddInlineButton(buttonBTC, string.Concat(new object[]
				{
					"/product?id=",
					productId,
					"?payCurrency=",
					PayCurrency.BTC.ToString(),
					"?buyAmount=",
					buyAmount
				}), "", null);
				bool flag2 = this._isApironeAvailable && this._apironeIsPayLTC;
				if (flag2)
				{
					string buttonLTC = "LTC";
					bool flag3 = this._discountLTC > 0m;
					if (flag3)
					{
						buttonLTC += string.Format(" ({0} {1}%)", Language.Discount, this._discountLTC);
					}
					wrapper.AddInlineButton(buttonLTC, string.Concat(new object[]
					{
						"/product?id=",
						productId,
						"?payCurrency=",
						PayCurrency.LTC.ToString(),
						"?buyAmount=",
						buyAmount
					}), "", null);
					buttonLTC = null;
				}
				await Helper.SendOrModifyMessage(botClient, user, text, wrapper.GetInlineKeyboardMarkup());
				text = null;
				wrapper = null;
				buttonBTC = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000F668 File Offset: 0x0000D868
		private async Task showPay2AndReserve(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId, int buyAmount)
		{
			try
			{
				string text = string.Format("{0} {1}\n\n", "\ud83d\uded2", Language.SelectPaymentMethod);
				PromoCode promo = this.UserPromocode(context, user);
				bool flag = promo != null;
				if (flag)
				{
					text += string.Format(Language.PromoCodeWillBeApplied + "\n\n", promo.Value, promo.DiscountFrom + Main.CURRENCY_NAME_CURRENT);
				}
				user.Action = TelegramBotBankStore.Domain.User.Actions.Store;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				string buttonBTC = "BTC";
				bool flag2 = this._discountBTC > 0m;
				if (flag2)
				{
					buttonBTC += string.Format(" ({0} {1}%)", Language.Discount, this._discountBTC);
				}
				wrapper.AddInlineButton(buttonBTC, "/load", "", "\ud83d\udce4");
				bool isExmoAvailable = Settings.Default.IsExmoAvailable;
				if (isExmoAvailable)
				{
					wrapper.AddInlineButton("EXMO code " + Main.CURRENCY_NAME_CURRENT.ToUpper().Replace(".", ""), "/loadExmo", "", "\ud83d\udce4");
				}
				bool isQiwiAvailable = Settings.Default.IsQiwiAvailable;
				if (isQiwiAvailable)
				{
					wrapper.AddInlineButton("Qiwi", "/loadQiwi", "", "\ud83d\udce4");
				}
				bool isYandexAvailable = Settings.Default.IsYandexAvailable;
				if (isYandexAvailable)
				{
					wrapper.AddInlineButton("Yandex", "/loadYandex", "", "\ud83d\udce4");
				}
				bool flag3 = this._isApironeAvailable && this._apironeIsPayLTC;
				if (flag3)
				{
					string buttonLTC = "LTC";
					bool flag4 = this._discountLTC > 0m;
					if (flag4)
					{
						buttonLTC += string.Format(" ({0} {1}%)", Language.Discount, this._discountLTC);
					}
					wrapper.AddInlineButton(buttonLTC, "/loadLTC", "", "\ud83d\udce4");
					buttonLTC = null;
				}
				bool isCardAvailable = Settings.Default.IsCardAvailable;
				if (isCardAvailable)
				{
					wrapper.AddInlineButton(Language.PayToCard, "/loadCard", "", "\ud83d\udce4");
				}
				bool isTele2Available = Settings.Default.IsTele2Available;
				if (isTele2Available)
				{
					wrapper.AddInlineButton("Tele2", "/loadTele2", "", "\ud83d\udce4");
				}
				Product product = context.Products.FirstOrDefault((Product x) => x.Id == productId);
				bool flag5 = product != null && product.PositionsList.Count >= buyAmount;
				if (flag5)
				{
					string positions = "";
					int num;
					for (int i = 0; i < buyAmount; i = num + 1)
					{
						string position = product.PositionsList.FirstOrDefault<string>();
						bool flag6 = i == buyAmount - 1;
						if (flag6)
						{
							positions += position;
						}
						else
						{
							positions = positions + position + "\r\n";
						}
						product.Positions = this.ReplaceFirst(product.Positions, position, "");
						product.Positions = product.Positions.Replace("\r\n\r\n", "\r\n");
						bool flag7 = product.Positions.StartsWith("\r\n");
						if (flag7)
						{
							product.Positions = product.Positions.Substring(2);
						}
						position = null;
						num = i;
					}
					Product product_temp = new Product();
					product_temp.Currency = PayCurrency.None;
					product_temp.User = user;
					product_temp.Name = product.Name;
					product_temp.Price = product.Price * buyAmount;
					bool flag8 = promo != null && product_temp.Price >= promo.DiscountFrom;
					if (flag8)
					{
						product_temp.Price = product.PriceWithDiscount(promo.Value) * buyAmount;
					}
					product_temp.Status = ProductStatus.WaitForPay;
					product_temp.HistoryCategoryId = new long?(product.Category.Id);
					product_temp.HistoryCategoryName = product.Category.Name;
					product_temp.HistoryOnePositionPrice = new decimal?(product.Price);
					product_temp.PurchaseDate = new DateTime?(DateTime.Now);
					product_temp.PurchasePosition = positions;
					user.Products.Add(product_temp);
					await Helper.SendOrModifyMessage(botClient, user, text, wrapper.GetInlineKeyboardMarkup());
					positions = null;
					product_temp = null;
				}
				text = null;
				promo = null;
				wrapper = null;
				buttonBTC = null;
				product = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		private Product OrderWaitingForPayPrepareAndGet(TelegramBotBankStore.Domain.User user, PayCurrency currency)
		{
			Product product = user.Products.FirstOrDefault((Product x) => x.Status == ProductStatus.WaitForPay);
			bool flag = product == null;
			if (flag)
			{
				throw new Exception("User do not have order for pay!");
			}
			product.Currency = currency;
			bool flag2 = currency == PayCurrency.BTC;
			if (flag2)
			{
				product.SumToPay = new decimal?(product.PriceIn_BTC_Or_LTC(this.BTC_RATE, this._discountBTC));
			}
			else
			{
				bool flag3 = currency == PayCurrency.LTC;
				if (flag3)
				{
					product.SumToPay = new decimal?(product.PriceIn_BTC_Or_LTC(this.LTC_RATE, this._discountLTC));
				}
				else
				{
					bool flag4 = currency == PayCurrency.RUB;
					if (flag4)
					{
						bool flag5 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.RUB;
						if (flag5)
						{
							product.SumToPay = new decimal?(product.Price);
						}
						else
						{
							bool flag6 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD;
							if (!flag6)
							{
								throw new Exception("Undefined currency.");
							}
							product.SumToPay = new decimal?(Math.Round(product.Price * this.RUB_RATE));
						}
					}
					else
					{
						bool flag7 = currency == PayCurrency.USD;
						if (!flag7)
						{
							throw new Exception("Pay currency is not set!");
						}
						bool flag8 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD;
						if (!flag8)
						{
							throw new Exception("Undefined currency for usd bot.");
						}
						product.SumToPay = new decimal?(product.Price);
					}
				}
			}
			return product;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000F844 File Offset: 0x0000DA44
		private async void CheckOrderTime()
		{
			try
			{
				bool flag = this._botClient == null;
				if (flag)
				{
					this.createClient();
				}
				double timeToCancel = (double)Settings.Default.TimeToCancelOrder;
				using (BotContext context = new BotContext())
				{
					foreach (Product prod in from x in context.Products
					where (int)x.Status == 1
					select x)
					{
						TimeSpan tsLeft = prod.PurchaseDate.Value.AddMinutes(timeToCancel) - DateTime.Now;
						bool flag2 = tsLeft.Minutes <= 0;
						if (flag2)
						{
							await this.CancelWaitForPayProduct(context, prod.User, false, true);
						}
						else if (tsLeft.Minutes == 20 || tsLeft.Minutes == 10 || tsLeft.Minutes == 5)
						{
							await this._botClient.SendTextMessageAsync(prod.User.ChatId, string.Format(Language.CheckOrderLeftTime, tsLeft.Minutes), ParseMode.Html, false, false, 0, null, default(CancellationToken));
						}
						tsLeft = default(TimeSpan);
						prod = null;
					}
					IEnumerator<Product> enumerator = null;
				}
				BotContext context = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000F880 File Offset: 0x0000DA80
		private async Task CancelWaitForPayProduct(BotContext context, TelegramBotBankStore.Domain.User user, bool isAdmin = false, bool isTimeOut = false)
		{
			Product prodCancle = user.Products.FirstOrDefault((Product x) => x.Status == ProductStatus.WaitForPay);
			bool flag = prodCancle != null;
			if (flag)
			{
				Product product = context.Products.FirstOrDefault((Product x) => x.Name == prodCancle.Name && x.Category.Id == prodCancle.HistoryCategoryId.Value);
				bool flag2 = product == null;
				if (flag2)
				{
					Category cat = context.Categories.FirstOrDefault((Category x) => x.Name == prodCancle.HistoryCategoryName);
					bool flag3 = cat == null;
					if (flag3)
					{
						cat = new Category();
						cat.Parent = null;
						cat.Name = prodCancle.HistoryCategoryName;
						context.Categories.Add(cat);
					}
					product = new Product();
					product.Category = cat;
					product.Name = prodCancle.Name;
					product.Price = prodCancle.HistoryOnePositionPrice.Value;
					cat.Products.Add(product);
					cat = null;
				}
				Product product2 = product;
				product2.Positions = product2.Positions + "\r\n" + prodCancle.PurchasePosition;
				product.Positions = product.Positions.Replace("\r\n\r\n", "\r\n");
				bool flag4 = product.Positions.StartsWith("\r\n");
				if (flag4)
				{
					product.Positions = product.Positions.Substring(2);
				}
				if (isAdmin)
				{
					prodCancle.Status = ProductStatus.AdminCanceled;
				}
				else if (isTimeOut)
				{
					prodCancle.Status = ProductStatus.TimeOut;
				}
				else
				{
					prodCancle.Status = ProductStatus.Canceled;
				}
				context.SaveChanges();
				string text = Language.OrderCanceled;
				await Helper.SendOrModifyMessage(this._botClient, user, text, null);
				product = null;
				text = null;
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
		private async Task<bool> ConfirmWaitForPayProduct(BotContext context, TelegramBotBankStore.Domain.User user, decimal payed, PayCurrency currency, bool isAdmin = false)
		{
			Product prod = user.Products.FirstOrDefault((Product x) => x.Status == ProductStatus.WaitForPay);
			bool flag = prod != null;
			if (flag)
			{
				decimal? sumToPay = prod.SumToPay;
				bool flag2 = (payed >= sumToPay.GetValueOrDefault() & sumToPay != null) && prod.Currency == currency;
				if (flag2)
				{
					if (isAdmin)
					{
						prod.Status = ProductStatus.AdminConfirmed;
					}
					else
					{
						prod.Status = ProductStatus.Paid;
					}
					prod.PurchaseSum = new decimal?(payed);
					PromoCode promo = this.UserPromocode(context, user);
					bool flag3 = promo != null && prod.Price >= promo.DiscountFrom;
					if (flag3)
					{
						this.ApplyPromocode(promo);
					}
					context.SaveChanges();
					string productsBuyed = prod.Name + "\n\n" + prod.PurchasePosition;
					string text = Language.YouPaidTheOrder + "\n\n" + prod.PurchasePosition;
					Product product = context.Products.FirstOrDefault((Product x) => x.Name == prod.Name);
					await this.WorkAfterShowBuy(user, product, text, productsBuyed);
					this.UpdateReferal(context, user, currency, payed);
					return true;
				}
				await this._botClient.SendTextMessageAsync(user.ChatId, Language.ErrorConfirmTheOrder, ParseMode.Html, false, false, 0, null, default(CancellationToken));
			}
			return false;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000F950 File Offset: 0x0000DB50
		private void dataGridViewProductsUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			bool flag = e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right && this.dataGridViewProductsUser.SelectedCells.Count == 1;
			if (flag)
			{
				ContextMenu contextMenu = new ContextMenu();
				MenuItem menuItem = contextMenu.MenuItems.Add("Подтвердить оплату");
				menuItem.Click += this.item_ClickConfirmOrderAsync;
				MenuItem menuItem2 = contextMenu.MenuItems.Add("Отменить резерв");
				menuItem2.Click += this.item_ClickCancelOrderAsync;
				contextMenu.MenuItems.Add(menuItem);
				contextMenu.MenuItems.Add(menuItem2);
				DataGridView dataGridView = (DataGridView)sender;
				contextMenu.Show(this.dataGridViewProductsUser, this.dataGridViewProductsUser.PointToClient(System.Windows.Forms.Cursor.Position));
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		private async void item_ClickConfirmOrderAsync(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dataGridViewProductsUser.SelectedCells.Count == 1;
				if (flag)
				{
					using (BotContext context = new BotContext())
					{
						bool flag2 = this.selectedUserId != null && context.Users.Any((TelegramBotBankStore.Domain.User x) => x.Id == this.selectedUserId.Value);
						if (flag2)
						{
							TelegramBotBankStore.Domain.User user = context.Users.FirstOrDefault((TelegramBotBankStore.Domain.User x) => x.Id == this.selectedUserId.Value);
							Product prod = user.Products.FirstOrDefault((Product x) => x.Status == ProductStatus.WaitForPay);
							bool flag3 = prod != null;
							if (flag3)
							{
								await this.ConfirmWaitForPayProduct(context, user, prod.SumToPay.Value, prod.Currency, true);
							}
							user = null;
							prod = null;
						}
						else
						{
							MessageBox.Show("Ошибка определения юзера, попробуйте заново.");
						}
					}
					BotContext context = null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000FA78 File Offset: 0x0000DC78
		private async void item_ClickCancelOrderAsync(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dataGridViewProductsUser.SelectedCells.Count == 1;
				if (flag)
				{
					using (BotContext context = new BotContext())
					{
						bool flag2 = this.selectedUserId != null && context.Users.Any((TelegramBotBankStore.Domain.User x) => x.Id == this.selectedUserId.Value);
						if (flag2)
						{
							TelegramBotBankStore.Domain.User user = context.Users.FirstOrDefault((TelegramBotBankStore.Domain.User x) => x.Id == this.selectedUserId.Value);
							await this.CancelWaitForPayProduct(context, user, true, false);
							user = null;
						}
						else
						{
							MessageBox.Show("Ошибка определения юзера, попробуйте заново.");
						}
					}
					BotContext context = null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		private async Task showBuyAmount(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId)
		{
			try
			{
				string text = string.Format("{0} {1}\n\n", "\ud83d\uded2", Language.Shop);
				user.Action = TelegramBotBankStore.Domain.User.Actions.WaitForBuyAmount;
				user.CommentForBuy = productId.ToString();
				Product product = context.Products.FirstOrDefault((Product x) => x.Id == productId);
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Back, "/back?id=" + product.Category.Id, "", "↩");
				int ccont = context.Products.FirstOrDefault((Product x) => x.Id == productId).PositionsList.Count;
				text += string.Format(Language.EnterAmountToBuy + "\n\n", ccont);
				bool flag = user.MessageId != null;
				if (flag)
				{
					await botClient.EditMessageTextAsync(user.ChatId, user.MessageId.Value, text, ParseMode.Html, false, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				}
				else
				{
					Telegram.Bot.Types.Message message2 = await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
					Telegram.Bot.Types.Message message = message2;
					message2 = null;
					user.MessageId = new int?(message.MessageId);
					message = null;
				}
				text = null;
				product = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000FB28 File Offset: 0x0000DD28
		private async Task showProduct(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId, PayCurrency currency, int buyAmount)
		{
			try
			{
				string text = string.Format("{0} {1}\n\n", "\ud83d\uded2", Language.Shop);
				user.Action = TelegramBotBankStore.Domain.User.Actions.Store;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				Product product = context.Products.FirstOrDefault((Product x) => x.Id == productId);
				PromoCode promo = this.UserPromocode(context, user);
				bool flag = promo != null;
				if (flag)
				{
					text = text + string.Format(Language.PromoCodeWillBeApplied, promo.Value, promo.DiscountFrom + Main.CURRENCY_NAME_CURRENT) + "\n\n";
				}
				decimal productPrice = 10000000m;
				bool flag2 = product != null && product.Price > 0m;
				if (flag2)
				{
					productPrice = product.Price * buyAmount;
					bool flag3 = promo != null && productPrice >= promo.DiscountFrom;
					if (flag3)
					{
						productPrice = product.PriceWithDiscount(promo.Value) * buyAmount;
					}
				}
				bool flag4 = !product.PositionsList.Any<string>();
				if (flag4)
				{
					text = text + this.getFullProductName(product, true) + "\n\n";
					text += Settings.Default.PositionOutOfStock;
					wrapper.AddInlineButton(Language.Back, "/back?id=" + product.Category.Id, "", "↩");
				}
				else
				{
					bool flag5 = product.PositionsList.Count < buyAmount;
					if (flag5)
					{
						user.Action = TelegramBotBankStore.Domain.User.Actions.WaitForBuyAmount;
						text += string.Format("{0} {1}", "\ud83d\udeab", Language.NotEnoughPosition);
						text += string.Format("\n\n {0}: {1} ", Language.AvailablePositions, product.PositionsList.Count);
						wrapper.AddInlineButton(Language.Back, "/back?id=" + product.Category.Id, "", "↩");
					}
					else
					{
						bool flag6 = currency == PayCurrency.None && this._isReserveAndPayInTheEndAvailable;
						if (flag6)
						{
							text += string.Format("{0}\n\n{1}: {2}\n\n", this.getFullProductName(product, true), Language.Amount, buyAmount);
							wrapper.AddInlineButton(Language.Buy, string.Concat(new object[]
							{
								"/payAndReserve?id=",
								product.Id,
								"?payCurrency=",
								currency.ToString(),
								"?buyAmount=",
								buyAmount
							}), "", "✅");
							wrapper.AddInlineButton(Language.Cancel, "/back?id=" + product.Category.Id, "", "❌");
						}
						else
						{
							bool flag7 = (currency == PayCurrency.BTC && user.BalanceBTCInRub(this.BTC_RATE) >= productPrice) || (currency == PayCurrency.LTC && user.BalanceLTCInRub(this.LTC_RATE) >= productPrice) || (currency == PayCurrency.RUB && user.BalanceRUB >= productPrice);
							if (flag7)
							{
								text += string.Format("{0}\n\n{1}: {2}\n\n", this.getFullProductName(product, true), Language.Amount, buyAmount);
								wrapper.AddInlineButton(Language.Buy, string.Concat(new object[]
								{
									"/buy?id=",
									product.Id,
									"?payCurrency=",
									currency.ToString(),
									"?buyAmount=",
									buyAmount
								}), "", "✅");
								wrapper.AddInlineButton(Language.Cancel, "/back?id=" + product.Category.Id, "", "❌");
							}
							else
							{
								text += string.Format("{0} {1}\n\n", "\ud83d\udeab", Language.NotEnoughMoney);
								wrapper.AddInlineButton(Language.Back, "/back?id=" + product.Category.Id, "", "↩");
							}
						}
					}
				}
				bool flag8 = user.MessageId != null;
				if (flag8)
				{
					await botClient.EditMessageTextAsync(user.ChatId, user.MessageId.Value, text, ParseMode.Html, false, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				}
				else
				{
					Telegram.Bot.Types.Message message2 = await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
					Telegram.Bot.Types.Message message = message2;
					message2 = null;
					user.MessageId = new int?(message.MessageId);
					message = null;
				}
				text = null;
				wrapper = null;
				product = null;
				promo = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		private async Task showBuy(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId, PayCurrency currency, int buyAmount, bool isForOperator = false)
		{
			Main.<>c__DisplayClass144_0 CS$<>8__locals1 = new Main.<>c__DisplayClass144_0();
			CS$<>8__locals1.productId = productId;
			try
			{
				bool flag = buyAmount < 0;
				if (!flag)
				{
					bool flag2 = user.MessageId != null;
					if (flag2)
					{
						try
						{
							await botClient.EditMessageTextAsync(user.ChatId, user.MessageId.Value, Language.ThankForBuy, ParseMode.Html, false, null, default(CancellationToken));
						}
						catch
						{
						}
					}
					string text = string.Format("{0} {1}:\n\n", "✅", Language.BuySuccess);
					string productsBuyed = "";
					IQueryable<Product> products = context.Products;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(Product), "x");
					Product product = products.FirstOrDefault(Expression.Lambda<Func<Product, bool>>(Expression.Equal(Expression.Property(parameterExpression, methodof(Product.get_Id())), Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Main.<>c__DisplayClass144_0)), fieldof(Main.<>c__DisplayClass144_0.productId))), new ParameterExpression[]
					{
						parameterExpression
					}));
					productsBuyed = product.Name + "\n\n";
					PromoCode promo = null;
					decimal addDiscount = 0m;
					decimal productPrice = 0m;
					if (!isForOperator)
					{
						promo = this.UserPromocode(context, user);
						if (promo != null)
						{
							productPrice = product.Price * buyAmount;
							if (productPrice >= promo.DiscountFrom)
							{
								addDiscount = promo.Value;
							}
						}
					}
					for (int i = 0; i < buyAmount; i++)
					{
						string position = product.PositionsList.FirstOrDefault<string>();
						if (!string.IsNullOrEmpty(position) && product.Positions.Contains(position))
						{
							decimal price = -1m;
							if (!isForOperator)
							{
								if (currency == PayCurrency.BTC)
								{
									price = product.PriceIn_BTC_Or_LTC(this.BTC_RATE, this._discountBTC + addDiscount);
									if (user.BalanceBTC < price)
									{
										goto IL_650;
									}
									user.BalanceBTC -= price;
								}
								else if (currency == PayCurrency.RUB)
								{
									price = product.PriceWithDiscount(addDiscount);
									if (user.BalanceRUB < price)
									{
										goto IL_650;
									}
									user.BalanceRUB -= price;
								}
								else if (currency == PayCurrency.LTC)
								{
									price = product.PriceIn_BTC_Or_LTC(this.LTC_RATE, this._discountLTC + addDiscount);
									if (user.BalanceLTC < price)
									{
										goto IL_650;
									}
									user.BalanceLTC -= price;
								}
								if (price == -1m)
								{
									goto IL_650;
								}
							}
							product.Positions = this.ReplaceFirst(product.Positions, position, "");
							product.Positions = product.Positions.Replace("\r\n\r\n", "\r\n");
							if (product.Positions.StartsWith("\r\n"))
							{
								product.Positions = product.Positions.Substring(2);
							}
							Product product_temp = new Product();
							product_temp.Currency = currency;
							product_temp.User = user;
							product_temp.Name = product.Name;
							product_temp.Price = product.Price;
							product_temp.PurchaseDate = new DateTime?(DateTime.Now);
							product_temp.PurchaseSum = new decimal?(price);
							product_temp.PurchasePosition = position;
							Product product2 = product_temp;
							Category category = product.Category;
							product2.HistoryCategoryId = ((category != null) ? new long?(category.Id) : null);
							product_temp.IsForOperator = isForOperator;
							user.Products.Add(product_temp);
							text = text + position + "\n";
							productsBuyed = productsBuyed + position + "\n";
							position = null;
							product_temp = null;
						}
						IL_650:;
					}
					if (!isForOperator && promo != null && productPrice >= promo.DiscountFrom)
					{
						this.ApplyPromocode(promo);
					}
					context.SaveChanges();
					await this.WorkAfterShowBuy(user, product, text, productsBuyed);
					text = null;
					productsBuyed = null;
					product = null;
					promo = null;
				}
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000FC18 File Offset: 0x0000DE18
		private async Task WorkAfterShowBuy(TelegramBotBankStore.Domain.User user, Product product, string text, string productsBuyed)
		{
			bool isReviewAvailable = Settings.Default.IsReviewAvailable;
			if (isReviewAvailable)
			{
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Review, "/Review", "", "\ud83d\udcc3");
				await Helper.SendBotLongMessage(this._botClient, user.ChatId, text, wrapper.GetInlineKeyboardMarkup());
				wrapper = null;
			}
			else
			{
				await Helper.SendBotLongMessage(this._botClient, user.ChatId, text, null);
			}
			if (product != null && product.PositionsList.Count < 3)
			{
				this.sendNotificationLessPositions(product.Id);
			}
			this.sendNotification(string.Concat(new string[]
			{
				user.UserName,
				" ",
				user.FirstName,
				", ",
				DateTime.Now.ToString(),
				" купил:\n",
				productsBuyed
			}));
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000FC7C File Offset: 0x0000DE7C
		public string ReplaceFirst(string text, string search, string replace)
		{
			int num = text.IndexOf(search);
			bool flag = num < 0;
			string result;
			if (flag)
			{
				result = text;
			}
			else
			{
				result = text.Substring(0, num) + replace + text.Substring(num + search.Length);
			}
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		private async Task showWallet(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				string text = string.Format("{0} {1}:\n\n", "\ud83d\udcb5", Language.Balance);
				user.MessageId = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.Wallet;
				text += string.Format("\ud83c\udf1e " + Language.ActualCourse + " BTC: 1 BTC = {0} {1}\n\n", Math.Round(this.BTC_RATE, 0), Main.CURRENCY_NAME_CURRENT);
				text += string.Format(Language.BalanceYouWallet + ": {0} BTC ({1} {2})\n", user.BalanceBTC, Math.Round(user.BalanceBTCInRub(this.BTC_RATE), 0), Main.CURRENCY_NAME_CURRENT);
				text += string.Format(Language.AmountOfLoad + ": {0} BTC\n", user.TotalLoadedBTC);
				text += string.Format(Language.AmountOfSpend + ": {0} BTC\n", user.TotalSpentBTC);
				text += string.Format("\n\n\ud83c\udf1e " + Language.BalanceYouWallet + ": {0} {1}\n", Math.Round(user.BalanceRUB), Main.CURRENCY_NAME_CURRENT);
				text += string.Format(Language.AmountOfLoad + ": {0} {1}\n", Math.Round(user.TotalLoadedRUB), Main.CURRENCY_NAME_CURRENT);
				text += string.Format(Language.AmountOfSpend + ": {0} {1}\n", Math.Round(user.TotalSpentRUB), Main.CURRENCY_NAME_CURRENT);
				text += string.Format("\n\n\ud83c\udf1e " + Language.ActualCourse + " LTC: 1 LTC = {0} {1}\n\n", Math.Round(this.LTC_RATE, 0), Main.CURRENCY_NAME_CURRENT);
				text += string.Format(Language.BalanceYouWallet + ": {0} LTC ({1} {2})\n", user.BalanceLTC, Math.Round(user.BalanceLTCInRub(this.LTC_RATE), 0), Main.CURRENCY_NAME_CURRENT);
				text += string.Format(Language.AmountOfLoad + ": {0} LTC\n", user.TotalLoadedLTC);
				text += string.Format(Language.AmountOfSpend + ": {0} LTC\n", user.TotalSpentLTC);
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				bool flag = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag)
				{
					text = text + "\n\n\n" + Language.WalletForWorkCancelOrder;
				}
				else
				{
					wrapper.AddInlineButton(Language.History, "/history", "", "⏳");
					wrapper.AddInlineButton(Language.Load, "/load", "", "\ud83d\udce4");
					wrapper.AddInlineButton(string.Format("{0} {1}", Language.ConvertTo, PayCurrency.BTC), "/ConvertAllTo?payCurrency=" + PayCurrency.BTC, "", "\ud83d\udcd5");
					bool isExmoAvailable = Settings.Default.IsExmoAvailable;
					if (isExmoAvailable)
					{
						wrapper.AddInlineButton(Language.Load_Exmo, "/loadExmo", "", "\ud83d\udce4");
					}
					bool isQiwiAvailable = Settings.Default.IsQiwiAvailable;
					if (isQiwiAvailable)
					{
						wrapper.AddInlineButton(Language.Load_Qiwi, "/loadQiwi", "", "\ud83d\udce4");
					}
					bool isYandexAvailable = Settings.Default.IsYandexAvailable;
					if (isYandexAvailable)
					{
						wrapper.AddInlineButton(Language.Load_Yandex, "/loadYandex", "", "\ud83d\udce4");
					}
					bool flag2 = this._isApironeAvailable && this._apironeIsPayLTC;
					if (flag2)
					{
						wrapper.AddInlineButton(Language.Load_LTC, "/loadLTC", "", "\ud83d\udce4");
					}
					bool isCardAvailable = Settings.Default.IsCardAvailable;
					if (isCardAvailable)
					{
						wrapper.AddInlineButton(Language.Load_Card, "/loadCard", "", "\ud83d\udce4");
					}
					bool isTele2Available = Settings.Default.IsTele2Available;
					if (isTele2Available)
					{
						wrapper.AddInlineButton(Language.Load_Tele2, "/loadTele2", "", "\ud83d\udce4");
					}
					bool isSendMoneyButtonAvailabile = Settings.Default.IsSendMoneyButtonAvailabile;
					if (isSendMoneyButtonAvailabile)
					{
						wrapper.AddInlineButton("Перевод юзеру", "/SendMoney", "", "\ud83d\udce4");
						wrapper.AddInlineButton("Получить ID", "/ReceiveMoney", "", "\ud83d\udce4");
					}
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		private async Task ConverAllWalletTo(BotContext context, TelegramBotBankStore.Domain.User user, PayCurrency ConvertTo)
		{
			bool flag = ConvertTo == PayCurrency.BTC;
			if (flag)
			{
				bool flag2 = user.BalanceRUB > 0m;
				if (flag2)
				{
					user.BalanceBTC += user.BalanceRUBInBTC(this.BTC_RATE);
					user.BalanceRUB = 0m;
				}
				bool flag3 = user.BalanceLTC > 0m;
				if (flag3)
				{
					user.BalanceBTC += user.BalanceLTCInRub(this.LTC_RATE) / this.BTC_RATE;
					user.BalanceLTC = 0m;
				}
			}
			else
			{
				bool flag4 = ConvertTo == PayCurrency.LTC;
				if (!flag4)
				{
					bool flag5 = ConvertTo == PayCurrency.RUB;
					if (flag5)
					{
						decimal convAdd = 0m;
						bool flag6 = user.BalanceBTC > 0m;
						if (flag6)
						{
							convAdd += user.BalanceBTCInRub(this.BTC_RATE);
						}
						bool flag7 = user.BalanceLTC > 0m;
						if (flag7)
						{
							convAdd += user.BalanceLTCInRub(this.LTC_RATE);
						}
					}
				}
			}
			context.SaveChanges();
			await this._botClient.SendTextMessageAsync(user.ChatId, "Готово. Все средства конвертированы и перведены в" + ConvertTo, ParseMode.Html, false, false, 0, null, default(CancellationToken));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000FD78 File Offset: 0x0000DF78
		private async Task showLoad(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				user.MessageId = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.Load;
				bool flag = string.IsNullOrEmpty(user.WalletBTC);
				if (flag)
				{
					bool flag2 = this._isApironeAvailable && this._apironeIsPayBTC;
					if (flag2)
					{
						user.WalletBTC = this._apironeAPIWallet.GetBtcAddress();
					}
					else
					{
						bool flag3 = this._walletBTC != null;
						if (flag3)
						{
							WalletAddress walletAddress = await this._walletBTC.NewAddressAsync(user.UserName);
							WalletAddress newAddr = walletAddress;
							walletAddress = null;
							user.WalletBTC = newAddr.AddressStr;
							newAddr = null;
						}
					}
					if (!string.IsNullOrEmpty(user.WalletBTC))
					{
						UserWalletHistory hist = new UserWalletHistory();
						hist.Address = user.WalletBTC;
						hist.HistoryType = HistoryType.BTC;
						hist.User = user;
						user.WalletHistories.Add(hist);
						hist = null;
					}
				}
				string text = string.Empty;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(1));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				if (Settings.Default.IsButtonIPaidForElse)
				{
					wrapper.AddInlineButton(Language.IPaid, "/IPaid?mthPaied=BTC", "", "✋");
				}
				if (user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay))
				{
					Product product = this.OrderWaitingForPayPrepareAndGet(user, PayCurrency.BTC);
					text = Language.YourOrderBTCAddress.Replace("\\n", "\n");
					text = text + "\n\n" + string.Format(Language.TimeForPay, Settings.Default.TimeToCancelOrder);
					text = text + "\n\n" + Language.SumToBePaid.Replace("\\n", "\n");
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
					await botClient.SendTextMessageAsync(user.ChatId, product.SumToPay.ToString(), ParseMode.Html, false, false, 0, null, default(CancellationToken));
					product = null;
				}
				else
				{
					text = string.Format("{0} {1}\n\n", "\ud83d\udcb5", Language.Balance);
					text += Language.YourOwnBTCAddress.Replace("\\n", "\n");
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				}
				await botClient.SendTextMessageAsync(user.ChatId, user.WalletBTC, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
		private async Task showLoadLTC(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				user.MessageId = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.LoadLTC;
				bool flag = this._isApironeAvailable && this._apironeIsPayLTC;
				if (flag)
				{
					bool flag2 = this._apironeAPIWallet != null;
					if (flag2)
					{
						user.WalletLTC = this._apironeAPIWallet.GetLtcAddress();
					}
					bool flag3 = !string.IsNullOrEmpty(user.WalletLTC);
					if (flag3)
					{
						UserWalletHistory hist = new UserWalletHistory();
						hist.Address = user.WalletLTC;
						hist.HistoryType = HistoryType.LTC;
						hist.User = user;
						user.WalletHistories.Add(hist);
						hist = null;
					}
				}
				string text = string.Empty;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(1));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				bool isButtonIPaidForElse = Settings.Default.IsButtonIPaidForElse;
				if (isButtonIPaidForElse)
				{
					wrapper.AddInlineButton(Language.IPaid, "/IPaid?mthPaied=LTC", "", "✋");
				}
				bool flag4 = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag4)
				{
					Product product = this.OrderWaitingForPayPrepareAndGet(user, PayCurrency.LTC);
					text = Language.YourOrderLTCAddress.Replace("\\n", "\n");
					text = text + "\n\n" + string.Format(Language.TimeForPay, Settings.Default.TimeToCancelOrder);
					text = text + "\n\n" + Language.SumToBePaid.Replace("\\n", "\n");
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
					await botClient.SendTextMessageAsync(user.ChatId, product.SumToPay.ToString(), ParseMode.Html, false, false, 0, null, default(CancellationToken));
					product = null;
				}
				else
				{
					text = string.Format("{0} {1}\n\n", "\ud83d\udcb5", Language.Balance);
					text += Language.YourOwnLTCAddress.Replace("\\n", "\n");
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				}
				await botClient.SendTextMessageAsync(user.ChatId, user.WalletLTC, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000FE30 File Offset: 0x0000E030
		private async Task showLoadCard(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				user.MessageId = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.None;
				string text = string.Empty;
				bool flag = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag)
				{
					Product product = this.OrderWaitingForPayPrepareAndGet(user, PayCurrency.RUB);
					text = string.Concat(new object[]
					{
						Language.SumToBePaid.Replace("\\n", "\n"),
						" ",
						product.SumToPay,
						" ",
						Main.CURRENCY_NAME_RUB
					});
					text = text + "\n\n" + string.Format(Language.TimeForPay, Settings.Default.TimeToCancelOrder);
					product = null;
				}
				else
				{
					text = string.Format("{0} {1}", "\ud83d\udcb5", Language.Balance);
				}
				bool isButtonIPaidForCard = Settings.Default.IsButtonIPaidForCard;
				if (isButtonIPaidForCard)
				{
					text = text + "\n\n" + Language.LoadCard2.Replace("\\n", "\n");
				}
				else
				{
					text = text + "\n\n" + Language.LoadCard.Replace("\\n", "\n");
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				TelegramWrapper wrapper = new TelegramWrapper(new int?(1));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				if (Settings.Default.IsButtonIPaidForCard)
				{
					wrapper.AddInlineButton(Language.IPaid, "/IPaid?mthPaied=Card", "", "✋");
				}
				await botClient.SendTextMessageAsync(user.ChatId, Settings.Default.CardNumber, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000FE8C File Offset: 0x0000E08C
		private async Task showLoadExmoCode(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				user.MessageId = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.LoadExmoCode;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				string text = string.Empty;
				bool flag = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag)
				{
					PayCurrency upc = PayCurrency.None;
					bool flag2 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.RUB;
					if (flag2)
					{
						upc = PayCurrency.RUB;
					}
					else
					{
						bool flag3 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD;
						if (!flag3)
						{
							throw new Exception("Currency error.");
						}
						upc = PayCurrency.USD;
					}
					Product product = this.OrderWaitingForPayPrepareAndGet(user, upc);
					text = string.Concat(new object[]
					{
						Language.SumToBePaid.Replace("\\n", "\n"),
						" ",
						product.SumToPay,
						" ",
						Main.CURRENCY_NAME_CURRENT
					});
					text = text + "\n\n" + string.Format(Language.TimeForPay, Settings.Default.TimeToCancelOrder);
					text = text + "\n\n" + Language.EnterExmoCode;
					product = null;
				}
				else
				{
					text = string.Format("{0} {1}\n\n", "\ud83d\udcb5", Language.Balance);
					text += Language.EnterExmoCode;
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				wrapper = null;
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		private async Task showLoadYandex(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				user.MessageId = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.LoadYandex;
				string commCode = this.getComment(6);
				user.Comment = "Yandex-" + commCode;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				string text = string.Empty;
				bool flag = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag)
				{
					Product product = this.OrderWaitingForPayPrepareAndGet(user, PayCurrency.RUB);
					text = string.Concat(new object[]
					{
						Language.SumToBePaid.Replace("\\n", "\n"),
						" ",
						product.SumToPay,
						" ",
						Main.CURRENCY_NAME_RUB
					});
					text = text + "\n\n" + string.Format(Language.TimeForPay, Settings.Default.TimeToCancelOrder);
					text = string.Concat(new object[]
					{
						text,
						"Переведите на Яндекс кошелек: ",
						Settings.Default.YandexAddress,
						", или используйте ссылку ниже.\nДобавьте комментарий - ",
						commCode,
						", Без него деньги НЕ ЗАЧИСЛЯЮТСЯ!\n\nhttps://money.yandex.ru/to/",
						Settings.Default.YandexAddress,
						"/",
						product.SumToPay,
						"\n"
					});
					product = null;
				}
				else
				{
					text = string.Format("{0} {1}\n\n", "\ud83d\udcb5", Language.Balance);
					text = string.Concat(new string[]
					{
						text,
						"Переведите на Яндекс кошелек: ",
						Settings.Default.YandexAddress,
						".\nДобавьте комментарий - ",
						commCode,
						", Без него деньги НЕ ЗАЧИСЛЯЮТСЯ!\n"
					});
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				commCode = null;
				wrapper = null;
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000FF44 File Offset: 0x0000E144
		private async Task invoiceCheckExmo(BotContext context, TelegramBotBankStore.Domain.User user, string code)
		{
			bool flag = this._exmoApi == null;
			if (!flag)
			{
				try
				{
					bool flag2 = string.IsNullOrEmpty(code) || code.Length < 20 || !code.StartsWith("EX");
					if (flag2)
					{
						string text = Language.PleaseEnterExmoCode;
						TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
						wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
						await this._botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
					}
					else
					{
						string res = this._exmoApi.ApiQuery("excode_load", new Dictionary<string, string>
						{
							{
								"code",
								code.ToString()
							}
						});
						this.log.Info("invoiceExmo() = " + res.ToString());
						IDictionary<string, string> dic = this._exmoApi.ToDictionary(res);
						if (dic["result"] == "true")
						{
							decimal payed = decimal.Parse(dic["amount"], NumberStyles.Currency, CultureInfo.InvariantCulture);
							string checkCurrency = "None";
							PayCurrency payCurrency = PayCurrency.None;
							if (Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD)
							{
								checkCurrency = "USD";
								payCurrency = PayCurrency.USD;
							}
							else
							{
								if (Main.CURRENCY_BOT_CURRENT != CurrencyBot.RUB)
								{
									throw new Exception("Currency Error.");
								}
								checkCurrency = "RUB";
								payCurrency = PayCurrency.RUB;
							}
							if (payed >= 0m && dic["currency"] == checkCurrency)
							{
								this.log.Info(string.Format("EXMO - payed: User - {0}, code - {1}, sum - {2}, currency - {3}", new object[]
								{
									user.GetFullName(),
									code,
									payed,
									checkCurrency
								}));
								TelegramBotBankStore.Domain.Transaction transaction = new TelegramBotBankStore.Domain.Transaction();
								transaction.TransactionType = TransactionType.Exmo;
								transaction.User = user;
								transaction.Address = code;
								transaction.Sum = payed;
								user.Transactions.Add(transaction);
								user.Action = TelegramBotBankStore.Domain.User.Actions.None;
								context.SaveChanges();
								bool flag3 = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
								bool flag4 = flag3;
								if (flag4)
								{
									bool flag5 = await this.ConfirmWaitForPayProduct(context, user, payed, payCurrency, false);
									flag4 = flag5;
								}
								if (!flag4)
								{
									transaction.IsAddedToBalance = true;
									user.BalanceRUB += payed;
									context.SaveChanges();
									string text2 = string.Format(Language.YourBalanceEncrease + " {0} {1}", payed, Main.CURRENCY_NAME_CURRENT);
									await this._botClient.SendTextMessageAsync(user.ChatId, text2, ParseMode.Html, false, false, 0, null, default(CancellationToken));
									this.UpdateReferal(context, user, payCurrency, payed);
									text2 = null;
								}
								transaction = null;
							}
							checkCurrency = null;
						}
						else
						{
							user.Action = TelegramBotBankStore.Domain.User.Actions.Wallet;
							await this._botClient.SendTextMessageAsync(user.ChatId, Language.WrongCode, ParseMode.Html, false, false, 0, null, default(CancellationToken));
						}
						res = null;
						dic = null;
					}
				}
				catch (Exception ex)
				{
					this.log.Error("invoiceExmo() ", ex);
				}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000FFA0 File Offset: 0x0000E1A0
		private async Task showLoadQiwi(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string message)
		{
			try
			{
				user.Action = TelegramBotBankStore.Domain.User.Actions.LoadQiwi;
				user.MessageId = null;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				string text = string.Empty;
				bool isForOrder = false;
				bool flag = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag)
				{
					Product product = this.OrderWaitingForPayPrepareAndGet(user, PayCurrency.RUB);
					isForOrder = true;
					text = string.Format(Language.TimeForPay, Settings.Default.TimeToCancelOrder);
					text = string.Concat(new object[]
					{
						text,
						"\n\n",
						Language.SumToBePaid.Replace("\\n", "\n"),
						" ",
						product.SumToPay,
						" ",
						Main.CURRENCY_NAME_RUB,
						"\r\n\r\n"
					});
					product = null;
				}
				else
				{
					text = string.Format("{0} {1}\n\n", "\ud83d\udcb5", Language.Balance);
				}
				bool flag2 = Settings.Default.QiwiMethod == 0;
				if (flag2)
				{
					bool flag3 = string.IsNullOrEmpty(message) || message.Contains("+") || !this.IsDigitsOnly(message) || message.Length < 8 || message.Length > 13;
					if (flag3)
					{
						user.Comment = this.GetQiwiNumber();
						user.Action = TelegramBotBankStore.Domain.User.Actions.WaitForQiwiNumber;
						context.SaveChanges();
						text = text + Language.QiwiTransferToWallet + user.Comment;
						text = text + "\n\n" + Language.QiwiNumberFromPaid;
					}
					else
					{
						user.Action = TelegramBotBankStore.Domain.User.Actions.None;
						user.Comment = user.Comment + "-+" + message;
						this.log.Info("QIWI - user number entered  - " + user.Comment);
						context.SaveChanges();
						bool flag4 = isForOrder;
						if (flag4)
						{
							text += Language.QiwiWaitForTransaction;
						}
						else
						{
							text += Language.QiwiWaitForTransactionWallwet;
						}
						bool isButtonIPaidForElse = Settings.Default.IsButtonIPaidForElse;
						if (isButtonIPaidForElse)
						{
							wrapper.AddInlineButton(Language.IPaid, "/IPaid?mthPaied=Qiwi", "", "✋");
						}
					}
				}
				else
				{
					bool flag5 = Settings.Default.QiwiMethod == 1;
					if (flag5)
					{
						string toNumber = this.GetQiwiNumber();
						string commCode = this.getComment(6);
						user.Comment = toNumber + "-" + commCode;
						context.SaveChanges();
						bool flag6 = isForOrder;
						if (flag6)
						{
							text += Language.QiwiPayToOrder;
						}
						else
						{
							text += Language.QiwiPayToWallet;
						}
						text = text + "\n\nQiwi: +" + toNumber;
						text = string.Concat(new string[]
						{
							text,
							"\n",
							Language.QiwiWithComment,
							commCode,
							"\n\n"
						});
						text = text + "❗❗" + Language.QiwiAttentionWithoutComment + "❗❗";
						bool isButtonIPaidForElse2 = Settings.Default.IsButtonIPaidForElse;
						if (isButtonIPaidForElse2)
						{
							wrapper.AddInlineButton(Language.IPaid, "/IPaid?mthPaied=Qiwi", "", "✋");
						}
						toNumber = null;
						commCode = null;
					}
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				wrapper = null;
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00010004 File Offset: 0x0000E204
		private async Task showLoadTele2(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string message = null)
		{
			try
			{
				user.MessageId = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.LoadTele2;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				string text = string.Empty;
				bool flag = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
				if (flag)
				{
					Product product = this.OrderWaitingForPayPrepareAndGet(user, PayCurrency.RUB);
					decimal toPay = this.CheckGetTele2PaySum(context, product.SumToPay.Value);
					user.Comment = "Tele2-" + toPay;
					context.SaveChanges();
					text = string.Concat(new object[]
					{
						Language.SumToBePaid.Replace("\\n", "\n"),
						" ",
						toPay,
						" ",
						Main.CURRENCY_NAME_RUB
					});
					text = text + "\n\n" + string.Format(Language.TimeForPay, Settings.Default.TimeToCancelOrder);
					text = text + "\n\n" + string.Format(Language.LoadTele2, Settings.Default.Tele2Number);
					bool isButtonIPaidForElse = Settings.Default.IsButtonIPaidForElse;
					if (isButtonIPaidForElse)
					{
						wrapper.AddInlineButton(Language.IPaid, "/IPaid?mthPaied=Tele2", "", "✋");
					}
					product = null;
				}
				else
				{
					bool flag2 = string.IsNullOrEmpty(message) || !this.IsDigitsOnly(message);
					if (flag2)
					{
						text += Language.AmountToLoad;
					}
					else
					{
						decimal amount = decimal.Parse(message);
						amount = this.CheckGetTele2PaySum(context, amount);
						user.Action = TelegramBotBankStore.Domain.User.Actions.None;
						user.Comment = "Tele2-" + amount;
						context.SaveChanges();
						this.log.Info("Tele2 - user " + user.GetFullName() + " amount entered  - " + user.Comment);
						text = string.Concat(new object[]
						{
							Language.SumToBePaid.Replace("\\n", "\n"),
							" ",
							amount,
							" ",
							Main.CURRENCY_NAME_RUB
						});
						text = text + "\n\n" + string.Format(Language.LoadTele2, Settings.Default.Tele2Number);
						bool isButtonIPaidForElse2 = Settings.Default.IsButtonIPaidForElse;
						if (isButtonIPaidForElse2)
						{
							wrapper.AddInlineButton(Language.IPaid, "/IPaid?mthPaied=Tele2", "", "✋");
						}
					}
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				wrapper = null;
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00010068 File Offset: 0x0000E268
		private decimal CheckGetTele2PaySum(BotContext context, decimal sum)
		{
			decimal sum2;
			try
			{
				Func<TelegramBotBankStore.Domain.User, bool> <>9__1;
				for (;;)
				{
					IEnumerable<TelegramBotBankStore.Domain.User> source = (from x in context.Users
					where x.Comment.StartsWith("Tele2-")
					select x).AsEnumerable<TelegramBotBankStore.Domain.User>();
					Func<TelegramBotBankStore.Domain.User, bool> predicate;
					if ((predicate = <>9__1) == null)
					{
						predicate = (<>9__1 = ((TelegramBotBankStore.Domain.User x) => decimal.Parse(x.Comment.Replace("Tele2-", "")) == sum));
					}
					if (!source.Any(predicate))
					{
						break;
					}
					sum += 1m;
				}
				sum2 = sum;
			}
			catch (Exception ex)
			{
				try
				{
					string text = string.Empty;
					IEnumerable<TelegramBotBankStore.Domain.User> enumerable = (from x in context.Users
					where x.Comment.StartsWith("Tele2-")
					select x).AsEnumerable<TelegramBotBankStore.Domain.User>();
					foreach (TelegramBotBankStore.Domain.User user in enumerable)
					{
						text = text + user.Comment + ", ";
					}
					this.log.Info("CheckGetTele2PaySum - users comments : " + text);
				}
				catch
				{
				}
				throw;
			}
			return sum2;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00010268 File Offset: 0x0000E468
		private bool IsDigitsOnly(string str)
		{
			foreach (char c in str)
			{
				bool flag = c < '0' || c > '9';
				if (flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000102B4 File Offset: 0x0000E4B4
		private string getComment(int count)
		{
			string text = string.Empty;
			Random random = new Random(DateTime.Now.Millisecond);
			for (int i = 0; i < count; i++)
			{
				text += random.Next(0, 9);
			}
			return text;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0001030C File Offset: 0x0000E50C
		private async Task invoiceCheckQiwi()
		{
			bool flag = this.MyQiwiList == null;
			if (!flag)
			{
				try
				{
					using (BotContext context = new BotContext())
					{
						foreach (TelegramBotBankStore.Domain.User user in from x in context.Users
						where !string.IsNullOrEmpty(x.Comment)
						select x)
						{
							bool flag2 = user.Comment.StartsWith("Yandex");
							if (!flag2)
							{
								string[] com = user.Comment.Split(new string[]
								{
									"-"
								}, StringSplitOptions.None);
								bool flag3 = com.Length == 2;
								if (flag3)
								{
									await this.invoiceCheckQiwi(context, user, com[0], com[1]);
								}
								com = null;
								user = null;
							}
						}
						IEnumerator<TelegramBotBankStore.Domain.User> enumerator = null;
					}
					BotContext context = null;
				}
				catch (Exception ex)
				{
					this.log.Error(ex);
				}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00010354 File Offset: 0x0000E554
		private async Task invoiceCheckQiwi(BotContext context, TelegramBotBankStore.Domain.User user, string number, string checkComment)
		{
			bool flag = this.MyQiwiList == null;
			if (!flag)
			{
				try
				{
					MyQiwi myqiwi = this.GetMyQiwiByNumber(number);
					bool flag2 = myqiwi == null;
					if (flag2)
					{
						ILog log = this.log;
						string[] array = new string[5];
						array[0] = "Qiwi - List of qiwi does not contain number ";
						array[1] = number;
						array[2] = ". List numbers - ";
						array[3] = string.Join(", ", (from x in this.MyQiwiList.Values
						select x.Number).Cast<string>().ToArray<string>());
						array[4] = ".";
						log.Error(string.Concat(array));
						user.Comment = "";
						context.SaveChanges();
					}
					else
					{
						this.log.Debug(string.Concat(new string[]
						{
							"Qiwi - Get history for number ",
							myqiwi.Number,
							", input ",
							number,
							", check ",
							checkComment
						}));
						History history2 = await myqiwi.GetHistory();
						History history = history2;
						history2 = null;
						if (history != null && history.Payments != null)
						{
							string toLog = "";
							foreach (Payment p in history.Payments.Take(5))
							{
								toLog += string.Format("Account - {0}, Comment {1}, Date {2}, Status {3}, Sum {4}, Total {5}, Type {6}.\r\n", new object[]
								{
									p.Account,
									p.Comment,
									p.Date,
									p.Status,
									p.Sum,
									p.Total,
									p.Type
								});
								p = null;
							}
							IEnumerator<Payment> enumerator = null;
							this.log.Debug("Qiwi - history loaded\r\n" + toLog);
							IEnumerable<Payment> payments = null;
							if (Settings.Default.QiwiMethod == 0)
							{
								payments = from x in history.Payments
								where x.Type == PaymentType.In && x.Status == PaymentStatus.Success && x.Account == checkComment
								select x;
							}
							else if (Settings.Default.QiwiMethod == 1)
							{
								payments = from x in history.Payments
								where x.Type == PaymentType.In && x.Status == PaymentStatus.Success && x.Comment == checkComment
								select x;
							}
							if (payments != null)
							{
								this.log.Debug("Qiwi - payments list count " + payments.Count<Payment>());
								List<Payment> pays = new List<Payment>();
								foreach (Payment p2 in payments)
								{
									if (!Main.transactionSet.Contains(p2.Id))
									{
										bool was = false;
										foreach (TelegramBotBankStore.Domain.Transaction tr in ((IEnumerable<TelegramBotBankStore.Domain.Transaction>)context.Transactions))
										{
											bool flag3;
											if (tr.TransactionType == TransactionType.Qiwi)
											{
												long? idQiwiTransaction = tr.IdQiwiTransaction;
												long id = p2.Id;
												flag3 = (idQiwiTransaction.GetValueOrDefault() == id & idQiwiTransaction != null);
											}
											else
											{
												flag3 = false;
											}
											if (flag3)
											{
												was = true;
												ILog log2 = this.log;
												object[] array2 = new object[10];
												array2[0] = "Qiwi - payment ";
												array2[1] = p2.Account;
												array2[2] = " ";
												array2[3] = p2.Total;
												array2[4] = " ";
												array2[5] = p2.Date;
												array2[6] = " is already used and in the user's transaction history ";
												int num = 7;
												TelegramBotBankStore.Domain.User user2 = tr.User;
												array2[num] = ((user2 != null) ? user2.GetFullName() : null);
												array2[8] = " ";
												array2[9] = tr.Address;
												log2.Debug(string.Concat(array2));
											}
											tr = null;
										}
										IEnumerator<TelegramBotBankStore.Domain.Transaction> enumerator3 = null;
										if (!was)
										{
											pays.Add(p2);
										}
									}
									else
									{
										this.log.Debug(string.Concat(new object[]
										{
											"Qiwi - payment ",
											p2.Account,
											" ",
											p2.Total,
											" ",
											p2.Date,
											" is in the processed list."
										}));
									}
									p2 = null;
								}
								IEnumerator<Payment> enumerator2 = null;
								if (pays.Count > 0)
								{
									Payment payment = pays[0];
									ILog log3 = this.log;
									object[] array3 = new object[4];
									array3[0] = "QIWI - transaction - ";
									int num2 = 1;
									Payment payment2 = payment;
									array3[num2] = ((payment2 != null) ? payment2.Account : null);
									array3[2] = ", rub - ";
									array3[3] = payment.Sum;
									log3.Info(string.Concat(array3));
									Main.transactionSet.Add(payment.Id);
									if (payment.Total > 0m)
									{
										this.log.Info(string.Format("QIWI - payed: User - {0}, number - {1}, sum - {2}", user.GetFullName(), user.Comment, payment.Total));
										TelegramBotBankStore.Domain.Transaction transaction = new TelegramBotBankStore.Domain.Transaction();
										transaction.TransactionType = TransactionType.Qiwi;
										transaction.IdQiwiTransaction = new long?(payment.Id);
										await this.UserPaidRUB(context, user, transaction, payment.Total);
										transaction = null;
									}
									payment = null;
								}
								pays = null;
							}
							toLog = null;
							payments = null;
						}
						myqiwi = null;
						history = null;
					}
				}
				catch (Exception ex)
				{
					this.log.Error(ex);
				}
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000103B8 File Offset: 0x0000E5B8
		private async Task UserPaidRUB(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotBankStore.Domain.Transaction transaction, decimal paidRub)
		{
			decimal sumPayed = 0m;
			bool flag = Main.CURRENCY_BOT_CURRENT == CurrencyBot.RUB;
			if (flag)
			{
				sumPayed = paidRub;
			}
			else
			{
				bool flag2 = Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD;
				if (flag2)
				{
					sumPayed = paidRub / this.RUB_RATE;
				}
			}
			transaction.Sum = sumPayed;
			transaction.User = user;
			transaction.Address = user.Comment;
			user.Transactions.Add(transaction);
			user.Action = TelegramBotBankStore.Domain.User.Actions.None;
			user.Comment = "";
			context.SaveChanges();
			bool flag3 = user.Products.Any((Product x) => x.Status == ProductStatus.WaitForPay);
			bool flag4 = flag3;
			if (flag4)
			{
				bool flag5 = await this.ConfirmWaitForPayProduct(context, user, paidRub, PayCurrency.RUB, false);
				flag4 = flag5;
			}
			bool flag6 = flag4;
			if (!flag6)
			{
				user.BalanceRUB += sumPayed;
				transaction.IsAddedToBalance = true;
				context.SaveChanges();
				string mess = string.Format(Language.YourBalanceEncrease + " {0} {1}", sumPayed, Main.CURRENCY_NAME_CURRENT);
				await this._botClient.SendTextMessageAsync(user.ChatId, mess, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				this.UpdateReferal(context, user, PayCurrency.RUB, sumPayed);
				mess = null;
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001041C File Offset: 0x0000E61C
		private async Task invoiceCheckYandexMoney()
		{
			try
			{
				bool flag = YandexMoney.Connection == null;
				if (flag)
				{
					throw new Exception("Yandex was not init.");
				}
				using (BotContext context = new BotContext())
				{
					List<TelegramBotBankStore.Domain.User> users = (from x in context.Users
					where !string.IsNullOrEmpty(x.Comment) && x.Comment.StartsWith("Yandex")
					select x).ToList<TelegramBotBankStore.Domain.User>();
					bool flag2 = users.Count > 0;
					if (flag2)
					{
						OperationHistoryRequest<OperationHistoryResult> ww = new OperationHistoryRequest<OperationHistoryResult>(YandexMoney.Connection, new JsonSerializer<OperationHistoryResult>());
						ww.From = new DateTime?(DateTime.Now.AddDays(-4.0));
						ww.Type = "deposition";
						ww.Details = true;
						OperationHistoryResult operationHistoryResult = await ww.Perform();
						OperationHistoryResult rr = operationHistoryResult;
						operationHistoryResult = null;
						foreach (TelegramBotBankStore.Domain.User user in users)
						{
							string[] com = user.Comment.Split(new string[]
							{
								"-"
							}, StringSplitOptions.None);
							if (com.Length == 2)
							{
								foreach (OperationDetailsResult o in rr.Operations)
								{
									if (com[1].Equals(o.Message.Trim()) && o.Status == ResponseStatus.Success)
									{
										ILog log = this.log;
										string format = "YANDEX - payed: User - {0}, comment - {1}, sum - {2}, от {3}";
										object[] array = new object[4];
										array[0] = user.GetFullName();
										array[1] = user.Comment;
										int num = 2;
										OperationDetailsResult operationDetailsResult = o;
										array[num] = ((operationDetailsResult != null) ? new double?(operationDetailsResult.Amount) : null);
										int num2 = 3;
										OperationDetailsResult operationDetailsResult2 = o;
										array[num2] = ((operationDetailsResult2 != null) ? operationDetailsResult2.Title : null);
										log.Info(string.Format(format, array));
										await this.UserPaidRUB(context, user, new TelegramBotBankStore.Domain.Transaction
										{
											TransactionType = TransactionType.Yandex
										}, (decimal)o.Amount);
										break;
									}
									o = null;
								}
								List<OperationDetailsResult>.Enumerator enumerator2 = default(List<OperationDetailsResult>.Enumerator);
							}
							com = null;
							user = null;
						}
						List<TelegramBotBankStore.Domain.User>.Enumerator enumerator = default(List<TelegramBotBankStore.Domain.User>.Enumerator);
						ww = null;
						rr = null;
					}
					users = null;
				}
				BotContext context = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00010464 File Offset: 0x0000E664
		private async Task invoiceCheckTele2()
		{
			try
			{
				bool flag = this._tele2Api == null;
				if (flag)
				{
					throw new Exception("Tele2Api was not init.");
				}
				using (BotContext context = new BotContext())
				{
					List<TelegramBotBankStore.Domain.User> users = (from x in context.Users
					where !string.IsNullOrEmpty(x.Comment) && x.Comment.StartsWith("Tele2-") && !string.IsNullOrEmpty(x.Comment.Replace("Tele2-", ""))
					select x).ToList<TelegramBotBankStore.Domain.User>();
					bool flag2 = users.Any<TelegramBotBankStore.Domain.User>();
					if (flag2)
					{
						foreach (TelegramBotBankStore.Domain.User user in users)
						{
							decimal sum = decimal.Parse(user.Comment.Replace("Tele2-", ""));
							Data data = this._tele2Api.IsDataSumPaid(sum);
							bool flag3 = data != null;
							if (flag3)
							{
								this.log.Info(string.Format("Tele2 - payed: User - {0}, sum - {1}, date {2}, to {3}", new object[]
								{
									user.GetFullName(),
									data.sum.amount,
									data.payDate,
									this._tele2Api.Number
								}));
								TelegramBotBankStore.Domain.Transaction transaction = new TelegramBotBankStore.Domain.Transaction();
								transaction.TransactionType = TransactionType.Tele2;
								await this.UserPaidRUB(context, user, transaction, data.sum.amount);
								transaction = null;
							}
							data = null;
							user = null;
						}
						List<TelegramBotBankStore.Domain.User>.Enumerator enumerator = default(List<TelegramBotBankStore.Domain.User>.Enumerator);
					}
					users = null;
				}
				BotContext context = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000104AC File Offset: 0x0000E6AC
		private async Task showHistory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				string text = string.Format("{0} {1}:\n\n", "⏳", Language.YourLastTransactions);
				bool flag = user.Transactions.Any<TelegramBotBankStore.Domain.Transaction>();
				if (flag)
				{
					int index = 1;
					List<TelegramBotBankStore.Domain.Transaction> transactions = (from x in user.Transactions
					orderby x.Din descending
					select x).ToList<TelegramBotBankStore.Domain.Transaction>();
					foreach (TelegramBotBankStore.Domain.Transaction transaction in transactions)
					{
						bool flag2 = index >= 11;
						if (flag2)
						{
							break;
						}
						string s = (transaction.TransactionType == TransactionType.Exmo && transaction.Address.Length > 21) ? (transaction.Address.Substring(0, 10) + "...") : transaction.Address;
						string s2 = (transaction.TransactionType == TransactionType.BTC || transaction.TransactionType == TransactionType.LTC) ? transaction.Sum.ToString() : Math.Round(transaction.Sum).ToString();
						bool flag3 = transaction.TransactionType == TransactionType.BTC;
						string s3;
						if (flag3)
						{
							s3 = "BTC";
						}
						else
						{
							bool flag4 = transaction.TransactionType == TransactionType.LTC;
							if (flag4)
							{
								s3 = "LTC";
							}
							else
							{
								s3 = Main.CURRENCY_NAME_CURRENT;
							}
						}
						text += string.Format(string.Concat(new string[]
						{
							"{0} ",
							Language.Date,
							": {1}   |   ",
							Language.Method,
							": {2}\n       ",
							Language.Address,
							": {3}\n       ",
							Language.Sum,
							": {4} {5}\n"
						}), new object[]
						{
							Emoji.GetNumber(index),
							transaction.Din.ToString("dd.MM.yyyy HH:mm:ss"),
							transaction.TransactionType.ToString(),
							s,
							s2,
							s3
						});
						int num = index;
						index = num + 1;
						s = null;
						s2 = null;
						s3 = null;
						transaction = null;
					}
					List<TelegramBotBankStore.Domain.Transaction>.Enumerator enumerator = default(List<TelegramBotBankStore.Domain.Transaction>.Enumerator);
					transactions = null;
				}
				else
				{
					text += string.Format("{0} {1}", "\ud83d\udeab", Language.YouHaveNotTransactions);
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00010508 File Offset: 0x0000E708
		private async Task showOrderHistory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				string text = string.Format("{0} {1}:\n\n", "\ud83d\udcb5", Language.HereIsYorLastOrders);
				bool flag = user.Products.Any<Product>();
				if (flag)
				{
					bool isNotFoundAvailable = Settings.Default.IsNotFoundAvailable;
					if (isNotFoundAvailable)
					{
						text += string.Format("{0}: {1}%.\n\n", Language.NotFoundYourStatistic, user.NotFoundStatistic);
					}
					int index = 1;
					List<Product> products = (from x in user.ProductsPaid
					orderby x.PurchaseDate descending
					select x).ToList<Product>();
					foreach (Product product in products)
					{
						bool flag2 = index >= 11;
						if (flag2)
						{
							break;
						}
						text = string.Concat(new string[]
						{
							text,
							string.Format("{0} {1}: {2}", index, Language.Date, product.PurchaseDate.Value.ToString("dd.MM.yyyy HH:mm:ss")),
							"   | ",
							Language.Name,
							": ",
							product.Name,
							"   | ",
							Language.Value,
							": ",
							product.PurchasePosition,
							"\n"
						});
						int num = index;
						index = num + 1;
						product = null;
					}
					List<Product>.Enumerator enumerator = default(List<Product>.Enumerator);
					products = null;
				}
				else
				{
					text += string.Format("{0} {1}", "\ud83d\udeab", Language.YouHaveNotOrders);
				}
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00010564 File Offset: 0x0000E764
		private async Task showSupport(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				string text = string.Format("{0} {1}\n\n", "❓", Language.Support);
				string name = Settings.Default.Support.Replace("@", "");
				string url = string.Format("https://t.me/{0}", name);
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.RefundPolicy, "/refund", "", null);
				wrapper.AddInlineButton(Language.ContactSupport, null, url, null);
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				name = null;
				url = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000105C0 File Offset: 0x0000E7C0
		private async Task showAddButton(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string button)
		{
			try
			{
				TelegramPage page = context.TelegramPages.FirstOrDefault((TelegramPage x) => x.Name.Contains(button));
				bool flag = page == null;
				if (!flag)
				{
					await Helper.SendPhoto(botClient, user.ChatId, page.PathPhoto);
					string text = page.Text;
					string name = Settings.Default.Support.Replace("@", "");
					string url = string.Format("https://t.me/{0}", name);
					TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
					wrapper.AddInlineButton(Language.ContactSupport, null, url, null);
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
					page = null;
					text = null;
					name = null;
					url = null;
					wrapper = null;
				}
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00010624 File Offset: 0x0000E824
		private async Task showRefunds(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				string text = Language.AdditionalInformation + "\n\n";
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				List<Policy> list = context.Policies.ToList<Policy>();
				bool flag = list.Any<Policy>();
				if (flag)
				{
					foreach (Policy policy in list)
					{
						wrapper.AddInlineButton(policy.Name, "/refund?id=" + policy.Id, "", null);
						policy = null;
					}
					List<Policy>.Enumerator enumerator = default(List<Policy>.Enumerator);
				}
				else
				{
					text += string.Format("{0} {1}", "\ud83d\udeab", Language.AdditionalInformationUnavailable);
				}
				wrapper.AddInlineButton(Language.Back, "/backmenu", "", "↩");
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
				list = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00010680 File Offset: 0x0000E880
		private async Task showRefund(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long id)
		{
			try
			{
				string text = Language.AdditionalInformation + "\n\n";
				Policy policy = context.Policies.FirstOrDefault((Policy x) => x.Id == id);
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Back, "/refund", "", null);
				text += ((!string.IsNullOrEmpty(policy.Value)) ? policy.Value : "-");
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				policy = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000106E4 File Offset: 0x0000E8E4
		private async Task leaveReview(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string message = null)
		{
			try
			{
				bool isReviewAvailable = Settings.Default.IsReviewAvailable;
				if (isReviewAvailable)
				{
					bool flag = string.IsNullOrEmpty(message) || message.Contains(Language.Wallet) || message.Contains(Language.OrderHistory) || message.Contains(Language.Support) || (message.Contains("RU") && message.Contains("EN"));
					if (flag)
					{
						string text = Language.PleaseEnterAMessage + "\n\n";
						user.Action = TelegramBotBankStore.Domain.User.Actions.WaitForReview;
						await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
						text = null;
					}
					else
					{
						string usr = user.GetFullName();
						Review rev = new Review
						{
							Text = message,
							UserName = usr
						};
						context.Reviews.Add(rev);
						this.sendNotification("Юзер " + usr + " оставил сообещине:\n\n" + message);
						await this.showMenu(context, user, botClient, "");
						usr = null;
						rev = null;
					}
				}
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00010748 File Offset: 0x0000E948
		private async Task showButtonIPaied(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string payMth)
		{
			try
			{
				string text = string.Format("{0} {1}:\n\n", "\ud83d\udcb5", Language.Balance);
				text = Language.IPaiedWait;
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				this.sendNotification("Юзер " + user.GetFullName() + " нажал 'Я оплатил' по методу:\n" + payMth);
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000107AC File Offset: 0x0000E9AC
		private async Task showSupportLogin(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				string text = string.Format("{0} {1}:\n\n", "\ud83d\udcb5", Language.EnterLogin);
				user.Action = TelegramBotBankStore.Domain.User.Actions.SupportLogin;
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00010808 File Offset: 0x0000EA08
		private async Task showSupportPassword(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			try
			{
				string text = string.Format("{0} {1}:\n\n", "\ud83d\udec2", Language.EnterPassword);
				user.Action = TelegramBotBankStore.Domain.User.Actions.SupportPassword;
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00010864 File Offset: 0x0000EA64
		private async Task showCategories(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string message = "")
		{
			try
			{
				string text = "Категории:";
				bool flag = !string.IsNullOrEmpty(message);
				if (flag)
				{
					text = text + "\n\n" + message;
				}
				user.Action = TelegramBotBankStore.Domain.User.Actions.Categories;
				user.EdditingCategoryId = null;
				user.EdditingProductId = null;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(1));
				bool isAdmin = user.IsAdmin;
				if (isAdmin)
				{
					wrapper.AddInlineButton(Language.AddCategory, "/addcategory", "", null);
				}
				List<Category> list = (from x in context.Categories
				where x.Parent == null
				select x).ToList<Category>();
				foreach (Category category in list)
				{
					wrapper.AddInlineButton("Категория: " + category.Name, "/showcategory?id=" + category.Id, "", null);
					category = null;
				}
				List<Category>.Enumerator enumerator = default(List<Category>.Enumerator);
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
				list = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000108C8 File Offset: 0x0000EAC8
		private async Task showAddCategory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long? parentId = null)
		{
			try
			{
				string text = Language.EnterCategoryName;
				user.Action = TelegramBotBankStore.Domain.User.Actions.EnterCategoryName;
				user.EdditingCategoryId = parentId;
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001092C File Offset: 0x0000EB2C
		private async Task showAddingCategory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string name, long? parentId = null)
		{
			try
			{
				string text = string.Empty;
				Category parent = null;
				bool flag = parentId != null;
				if (flag)
				{
					parent = context.Categories.FirstOrDefault((Category x) => x.Id == parentId.Value);
				}
				Category category = (parent != null) ? parent.Childs.FirstOrDefault((Category x) => x.Name == name) : context.Categories.FirstOrDefault((Category x) => x.Name == name);
				bool flag2 = category != null;
				if (flag2)
				{
					text = "категория с таким названием уже есть";
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				}
				else
				{
					category = new Category();
					category.Parent = parent;
					category.Name = name;
					if (parent != null)
					{
						parent.Childs.Add(category);
					}
					else
					{
						context.Categories.Add(category);
					}
					context.SaveChanges();
					await this.showCategories(context, user, botClient, text = "категория успешно добавлена");
				}
				text = null;
				parent = null;
				category = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00010998 File Offset: 0x0000EB98
		private async Task showShowCategory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long categoryId)
		{
			try
			{
				string text = Language.Category + " \n\n";
				Category category = context.Categories.FirstOrDefault((Category x) => x.Id == categoryId);
				text += category.NameFull;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(3));
				bool isAdmin = user.IsAdmin;
				if (isAdmin)
				{
					wrapper.AddInlineButton(Language.AddCategory, "/addcategory?id=" + categoryId, "", null);
				}
				wrapper.AddInlineButton(Language.EditCategory, "/editcategory?id=" + categoryId, "", null);
				bool isAdmin2 = user.IsAdmin;
				if (isAdmin2)
				{
					wrapper.AddInlineButton(Language.DeleteCategory, "/deletecategory?id=" + categoryId, "", null);
				}
				wrapper.NextInline();
				foreach (Category child in category.Childs)
				{
					wrapper.AddInlineButton("Категория: " + child.Name, "/showcategory?id=" + child.Id, "", null);
					wrapper.NextInline();
					child = null;
				}
				IEnumerator<Category> enumerator = null;
				wrapper.NextInline();
				wrapper.AddInlineButton(Language.AddProduct, "/addproduct?id=" + categoryId, "", null);
				wrapper.NextInline();
				foreach (Product product in category.Products)
				{
					wrapper.AddInlineButton("Товар: " + product.Name, "/showproduct?id=" + product.Id, "", null);
					wrapper.NextInline();
					product = null;
				}
				IEnumerator<Product> enumerator2 = null;
				user.Action = TelegramBotBankStore.Domain.User.Actions.EditCategory;
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				category = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000109FC File Offset: 0x0000EBFC
		private async Task showEditCategory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long categoryId)
		{
			try
			{
				string text = "Введите новое название для: \n\n";
				user.Action = TelegramBotBankStore.Domain.User.Actions.EdditingCategory;
				Category category = context.Categories.FirstOrDefault((Category x) => x.Id == categoryId);
				user.EdditingCategoryId = new long?(category.Id);
				text += category.Name;
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
				category = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00010A60 File Offset: 0x0000EC60
		private async Task showEdditingCategory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string name)
		{
			try
			{
				string text = string.Empty;
				bool flag = context.Categories.Any((Category x) => x.Name == name);
				if (flag)
				{
					text = "категория с таким названием уже есть";
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				}
				else
				{
					Category category = context.Categories.FirstOrDefault((Category x) => x.Id == user.EdditingCategoryId.Value);
					category.Name = name;
					user.EdditingCategoryId = null;
					context.SaveChanges();
					await this.showCategories(context, user, botClient, text = "категория успешно изменена");
					category = null;
				}
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00010AC4 File Offset: 0x0000ECC4
		private async Task showDeleteCategory(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long categoryId)
		{
			try
			{
				string text = "категория успешно удалена";
				Category category = context.Categories.FirstOrDefault((Category x) => x.Id == categoryId);
				bool flag = category != null;
				if (flag)
				{
					this.removeChilds(context, category);
					try
					{
						List<Product> cts = (from x in context.Products
						where x.Category.Id == categoryId
						select x).ToList<Product>();
						foreach (Product ccc in cts)
						{
							ccc.Category = null;
							ccc = null;
						}
						List<Product>.Enumerator enumerator = default(List<Product>.Enumerator);
						cts = null;
					}
					catch
					{
					}
					context.Categories.Remove(category);
					context.SaveChanges();
				}
				await this.showCategories(context, user, botClient, text);
				text = null;
				category = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00010B28 File Offset: 0x0000ED28
		private async Task showAddProduct(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long categoryId)
		{
			try
			{
				string text = Language.EnterProductName;
				user.Action = TelegramBotBankStore.Domain.User.Actions.EnterProductName;
				user.EdditingCategoryId = new long?(categoryId);
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00010B8C File Offset: 0x0000ED8C
		private async Task showAddingProduct(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string name)
		{
			try
			{
				string text = string.Empty;
				bool flag = user.EdditingProductId != null;
				if (flag)
				{
					Product product = context.Products.FirstOrDefault((Product x) => x.Id == user.EdditingProductId.Value);
					bool flag2 = product.Category.Products.Any((Product x) => x.Name == name);
					if (flag2)
					{
						text = "товар с таким названием уже есть";
						await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
					}
					else
					{
						text = Language.EnterProductPrice;
						user.ProductName = name;
						user.Action = TelegramBotBankStore.Domain.User.Actions.EnterProductPrice;
						await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
					}
					product = null;
				}
				else
				{
					Category category = context.Categories.FirstOrDefault((Category x) => x.Id == user.EdditingCategoryId.Value);
					if (category != null)
					{
						Product product2 = category.Products.FirstOrDefault((Product x) => x.Name == name);
						if (product2 != null)
						{
							text = "товар с таким названием уже есть";
							await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
						}
						else
						{
							text = Language.EnterProductPrice;
							user.ProductName = name;
							user.Action = TelegramBotBankStore.Domain.User.Actions.EnterProductPrice;
							await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
						}
						product2 = null;
					}
					category = null;
				}
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		private async Task showAddingProductPrice(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string name)
		{
			try
			{
				string text = string.Empty;
				decimal price = 0m;
				bool flag = decimal.TryParse(name.Replace(",", "."), out price);
				if (flag)
				{
					text = Language.EnterProductValue;
					user.ProductPrice = price;
					user.Action = TelegramBotBankStore.Domain.User.Actions.EnterProductValue;
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				}
				else
				{
					text = "Неверное значение цены";
					await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				}
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00010C54 File Offset: 0x0000EE54
		private async Task showAddingProductValue(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, string name)
		{
			try
			{
				string text = string.Empty;
				text = Language.EnterProductType;
				user.ProductValue = name;
				user.Action = TelegramBotBankStore.Domain.User.Actions.EnterProductType;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(3));
				wrapper.AddInlineButton(Language.SinglePosition, "/singleposition", "", null);
				wrapper.AddInlineButton(Language.MultiplePosition, "/multipleposition", "", null);
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00010CB8 File Offset: 0x0000EEB8
		private async Task showAddProductType(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, bool isSingle)
		{
			try
			{
				string text = string.Empty;
				Category category = null;
				Product product = null;
				bool flag = user.EdditingProductId != null;
				if (flag)
				{
					product = context.Products.FirstOrDefault((Product x) => x.Id == user.EdditingProductId.Value);
				}
				else
				{
					category = context.Categories.FirstOrDefault((Category x) => x.Id == user.EdditingCategoryId.Value);
					product = new Product();
					product.Category = category;
				}
				product.Name = user.ProductName;
				product.Price = user.ProductPrice;
				if (isSingle)
				{
					Product product2 = product;
					product2.Positions = product2.Positions + " " + user.ProductValue.Replace("\n", " ");
				}
				else
				{
					Product product3 = product;
					product3.Positions = product3.Positions + "\r\n" + user.ProductValue.Replace("\n", "\r\n");
				}
				bool flag2 = product.Id == 0L;
				if (flag2)
				{
					category.Products.Add(product);
				}
				context.SaveChanges();
				bool flag3 = user.EdditingProductId != null;
				if (flag3)
				{
					text = "товар успешно изменен";
				}
				else
				{
					Singleton.Main.SendNotificationNewPositions(product.Id);
					text = "товар успешно добавлен";
				}
				await this.showCategories(context, user, botClient, text);
				text = null;
				category = null;
				product = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00010D1C File Offset: 0x0000EF1C
		private async Task showShowProduct(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId)
		{
			try
			{
				string text = Language.Product + " \n\n";
				Product product = context.Products.FirstOrDefault((Product x) => x.Id == productId);
				text = text + "Категория: " + product.Category.NameFull + "\n";
				text = text + "Название: " + product.Name + "\n";
				text = string.Concat(new object[]
				{
					text,
					"Цена: ",
					product.Price,
					"\n"
				});
				TelegramWrapper wrapper = new TelegramWrapper(new int?(3));
				wrapper.AddInlineButton(Language.AddPosition, "/addposition?id=" + productId, "", null);
				wrapper.AddInlineButton(Language.EditCategory, "/editproduct?id=" + productId, "", null);
				wrapper.NextInline();
				wrapper.AddInlineButton(Language.DeleteCategory, "/deleteproduct?id=" + productId, "", null);
				wrapper.AddInlineButton(Language.TakeOff, "/takeoff?id=" + productId, "", null);
				wrapper.NextInline();
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				product = null;
				wrapper = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00010D80 File Offset: 0x0000EF80
		private async Task showDeleteProduct(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId)
		{
			try
			{
				string text = "товар успешно удален";
				Product product = context.Products.FirstOrDefault((Product x) => x.Id == productId);
				bool flag = product != null;
				if (flag)
				{
					context.Products.Remove(product);
					context.SaveChanges();
				}
				await this.showCategories(context, user, botClient, text);
				text = null;
				product = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		private async Task showEditProduct(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId)
		{
			try
			{
				string text = Language.EnterProductName;
				user.Action = TelegramBotBankStore.Domain.User.Actions.EnterProductName;
				user.EdditingProductId = new long?(productId);
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00010E48 File Offset: 0x0000F048
		private async Task showAddProductPosition(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, long productId)
		{
			try
			{
				string text = Language.EnterProductValue;
				user.Action = TelegramBotBankStore.Domain.User.Actions.AddPosition;
				user.EdditingProductId = new long?(productId);
				await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00010EAC File Offset: 0x0000F0AC
		private void initialize()
		{
			try
			{
				this.enable();
				using (BotContext botContext = new BotContext())
				{
					this.initUsers(botContext);
				}
				this.initProducts(new List<Product>());
				this.initTransactions(new List<TelegramBotBankStore.Domain.Transaction>());
				this.initProductsUser(new List<Product>());
				this.initPolicies(new List<Policy>());
				this.initReviews(new List<Review>());
				this.initTablePromoCodes(new List<PromoCode>());
				this.initApirone();
				this.initCurrency();
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00010F70 File Offset: 0x0000F170
		private void initSettingsPage1()
		{
			try
			{
				this.flatTextBoxBotToken.Text = Settings.Default.BotToken;
				this.flatTextBoxChanell.Text = Settings.Default.BotChannel;
				this.flatTextBoxGreeting.Text = Settings.Default.Greeting;
				this.flatTextBoxPositionOutOfStock.Text = Settings.Default.PositionOutOfStock;
				this.flatTextBoxSupport.Text = Settings.Default.Support;
				this.flatTextBoxCommandSupport.Text = Settings.Default.CommandSupport;
				this.flatTextBoxApiKey.Text = Settings.Default.BlockChainApiKey;
				this.flatTextBoxIdWallet.Text = Settings.Default.BlockChainIdWallet;
				this.flatTextBoxPassword.Text = Key.Decrypt(Settings.Default.BlockChainPassword);
				this.flatTextBoxServiceHost.Text = Settings.Default.BlockChainServiceHost;
				this.IsExmoAvailable1.Checked = Settings.Default.IsExmoAvailable;
				this.flatTextBoxExmoKey.Text = Settings.Default.ExmoKey;
				this.flatTextBoxExmoSecret.Text = Key.Decrypt(Settings.Default.ExmoSecret);
				this.checkBoxApironePayLTC.Checked = Settings.Default.ApironePayLTC;
				this.checkBoxApironePayBTC.Checked = Settings.Default.ApironePayBTC;
				this.IsApironeAvailable.Checked = Settings.Default.IsApironeAvailable;
				this.flatTextBoxApironeBTCWallet.Text = Key.Decrypt(Settings.Default.ApironeWalletBTCAddress);
				this.flatTextBoxApironeLTCWallet.Text = Key.Decrypt(Settings.Default.ApironeWalletLTCAddress);
				this.flatNumericDicountPayBTC.Value = Settings.Default.DiscountBTC;
				this.flatNumericDicountPayLTC.Value = Settings.Default.DiscountLTC;
				this.checkBoxIsUserPayWalletAvailable.Checked = Settings.Default.IsUserPayWalletAvailable;
				this.checkBoxIsReservAndPayInTheEndAvailable.Checked = Settings.Default.IsReserveAndPayInTheEndAvailable;
				this.flatNumericTimeToCancelOrder.Value = Settings.Default.TimeToCancelOrder;
				this.checkBoxIsButtonLanguageAvailable.Checked = Settings.Default.IsButtonLanguageAvailable;
				this.cbIsEnterAmountToBuy.Checked = Settings.Default.IsNotEnterAmountToBuy;
				this.cbButtonIPaidForCard.Checked = Settings.Default.IsButtonIPaidForCard;
				this.cbButtonIPaidForElse.Checked = Settings.Default.IsButtonIPaidForElse;
				this.cbIsLockCheckPayment.Checked = Settings.Default.IsLockCheckPayment;
				this.numericUpDownRefferal.Value = Settings.Default.RefferalRewarding;
				this.flatTextBoxReferral.Text = Settings.Default.Referral;
				this.IsReferalAvailable.Checked = Settings.Default.IsReferalAvailable;
				this.cbIsButtonAvailability.Checked = Settings.Default.IsMainButtonAvailability;
				this.cbIsButtonStatistic.Checked = Settings.Default.IsMainButtonStatistics;
				this.cbIsNotFoundAvailable.Checked = Settings.Default.IsNotFoundAvailable;
				this.IsReviewAvailable.Checked = Settings.Default.IsReviewAvailable;
				this.tbNotFoundText.Text = Settings.Default.NotFoundText;
				this.tbNotFoundChennel.Text = Settings.Default.NotFoundChennel;
				this.cbIsSendMoneyButtonAvailabile.Checked = Settings.Default.IsSendMoneyButtonAvailabile;
				this.initCurrency();
				bool flag = Settings.Default.Currency == 0;
				if (flag)
				{
					this.flatRadioButtonRUB.Checked = true;
				}
				else
				{
					bool flag2 = Settings.Default.Currency == 1;
					if (flag2)
					{
						this.flatRadioButtonUSD.Checked = true;
					}
				}
				bool flag3 = Key.Decrypt(Settings.Default.AUA) == this.SecureStringForAutoLogIn;
				if (flag3)
				{
					this.checkBoxIsWithoutLogin.Checked = true;
				}
				bool flag4 = System.IO.File.Exists(this.IMAGE_PATH + "greeting.jpeg");
				if (flag4)
				{
					this.settingPictureBoxImage.ImageLocation = this.IMAGE_PATH + "greeting.jpeg";
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000113C4 File Offset: 0x0000F5C4
		private void initSettingsPage2()
		{
			try
			{
				this.initQiwiSettings();
				this.initYandex();
				this.initTele2Setting();
				this.textBoxCard.Text = Settings.Default.CardNumber;
				this.textBoxCard.Enabled = (this.IsCardAvailable1.Checked = Settings.Default.IsCardAvailable);
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00011454 File Offset: 0x0000F654
		private void initUsers(BotContext context)
		{
			this.dataGridViewUsers.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewUsers.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
				this.dataGridViewUsers.DataSource = this.filterUsers(context);
				foreach (object obj in this.dataGridViewUsers.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					string name = dataGridViewColumn.Name;
					string text = name;
					if (text == null)
					{
						goto IL_3DF;
					}
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
					if (num <= 2023571584u)
					{
						if (num <= 819273112u)
						{
							if (num != 25315532u)
							{
								if (num != 232243002u)
								{
									if (num != 819273112u)
									{
										goto IL_3DF;
									}
									if (!(text == "BalanceRUB"))
									{
										goto IL_3DF;
									}
									dataGridViewColumn.HeaderText = "Баланс " + Main.CURRENCY_NAME_CURRENT;
									dataGridViewColumn.Width = 130;
								}
								else
								{
									if (!(text == "FirstName"))
									{
										goto IL_3DF;
									}
									dataGridViewColumn.HeaderText = "Имя";
									dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
									dataGridViewColumn.MinimumWidth = 100;
								}
							}
							else
							{
								if (!(text == "Wallet"))
								{
									goto IL_3DF;
								}
								dataGridViewColumn.HeaderText = "Кошелек";
								dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
								dataGridViewColumn.MinimumWidth = 100;
							}
						}
						else if (num != 845748512u)
						{
							if (num != 1756189037u)
							{
								if (num != 2023571584u)
								{
									goto IL_3DF;
								}
								if (!(text == "BalanceLTC"))
								{
									goto IL_3DF;
								}
								dataGridViewColumn.HeaderText = "Баланс LTC";
								dataGridViewColumn.Width = 130;
							}
							else
							{
								if (!(text == "WalletLTC"))
								{
									goto IL_3DF;
								}
								dataGridViewColumn.HeaderText = "Кошелек LTC";
								dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
								dataGridViewColumn.MinimumWidth = 100;
							}
						}
						else
						{
							if (!(text == "Din"))
							{
								goto IL_3DF;
							}
							dataGridViewColumn.HeaderText = "Дата подк.";
							dataGridViewColumn.Width = 150;
							dataGridViewColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
						}
					}
					else if (num <= 2860468778u)
					{
						if (num != 2555355134u)
						{
							if (num != 2620727545u)
							{
								if (num != 2860468778u)
								{
									goto IL_3DF;
								}
								if (!(text == "BalanceBTC"))
								{
									goto IL_3DF;
								}
								dataGridViewColumn.HeaderText = "Баланс BTC";
								dataGridViewColumn.Width = 130;
							}
							else
							{
								if (!(text == "UserName"))
								{
									goto IL_3DF;
								}
								dataGridViewColumn.HeaderText = "Юзернейм";
								dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
								dataGridViewColumn.MinimumWidth = 100;
							}
						}
						else
						{
							if (!(text == "Comment"))
							{
								goto IL_3DF;
							}
							dataGridViewColumn.HeaderText = "Коммент";
							dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							dataGridViewColumn.MinimumWidth = 100;
						}
					}
					else if (num != 2925385203u)
					{
						if (num != 3927979167u)
						{
							if (num != 4123337125u)
							{
								goto IL_3DF;
							}
							if (!(text == "RefferalName"))
							{
								goto IL_3DF;
							}
							dataGridViewColumn.HeaderText = "Реферал";
							dataGridViewColumn.Width = 150;
							dataGridViewColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
						}
						else
						{
							if (!(text == "IsSupportText"))
							{
								goto IL_3DF;
							}
							dataGridViewColumn.HeaderText = "Сап?";
							dataGridViewColumn.Width = 50;
						}
					}
					else
					{
						if (!(text == "IsAdminText"))
						{
							goto IL_3DF;
						}
						dataGridViewColumn.HeaderText = "Адм?";
						dataGridViewColumn.Width = 50;
					}
					continue;
					IL_3DF:
					dataGridViewColumn.Visible = false;
				}
				this.dataGridViewUsers.ClearSelection();
				DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
				dataGridViewImageColumn.Name = "edit";
				dataGridViewImageColumn.HeaderText = "";
				dataGridViewImageColumn.Width = 20;
				dataGridViewImageColumn.Image = Resources.edit_dark;
				this.dataGridViewUsers.Columns.Add(dataGridViewImageColumn);
				DataGridViewImageColumn dataGridViewImageColumn2 = new DataGridViewImageColumn();
				dataGridViewImageColumn2.Name = "remove";
				dataGridViewImageColumn2.HeaderText = "";
				dataGridViewImageColumn2.Width = 20;
				dataGridViewImageColumn2.Image = Resources.remove_dark;
				this.dataGridViewUsers.Columns.Add(dataGridViewImageColumn2);
			}));
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00011490 File Offset: 0x0000F690
		private void initTransactions(List<TelegramBotBankStore.Domain.Transaction> list)
		{
			this.dataGridViewTransactions.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewTransactions.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
				this.dataGridViewTransactions.DataSource = (from x in list
				orderby x.Din descending
				select x).ToList<TelegramBotBankStore.Domain.Transaction>();
				foreach (object obj in this.dataGridViewTransactions.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					string name = dataGridViewColumn.Name;
					string text = name;
					if (text == null)
					{
						goto IL_1A3;
					}
					if (!(text == "Address"))
					{
						if (!(text == "Sum"))
						{
							if (!(text == "Din"))
							{
								if (!(text == "IsAddedToBalance"))
								{
									if (!(text == "TransactionType"))
									{
										goto IL_1A3;
									}
									dataGridViewColumn.HeaderText = "Тип";
									dataGridViewColumn.Width = 80;
									dataGridViewColumn.DisplayIndex = 4;
								}
								else
								{
									dataGridViewColumn.HeaderText = "Был + к балансу?";
									dataGridViewColumn.Width = 150;
									dataGridViewColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
									dataGridViewColumn.DisplayIndex = 3;
								}
							}
							else
							{
								dataGridViewColumn.HeaderText = "Дата";
								dataGridViewColumn.Width = 150;
								dataGridViewColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
								dataGridViewColumn.DisplayIndex = 2;
							}
						}
						else
						{
							dataGridViewColumn.HeaderText = "Сумма";
							dataGridViewColumn.Width = 150;
							dataGridViewColumn.DisplayIndex = 1;
						}
					}
					else
					{
						dataGridViewColumn.HeaderText = "Адрес";
						dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						dataGridViewColumn.DisplayIndex = 0;
					}
					continue;
					IL_1A3:
					dataGridViewColumn.Visible = false;
				}
				this.dataGridViewTransactions.ClearSelection();
			}));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000114CC File Offset: 0x0000F6CC
		private void initProducts(List<Product> list)
		{
			this.dataGridViewProducts.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewProducts.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
				this.dataGridViewProducts.DataSource = list;
				foreach (object obj in this.dataGridViewProducts.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					string name = dataGridViewColumn.Name;
					string text = name;
					if (text == null)
					{
						goto IL_D4;
					}
					if (!(text == "Name"))
					{
						if (!(text == "PositionsCount"))
						{
							if (!(text == "Price"))
							{
								goto IL_D4;
							}
							dataGridViewColumn.HeaderText = "Цена";
							dataGridViewColumn.Width = 100;
						}
						else
						{
							dataGridViewColumn.HeaderText = "Позиций";
							dataGridViewColumn.Width = 100;
						}
					}
					else
					{
						dataGridViewColumn.HeaderText = "Название";
						dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					}
					continue;
					IL_D4:
					dataGridViewColumn.Visible = false;
				}
				this.dataGridViewProducts.ClearSelection();
				DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
				dataGridViewImageColumn.Name = "edit";
				dataGridViewImageColumn.HeaderText = "";
				dataGridViewImageColumn.Width = 20;
				dataGridViewImageColumn.Image = Resources.edit_dark;
				this.dataGridViewProducts.Columns.Add(dataGridViewImageColumn);
				DataGridViewImageColumn dataGridViewImageColumn2 = new DataGridViewImageColumn();
				dataGridViewImageColumn2.Name = "remove";
				dataGridViewImageColumn2.HeaderText = "";
				dataGridViewImageColumn2.Width = 20;
				dataGridViewImageColumn2.Image = Resources.remove_dark;
				this.dataGridViewProducts.Columns.Add(dataGridViewImageColumn2);
			}));
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00011508 File Offset: 0x0000F708
		private void initProductsUser(List<Product> list)
		{
			this.dataGridViewProductsUser.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewProductsUser.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
				this.dataGridViewProductsUser.DataSource = list;
				foreach (object obj in this.dataGridViewProductsUser.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					string name = dataGridViewColumn.Name;
					string text = name;
					if (text == null)
					{
						goto IL_1B4;
					}
					if (!(text == "Name"))
					{
						if (!(text == "PurchasePosition"))
						{
							if (!(text == "Price"))
							{
								if (!(text == "PurchaseSumValue"))
								{
									if (!(text == "PurchaseDate"))
									{
										if (!(text == "Status"))
										{
											goto IL_1B4;
										}
										dataGridViewColumn.HeaderText = "Статус";
										dataGridViewColumn.Width = 100;
										dataGridViewColumn.DisplayIndex = 5;
									}
									else
									{
										dataGridViewColumn.HeaderText = "Дата";
										dataGridViewColumn.Width = 150;
										dataGridViewColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
										dataGridViewColumn.DisplayIndex = 4;
									}
								}
								else
								{
									dataGridViewColumn.HeaderText = "Оплачено";
									dataGridViewColumn.Width = 150;
									dataGridViewColumn.DisplayIndex = 3;
								}
							}
							else
							{
								dataGridViewColumn.HeaderText = "Цена " + Main.CURRENCY_NAME_CURRENT;
								dataGridViewColumn.Width = 95;
								dataGridViewColumn.DisplayIndex = 2;
							}
						}
						else
						{
							dataGridViewColumn.HeaderText = "Позиция";
							dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							dataGridViewColumn.MinimumWidth = 100;
							dataGridViewColumn.DisplayIndex = 1;
						}
					}
					else
					{
						dataGridViewColumn.HeaderText = "Название";
						dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						dataGridViewColumn.MinimumWidth = 100;
						dataGridViewColumn.DisplayIndex = 0;
					}
					continue;
					IL_1B4:
					dataGridViewColumn.Visible = false;
				}
				this.dataGridViewProductsUser.ClearSelection();
			}));
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00011544 File Offset: 0x0000F744
		private void initPolicies(List<Policy> list)
		{
			this.dataGridViewPolicies.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewPolicies.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
				this.dataGridViewPolicies.DataSource = list;
				foreach (object obj in this.dataGridViewPolicies.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					string name = dataGridViewColumn.Name;
					string text = name;
					if (text == null)
					{
						goto IL_8D;
					}
					if (!(text == "Name"))
					{
						goto IL_8D;
					}
					dataGridViewColumn.HeaderText = "Юзернейм";
					dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					dataGridViewColumn.MinimumWidth = 100;
					continue;
					IL_8D:
					dataGridViewColumn.Visible = false;
				}
				DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
				dataGridViewImageColumn.Name = "remove";
				dataGridViewImageColumn.HeaderText = "";
				dataGridViewImageColumn.Width = 20;
				dataGridViewImageColumn.Image = Resources.remove_dark;
				this.dataGridViewPolicies.Columns.Add(dataGridViewImageColumn);
				this.dataGridViewPolicies.ClearSelection();
			}));
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00011580 File Offset: 0x0000F780
		private void initReviews(List<Review> list)
		{
			this.dataGridViewReviews.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewReviews.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
				this.dataGridViewReviews.DataSource = list;
				foreach (object obj in this.dataGridViewReviews.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					string name = dataGridViewColumn.Name;
					string text = name;
					if (text == null)
					{
						goto IL_F0;
					}
					if (!(text == "UserName"))
					{
						if (!(text == "Date"))
						{
							if (!(text == "Text"))
							{
								goto IL_F0;
							}
							dataGridViewColumn.HeaderText = "Отзыв";
							dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							dataGridViewColumn.MinimumWidth = 100;
						}
						else
						{
							dataGridViewColumn.HeaderText = "Дата";
							dataGridViewColumn.Width = 150;
							dataGridViewColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
						}
					}
					else
					{
						dataGridViewColumn.HeaderText = "Юзернейм";
						dataGridViewColumn.Width = 200;
					}
					continue;
					IL_F0:
					dataGridViewColumn.Visible = false;
				}
				this.dataGridViewReviews.ClearSelection();
			}));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000115BC File Offset: 0x0000F7BC
		private async void initBlockChain()
		{
			try
			{
				string _blockChainApiKey = Settings.Default.BlockChainApiKey;
				string _blockChainIdWallet = Settings.Default.BlockChainIdWallet;
				string _blockChainServiceHost = Settings.Default.BlockChainServiceHost;
				string _blockChainPassword = Key.Decrypt(Settings.Default.BlockChainPassword);
				bool flag = !string.IsNullOrEmpty(_blockChainApiKey) && !string.IsNullOrEmpty(_blockChainIdWallet) && !string.IsNullOrEmpty(_blockChainServiceHost) && !string.IsNullOrEmpty(_blockChainPassword);
				if (flag)
				{
					BlockchainHttpClient blockchainHttpClient = new BlockchainHttpClient(_blockChainApiKey, _blockChainServiceHost);
					BlockchainApiHelper apiHelper = new BlockchainApiHelper(null, null, null, blockchainHttpClient);
					this._walletBTC = apiHelper.InitializeWallet(_blockChainIdWallet, _blockChainPassword, null);
					BitcoinValue bitcoinValue = await this._walletBTC.GetBalanceAsync();
					this.updateStatus("Подключено", null, null);
					blockchainHttpClient = null;
					apiHelper = null;
				}
				else
				{
					this.updateStatus("", null, null);
				}
				_blockChainApiKey = null;
				_blockChainIdWallet = null;
				_blockChainServiceHost = null;
				_blockChainPassword = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000115F8 File Offset: 0x0000F7F8
		private async void flatButtonBlockChainArchiv_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this._walletBTC == null;
				if (flag)
				{
					this.initBlockChain();
				}
				using (BotContext context = new BotContext())
				{
					List<WalletAddress> list2 = await this._walletBTC.ListAddressesAsync();
					List<WalletAddress> list = list2;
					list2 = null;
					for (int i = 0; i <= list.Count; i++)
					{
						Main.<>c__DisplayClass202_0 CS$<>8__locals1 = new Main.<>c__DisplayClass202_0();
						this.updateStatus(string.Format("Обработка {0} из {1}", i, list.Count), null, null);
						CS$<>8__locals1.addr = list[i].AddressStr;
						bool flag2;
						if (list[i].Balance.Satoshis == 0L)
						{
							IQueryable<TelegramBotBankStore.Domain.User> users = context.Users;
							ParameterExpression parameterExpression = Expression.Parameter(typeof(TelegramBotBankStore.Domain.User), "x");
							flag2 = !users.Any(Expression.Lambda<Func<TelegramBotBankStore.Domain.User, bool>>(Expression.Equal(Expression.Property(parameterExpression, methodof(TelegramBotBankStore.Domain.User.get_WalletBTC())), Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Main.<>c__DisplayClass202_0)), fieldof(Main.<>c__DisplayClass202_0.addr))), new ParameterExpression[]
							{
								parameterExpression
							}));
						}
						else
						{
							flag2 = false;
						}
						if (flag2)
						{
							string text = await this._walletBTC.ArchiveAddressAsync(CS$<>8__locals1.addr);
							Thread.Sleep(300);
						}
						CS$<>8__locals1 = null;
					}
					this.updateStatus(string.Format("Обработка Завершена", Array.Empty<object>()), null, null);
					list = null;
				}
				BotContext context = null;
			}
			catch (Exception ex)
			{
				this.log.Error(ex);
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00011644 File Offset: 0x0000F844
		private void initExmo()
		{
			bool isExmoAvailable = Settings.Default.IsExmoAvailable;
			if (isExmoAvailable)
			{
				try
				{
					string exmoKey = Settings.Default.ExmoKey;
					string text = Key.Decrypt(Settings.Default.ExmoSecret);
					bool flag = !string.IsNullOrEmpty(exmoKey) && !string.IsNullOrEmpty(text);
					if (flag)
					{
						this._exmoApi = new ExmoApi(exmoKey, text);
						this.updateStatus("Exmo Подключено", null, null);
					}
					else
					{
						this.updateStatus("", null, null);
					}
				}
				catch (Exception ex)
				{
					this.log.Error(ex);
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00011718 File Offset: 0x0000F918
		private void flatButtonExmoInit_Click(object sender, EventArgs e)
		{
			this.initExmo();
			bool flag = !Settings.Default.IsExmoAvailable;
			if (flag)
			{
				Main.ShowMessage("Exmo не активен.", null);
			}
			else
			{
				try
				{
					string text = this._exmoApi.ApiQuery("excode_load", new Dictionary<string, string>
					{
						{
							"code",
							"TESTCODE"
						}
					});
					bool flag2 = text.Contains("Error 10104: Incorrect code EX-CODE");
					if (!flag2)
					{
						throw new Exception(text);
					}
					Main.ShowMessage("Exmo подключено", null);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex);
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000024FE File Offset: 0x000006FE
		private void flatTextBoxExmoKey_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.ExmoKey = this.flatTextBoxExmoKey.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002522 File Offset: 0x00000722
		private void flatTextBoxExmoSecret_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.ExmoSecret = Key.Encrypt(this.flatTextBoxExmoSecret.Text);
			Settings.Default.Save();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000254B File Offset: 0x0000074B
		private void IsExmoAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsExmoAvailable = this.IsExmoAvailable1.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000256F File Offset: 0x0000076F
		private void IsApironeAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsApironeAvailable = this.IsApironeAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002593 File Offset: 0x00000793
		private void FlatTextBoxApironeBTCWallet_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.ApironeWalletBTCAddress = Key.Encrypt(this.flatTextBoxApironeBTCWallet.Text);
			Settings.Default.Save();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000025BC File Offset: 0x000007BC
		private void FlatTextBoxApironeLTCWallet_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.ApironeWalletLTCAddress = Key.Encrypt(this.flatTextBoxApironeLTCWallet.Text);
			Settings.Default.Save();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000117DC File Offset: 0x0000F9DC
		private void FlatButtonApirone_Click(object sender, EventArgs e)
		{
			try
			{
				this.initApirone();
				string text = this._apironeAPIWallet.History();
				MessageBox.Show(text, "Apirone");
			}
			catch (Exception arg)
			{
				MessageBox.Show("Error: " + arg);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000025E5 File Offset: 0x000007E5
		private void CheckBoxApironePayBTC_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.ApironePayBTC = this.checkBoxApironePayBTC.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002609 File Offset: 0x00000809
		private void CheckBoxApironePayLTC_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.ApironePayLTC = this.checkBoxApironePayLTC.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00011834 File Offset: 0x0000FA34
		private void initApirone()
		{
			this._isApironeAvailable = Settings.Default.IsApironeAvailable;
			this._apironeIsPayBTC = Settings.Default.ApironePayBTC;
			this._apironeIsPayLTC = Settings.Default.ApironePayLTC;
			this._apironeAPIWallet = new Apirone(Key.Decrypt(Settings.Default.ApironeWalletBTCAddress), Key.Decrypt(Settings.Default.ApironeWalletLTCAddress));
			bool flag = this._isApironeAvailable && this._apironeIsPayLTC;
			if (flag)
			{
				Task.Run(delegate()
				{
					this.refreshLTCRate();
				});
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000118C4 File Offset: 0x0000FAC4
		private void radioButtonIsQiwiNumber_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.radioButtonIsQiwiNumber.Checked;
			if (@checked)
			{
				Settings.Default.QiwiMethod = 0;
				Settings.Default.Save();
			}
			else
			{
				bool checked2 = this.radioButtonIsQiwiCode.Checked;
				if (checked2)
				{
					Settings.Default.QiwiMethod = 1;
					Settings.Default.Save();
				}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00011924 File Offset: 0x0000FB24
		private void CheckBoxIsWithoutLogin_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkBoxIsWithoutLogin.Checked;
			if (@checked)
			{
				Settings.Default.AUA = Key.Encrypt(this.SecureStringForAutoLogIn);
				Settings.Default.Save();
			}
			else
			{
				Settings.Default.AUA = "";
				Settings.Default.Save();
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00011984 File Offset: 0x0000FB84
		public void RefreshReviews(List<Review> list)
		{
			this.dataGridViewReviews.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewReviews.DataSource = list;
			}));
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000119C0 File Offset: 0x0000FBC0
		public void RefreshUsers(BotContext context)
		{
			this.dataGridViewUsers.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewUsers.DataSource = this.filterUsers(context);
			}));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000119FC File Offset: 0x0000FBFC
		private void refreshCategories(BotContext context)
		{
			this.treeViewCategories.Invoke(new MethodInvoker(delegate()
			{
				this.treeViewCategories.Nodes.Clear();
				List<Category> list = (from x in context.Categories
				where x.Parent == null
				select x).ToList<Category>();
				foreach (Category category in list)
				{
					TreeNode treeNode = new TreeNode();
					treeNode.Tag = category.Id;
					treeNode.Text = category.Name;
					this.addChild(category, treeNode);
					this.treeViewCategories.Nodes.Add(treeNode);
				}
			}));
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00011A38 File Offset: 0x0000FC38
		public void RefreshProducts(List<Product> list)
		{
			this.dataGridViewProducts.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewProducts.DataSource = (from x in list
				where x.User == null
				select x).ToList<Product>();
			}));
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00011A74 File Offset: 0x0000FC74
		private void refreshTransactions(List<TelegramBotBankStore.Domain.Transaction> list)
		{
			this.dataGridViewTransactions.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewTransactions.DataSource = (from x in list
				orderby x.Din descending
				select x).ToList<TelegramBotBankStore.Domain.Transaction>();
			}));
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		private void refreshProductsUser(List<Product> list)
		{
			this.dataGridViewProductsUser.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewProductsUser.DataSource = (from x in list
				where !x.IsForOperator
				orderby x.PurchaseDate descending
				select x).ToList<Product>();
			}));
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00011AEC File Offset: 0x0000FCEC
		private void refreshPolicies(List<Policy> list)
		{
			this.dataGridViewPolicies.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewPolicies.DataSource = list;
			}));
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00011B28 File Offset: 0x0000FD28
		private void FlatMax1_Click(object sender, EventArgs e)
		{
			this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000262D File Offset: 0x0000082D
		public static void ShowMessage(string message, string caption = null)
		{
			new FormMessage(message, caption).ShowDialog();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00011B50 File Offset: 0x0000FD50
		private async void FlatButtonSender_Click(object sender, EventArgs e)
		{
			string toSend = this.flatTextBoxSender.Text;
			bool flag = this._botClient == null;
			if (flag)
			{
				Main.ShowMessage("Нажмите кнопку старт для включения бота.", null);
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(toSend);
				if (flag2)
				{
					Main.ShowMessage("Текст для отправки отсутствует.", null);
				}
				else
				{
					int i = 0;
					using (BotContext context = new BotContext())
					{
						foreach (TelegramBotBankStore.Domain.User user in ((IEnumerable<TelegramBotBankStore.Domain.User>)context.Users))
						{
							try
							{
								await this._botClient.SendTextMessageAsync(user.ChatId, toSend, ParseMode.Html, false, false, 0, null, default(CancellationToken));
								i++;
							}
							catch
							{
							}
							Task.Delay(500).Wait();
							user = null;
						}
						IEnumerator<TelegramBotBankStore.Domain.User> enumerator = null;
						Main.ShowMessage(string.Concat(new object[]
						{
							"Всего юзеров - ",
							context.Users.Count<TelegramBotBankStore.Domain.User>(),
							", отправлено ",
							i,
							" юзерам."
						}), null);
					}
					BotContext context = null;
					this.LogUserAction("Sent \r\n" + toSend + "\r\n to users.");
				}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00011B9C File Offset: 0x0000FD9C
		private void flatButtonSelectImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					bool flag2 = openFileDialog.OpenFile() != null;
					if (flag2)
					{
						this.settingPictureBoxImage.Image = new Bitmap(openFileDialog.FileName);
						bool flag3 = !Directory.Exists(this.IMAGE_PATH);
						if (flag3)
						{
							Directory.CreateDirectory(this.IMAGE_PATH);
						}
						string filename = this.IMAGE_PATH + "greeting.jpeg";
						this.settingPictureBoxImage.Image.Save(filename, ImageFormat.Jpeg);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00011C64 File Offset: 0x0000FE64
		private void flatButtonDeleteImage_Click(object sender, EventArgs e)
		{
			this.settingPictureBoxImage.Image = null;
			string path = this.IMAGE_PATH + "greeting.jpeg";
			bool flag = System.IO.File.Exists(path);
			if (flag)
			{
				System.IO.File.Delete(path);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000263D File Offset: 0x0000083D
		private void IsCardAvailable_CheckedChanged(object sender, EventArgs e)
		{
			this.textBoxCard.Enabled = this.IsCardAvailable1.Checked;
			Settings.Default.IsCardAvailable = this.IsCardAvailable1.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002678 File Offset: 0x00000878
		private void textBoxCard_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.CardNumber = this.textBoxCard.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000269C File Offset: 0x0000089C
		private void flatNumericDicountPayBTC_MouseUp(object sender, MouseEventArgs e)
		{
			this.UpdateNumericDicountPayBTC();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000269C File Offset: 0x0000089C
		private void flatNumericDicountPayBTC_KeyUp(object sender, KeyEventArgs e)
		{
			this.UpdateNumericDicountPayBTC();
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000026A6 File Offset: 0x000008A6
		private void UpdateNumericDicountPayBTC()
		{
			Settings.Default.DiscountBTC = this.flatNumericDicountPayBTC.Value;
			Settings.Default.Save();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000026CA File Offset: 0x000008CA
		private void flatNumericDicountPayLTC_KeyUp(object sender, KeyEventArgs e)
		{
			this.UpdateNumericDicountPayLTC();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000026CA File Offset: 0x000008CA
		private void flatNumericDicountPayLTC_MouseUp(object sender, MouseEventArgs e)
		{
			this.UpdateNumericDicountPayLTC();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000026D4 File Offset: 0x000008D4
		private void UpdateNumericDicountPayLTC()
		{
			Settings.Default.DiscountLTC = this.flatNumericDicountPayLTC.Value;
			Settings.Default.Save();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000026F8 File Offset: 0x000008F8
		private void IsReviewAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsReviewAvailable = this.IsReviewAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000271C File Offset: 0x0000091C
		private void checkBoxIsUserPayWalletAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsUserPayWalletAvailable = this.checkBoxIsUserPayWalletAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002740 File Offset: 0x00000940
		private void checkBoxIsReservAndPayInTheEndAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsReserveAndPayInTheEndAvailable = this.checkBoxIsReservAndPayInTheEndAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002764 File Offset: 0x00000964
		private void flatNumericTimeToCancelOrder_KeyUp(object sender, KeyEventArgs e)
		{
			this.flatNumericTimeToCancelOrderChange();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002764 File Offset: 0x00000964
		private void flatNumericTimeToCancelOrder_MouseUp(object sender, MouseEventArgs e)
		{
			this.flatNumericTimeToCancelOrderChange();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000276E File Offset: 0x0000096E
		private void flatNumericTimeToCancelOrderChange()
		{
			Settings.Default.TimeToCancelOrder = this.flatNumericTimeToCancelOrder.Value;
			Settings.Default.Save();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002792 File Offset: 0x00000992
		private void flatClose1_Click(object sender, EventArgs e)
		{
			Apirone.SaveCache();
			base.Close();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000027A2 File Offset: 0x000009A2
		private void flatRadioButtonRUB_CheckedChanged(object o)
		{
			this.CurrencyChange();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000027A2 File Offset: 0x000009A2
		private void flatRadioButtonUSD_CheckedChanged(object o)
		{
			this.CurrencyChange();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00011CA4 File Offset: 0x0000FEA4
		private void CurrencyChange()
		{
			bool flag = this.RUB_RATE == 0m;
			if (flag)
			{
				MessageBox.Show("Неизвестный курс рубля.");
			}
			else
			{
				bool flag2 = this.flatRadioButtonRUB.Checked && Settings.Default.Currency == 1;
				if (flag2)
				{
					DialogResult dialogResult = MessageBox.Show("Вы сменили валюту на рубль. Пересчитать кошельки у юзеров?", "Внимание!", MessageBoxButtons.YesNo);
					bool flag3 = dialogResult == DialogResult.Yes;
					if (flag3)
					{
						using (BotContext botContext = new BotContext())
						{
							foreach (TelegramBotBankStore.Domain.User user in ((IEnumerable<TelegramBotBankStore.Domain.User>)botContext.Users))
							{
								bool flag4 = user.BalanceRUB > 0m;
								if (flag4)
								{
									user.BalanceRUB = Math.Round(user.BalanceRUB * this.RUB_RATE, 2);
								}
							}
							botContext.SaveChanges();
						}
					}
					Settings.Default.Currency = 0;
					Settings.Default.Save();
					this.initCurrency();
				}
				else
				{
					bool flag5 = this.flatRadioButtonUSD.Checked && Settings.Default.Currency == 0;
					if (flag5)
					{
						DialogResult dialogResult2 = MessageBox.Show("Вы сменили валюту на доллар. Пересчитать кошельки у юзеров?", "Внимание!", MessageBoxButtons.YesNo);
						bool flag6 = dialogResult2 == DialogResult.Yes;
						if (flag6)
						{
							using (BotContext botContext2 = new BotContext())
							{
								foreach (TelegramBotBankStore.Domain.User user2 in ((IEnumerable<TelegramBotBankStore.Domain.User>)botContext2.Users))
								{
									bool flag7 = user2.BalanceRUB > 0m;
									if (flag7)
									{
										user2.BalanceRUB = Math.Round(user2.BalanceRUB / this.RUB_RATE, 2);
									}
								}
								botContext2.SaveChanges();
							}
						}
						Settings.Default.Currency = 1;
						Settings.Default.Save();
						this.initCurrency();
					}
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00011EF4 File Offset: 0x000100F4
		private void initCurrency()
		{
			Main.CURRENCY_BOT_CURRENT = (CurrencyBot)Settings.Default.Currency;
			CurrencyBot currency_BOT_CURRENT = Main.CURRENCY_BOT_CURRENT;
			CurrencyBot currencyBot = currency_BOT_CURRENT;
			if (currencyBot != CurrencyBot.RUB)
			{
				if (currencyBot != CurrencyBot.USD)
				{
					MessageBox.Show("Ошибка выбора валют");
				}
				else
				{
					Main.CURRENCY_NAME_CURRENT = Main.CURRENCY_NAME_USD;
				}
			}
			else
			{
				Main.CURRENCY_NAME_CURRENT = Main.CURRENCY_NAME_RUB;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000027AC File Offset: 0x000009AC
		private void checkBoxIsButtonLanguageAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsButtonLanguageAvailable = this.checkBoxIsButtonLanguageAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000027D0 File Offset: 0x000009D0
		private void cbIsEnterAmountToBuy_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsNotEnterAmountToBuy = this.cbIsEnterAmountToBuy.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000027F4 File Offset: 0x000009F4
		private void cbButtonIPaidForCard_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsButtonIPaidForCard = this.cbButtonIPaidForCard.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002818 File Offset: 0x00000A18
		private void cbButtonIPaidForElse_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsButtonIPaidForElse = this.cbButtonIPaidForElse.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000283C File Offset: 0x00000A3C
		private void cbLockCheckPayment_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsLockCheckPayment = this.cbIsLockCheckPayment.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00011F4C File Offset: 0x0001014C
		private void initYandex()
		{
			this.IsYandexAvailable.Checked = Settings.Default.IsYandexAvailable;
			this.textBoxYandexAddress.Text = Settings.Default.YandexAddress;
			this.textBoxYansexClientId.Text = Settings.Default.YansexClientId;
			this.textBoxYansexRedirectUri.Text = Settings.Default.YandexRedirectUri;
			this.textBoxYandexProxyName.Text = Settings.Default.YandexProxyNamePass;
			this.textBoxYandexProxyPort.Text = Settings.Default.YandexProxyIpPort;
			YandexMoney.InitYandexMoney();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00011FE4 File Offset: 0x000101E4
		private void flatButton1_Click(object sender, EventArgs e)
		{
			this.initYandex();
			YandexMoney yandexMoney = new YandexMoney();
			yandexMoney.Show();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002860 File Offset: 0x00000A60
		private void IsYandexAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsYandexAvailable = this.IsYandexAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002884 File Offset: 0x00000A84
		private void textBoxYandexAddress_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.YandexAddress = this.textBoxYandexAddress.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000028A8 File Offset: 0x00000AA8
		private void textBoxYansexRedirectUri_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.YandexRedirectUri = this.textBoxYansexRedirectUri.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000028CC File Offset: 0x00000ACC
		private void textBoxYansexClientId_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.YansexClientId = this.textBoxYansexClientId.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000028F0 File Offset: 0x00000AF0
		private void textBoxYandexProxyPort_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.YandexProxyIpPort = this.textBoxYandexProxyPort.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002914 File Offset: 0x00000B14
		private void textBoxYandexProxyName_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.YandexProxyNamePass = this.textBoxYandexProxyName.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00012008 File Offset: 0x00010208
		private void flatButtonUpCategory_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = this.treeViewCategories.SelectedNode;
			bool flag = selectedNode != null;
			if (flag)
			{
				using (BotContext botContext = new BotContext())
				{
					long id = long.Parse(selectedNode.Tag.ToString());
					List<Category> source = botContext.Categories.ToList<Category>();
					Category category = source.FirstOrDefault((Category x) => x.Id == id);
					List<Category> list = (from x in source
					where x.Parent == category.Parent
					select x).ToList<Category>();
					int num = list.IndexOf(category);
					bool flag2 = num >= 1;
					if (flag2)
					{
						Category.ExchangeCategory(category, list.ElementAt(num - 1));
						botContext.SaveChanges();
						this.refreshCategories(botContext);
					}
				}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000120F8 File Offset: 0x000102F8
		private void flatButtonDownCategory_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = this.treeViewCategories.SelectedNode;
			bool flag = selectedNode != null;
			if (flag)
			{
				using (BotContext botContext = new BotContext())
				{
					long id = long.Parse(selectedNode.Tag.ToString());
					List<Category> source = botContext.Categories.ToList<Category>();
					Category category = source.FirstOrDefault((Category x) => x.Id == id);
					List<Category> list = (from x in source
					where x.Parent == category.Parent
					select x).ToList<Category>();
					int num = list.IndexOf(category);
					bool flag2 = num <= list.Count - 2;
					if (flag2)
					{
						Category.ExchangeCategory(category, list.ElementAt(num + 1));
						botContext.SaveChanges();
						this.refreshCategories(botContext);
					}
				}
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000121F0 File Offset: 0x000103F0
		private void flatButtonUpProduct_Click(object sender, EventArgs e)
		{
			bool flag = this.dataGridViewProducts.SelectedCells.Count == 1;
			if (flag)
			{
				try
				{
					long id = long.Parse(this.dataGridViewProducts.Rows[this.dataGridViewProducts.SelectedCells[0].RowIndex].Cells["Id"].Value.ToString());
					using (BotContext botContext = new BotContext())
					{
						long categoryId = long.Parse(this.treeViewCategories.SelectedNode.Tag.ToString());
						Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == categoryId);
						Product product = category.Products.FirstOrDefault((Product x) => x.Id == id);
						List<Product> list = category.Products.ToList<Product>();
						int num = list.IndexOf(product);
						bool flag2 = num >= 1;
						if (flag2)
						{
							Product.ExchangeProduct(product, list.ElementAt(num - 1));
							botContext.SaveChanges();
							this.RefreshProducts(category.Products.ToList<Product>());
						}
					}
				}
				catch (Exception ex)
				{
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000123D8 File Offset: 0x000105D8
		private void flatButtonDownProduct_Click(object sender, EventArgs e)
		{
			bool flag = this.dataGridViewProducts.SelectedCells.Count == 1;
			if (flag)
			{
				try
				{
					long id = long.Parse(this.dataGridViewProducts.Rows[this.dataGridViewProducts.SelectedCells[0].RowIndex].Cells["Id"].Value.ToString());
					using (BotContext botContext = new BotContext())
					{
						long categoryId = long.Parse(this.treeViewCategories.SelectedNode.Tag.ToString());
						Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == categoryId);
						Product product = category.Products.FirstOrDefault((Product x) => x.Id == id);
						List<Product> list = category.Products.ToList<Product>();
						int num = list.IndexOf(product);
						bool flag2 = num <= list.Count - 2;
						if (flag2)
						{
							Product.ExchangeProduct(product, list.ElementAt(num + 1));
							botContext.SaveChanges();
							this.RefreshProducts(category.Products.ToList<Product>());
						}
					}
				}
				catch (Exception ex)
				{
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000125C8 File Offset: 0x000107C8
		public void UpdateReferal(BotContext context, TelegramBotBankStore.Domain.User user, PayCurrency currency, decimal sum)
		{
			bool flag = !Settings.Default.IsReferalAvailable || sum <= 0m || Settings.Default.RefferalRewarding == 0;
			if (!flag)
			{
				try
				{
					bool flag2 = user.RefferalUser != null;
					if (flag2)
					{
						decimal num = sum * Settings.Default.RefferalRewarding / 100m;
						TelegramBotBankStore.Domain.Transaction transaction = new TelegramBotBankStore.Domain.Transaction();
						bool flag3 = currency == PayCurrency.BTC;
						if (flag3)
						{
							user.RefferalUser.BalanceBTC += num;
							transaction.TransactionType = TransactionType.BTC;
						}
						else
						{
							bool flag4 = currency == PayCurrency.LTC;
							if (flag4)
							{
								user.RefferalUser.BalanceLTC += num;
								transaction.TransactionType = TransactionType.LTC;
							}
							else
							{
								bool flag5 = (currency == PayCurrency.RUB && Main.CURRENCY_BOT_CURRENT == CurrencyBot.RUB) || (currency == PayCurrency.USD && Main.CURRENCY_BOT_CURRENT == CurrencyBot.USD);
								if (!flag5)
								{
									throw new Exception("User pay currency ERROR! Currency pay " + currency.ToString() + " bot curr " + Main.CURRENCY_BOT_CURRENT.ToString());
								}
								user.RefferalUser.BalanceRUB += num;
								transaction.TransactionType = TransactionType.Qiwi;
							}
						}
						string fullName = user.GetFullName();
						transaction.User = user.RefferalUser;
						transaction.Address = "Refferal " + fullName;
						transaction.Sum = num;
						user.RefferalUser.Transactions.Add(transaction);
						user.IsReferalDone = true;
						context.SaveChanges();
						string text = (currency == PayCurrency.RUB) ? Main.CURRENCY_BOT_CURRENT.ToString() : currency.ToString();
						this.log.Info(string.Format("Начислено рефералу {0} сумму {1} {2} от {3}", new object[]
						{
							user.RefferalUser.GetFullName(),
							num,
							text,
							fullName
						}));
						string text2 = string.Format(Language.RefferalGet, num, text, fullName);
						this._botClient.SendTextMessageAsync(user.RefferalUser.ChatId, text2, ParseMode.Html, false, false, 0, null, default(CancellationToken)).Wait();
					}
				}
				catch (Exception message)
				{
					this.log.Error(message);
				}
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002938 File Offset: 0x00000B38
		private void numericUpDownRefferal_Click(object sender, EventArgs e)
		{
			Settings.Default.RefferalRewarding = (int)this.numericUpDownRefferal.Value;
			Settings.Default.Save();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002961 File Offset: 0x00000B61
		private void flatTextBoxReferral_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.Referral = this.flatTextBoxReferral.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00012858 File Offset: 0x00010A58
		private async Task showRefLink(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			string text = Settings.Default.Referral;
			text = string.Concat(new object[]
			{
				text,
				"\n\n\ud83d\udc65",
				Language.RefferalYours,
				" ",
				user.Referals.Count<TelegramBotBankStore.Domain.User>()
			});
			text = text + "\n\ud83c\udf81" + Language.RefferalSumGet + "\n";
			text = string.Concat(new object[]
			{
				text,
				"  BTC - ",
				user.TotalReferralBonusBTC,
				"\n"
			});
			text = string.Concat(new object[]
			{
				text,
				"  LTC - ",
				user.TotalReferralBonusLTC,
				"\n"
			});
			text = string.Concat(new object[]
			{
				text,
				"  RUB - ",
				user.TotalReferralBonusRUB,
				"\n"
			});
			bool flag = this._botMeInformation == null || string.IsNullOrEmpty(this._botMeInformation.Username);
			if (flag)
			{
				Telegram.Bot.Types.User botMeInformation = await botClient.GetMeAsync(default(CancellationToken));
				this._botMeInformation = botMeInformation;
				botMeInformation = null;
			}
			string reff_url = string.Format("https://t.me/{0}?start={1}", this._botMeInformation.Username, user.ChatId);
			reff_url = string.Format("\n\n<b>{0} {1}:</b> {2}", "➰", Language.YourRefferalLink, reff_url);
			await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, true, true, 0, null, default(CancellationToken));
			await botClient.SendTextMessageAsync(user.ChatId, reff_url, ParseMode.Html, true, true, 0, null, default(CancellationToken));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002985 File Offset: 0x00000B85
		private void IsReferalAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsReferalAvailable = this.IsReferalAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000128B4 File Offset: 0x00010AB4
		private void buttonTele2Init_Click(object sender, EventArgs e)
		{
			bool flag = !Settings.Default.IsTele2Available;
			if (flag)
			{
				Main.ShowMessage("Tele2 не активен.", null);
			}
			else
			{
				try
				{
					this.initTele2Api();
					Main.ShowMessage("Баланс - " + this._tele2Api.GetBalance(), null);
				}
				catch (Exception ex)
				{
					FormMessage formMessage = new FormMessage(ex.Message, null);
					formMessage.ShowDialog();
				}
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00012938 File Offset: 0x00010B38
		private void IsTele2Available_CheckedChanged(object sender, EventArgs e)
		{
			this.textBoxTele2Number.Enabled = (this.textBoxTele2Password.Enabled = this.IsTele2Available.Checked);
			Settings.Default.IsTele2Available = this.IsTele2Available.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000029A9 File Offset: 0x00000BA9
		private void textBoxTele2Number_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.Tele2Number = this.textBoxTele2Number.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000029CD File Offset: 0x00000BCD
		private void textBoxTele2Password_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.Tele2Password = Key.Encrypt(this.textBoxTele2Password.Text);
			Settings.Default.Save();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00012990 File Offset: 0x00010B90
		private void initTele2Setting()
		{
			string tele2Number = Settings.Default.Tele2Number;
			string text = Key.Decrypt(Settings.Default.Tele2Password);
			this.IsTele2Available.Checked = Settings.Default.IsTele2Available;
			this.textBoxTele2Password.Text = text;
			this.textBoxTele2Number.Text = tele2Number;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000129EC File Offset: 0x00010BEC
		private void initTele2Api()
		{
			string tele2Number = Settings.Default.Tele2Number;
			string text = Key.Decrypt(Settings.Default.Tele2Password);
			bool isTele2Available = Settings.Default.IsTele2Available;
			if (isTele2Available)
			{
				bool flag = !string.IsNullOrEmpty(tele2Number) && !string.IsNullOrEmpty(text);
				if (flag)
				{
					bool flag2 = this._tele2Api == null;
					if (flag2)
					{
						this._tele2Api = new Tele2Api(tele2Number, text);
					}
				}
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000029F6 File Offset: 0x00000BF6
		private void cbIsButtonAvailability_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsMainButtonAvailability = this.cbIsButtonAvailability.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002A1A File Offset: 0x00000C1A
		private void cbIsButtonStatistic_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsMainButtonStatistics = this.cbIsButtonStatistic.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002A3E File Offset: 0x00000C3E
		private void cbIsNotFoundAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsNotFoundAvailable = this.cbIsNotFoundAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00012A5C File Offset: 0x00010C5C
		private async Task showNotFound(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient)
		{
			string text = string.IsNullOrWhiteSpace(Settings.Default.NotFoundText) ? Language.NotFoundText : Settings.Default.NotFoundText;
			user.Action = TelegramBotBankStore.Domain.User.Actions.WaitForNotFoundMessage;
			user.Comment = "";
			TelegramWrapper wrapper = new TelegramWrapper(new int?(1));
			wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
			wrapper.AddInlineButton(Language.Confirm, "/notFound", "", "✅");
			await botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00012AB8 File Offset: 0x00010CB8
		private async Task ResendNotFound(BotContext context, TelegramBotBankStore.Domain.User user, TelegramBotClient botClient, Telegram.Bot.Types.Message message)
		{
			bool flag = string.IsNullOrWhiteSpace(user.Comment);
			if (!flag)
			{
				string text = "*ненаход*";
				string[] mesId = user.Comment.Split(new string[]
				{
					"-"
				}, StringSplitOptions.None);
				string chanell = string.Empty;
				try
				{
					chanell = this.getChannelName(Settings.Default.NotFoundChennel);
					bool flag2 = !string.IsNullOrEmpty(chanell);
					if (flag2)
					{
						await botClient.SendTextMessageAsync(chanell, text, ParseMode.Html, false, false, 0, null, default(CancellationToken));
					}
				}
				catch (Exception ex)
				{
					this.log.Error(ex);
				}
				foreach (string id in mesId)
				{
					try
					{
						if (!string.IsNullOrEmpty(chanell))
						{
							await botClient.ForwardMessageAsync(chanell, user.ChatId, int.Parse(id), false, default(CancellationToken));
						}
					}
					catch (Exception ex2)
					{
						this.log.Error("id - " + id);
						this.log.Error(ex2);
					}
					id = null;
				}
				string[] array = null;
				user.Comment = "";
				user.Action = TelegramBotBankStore.Domain.User.Actions.None;
				user.NotFoundAmount++;
				await botClient.SendTextMessageAsync(user.ChatId, Language.NotFoundConfirmed, ParseMode.Html, false, false, 0, null, default(CancellationToken));
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002A62 File Offset: 0x00000C62
		private void tbNotFoundText_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.NotFoundText = this.tbNotFoundText.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002A86 File Offset: 0x00000C86
		private void tbNotFoundChennel_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.NotFoundChennel = this.tbNotFoundChennel.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00012B1C File Offset: 0x00010D1C
		private async void bNotFoundChennelTest_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = string.IsNullOrEmpty(Settings.Default.NotFoundChennel);
				if (flag)
				{
					throw new Exception("Необходимо ввести название канала");
				}
				bool flag2 = this._botClient == null;
				if (flag2)
				{
					this._botClient = this.createClient();
				}
				string chanell = this.getChannelName(Settings.Default.NotFoundChennel);
				await this._botClient.SendTextMessageAsync(chanell, "testNotFound", ParseMode.Default, false, false, 0, null, default(CancellationToken));
				this.updateStatus("Сообщение успешно отправлено", null, null);
				chanell = null;
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002AAA File Offset: 0x00000CAA
		private void cbIsSendMoneyButtonAvailabile_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsSendMoneyButtonAvailabile = this.cbIsSendMoneyButtonAvailabile.Checked;
			Settings.Default.Save();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00012B68 File Offset: 0x00010D68
		private async Task SendMoney(BotContext context, TelegramBotBankStore.Domain.User user, string MessageConvertTo = null)
		{
			string text = string.Empty;
			bool flag = string.IsNullOrWhiteSpace(MessageConvertTo);
			if (flag)
			{
				text = "Чтобы отправить деньги другому юзеру в боте введите сумму, наименование валюты и id, полученное от пользователя (юзер может его получить нажав кнопку 'Получить ID')";
				text += "\n\nПримеры:";
				text += "\n0,005 BTC 556854";
				text = text + "\n10 " + Main.CURRENCY_BOT_CURRENT.ToString() + " 558568";
				user.Action = TelegramBotBankStore.Domain.User.Actions.WaitForSendMoneyMessage;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(1));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				await this._botClient.SendTextMessageAsync(user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				wrapper = null;
			}
			else
			{
				string[] spl = MessageConvertTo.Split(new string[]
				{
					" "
				}, StringSplitOptions.RemoveEmptyEntries);
				if (spl.Length == 3)
				{
					decimal sum;
					if (decimal.TryParse(spl[0].Replace(",", "."), out sum))
					{
						PayCurrency currency = PayCurrency.None;
						Enum.TryParse<PayCurrency>(spl[1], out currency);
						if (currency != PayCurrency.None)
						{
							Main.<>c__DisplayClass285_0 CS$<>8__locals1 = new Main.<>c__DisplayClass285_0();
							if (long.TryParse(spl[2], out CS$<>8__locals1.toUserId))
							{
								IQueryable<TelegramBotBankStore.Domain.User> users = context.Users;
								ParameterExpression parameterExpression = Expression.Parameter(typeof(TelegramBotBankStore.Domain.User), "x");
								TelegramBotBankStore.Domain.User toUser = users.FirstOrDefault(Expression.Lambda<Func<TelegramBotBankStore.Domain.User, bool>>(Expression.Equal(Expression.Property(parameterExpression, methodof(TelegramBotBankStore.Domain.User.get_ChatId())), Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Main.<>c__DisplayClass285_0)), fieldof(Main.<>c__DisplayClass285_0.toUserId))), new ParameterExpression[]
								{
									parameterExpression
								}));
								if (toUser != null)
								{
									bool isOk = false;
									if (currency == PayCurrency.BTC && user.BalanceBTC >= sum)
									{
										user.BalanceBTC -= sum;
										toUser.BalanceBTC += sum;
										isOk = true;
									}
									else if (currency == PayCurrency.LTC && user.BalanceLTC >= sum)
									{
										user.BalanceLTC -= sum;
										toUser.BalanceLTC += sum;
										isOk = true;
									}
									else if (currency == PayCurrency.RUB && user.BalanceRUB >= sum)
									{
										user.BalanceRUB -= sum;
										toUser.BalanceRUB += sum;
										isOk = true;
									}
									if (isOk)
									{
										this.log.Info(string.Format("SEND MMONEY - User {0}, sended {1}, currency {2}, to {3} ", new object[]
										{
											user.GetFullName(),
											sum,
											currency,
											toUser.GetFullName()
										}));
										user.Action = TelegramBotBankStore.Domain.User.Actions.None;
										context.SaveChanges();
										await this._botClient.SendTextMessageAsync(user.ChatId, "Успешно отправлено.", ParseMode.Html, false, false, 0, null, default(CancellationToken));
										await this._botClient.SendTextMessageAsync(toUser.ChatId, string.Format("Вам поступила сумма {0}{1} от {2}", sum, currency, user.GetFullName()), ParseMode.Html, false, false, 0, null, default(CancellationToken));
										return;
									}
								}
								toUser = null;
							}
							CS$<>8__locals1 = null;
						}
					}
				}
				await this._botClient.SendTextMessageAsync(user.ChatId, "Неверный формат данных", ParseMode.Html, false, false, 0, null, default(CancellationToken));
				spl = null;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00012BC4 File Offset: 0x00010DC4
		private async Task ReceiveMoney(BotContext context, TelegramBotBankStore.Domain.User user)
		{
			await this._botClient.SendTextMessageAsync(user.ChatId, "Ваше ID, отправьте его тому, кто делает перевод:", ParseMode.Default, false, false, 0, null, default(CancellationToken));
			await this._botClient.SendTextMessageAsync(user.ChatId, user.ChatId.ToString(), ParseMode.Default, false, false, 0, null, default(CancellationToken));
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00012C1C File Offset: 0x00010E1C
		private void bHistoryTransaction_Click(object sender, EventArgs e)
		{
			using (BotContext botContext = new BotContext())
			{
				FormTransactions formTransactions = new FormTransactions(botContext);
				formTransactions.ShowDialog();
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00024164 File Offset: 0x00022364
		private void initTablePromoCodes(List<PromoCode> list)
		{
			this.dataGridViewPromoCodes.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewPromoCodes.DataGridView_Init(ControlExtensions.DataGridStyles.MonoFlatDark);
				this.dataGridViewPromoCodes.DataSource = list;
				foreach (object obj in this.dataGridViewPromoCodes.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					string name = dataGridViewColumn.Name;
					string text = name;
					if (text == null)
					{
						goto IL_290;
					}
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
					if (num <= 613194351u)
					{
						if (num != 266367750u)
						{
							if (num != 426922525u)
							{
								if (num != 613194351u)
								{
									goto IL_290;
								}
								if (!(text == "DateApply"))
								{
									goto IL_290;
								}
								dataGridViewColumn.HeaderText = "Дата применения";
								dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
								dataGridViewColumn.MinimumWidth = 100;
								dataGridViewColumn.DisplayIndex = 6;
							}
							else
							{
								if (!(text == "PromoCodeType"))
								{
									goto IL_290;
								}
								dataGridViewColumn.HeaderText = "Тип";
								dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
								dataGridViewColumn.MinimumWidth = 70;
								dataGridViewColumn.DisplayIndex = 1;
							}
						}
						else
						{
							if (!(text == "Name"))
							{
								goto IL_290;
							}
							dataGridViewColumn.HeaderText = "Название";
							dataGridViewColumn.Width = 110;
							dataGridViewColumn.DisplayIndex = 0;
						}
					}
					else if (num <= 1821930810u)
					{
						if (num != 739214825u)
						{
							if (num != 1821930810u)
							{
								goto IL_290;
							}
							if (!(text == "IsApplied"))
							{
								goto IL_290;
							}
							dataGridViewColumn.HeaderText = "Применен?";
							dataGridViewColumn.Width = 100;
							dataGridViewColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
							dataGridViewColumn.DisplayIndex = 5;
						}
						else
						{
							if (!(text == "DateCreate"))
							{
								goto IL_290;
							}
							dataGridViewColumn.HeaderText = "Дата создания";
							dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
							dataGridViewColumn.MinimumWidth = 100;
							dataGridViewColumn.DisplayIndex = 3;
						}
					}
					else if (num != 2620727545u)
					{
						if (num != 3511155050u)
						{
							goto IL_290;
						}
						if (!(text == "Value"))
						{
							goto IL_290;
						}
						dataGridViewColumn.HeaderText = "Значение";
						dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						dataGridViewColumn.MinimumWidth = 80;
						dataGridViewColumn.DisplayIndex = 2;
					}
					else
					{
						if (!(text == "UserName"))
						{
							goto IL_290;
						}
						dataGridViewColumn.HeaderText = "Присвоено юзеру";
						dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						dataGridViewColumn.MinimumWidth = 100;
						dataGridViewColumn.DisplayIndex = 4;
					}
					continue;
					IL_290:
					dataGridViewColumn.Visible = false;
				}
				this.dataGridViewPromoCodes.ClearSelection();
				DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn();
				dataGridViewImageColumn.Name = "remove";
				dataGridViewImageColumn.HeaderText = "";
				dataGridViewImageColumn.Width = 20;
				dataGridViewImageColumn.Image = Resources.remove_dark;
				dataGridViewImageColumn.DisplayIndex = 7;
				this.dataGridViewPromoCodes.Columns.Add(dataGridViewImageColumn);
			}));
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000241A0 File Offset: 0x000223A0
		private void InitPagePromoCodesSetting(BotContext context)
		{
			this.cbIsPromoCodeAvailable.Checked = Settings.Default.IsPromoCodeAvailable;
			this.radioButtonPromoCodeAddToWallet.Checked = true;
			this.RefreshTablePromoCodes(context.PromoCodes.Include("User").ToList<PromoCode>());
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000241F0 File Offset: 0x000223F0
		public void RefreshTablePromoCodes(List<PromoCode> list)
		{
			this.dataGridViewPromoCodes.Invoke(new MethodInvoker(delegate()
			{
				this.dataGridViewPromoCodes.DataSource = list;
			}));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002ACE File Offset: 0x00000CCE
		private void radioButtonPromoCode_CheckedChanged(object sender, EventArgs e)
		{
			this.SetParametersForGeneratePromocode();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0002422C File Offset: 0x0002242C
		private void SetParametersForGeneratePromocode()
		{
			bool @checked = this.radioButtonPromoCodeAddToWallet.Checked;
			if (@checked)
			{
				this.flatNumericPromocodeValue.Value = 0m;
				this.flatNumericPromocodeValue.Minimum = 0m;
				this.flatNumericPromocodeValue.Maximum = 10000m;
				this.lbPromoCodeFrom.Visible = false;
				this.flatNumericPromocodeFrom.Visible = false;
				this.labelPromoCodeValue.Text = "Сумма пополнения:";
			}
			else
			{
				bool checked2 = this.radioButtonPromoCodeDiscount.Checked;
				if (checked2)
				{
					this.flatNumericPromocodeValue.Value = 0m;
					this.flatNumericPromocodeValue.Minimum = 0m;
					this.flatNumericPromocodeValue.Maximum = 100m;
					this.lbPromoCodeFrom.Visible = true;
					this.flatNumericPromocodeFrom.Visible = true;
					this.labelPromoCodeValue.Text = "Значение скидки в %:";
				}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00024324 File Offset: 0x00022524
		private void flatButtonGeneratePromoCodes_Click(object sender, EventArgs e)
		{
			PromoCode promo = new PromoCode();
			bool flag = string.IsNullOrEmpty(this.flatTextBoxPromoCode.Text);
			if (flag)
			{
				promo.Name = this.getComment(8);
			}
			else
			{
				promo.Name = this.flatTextBoxPromoCode.Text;
			}
			promo.Value = this.flatNumericPromocodeValue.Value;
			promo.MaxNumberOfCurrentPromo = (int)this.flatNumericPromocodeMaxNumber.Value;
			bool @checked = this.radioButtonPromoCodeAddToWallet.Checked;
			if (@checked)
			{
				promo.PromoCodeType = PromoCodeEnum.AddToWallet;
			}
			else
			{
				bool checked2 = this.radioButtonPromoCodeDiscount.Checked;
				if (!checked2)
				{
					return;
				}
				promo.PromoCodeType = PromoCodeEnum.Discount;
				promo.DiscountFrom = this.flatNumericPromocodeFrom.Value;
			}
			using (BotContext botContext = new BotContext())
			{
				bool flag2 = botContext.PromoCodes.Any((PromoCode x) => x.Name == promo.Name);
				if (flag2)
				{
					Main.ShowMessage("Название промокода уже есть, попробуйте еще.", "Промокод");
					return;
				}
				botContext.PromoCodes.Add(promo);
				botContext.SaveChanges();
				this.RefreshTablePromoCodes(botContext.PromoCodes.Include("User").ToList<PromoCode>());
			}
			this.flatTextBoxPromoCode.Text = promo.Name;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002AD8 File Offset: 0x00000CD8
		private void cbIsPromoCodeAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsPromoCodeAvailable = this.cbIsPromoCodeAvailable.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00024524 File Offset: 0x00022724
		private async Task invoiceCheckPromoCode(BotContext context, TelegramBotBankStore.Domain.User user, string promo)
		{
			Main.<>c__DisplayClass595_0 CS$<>8__locals1 = new Main.<>c__DisplayClass595_0();
			CS$<>8__locals1.promo = promo;
			CS$<>8__locals1.user = user;
			bool flag = string.IsNullOrEmpty(CS$<>8__locals1.promo) || CS$<>8__locals1.promo.Contains(Language.PromoCode);
			if (flag)
			{
				string text = Language.PromoCodePleaseEnter;
				CS$<>8__locals1.user.Action = TelegramBotBankStore.Domain.User.Actions.WaitForPromoCode;
				TelegramWrapper wrapper = new TelegramWrapper(new int?(2));
				wrapper.AddInlineButton(Language.Cancel, "/backmenu", "", "❌");
				await this._botClient.SendTextMessageAsync(CS$<>8__locals1.user.ChatId, text, ParseMode.Html, false, false, 0, wrapper.GetInlineKeyboardMarkup(), default(CancellationToken));
				text = null;
				wrapper = null;
			}
			else
			{
				string text2 = string.Empty;
				IQueryable<PromoCode> promoCodes = context.PromoCodes;
				ParameterExpression parameterExpression = Expression.Parameter(typeof(PromoCode), "x");
				PromoCode prom = promoCodes.FirstOrDefault(Expression.Lambda<Func<PromoCode, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, methodof(PromoCode.get_Name())), Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Main.<>c__DisplayClass595_0)), fieldof(Main.<>c__DisplayClass595_0.promo))), Expression.Not(Expression.Property(parameterExpression, methodof(PromoCode.get_IsApplied())))), new ParameterExpression[]
				{
					parameterExpression
				}));
				IQueryable<PromoCode> promoCodes2 = context.PromoCodes;
				parameterExpression = Expression.Parameter(typeof(PromoCode), "x");
				if (promoCodes2.Any(Expression.Lambda<Func<PromoCode, bool>>(Expression.AndAlso(Expression.Equal(Expression.Property(parameterExpression, methodof(PromoCode.get_Name())), Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Main.<>c__DisplayClass595_0)), fieldof(Main.<>c__DisplayClass595_0.promo))), Expression.Equal(Expression.Property(Expression.Property(parameterExpression, methodof(PromoCode.get_User())), methodof(TelegramBotBankStore.Domain.User.get_ChatId())), Expression.Property(Expression.Field(Expression.Constant(CS$<>8__locals1, typeof(Main.<>c__DisplayClass595_0)), fieldof(Main.<>c__DisplayClass595_0.user)), methodof(TelegramBotBankStore.Domain.User.get_ChatId())))), new ParameterExpression[]
				{
					parameterExpression
				})))
				{
					prom = null;
				}
				if (prom == null)
				{
					text2 = Language.PromoCodeIsNotValid;
				}
				else
				{
					if (prom.PromoCodeType == PromoCodeEnum.AddToWallet)
					{
						CS$<>8__locals1.user.BalanceRUB += prom.Value;
						prom.IsApplied = true;
						prom.DateApply = new DateTime?(DateTime.Now);
						prom.User = CS$<>8__locals1.user;
						context.SaveChanges();
						text2 = string.Concat(new object[]
						{
							Language.PromoCodeToWalletApplied,
							prom.Value,
							" ",
							Main.CURRENCY_NAME_CURRENT
						});
					}
					else
					{
						if (prom.PromoCodeType != PromoCodeEnum.Discount)
						{
							throw new NotImplementedException("Undefined promocode.");
						}
						prom.User = CS$<>8__locals1.user;
						context.SaveChanges();
						text2 = string.Format(Language.PromoCodeDiscount, prom.Value, prom.DiscountFrom + Main.CURRENCY_NAME_CURRENT);
					}
					this.CreateNextPromocodeIfCan(context, prom);
				}
				CS$<>8__locals1.user.Action = TelegramBotBankStore.Domain.User.Actions.None;
				await this._botClient.SendTextMessageAsync(CS$<>8__locals1.user.ChatId, text2, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				text2 = null;
				prom = null;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00024580 File Offset: 0x00022780
		private PromoCode UserPromocode(BotContext context, TelegramBotBankStore.Domain.User user)
		{
			return context.PromoCodes.FirstOrDefault((PromoCode x) => !x.IsApplied && x.User.Id == user.Id);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002AFC File Offset: 0x00000CFC
		private void ApplyPromocode(PromoCode promo)
		{
			promo.IsApplied = true;
			promo.DateApply = new DateTime?(DateTime.Now);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00024650 File Offset: 0x00022850
		private void CreateNextPromocodeIfCan(BotContext context, PromoCode copyPromo)
		{
			try
			{
				bool flag = copyPromo.NumberOfCurrentPromo < copyPromo.MaxNumberOfCurrentPromo;
				if (flag)
				{
					PromoCode promoCode = new PromoCode();
					promoCode.Name = copyPromo.Name;
					promoCode.Value = copyPromo.Value;
					promoCode.PromoCodeType = copyPromo.PromoCodeType;
					promoCode.MaxNumberOfCurrentPromo = copyPromo.MaxNumberOfCurrentPromo;
					promoCode.NumberOfCurrentPromo = copyPromo.NumberOfCurrentPromo + 1;
					context.PromoCodes.Add(promoCode);
					context.SaveChanges();
					this.RefreshTablePromoCodes(context.PromoCodes.Include("User").ToList<PromoCode>());
				}
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00024714 File Offset: 0x00022914
		private void flatButtonPromoCodeCopy_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.flatTextBoxPromoCode.Text);
			if (flag)
			{
				Clipboard.SetText(this.flatTextBoxPromoCode.Text);
				this.flatTextBoxPromoCode.Text = string.Empty;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00024760 File Offset: 0x00022960
		private async void flatButtonPromoCodeCopyRef_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.flatTextBoxPromoCode.Text);
			if (flag)
			{
				bool flag2 = this._botClient == null;
				if (flag2)
				{
					this._botClient = this.createClient();
				}
				bool flag3 = this._botMeInformation == null || string.IsNullOrEmpty(this._botMeInformation.Username);
				if (flag3)
				{
					Telegram.Bot.Types.User botMeInformation = await this._botClient.GetMeAsync(default(CancellationToken));
					this._botMeInformation = botMeInformation;
					botMeInformation = null;
				}
				string s = string.Format("https://t.me/{0}?start=promo{1}", this._botMeInformation.Username, this.flatTextBoxPromoCode.Text);
				Clipboard.SetText(s);
				s = null;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000247AC File Offset: 0x000229AC
		private async void FlatButtonQiwiProxy_Click(object sender, EventArgs e)
		{
			StringCollection lists = new StringCollection();
			lists.Add(string.Concat(new string[]
			{
				this.textNumber1.Text,
				"-",
				this.textAPI1.Text,
				"-",
				this.textProxy1.Text,
				"-",
				this.textPass1.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber2.Text,
				"-",
				this.textAPI2.Text,
				"-",
				this.textProxy2.Text,
				"-",
				this.textPass2.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber3.Text,
				"-",
				this.textAPI3.Text,
				"-",
				this.textProxy3.Text,
				"-",
				this.textPass3.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber4.Text,
				"-",
				this.textAPI4.Text,
				"-",
				this.textProxy4.Text,
				"-",
				this.textPass4.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber5.Text,
				"-",
				this.textAPI5.Text,
				"-",
				this.textProxy5.Text,
				"-",
				this.textPass5.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber6.Text,
				"-",
				this.textAPI6.Text,
				"-",
				this.textProxy6.Text,
				"-",
				this.textPass6.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber7.Text,
				"-",
				this.textAPI7.Text,
				"-",
				this.textProxy7.Text,
				"-",
				this.textPass7.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber8.Text,
				"-",
				this.textAPI8.Text,
				"-",
				this.textProxy8.Text,
				"-",
				this.textPass8.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber9.Text,
				"-",
				this.textAPI9.Text,
				"-",
				this.textProxy9.Text,
				"-",
				this.textPass9.Text
			}));
			lists.Add(string.Concat(new string[]
			{
				this.textNumber10.Text,
				"-",
				this.textAPI10.Text,
				"-",
				this.textProxy10.Text,
				"-",
				this.textPass10.Text
			}));
			Settings.Default.QiwiListSettings = lists;
			Settings.Default.Save();
			string[] array = await this.InitMyQiwi();
			string[] response = array;
			array = null;
			for (int i = 0; i < 10; i++)
			{
				Label tbx = base.Controls.Find("labelF" + (i + 1), true).FirstOrDefault<Control>() as Label;
				tbx.Text = response[i];
				tbx = null;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002B18 File Offset: 0x00000D18
		private void IsQiwiAvailable_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.IsQiwiAvailable = this.IsQiwiAvailable1.Checked;
			Settings.Default.Save();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000247F8 File Offset: 0x000229F8
		public void initQiwiSettings()
		{
			this.IsQiwiAvailable1.Checked = Settings.Default.IsQiwiAvailable;
			bool flag = Settings.Default.QiwiMethod == 0;
			if (flag)
			{
				this.radioButtonIsQiwiNumber.Checked = true;
			}
			else
			{
				bool flag2 = Settings.Default.QiwiMethod == 1;
				if (flag2)
				{
					this.radioButtonIsQiwiCode.Checked = true;
				}
			}
			StringCollection qiwiListSettings = Settings.Default.QiwiListSettings;
			bool flag3 = qiwiListSettings != null;
			if (flag3)
			{
				int num = 1;
				foreach (string text in qiwiListSettings)
				{
					try
					{
						string[] array = text.Split(new char[]
						{
							'-'
						});
						FlatTextBox flatTextBox = this.tabPageSettingQiwi.Controls.Find("textNumber" + num, true).FirstOrDefault<Control>() as FlatTextBox;
						flatTextBox.Text = array[0];
						flatTextBox = (base.Controls.Find("textAPI" + num, true).FirstOrDefault<Control>() as FlatTextBox);
						flatTextBox.Text = array[1];
						try
						{
							flatTextBox = (base.Controls.Find("textProxy" + num, true).FirstOrDefault<Control>() as FlatTextBox);
							flatTextBox.Text = array[2];
							flatTextBox = (base.Controls.Find("textPass" + num, true).FirstOrDefault<Control>() as FlatTextBox);
							flatTextBox.Text = array[3];
						}
						catch
						{
						}
						Label label = base.Controls.Find("labelF" + num, true).FirstOrDefault<Control>() as Label;
						label.Text = "";
						num++;
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00024A40 File Offset: 0x00022C40
		private string GetQiwiNumber()
		{
			this._qiwiCurrentNumber++;
			bool flag = this._qiwiCurrentNumber > 10;
			if (flag)
			{
				this._qiwiCurrentNumber = 1;
			}
			bool flag2 = this.MyQiwiList.ContainsKey(this._qiwiCurrentNumber);
			string result;
			if (flag2)
			{
				this.countInnerCall = 0;
				result = this.MyQiwiList[this._qiwiCurrentNumber].Number;
			}
			else
			{
				bool flag3 = this.countInnerCall > 11;
				if (flag3)
				{
					this.countInnerCall = 0;
					result = "";
				}
				else
				{
					this.countInnerCall++;
					result = this.GetQiwiNumber();
				}
			}
			return result;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00024AE0 File Offset: 0x00022CE0
		public MyQiwi GetMyQiwiByNumber(string numb)
		{
			bool flag = string.IsNullOrEmpty(numb);
			MyQiwi result;
			if (flag)
			{
				result = null;
			}
			else
			{
				foreach (MyQiwi myQiwi in this.MyQiwiList.Values)
				{
					bool flag2 = myQiwi.Number == numb;
					if (flag2)
					{
						return myQiwi;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00024B64 File Offset: 0x00022D64
		public async Task<string[]> InitMyQiwi()
		{
			string[] response = new string[10];
			bool flag = !Settings.Default.IsQiwiAvailable;
			string[] result;
			if (flag)
			{
				result = response;
			}
			else
			{
				this.MyQiwiList = new Dictionary<int, MyQiwi>();
				StringCollection list = Settings.Default.QiwiListSettings;
				int i = 1;
				bool flag2 = list != null;
				if (flag2)
				{
					foreach (string line in list)
					{
						string[] arr = line.Trim().Split(new char[]
						{
							'-'
						});
						MyQiwi qiwi = new MyQiwi();
						qiwi.Number = arr[0];
						qiwi.API = arr[1];
						qiwi.QiwiConnection = new Qiwi(qiwi.Number, qiwi.API);
						try
						{
							bool flag3 = arr[2] != "" && arr[3] != null;
							if (flag3)
							{
								string[] a = arr[2].Split(new char[]
								{
									':'
								});
								string[] b = arr[3].Split(new char[]
								{
									':'
								});
								WebProxy proxy = new WebProxy(a[0], Convert.ToInt32(a[1]));
								proxy.Credentials = new NetworkCredential(b[0], b[1]);
								typeof(Qiwi).GetField("_webClient", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(qiwi.QiwiConnection, new WebClient
								{
									Encoding = Encoding.UTF8,
									Proxy = proxy,
									Credentials = new NetworkCredential(b[0], b[1])
								});
								a = null;
								b = null;
								proxy = null;
							}
							Balances balances2 = await qiwi.QiwiConnection.GetBalancesAsync();
							Balances balances = balances2;
							balances2 = null;
							History history2 = await qiwi.GetHistory();
							History history = history2;
							history2 = null;
							foreach (Payment p in history.Payments)
							{
								Main.transactionSet.Add(p.Id);
								p = null;
							}
							Payment[] array = null;
							string text = qiwi.Number + " - Подключен, баланс - " + balances.Rub.ToString();
							response[i - 1] = text;
							this.MyQiwiList.Add(i, qiwi);
							balances = null;
							history = null;
							text = null;
						}
						catch (Exception ex)
						{
							response[i - 1] = "Не подключено. " + ex.Message;
						}
						i++;
						arr = null;
						qiwi = null;
						line = null;
					}
					StringEnumerator stringEnumerator = null;
				}
				result = response;
			}
			return result;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00024BAC File Offset: 0x00022DAC
		private void FlatButtonChart1_Click(object sender, EventArgs e)
		{
			ValueTuple<string[], double[]> forAllSaled = this.GetForAllSaled();
			string[] item = forAllSaled.Item1;
			double[] item2 = forAllSaled.Item2;
			this.Draw(item, item2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00024BD8 File Offset: 0x00022DD8
		private ValueTuple<string[], double[]> GetForAllSaled()
		{
			Main.<>c__DisplayClass611_0 CS$<>8__locals1 = new Main.<>c__DisplayClass611_0();
			List<Product> source;
			using (BotContext botContext = new BotContext())
			{
				source = (from x in botContext.Products
				where x.Category == null && x.User != null
				select x).ToList<Product>();
			}
			CS$<>8__locals1.listNames = (from x in source
			select x.Name).Distinct<string>().ToArray<string>();
			double[] array = new double[CS$<>8__locals1.listNames.Length];
			int i;
			int i2;
			for (i = 0; i < CS$<>8__locals1.listNames.Length; i = i2 + 1)
			{
				array[i] = (double)source.Count((Product x) => x.Name == CS$<>8__locals1.listNames[i]);
				string[] listNames = CS$<>8__locals1.listNames;
				int j = i;
				listNames[j] = listNames[j] + " - " + array[i];
				i2 = i;
			}
			return new ValueTuple<string[], double[]>(CS$<>8__locals1.listNames, array);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00024D98 File Offset: 0x00022F98
		private void FlatButtonChart2_Click(object sender, EventArgs e)
		{
			ValueTuple<string[], double[]> forAllSaledAndCurrnetProduct = this.GetForAllSaledAndCurrnetProduct();
			string[] item = forAllSaledAndCurrnetProduct.Item1;
			double[] item2 = forAllSaledAndCurrnetProduct.Item2;
			this.Draw(item, item2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00024DC4 File Offset: 0x00022FC4
		private ValueTuple<string[], double[]> GetForAllSaledAndCurrnetProduct()
		{
			Main.<>c__DisplayClass613_0 CS$<>8__locals1 = new Main.<>c__DisplayClass613_0();
			List<Product> list = new List<Product>();
			int i;
			List<Product> source;
			using (BotContext botContext = new BotContext())
			{
				foreach (Category category in ((IEnumerable<Category>)botContext.Categories))
				{
					List<Product> list2 = (from i in category.Products
					where i.User == null
					select i).ToList<Product>();
					bool flag = list2 != null;
					if (flag)
					{
						list.AddRange(list2);
					}
				}
				source = (from x in botContext.Products
				where x.Category == null && x.User != null
				select x).ToList<Product>();
			}
			CS$<>8__locals1.listNames = (from x in list
			select x.Name).Distinct<string>().ToArray<string>();
			double[] array = new double[CS$<>8__locals1.listNames.Length];
			int i2;
			for (i = 0; i < CS$<>8__locals1.listNames.Length; i = i2 + 1)
			{
				array[i] = (double)source.Count((Product x) => x.Name == CS$<>8__locals1.listNames[i]);
				string[] listNames = CS$<>8__locals1.listNames;
				int j = i;
				listNames[j] = listNames[j] + " - " + array[i];
				i2 = i;
			}
			return new ValueTuple<string[], double[]>(CS$<>8__locals1.listNames, array);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0002502C File Offset: 0x0002322C
		private void Draw(string[] s, double[] d)
		{
			this.chartStatistics.Series.Clear();
			this.chartStatistics.Titles.Clear();
			this.chartStatistics.BackColor = Color.Gray;
			this.chartStatistics.BorderlineDashStyle = ChartDashStyle.Solid;
			this.chartStatistics.BorderlineColor = Color.Gray;
			this.chartStatistics.ChartAreas[0].BackColor = Color.Wheat;
			this.chartStatistics.Titles.Add("Диаграмма");
			this.chartStatistics.Titles[0].Font = new Font("Utopia", 16f);
			this.chartStatistics.Series.Add(new Series("ColumnSeries")
			{
				ChartType = SeriesChartType.Pie
			});
			this.chartStatistics.Series["ColumnSeries"].Points.DataBindXY(s, new IEnumerable[]
			{
				d
			});
			this.chartStatistics.ChartAreas[0].Area3DStyle.Enable3D = true;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00025150 File Offset: 0x00023350
		private void bStatisticsPromoCodes_Click(object sender, EventArgs e)
		{
			Main.<>c__DisplayClass615_0 CS$<>8__locals1 = new Main.<>c__DisplayClass615_0();
			List<PromoCode> source;
			using (BotContext botContext = new BotContext())
			{
				source = botContext.PromoCodes.ToList<PromoCode>();
			}
			CS$<>8__locals1.listNames = (from x in source
			select x.Name).Distinct<string>().ToArray<string>();
			double[] array = new double[CS$<>8__locals1.listNames.Length];
			int i;
			int i2;
			for (i = 0; i < CS$<>8__locals1.listNames.Length; i = i2 + 1)
			{
				array[i] = (double)source.Count((PromoCode x) => x.Name == CS$<>8__locals1.listNames[i]);
				string[] listNames = CS$<>8__locals1.listNames;
				int j = i;
				listNames[j] = listNames[j] + " - " + array[i];
				i2 = i;
			}
			this.Draw(CS$<>8__locals1.listNames, array);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00025288 File Offset: 0x00023488
		private void bStatisticsCommon_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			using (BotContext botContext = new BotContext())
			{
				text = this.GetCommonStatistic(botContext);
			}
			MessageBox.Show(text, "Статистика");
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000252D8 File Offset: 0x000234D8
		private string GetCommonStatistic(BotContext context)
		{
			string result = string.Empty;
			try
			{
				List<TelegramBotBankStore.Domain.Transaction> list = (from x in context.Transactions
				where x.IsAddedToBalance
				select x).ToList<TelegramBotBankStore.Domain.Transaction>();
				List<Product> list2 = (from x in context.Products
				where x.Category == null && x.User != null
				select x).ToList<Product>();
				List<TelegramBotBankStore.Domain.Transaction> list3 = (from x in list
				where x.Din.Date == DateTime.Today
				select x).ToList<TelegramBotBankStore.Domain.Transaction>();
				List<Product> list4 = (from x in list2
				where this.IsOneDay(x.PurchaseDate.Value, DateTime.Today)
				select x).ToList<Product>();
				List<TelegramBotBankStore.Domain.Transaction> list5 = (from x in list
				where x.Din.Date == DateTime.Today.AddDays(-1.0)
				select x).ToList<TelegramBotBankStore.Domain.Transaction>();
				List<Product> list6 = (from x in list2
				where this.IsOneDay(x.PurchaseDate.Value, DateTime.Today.AddDays(-1.0))
				select x).ToList<Product>();
				List<TelegramBotBankStore.Domain.Transaction> list7 = (from x in list
				where Main.IsBewteenTwoDates(new DateTime?(x.Din), DateTime.Today.AddDays(-7.0), DateTime.Today)
				select x).ToList<TelegramBotBankStore.Domain.Transaction>();
				List<Product> list8 = (from x in list2
				where Main.IsBewteenTwoDates(x.PurchaseDate, DateTime.Today.AddDays(-7.0), DateTime.Today)
				select x).ToList<Product>();
				List<TelegramBotBankStore.Domain.Transaction> list9 = (from x in list
				where Main.IsBewteenTwoDates(new DateTime?(x.Din), DateTime.Today.AddDays(-30.0), DateTime.Today)
				select x).ToList<TelegramBotBankStore.Domain.Transaction>();
				List<Product> list10 = (from x in list2
				where Main.IsBewteenTwoDates(x.PurchaseDate, DateTime.Today.AddDays(-30.0), DateTime.Today)
				select x).ToList<Product>();
				result = string.Concat(new object[]
				{
					"\ud83d\udd50 Сегодня:\r\nКоличество транзакций: ",
					list3.Count<TelegramBotBankStore.Domain.Transaction>(),
					"\r\nОбщая сумма пополнений: ",
					this.GetAddSums(list3),
					"\r\nПроданно на сумму: ",
					this.GetPurcSums(list4),
					"\r\n\r\n\ud83d\udd50 Вчера:\r\nКоличество транзакций: ",
					list5.Count<TelegramBotBankStore.Domain.Transaction>(),
					"\r\nОбщая сумма пополнений: ",
					this.GetAddSums(list5),
					"\r\nПроданно на сумму: ",
					this.GetPurcSums(list6),
					"\r\n\r\n\ud83d\udcc6 За последние 7 дней:\r\nКоличество транзакций: ",
					list7.Count<TelegramBotBankStore.Domain.Transaction>(),
					"\r\nОбщая сумма пополнений: ",
					this.GetAddSums(list7),
					"\r\nПроданно на сумму: ",
					this.GetPurcSums(list8),
					"\r\n\r\n\ud83d\udcc6 За последние 30 дней:\r\nКоличество транзакций: ",
					list9.Count<TelegramBotBankStore.Domain.Transaction>(),
					"\r\nОбщая сумма пополнений: ",
					this.GetAddSums(list9),
					"\r\nПроданно на сумму: ",
					this.GetPurcSums(list10),
					"\r\n\r\n\ud83d\udcc6 За все время:\r\nКоличество транзакций: ",
					list.Count<TelegramBotBankStore.Domain.Transaction>(),
					"\r\nОбщая сумма пополнений: ",
					this.GetAddSums(list),
					"\r\nПроданно на сумму: ",
					this.GetPurcSums(list2)
				});
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
			return result;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00025690 File Offset: 0x00023890
		public static bool IsBewteenTwoDates(DateTime? dt, DateTime start, DateTime end)
		{
			bool flag = dt != null;
			return flag && dt >= start && dt <= end;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000256F0 File Offset: 0x000238F0
		private bool IsOneDay(DateTime first, DateTime second)
		{
			return first.Day == second.Day && first.Month == second.Month && first.Year == second.Year;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00025740 File Offset: 0x00023940
		private string GetPurcSums(List<Product> list)
		{
			string[] array = new string[8];
			array[0] = "BTC ";
			array[1] = (from x in list
			where x.Currency == PayCurrency.BTC
			select x).Sum((Product x) => x.PurchaseSumValue).ToString();
			array[2] = ", LTC ";
			array[3] = (from x in list
			where x.Currency == PayCurrency.LTC
			select x).Sum((Product x) => x.PurchaseSumValue).ToString();
			array[4] = ", RUB ";
			array[5] = Math.Round((from x in list
			where x.Currency == PayCurrency.RUB
			select x).Sum((Product x) => x.PurchaseSumValue)).ToString();
			array[6] = ", USD ";
			array[7] = Math.Round((from x in list
			where x.Currency == PayCurrency.USD
			select x).Sum((Product x) => x.PurchaseSumValue)).ToString();
			return string.Concat(array);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000258D8 File Offset: 0x00023AD8
		private string GetAddSums(List<TelegramBotBankStore.Domain.Transaction> list)
		{
			string[] array = new string[12];
			array[0] = "BTC ";
			array[1] = (from x in list
			where x.TransactionType == TransactionType.BTC
			select x).Sum((TelegramBotBankStore.Domain.Transaction x) => x.Sum).ToString();
			array[2] = ", LTC ";
			array[3] = (from x in list
			where x.TransactionType == TransactionType.LTC
			select x).Sum((TelegramBotBankStore.Domain.Transaction x) => x.Sum).ToString();
			array[4] = ", Qiwi ";
			array[5] = Math.Round((from x in list
			where x.TransactionType == TransactionType.Qiwi
			select x).Sum((TelegramBotBankStore.Domain.Transaction x) => x.Sum)).ToString();
			array[6] = ", Exmo ";
			array[7] = Math.Round((from x in list
			where x.TransactionType == TransactionType.Exmo
			select x).Sum((TelegramBotBankStore.Domain.Transaction x) => x.Sum)).ToString();
			array[8] = ", Yandex ";
			array[9] = Math.Round((from x in list
			where x.TransactionType == TransactionType.Yandex
			select x).Sum((TelegramBotBankStore.Domain.Transaction x) => x.Sum)).ToString();
			array[10] = ", Tele2 ";
			array[11] = Math.Round((from x in list
			where x.TransactionType == TransactionType.Tele2
			select x).Sum((TelegramBotBankStore.Domain.Transaction x) => x.Sum)).ToString();
			return string.Concat(array);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00025B38 File Offset: 0x00023D38
		private void bStatisticsCommonЗкщвгсе_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			using (BotContext botContext = new BotContext())
			{
				text = this.GetCommonStatisticProduct(botContext);
			}
			MessageBox.Show(text, "Статистика");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00025B88 File Offset: 0x00023D88
		private string GetCommonStatisticProduct(BotContext context)
		{
			string result = string.Empty;
			try
			{
				result = this.GetCommonCategories(context, true);
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00025BCC File Offset: 0x00023DCC
		private void bStatisticsCommonCategories_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			using (BotContext botContext = new BotContext())
			{
				text = this.GetCommonCategories(botContext, false);
			}
			MessageBox.Show(text, "Статистика");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00025C1C File Offset: 0x00023E1C
		private string GetCommonCategories(BotContext context, bool isForSold = false)
		{
			string text = string.Empty;
			bool flag = !isForSold;
			if (flag)
			{
				text = "\ud83d\udce6 <b>Наличие товаров по городам:</b>";
			}
			try
			{
				List<Category> list = (from x in context.Categories
				where x.Parent == null
				select x).ToList<Category>();
				foreach (Category category in list)
				{
					string empty = string.Empty;
					this.GetCommonCategoriesChild(context, category, 2, ref empty, isForSold);
					bool flag2 = !string.IsNullOrEmpty(empty);
					if (flag2)
					{
						text = text + "\r\n\r\n\ud83c\udfe1 " + category.Name;
						text += empty;
					}
				}
			}
			catch (Exception ex)
			{
				this.log.Error(ex.Message);
			}
			return text;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00025D54 File Offset: 0x00023F54
		private void GetCommonCategoriesChild(BotContext context, Category category, int space, ref string text, bool isForSold)
		{
			bool flag = category.Childs.Any<Category>();
			if (flag)
			{
				foreach (Category category2 in category.Childs)
				{
					string empty = string.Empty;
					this.GetCommonCategoriesChild(context, category2, space + 2, ref empty, isForSold);
					bool flag2 = !string.IsNullOrEmpty(empty);
					if (flag2)
					{
						text = text + "\r\n" + new string(' ', space) + category2.Name;
						text += empty;
					}
				}
			}
			else if (isForSold)
			{
				text += this.AddAmountSoldProductForDays(context, category, space);
			}
			else
			{
				text += this.AddAmountProduct(category, space);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00025E3C File Offset: 0x0002403C
		private string AddAmountProduct(Category category, int space)
		{
			string text = string.Empty;
			IEnumerable<Product> enumerable = from x in category.Products
			where x.PositionsCount > 0
			select x;
			bool flag = enumerable.Any<Product>();
			if (flag)
			{
				foreach (Product product in enumerable)
				{
					text = string.Concat(new object[]
					{
						text,
						"\r\n",
						new string(' ', space + 2),
						"\ud83d\udecd ",
						product.Name,
						": ",
						product.PositionsCount,
						", ",
						product.Price,
						" ",
						Main.CURRENCY_NAME_CURRENT
					});
				}
			}
			return text;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00025F48 File Offset: 0x00024148
		private string AddAmountSoldProductForDays(BotContext context, Category category, int space)
		{
			List<Product> listSaltedAll = (from x in context.Products
			where x.Category == null && x.User != null && x.HistoryCategoryId.HasValue && x.HistoryCategoryId.Value == category.Id && x.PurchaseDate.HasValue
			select x).ToList<Product>();
			return this.AddAmountSoldProductForDays(context, listSaltedAll, space + 2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000260D4 File Offset: 0x000242D4
		private string AddAmountSoldProductForDays(BotContext context, List<Product> listSaltedAll, int space)
		{
			string str = new string(' ', space) + "\ud83d\udd50 Сегодня:\r\n";
			List<Product> listSalted = (from x in listSaltedAll
			where this.IsOneDay(x.PurchaseDate.Value, DateTime.Today)
			select x).ToList<Product>();
			str += this.AddAmountSoldProduct(listSalted, space);
			str = str + "\r\n\r\n" + new string(' ', space) + "\ud83d\udd50 Вчера:\r\n";
			listSalted = (from x in listSaltedAll
			where this.IsOneDay(x.PurchaseDate.Value, DateTime.Today.AddDays(-1.0))
			select x).ToList<Product>();
			str += this.AddAmountSoldProduct(listSalted, space);
			str = str + "\r\n\r\n" + new string(' ', space) + "\ud83d\udcc6 За последние 7 дней:\r\n";
			listSalted = (from x in listSaltedAll
			where Main.IsBewteenTwoDates(new DateTime?(x.PurchaseDate.Value), DateTime.Today.AddDays(-7.0), DateTime.Today)
			select x).ToList<Product>();
			str += this.AddAmountSoldProduct(listSalted, space);
			str = str + "\r\n\r\n" + new string(' ', space) + "\ud83d\udcc6 За последние 30 дней:\r\n";
			listSalted = (from x in listSaltedAll
			where Main.IsBewteenTwoDates(new DateTime?(x.PurchaseDate.Value), DateTime.Today.AddDays(-30.0), DateTime.Today)
			select x).ToList<Product>();
			str += this.AddAmountSoldProduct(listSalted, space);
			str = str + "\r\n\r\n" + new string(' ', space) + "\ud83d\udcc6 За все время:\r\n";
			return str + this.AddAmountSoldProduct(listSaltedAll, space);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00026230 File Offset: 0x00024430
		private string AddAmountSoldProduct(List<Product> listSalted, int space)
		{
			string text = string.Empty;
			bool flag = listSalted != null && listSalted.Any<Product>();
			if (flag)
			{
				Main.<>c__DisplayClass630_0 CS$<>8__locals1 = new Main.<>c__DisplayClass630_0();
				CS$<>8__locals1.listNames = (from x in listSalted
				select x.Name).Distinct<string>().ToArray<string>();
				int i2;
				int i;
				for (i = 0; i < CS$<>8__locals1.listNames.Length; i = i2 + 1)
				{
					string[] listNames = CS$<>8__locals1.listNames;
					int k = i;
					listNames[k] = listNames[k] + " - " + listSalted.Count((Product x) => x.Name == CS$<>8__locals1.listNames[i]);
					i2 = i;
				}
				foreach (string str in CS$<>8__locals1.listNames)
				{
					text = text + "\r\n" + new string(' ', space + 2) + str;
				}
			}
			bool flag2 = text.StartsWith("\r\n");
			if (flag2)
			{
				text = text.Substring(2);
			}
			return text;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00026370 File Offset: 0x00024570
		private void bStatisticsCommonProduct_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			try
			{
				using (BotContext botContext = new BotContext())
				{
					text = this.GetCommonStatisticsProduct(botContext);
				}
			}
			catch (Exception ex)
			{
				text = ex.Message;
			}
			MessageBox.Show(text, "Статистика");
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000263DC File Offset: 0x000245DC
		private string GetCommonStatisticsProduct(BotContext context)
		{
			List<string> listExist = new List<string>();
			foreach (Category category in ((IEnumerable<Category>)context.Categories))
			{
				IEnumerable<string> enumerable = from i in category.Products
				where i.User == null
				select i into x
				select x.Name;
				bool flag = enumerable != null;
				if (flag)
				{
					listExist.AddRange(enumerable);
				}
			}
			List<Product> listSaltedAll = (from x in context.Products
			where x.Category == null && x.User != null && listExist.Contains(x.Name)
			select x).ToList<Product>();
			return this.AddAmountSoldProductForDays(context, listSaltedAll, 0);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000265A0 File Offset: 0x000247A0
		private void checkBoxIsAddButtonAvailable_CheckedChanged(object sender, EventArgs e)
		{
			this.tbTelegramPageName.Enabled = (this.tbTelegramPageText.Enabled = this.cbIsTelegramPageAvailable.Checked);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000265D4 File Offset: 0x000247D4
		private void OpenCurrentTelegramPage()
		{
			bool flag = this._currentSelectedTelegramPage != null;
			if (flag)
			{
				using (BotContext botContext = new BotContext())
				{
					TelegramPage telegramPage = botContext.TelegramPages.FirstOrDefault((TelegramPage x) => (long?)x.Id == this._currentSelectedTelegramPage);
					bool flag2 = telegramPage != null;
					if (flag2)
					{
						this.tbTelegramPageName.Text = telegramPage.Name;
						this.tbTelegramPageText.Text = telegramPage.Text;
						this.cbIsTelegramPageAvailable.Checked = telegramPage.IsAnabled;
						this.lbTelegramPagePicPath.Text = telegramPage.PathPhoto;
						bool flag3 = System.IO.File.Exists(telegramPage.PathPhoto);
						if (flag3)
						{
							this.pbTelegramPagePic.ImageLocation = telegramPage.PathPhoto;
						}
						else
						{
							this.pbTelegramPagePic.Image = null;
						}
						botContext.SaveChanges();
					}
				}
			}
			this.checkBoxIsAddButtonAvailable_CheckedChanged(null, null);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002B3C File Offset: 0x00000D3C
		private void bTelegramPageSave_Click(object sender, EventArgs e)
		{
			this.SaveCurrentTelegramPage();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00026738 File Offset: 0x00024938
		private void SaveCurrentTelegramPage()
		{
			bool flag = this._currentSelectedTelegramPage != null;
			if (flag)
			{
				using (BotContext botContext = new BotContext())
				{
					TelegramPage telegramPage = botContext.TelegramPages.FirstOrDefault((TelegramPage x) => (long?)x.Id == this._currentSelectedTelegramPage);
					bool flag2 = telegramPage != null;
					if (flag2)
					{
						telegramPage.Name = this.tbTelegramPageName.Text;
						telegramPage.Text = this.tbTelegramPageText.Text;
						telegramPage.IsAnabled = this.cbIsTelegramPageAvailable.Checked;
						telegramPage.PathPhoto = this.lbTelegramPagePicPath.Text;
						botContext.SaveChanges();
						this.groupBoxTelegramPage.Visible = false;
					}
				}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00026860 File Offset: 0x00024A60
		private void buttonSelectImageAddBut_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					bool flag2 = openFileDialog.OpenFile() != null;
					if (flag2)
					{
						this.lbTelegramPagePicPath.Text = openFileDialog.FileName;
						this.pbTelegramPagePic.Image = new Bitmap(this.lbTelegramPagePicPath.Text);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002B46 File Offset: 0x00000D46
		private void buttonDeleteImageAddBut_Click(object sender, EventArgs e)
		{
			this.pbTelegramPagePic.Image = null;
			this.lbTelegramPagePicPath.Text = "";
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000268F0 File Offset: 0x00024AF0
		private void bTelegramPagesAdd_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = string.IsNullOrEmpty(this.tbTelegramPagesNameToAdd.Text);
				if (flag)
				{
					throw new Exception("Необходимо ввести название.");
				}
				using (BotContext botContext = new BotContext())
				{
					TelegramPage telegramPage = null;
					bool flag2 = this.tvTelegramPages.SelectedNode != null;
					if (flag2)
					{
						long id = long.Parse(this.tvTelegramPages.SelectedNode.Tag.ToString());
						telegramPage = botContext.TelegramPages.FirstOrDefault((TelegramPage x) => x.Id == id);
					}
					TelegramPage telegramPage2 = new TelegramPage();
					telegramPage2.Parent = telegramPage;
					telegramPage2.Name = this.tbTelegramPagesNameToAdd.Text;
					bool flag3 = telegramPage != null;
					if (flag3)
					{
						telegramPage.Childs.Add(telegramPage2);
					}
					else
					{
						botContext.TelegramPages.Add(telegramPage2);
					}
					botContext.SaveChanges();
					this.refreshTelegramPages(botContext);
					this.tbTelegramPagesNameToAdd.Text = string.Empty;
					this.tvTelegramPages.SelectedNode = null;
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00026AAC File Offset: 0x00024CAC
		private void bTelegramPagesDelete_Click(object sender, EventArgs e)
		{
			bool flag = this._currentSelectedTelegramPage != null;
			if (flag)
			{
				try
				{
					using (BotContext botContext = new BotContext())
					{
						TelegramPage entity = botContext.TelegramPages.FirstOrDefault((TelegramPage x) => (long?)x.Id == this._currentSelectedTelegramPage);
						botContext.TelegramPages.Remove(entity);
						botContext.SaveChanges();
						this.refreshTelegramPages(botContext);
					}
				}
				catch (Exception ex)
				{
					this.updateStatus("", null, ex);
				}
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00026BB8 File Offset: 0x00024DB8
		private void tvTelegramPages_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this._currentSelectedTelegramPage = null;
			try
			{
				using (BotContext botContext = new BotContext())
				{
					this._currentSelectedTelegramPage = new long?(long.Parse(this.tvTelegramPages.SelectedNode.Tag.ToString()));
					TelegramPage telegramPage = botContext.TelegramPages.FirstOrDefault((TelegramPage x) => (long?)x.Id == this._currentSelectedTelegramPage);
					this.tbTelegramPagesNameToAdd.Text = telegramPage.Name;
					this.groupBoxTelegramPage.Visible = true;
					this.OpenCurrentTelegramPage();
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002B67 File Offset: 0x00000D67
		private void InitTelegramPagesTab(BotContext context)
		{
			this.groupBoxTelegramPage.Visible = false;
			this.refreshTelegramPages(context);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00026CE8 File Offset: 0x00024EE8
		private void refreshTelegramPages(BotContext context)
		{
			this.tvTelegramPages.Invoke(new MethodInvoker(delegate()
			{
				this.tvTelegramPages.Nodes.Clear();
				List<TelegramPage> list = (from x in context.TelegramPages
				where x.Parent == null
				select x).ToList<TelegramPage>();
				foreach (TelegramPage telegramPage in list)
				{
					TreeNode treeNode = new TreeNode();
					treeNode.Tag = telegramPage.Id;
					treeNode.Text = telegramPage.Name;
					this.addChildTelegramPage(telegramPage, treeNode);
					this.tvTelegramPages.Nodes.Add(treeNode);
				}
			}));
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00026D24 File Offset: 0x00024F24
		private void addChildTelegramPage(TelegramPage telegramPage, TreeNode parent)
		{
			try
			{
				bool flag = telegramPage.Childs.Any<TelegramPage>();
				if (flag)
				{
					foreach (TelegramPage telegramPage2 in telegramPage.Childs)
					{
						TreeNode treeNode = new TreeNode();
						treeNode.Tag = telegramPage2.Id;
						treeNode.Text = telegramPage2.Name;
						this.addChildTelegramPage(telegramPage2, treeNode);
						parent.Nodes.Add(treeNode);
					}
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00026DEC File Offset: 0x00024FEC
		private void InitBotUsers()
		{
			this._applicationUsers = new ApplicationUsers(this._logUsersActions);
			this.flatComboBoxUsers.Items.Clear();
			foreach (ApplicationUser applicationUser in this._applicationUsers.GetUsersList())
			{
				this.flatComboBoxUsers.Items.Add(applicationUser.Name);
			}
			this.UserUnLoging();
			bool flag = Key.Decrypt(Settings.Default.AUA) == this.SecureStringForAutoLogIn;
			if (flag)
			{
				bool flag2 = this._applicationUsers.UserAutorize("Admin", "AdminAdmin");
				if (flag2)
				{
					this.UserLogIn();
					this.flatTabControlMain.SelectedTab = this.tabPageMain;
				}
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00026ED8 File Offset: 0x000250D8
		public void LogUserAction(string action)
		{
			try
			{
				this._applicationUsers.LogUserAction(action);
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00026F1C File Offset: 0x0002511C
		private void FlatButton1_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.flatComboBoxUsers.SelectedItem.ToString());
			if (flag)
			{
				try
				{
					bool flag2 = this._applicationUsers.UserAutorize(this.flatComboBoxUsers.SelectedItem.ToString(), this.flatTextBoxUserPassword.Text);
					if (flag2)
					{
						this.flatTextBoxUserPassword.Text = "";
						this.UserLogIn();
					}
				}
				catch (Exception ex)
				{
					Main.ShowMessage(ex.Message, null);
				}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00026FB4 File Offset: 0x000251B4
		private void UserLogIn()
		{
			bool flag = this._applicationUsers.GetCurrentUser().IsInRole(UserPermission.Admin.ToString());
			if (flag)
			{
				this.flatButtonUsers.Visible = true;
			}
			this.flatButtonUserChangePassword.Visible = true;
			this.labelUserExit.Visible = true;
			this.flatComboBoxUsers.Visible = false;
			this.flatLabel18.Visible = false;
			this.flatLabel17.Visible = false;
			this.flatTextBoxUserPassword.Visible = false;
			this.flatButtonUserEnter.Visible = false;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00027050 File Offset: 0x00025250
		private void UserUnLoging()
		{
			this._applicationUsers.UnLogCurrentUser();
			this.flatButtonUsers.Visible = false;
			this.flatButtonUserChangePassword.Visible = false;
			this.labelUserExit.Visible = false;
			this.flatTabControlMain.SelectedTab = this.tabPageAutorization;
			this.flatComboBoxUsers.Visible = true;
			this.flatLabel18.Visible = true;
			this.flatLabel17.Visible = true;
			this.flatTextBoxUserPassword.Visible = true;
			this.flatButtonUserEnter.Visible = true;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000270E4 File Offset: 0x000252E4
		private void FlatTabControlMain_Selecting(object sender, TabControlCancelEventArgs e)
		{
			bool flag = this.flatTabControlMain.SelectedTab == this.tabPageSender || this.flatTabControlMain.SelectedTab == this.tabPageCategory || this.flatTabControlMain.SelectedTab == this.tabPagePolicy || this.flatTabControlMain.SelectedTab == this.tabPageStatistic || this.flatTabControlMain.SelectedTab == this.tabPageAutorization;
			if (flag)
			{
				bool flag2 = this._applicationUsers.GetCurrentUser() == null;
				if (flag2)
				{
					e.Cancel = true;
				}
			}
			else
			{
				bool flag3 = this._applicationUsers.GetCurrentUser() == null || !this._applicationUsers.GetCurrentUser().IsInRole(UserPermission.Admin.ToString());
				if (flag3)
				{
					e.Cancel = true;
				}
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002B7F File Offset: 0x00000D7F
		private void LabelUserExit_Click(object sender, EventArgs e)
		{
			this.UserUnLoging();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000271B8 File Offset: 0x000253B8
		private void FlatButtonUsers_Click(object sender, EventArgs e)
		{
			FormListUsers formListUsers = new FormListUsers(this._applicationUsers);
			formListUsers.ShowDialog();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000271DC File Offset: 0x000253DC
		private void FlatButtonUserChangePassword_Click(object sender, EventArgs e)
		{
			FormChangePassword formChangePassword = new FormChangePassword(this._applicationUsers);
			formChangePassword.ShowDialog();
		}

		// Token: 0x040000D4 RID: 212
		private readonly ILog log = LogManager.GetLogger(typeof(Main));

		// Token: 0x040000D5 RID: 213
		private string IMAGE_PATH = Directory.GetCurrentDirectory() + "\\Images\\";

		// Token: 0x040000D6 RID: 214
		private TelegramBotClient _botClient;

		// Token: 0x040000D7 RID: 215
		private Telegram.Bot.Types.User _botMeInformation;

		// Token: 0x040000D8 RID: 216
		private Info.Blockchain.API.Wallet.Wallet _walletBTC;

		// Token: 0x040000D9 RID: 217
		private ExmoApi _exmoApi;

		// Token: 0x040000DA RID: 218
		private Tele2Api _tele2Api;

		// Token: 0x040000DB RID: 219
		private Apirone _apironeAPIWallet;

		// Token: 0x040000DC RID: 220
		private bool _isApironeAvailable;

		// Token: 0x040000DD RID: 221
		private bool _apironeIsPayBTC;

		// Token: 0x040000DE RID: 222
		private bool _apironeIsPayLTC;

		// Token: 0x040000DF RID: 223
		private const string COMMAND_CATEGORY = "/category";

		// Token: 0x040000E0 RID: 224
		private const string COMMAND_BACK_MENU = "/backmenu";

		// Token: 0x040000E1 RID: 225
		private const string COMMAND_BACK = "/back";

		// Token: 0x040000E2 RID: 226
		private const string COMMAND_PRODUCT = "/product";

		// Token: 0x040000E3 RID: 227
		private const string COMMAND_LOAD = "/load";

		// Token: 0x040000E4 RID: 228
		private const string COMMAND_LOAD_EXMO = "/loadExmo";

		// Token: 0x040000E5 RID: 229
		private const string COMMAND_LOAD_QIWI = "/loadQiwi";

		// Token: 0x040000E6 RID: 230
		private const string COMMAND_LOAD_YANDEX = "/loadYandex";

		// Token: 0x040000E7 RID: 231
		private const string COMMAND_LOAD_LTC = "/loadLTC";

		// Token: 0x040000E8 RID: 232
		private const string COMMAND_LOAD_CARD = "/loadCard";

		// Token: 0x040000E9 RID: 233
		private const string COMMAND_LOAD_TELE2 = "/loadTele2";

		// Token: 0x040000EA RID: 234
		private const string COMMAND_HISTORY = "/history";

		// Token: 0x040000EB RID: 235
		private const string COMMAND_BUY = "/buy";

		// Token: 0x040000EC RID: 236
		private const string COMMAND_REFUND = "/refund";

		// Token: 0x040000ED RID: 237
		private const string COMMAND_PAY_CURRENCY = "/payCurrency";

		// Token: 0x040000EE RID: 238
		private const string COMMAND_BUY_AMOUNT = "/buyAmount";

		// Token: 0x040000EF RID: 239
		private const string COMMAND_CHANGE_LANGUAGE = "/ChangeLanguage";

		// Token: 0x040000F0 RID: 240
		private const string COMMAND_REVIEW = "/Review";

		// Token: 0x040000F1 RID: 241
		private const string COMMAND_I_PAID = "/IPaid";

		// Token: 0x040000F2 RID: 242
		private const string COMMAND_PAY_METHOD = "/payMethod";

		// Token: 0x040000F3 RID: 243
		private const string COMMAND_PAY2_AND_RESERVE = "/payAndReserve";

		// Token: 0x040000F4 RID: 244
		private const string COMMAND_NOTFOUND = "/notFound";

		// Token: 0x040000F5 RID: 245
		private const string COMMAND_СONVERT_ALL_TO = "/ConvertAllTo";

		// Token: 0x040000F6 RID: 246
		private const string COMMAND_SEND_MONEY = "/SendMoney";

		// Token: 0x040000F7 RID: 247
		private const string COMMAND_RECEIVE_MONEY = "/ReceiveMoney";

		// Token: 0x040000F8 RID: 248
		private const string COMMAND_ADD_CATEGORY = "/addcategory";

		// Token: 0x040000F9 RID: 249
		private const string COMMAND_SHOW_CATEGORY = "/showcategory";

		// Token: 0x040000FA RID: 250
		private const string COMMAND_EDIT_CATEGORY = "/editcategory";

		// Token: 0x040000FB RID: 251
		private const string COMMAND_DELETE_CATEGORY = "/deletecategory";

		// Token: 0x040000FC RID: 252
		private const string COMMAND_ADD_PRODUCT = "/addproduct";

		// Token: 0x040000FD RID: 253
		private const string COMMAND_EDIT_PRODUCT = "/editproduct";

		// Token: 0x040000FE RID: 254
		private const string COMMAND_DELETE_PRODUCT = "/deleteproduct";

		// Token: 0x040000FF RID: 255
		private const string COMMAND_SHOW_PRODUCT = "/showproduct";

		// Token: 0x04000100 RID: 256
		private const string COMMAND_SINGLE_POSITION = "/singleposition";

		// Token: 0x04000101 RID: 257
		private const string COMMAND_MULTIPLE_POSITION = "/multipleposition";

		// Token: 0x04000102 RID: 258
		private const string COMMAND_TAKEOFF = "/takeoff";

		// Token: 0x04000103 RID: 259
		private const string COMMAND_ADD_POSITION = "/addposition";

		// Token: 0x04000105 RID: 261
		private static string CURRENCY_NAME_CURRENT;

		// Token: 0x04000106 RID: 262
		private static string CURRENCY_NAME_RUB = "руб.";

		// Token: 0x04000107 RID: 263
		private static string CURRENCY_NAME_USD = "usd";

		// Token: 0x04000108 RID: 264
		private decimal BALANCE_BTC;

		// Token: 0x04000109 RID: 265
		private decimal BTC_RATE;

		// Token: 0x0400010A RID: 266
		private decimal LTC_RATE;

		// Token: 0x0400010B RID: 267
		private decimal RUB_RATE;

		// Token: 0x0400010C RID: 268
		private long? selectedUserId;

		// Token: 0x0400010D RID: 269
		private long? selectedPolicyId;

		// Token: 0x0400010E RID: 270
		private bool isCanceled = true;

		// Token: 0x0400010F RID: 271
		private int countCheck;

		// Token: 0x04000110 RID: 272
		private int countLog = 0;

		// Token: 0x04000111 RID: 273
		private static HashSet<long> transactionSet = new HashSet<long>();

		// Token: 0x0400023C RID: 572
		private int _qiwiCurrentNumber = 0;

		// Token: 0x0400023D RID: 573
		private int countInnerCall = 0;

		// Token: 0x0400023E RID: 574
		public Dictionary<int, MyQiwi> MyQiwiList;

		// Token: 0x0400023F RID: 575
		private long? _currentSelectedTelegramPage;

		// Token: 0x04000240 RID: 576
		private readonly string SecureStringForAutoLogIn = "true";

		// Token: 0x04000241 RID: 577
		private readonly ILog _logUsersActions = LogManager.GetLogger("LogUsersAction");

		// Token: 0x04000242 RID: 578
		private ApplicationUsers _applicationUsers;
	}
}
