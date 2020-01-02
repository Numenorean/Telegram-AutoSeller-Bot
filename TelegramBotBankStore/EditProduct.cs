using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Authorization.Logic;
using Authorization.Logic.DbContext;
using CommonWrapper;
using FlatUI;
using TelegramBotBankStore.Domain;
using TelegramBotBankStore.Domain.DbContext;

namespace TelegramBotBankStore
{
	// Token: 0x02000010 RID: 16
	public partial class EditProduct : Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000021E5 File Offset: 0x000003E5
		public EditProduct(long categoryId, long? productId)
		{
			this.InitializeComponent();
			this.categoryId = categoryId;
			this.productId = productId;
			ControlExtensions.Panel_СenterButtons(this.panelButtons, this.flatButtonCancel, this.flatButtonSave);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000921C File Offset: 0x0000741C
		private void EditProduct_Load(object sender, EventArgs e)
		{
			try
			{
				using (BotContext botContext = new BotContext())
				{
					Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == this.categoryId);
					this.flatLabelCategory.Text = Singleton.Main.GetFullCategoryName(category);
					bool flag = this.productId != null;
					if (flag)
					{
						Product product = category.Products.FirstOrDefault((Product x) => x.Id == this.productId.Value);
						this.flatTextBoxName.Text = product.Name;
						this.flatNumericPrice.Value = Math.Round(product.Price);
						bool flag2 = ((ApplicationUser)Thread.CurrentPrincipal).IsInRole(UserPermission.Admin.ToString());
						if (flag2)
						{
							this.flatTextBoxPositions.Text = product.Positions;
							this.notVisiblePosition = null;
						}
						else
						{
							this.notVisiblePosition = product.Positions;
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
				base.Close();
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000093C8 File Offset: 0x000075C8
		private void flatButtonSave_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = string.IsNullOrEmpty(this.flatTextBoxName.Text);
				if (flag)
				{
					throw new Exception("Необходимо ввести название");
				}
				bool flag2 = this.flatNumericPrice.Value == 0m;
				if (flag2)
				{
					throw new Exception("Необходимо ввести цену");
				}
				using (BotContext botContext = new BotContext())
				{
					Category category = botContext.Categories.FirstOrDefault((Category x) => x.Id == this.categoryId);
					Product product = (this.productId != null) ? category.Products.FirstOrDefault((Product x) => x.Id == this.productId.Value) : category.Products.FirstOrDefault((Product x) => x.Name == this.flatTextBoxName.Text);
					bool flag3 = this.productId != null;
					if (flag3)
					{
						bool flag4 = product != null && category.Products.Any((Product x) => x.Name == this.flatTextBoxName.Text && x.Id != product.Id);
						if (flag4)
						{
							throw new Exception("Товар с таким названием уже есть");
						}
					}
					else
					{
						bool flag5 = category.Products.Any((Product x) => x.Name == this.flatTextBoxName.Text);
						if (flag5)
						{
							throw new Exception("Товар с таким названием уже есть");
						}
						product = new Product();
						product.Category = category;
					}
					product.Name = this.flatTextBoxName.Text;
					product.Price = this.flatNumericPrice.Value;
					bool flag6 = false;
					bool @checked = this.flatToggle1.Checked;
					if (@checked)
					{
						Product product2 = product;
						product2.Positions = product2.Positions + "\r\n" + this.flatTextBoxPositions.Text.Replace("\r\n", "\n");
					}
					else
					{
						bool flag7 = this.notVisiblePosition == null;
						if (flag7)
						{
							bool flag8 = product.Positions != this.flatTextBoxPositions.Text;
							if (flag8)
							{
								product.Positions = this.flatTextBoxPositions.Text.Replace("\\n", "\n");
								flag6 = true;
							}
						}
						else
						{
							bool flag9 = product.Positions != this.notVisiblePosition + this.flatTextBoxPositions.Text.Trim();
							if (flag9)
							{
								Singleton.Main.LogUserAction("User added position: \r\n" + this.flatTextBoxPositions.Text.Trim());
								product.Positions = this.notVisiblePosition + "\r\n" + this.flatTextBoxPositions.Text.Replace("\\n", "\n").Trim();
								flag6 = true;
							}
						}
					}
					bool flag10 = product.Id == 0L;
					if (flag10)
					{
						flag6 = true;
						category.Products.Add(product);
					}
					botContext.SaveChanges();
					Singleton.Main.RefreshProducts(category.Products.ToList<Product>());
					bool flag11 = flag6;
					if (flag11)
					{
						Singleton.Main.SendNotificationNewPositions(product.Id);
					}
					base.Close();
				}
			}
			catch (Exception ex)
			{
				this.updateStatus("", null, ex);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002076 File Offset: 0x00000276
		private void flatButtonCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000097BC File Offset: 0x000079BC
		private void updateStatus(string text = "", int? progressBarValue = null, Exception ex = null)
		{
			this.flatStatusBarMain.Invoke(new MethodInvoker(delegate()
			{
				this.flatStatusBarMain.MyTextColor = ((ex != null) ? Brushes.LightPink : Brushes.White);
				this.flatStatusBarMain.Text = ((ex != null) ? ex.Message : text);
			}));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00009800 File Offset: 0x00007A00
		private void flatToggle1_CheckedChanged(object sender)
		{
			bool @checked = this.flatToggle1.Checked;
			if (@checked)
			{
				this.flatTextBoxPositions.Text = "";
			}
			else
			{
				this.EditProduct_Load(null, null);
			}
		}

		// Token: 0x04000061 RID: 97
		private long categoryId;

		// Token: 0x04000062 RID: 98
		private long? productId;

		// Token: 0x04000063 RID: 99
		private string notVisiblePosition;
	}
}
