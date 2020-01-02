using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FlatUI;

namespace TelegramBotBankStore
{
	// Token: 0x0200000E RID: 14
	public partial class FormMessage : Form
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00008268 File Offset: 0x00006468
		public string GetMessage
		{
			get
			{
				return this.flatTextBoMessage.Text;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00008288 File Offset: 0x00006488
		public FormMessage(string messsage, string capture = null)
		{
			this.InitializeComponent();
			this.message = messsage;
			bool flag = capture != null;
			if (flag)
			{
				this.formSkin1.Text = capture;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002167 File Offset: 0x00000367
		private void FormMessage_Load(object sender, EventArgs e)
		{
			this.flatTextBoMessage.Text = this.message;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000217C File Offset: 0x0000037C
		private void FlatButton1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002076 File Offset: 0x00000276
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x04000052 RID: 82
		private string message;
	}
}
