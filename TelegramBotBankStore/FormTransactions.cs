using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FlatUI;
using TelegramBotBankStore.Domain;
using TelegramBotBankStore.Domain.DbContext;

namespace TelegramBotBankStore
{
	// Token: 0x0200001A RID: 26
	public partial class FormTransactions : Form
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000022DD File Offset: 0x000004DD
		public FormTransactions(BotContext context)
		{
			this.InitializeComponent();
			this._context = context;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000B180 File Offset: 0x00009380
		private void FormTransactions_Load(object sender, EventArgs e)
		{
			try
			{
				IQueryable<Transaction> queryable = from x in this._context.Transactions
				where (int)x.TransactionType == 1
				select x;
				foreach (Transaction transaction in queryable)
				{
					this.lbText.Items.Add(string.Concat(new object[]
					{
						transaction.Address,
						" на ",
						Math.Round(transaction.Sum, 8),
						" от ",
						transaction.User.GetFullName()
					}));
				}
			}
			catch (Exception ex)
			{
				this.lbText.Items.Add(ex.Message);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002076 File Offset: 0x00000276
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040000A1 RID: 161
		private BotContext _context;
	}
}
