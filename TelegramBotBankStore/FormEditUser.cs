using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FlatUI;
using TelegramBotBankStore.Domain;
using TelegramBotBankStore.Domain.DbContext;
using TelegramBotBankStore.Properties;

namespace TelegramBotBankStore
{
	// Token: 0x0200000D RID: 13
	public partial class FormEditUser : Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00006018 File Offset: 0x00004218
		public FormEditUser(BotContext context, User user)
		{
			this.InitializeComponent();
			this.Context = context;
			this.User = user;
			this.formSkin1.Text = "Юзер: " + user.GetFullName();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006068 File Offset: 0x00004268
		private void FormEditUser_Load(object sender, EventArgs e)
		{
			this.textBoxBTC.Text = this.User.BalanceBTC.ToString();
			this.textBoxRUB.Text = this.User.BalanceRUB.ToString();
			this.textBoxLTC.Text = this.User.BalanceLTC.ToString();
			this.flatTextBoxBTCAddress.Text = this.User.WalletBTC;
			this.flatTextBoxRubComment.Text = this.User.Comment;
			this.flatTextBoxLTCAddress.Text = this.User.WalletLTC;
			this.flatToggleBan.Checked = this.User.IsBanned;
			this.flatToggleSapport.Checked = this.User.IsSupport;
			this.lbCurrency.Text = Main.CURRENCY_BOT_CURRENT.ToString() + ":";
			bool isNotFoundAvailable = Settings.Default.IsNotFoundAvailable;
			if (isNotFoundAvailable)
			{
				this.flatLabel8.Visible = true;
				this.flatNumeric1.Visible = true;
				this.flatLabel9.Visible = true;
				this.lbNotFoundStatistics.Visible = true;
				this.flatNumeric1.Value = this.User.NotFoundAmount;
				this.lbNotFoundStatistics.Text = this.User.NotFoundStatistic + "%";
			}
			try
			{
				foreach (UserWalletHistory userWalletHistory in this.User.WalletHistories)
				{
					FlatTextBox flatTextBox = this.tbAddressHistory;
					flatTextBox.Text = string.Concat(new string[]
					{
						flatTextBox.Text,
						userWalletHistory.HistoryType.ToString(),
						"-",
						userWalletHistory.Address,
						"\r\n"
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка вывода истории. " + ex.Message);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000062C0 File Offset: 0x000044C0
		private void FlatButton2_Click(object sender, EventArgs e)
		{
			try
			{
				decimal num = decimal.Parse(this.textBoxBTC.Text);
				decimal num2 = decimal.Parse(this.textBoxRUB.Text);
				decimal num3 = decimal.Parse(this.textBoxLTC.Text);
				bool flag = num != this.User.BalanceBTC;
				if (flag)
				{
					bool flag2 = !string.IsNullOrEmpty(this.flatTextBoxBTCAddress.Text);
					if (flag2)
					{
						DialogResult dialogResult = MessageBox.Show("Для безопасти, при изминении баланса BTC юзера лучше удалить его адресс пополнения. Удалить?", "Внимение", MessageBoxButtons.YesNo);
						bool flag3 = dialogResult == DialogResult.Yes;
						if (flag3)
						{
							this.flatTextBoxBTCAddress.Text = "";
						}
						else
						{
							bool flag4 = dialogResult == DialogResult.No;
							if (flag4)
							{
							}
						}
					}
					decimal sum = num - this.User.BalanceBTC;
					Singleton.Main.UpdateReferal(this.Context, this.User, PayCurrency.BTC, sum);
					this.User.BalanceBTC = num;
					Transaction transaction = new Transaction();
					transaction.TransactionType = TransactionType.BTC;
					transaction.User = this.User;
					transaction.Address = "By Admin";
					transaction.Sum = sum;
					transaction.IsAddedToBalance = true;
					this.User.Transactions.Add(transaction);
				}
				bool flag5 = num2 != this.User.BalanceRUB;
				if (flag5)
				{
					bool flag6 = !string.IsNullOrEmpty(this.flatTextBoxRubComment.Text);
					if (flag6)
					{
						DialogResult dialogResult2 = MessageBox.Show("Для безопасти, при изминении баланса RUB юзера лучше удалить его адресс пополнения. Удалить?", "Внимение", MessageBoxButtons.YesNo);
						bool flag7 = dialogResult2 == DialogResult.Yes;
						if (flag7)
						{
							this.flatTextBoxRubComment.Text = "";
						}
					}
					decimal sum2 = num2 - this.User.BalanceRUB;
					Singleton.Main.UpdateReferal(this.Context, this.User, PayCurrency.RUB, sum2);
					this.User.BalanceRUB = num2;
					Transaction transaction2 = new Transaction();
					transaction2.TransactionType = TransactionType.Qiwi;
					transaction2.User = this.User;
					transaction2.Address = "By Admin";
					transaction2.Sum = sum2;
					transaction2.IsAddedToBalance = true;
					this.User.Transactions.Add(transaction2);
				}
				bool flag8 = num3 != this.User.BalanceLTC;
				if (flag8)
				{
					bool flag9 = !string.IsNullOrEmpty(this.flatTextBoxLTCAddress.Text);
					if (flag9)
					{
						DialogResult dialogResult3 = MessageBox.Show("Для безопасти, при изминении баланса LTC юзера лучше удалить его адресс пополнения. Удалить?", "Внимение", MessageBoxButtons.YesNo);
						bool flag10 = dialogResult3 == DialogResult.Yes;
						if (flag10)
						{
							this.flatTextBoxLTCAddress.Text = "";
						}
					}
					decimal sum3 = num3 - this.User.BalanceLTC;
					Singleton.Main.UpdateReferal(this.Context, this.User, PayCurrency.LTC, sum3);
					this.User.BalanceLTC = num3;
					Transaction transaction3 = new Transaction();
					transaction3.TransactionType = TransactionType.LTC;
					transaction3.User = this.User;
					transaction3.Address = "By Admin";
					transaction3.Sum = sum3;
					transaction3.IsAddedToBalance = true;
					this.User.Transactions.Add(transaction3);
				}
				this.User.WalletBTC = this.flatTextBoxBTCAddress.Text;
				this.User.Comment = this.flatTextBoxRubComment.Text;
				this.User.WalletLTC = this.flatTextBoxLTCAddress.Text;
				this.User.IsBanned = this.flatToggleBan.Checked;
				this.User.IsSupport = this.flatToggleSapport.Checked;
				this.Context.SaveChanges();
				base.Close();
			}
			catch (Exception ex)
			{
				Main.ShowMessage(ex.Message, null);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002076 File Offset: 0x00000276
		private void FlatButton1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000066A0 File Offset: 0x000048A0
		private void flatTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.tbAddressHistory.Text = "";
				ICollection<UserWalletHistory> collection = this.User.WalletHistories;
				bool flag = !string.IsNullOrWhiteSpace(this.flatTextBox1.Text);
				if (flag)
				{
					collection = (from x in this.User.WalletHistories
					where x.Address.Contains(this.flatTextBox1.Text)
					select x).ToList<UserWalletHistory>();
				}
				foreach (UserWalletHistory userWalletHistory in collection)
				{
					FlatTextBox flatTextBox = this.tbAddressHistory;
					flatTextBox.Text = string.Concat(new string[]
					{
						flatTextBox.Text,
						userWalletHistory.HistoryType.ToString(),
						"-",
						userWalletHistory.Address,
						"\r\n"
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка вывода истории. " + ex.Message);
			}
		}

		// Token: 0x04000035 RID: 53
		private BotContext Context;

		// Token: 0x04000036 RID: 54
		private User User;
	}
}
