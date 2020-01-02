using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FlatUI;
using TelegramBotBankStore.Properties;

namespace TelegramBotBankStore
{
	// Token: 0x0200000F RID: 15
	public partial class AuthorizationDialog : Form
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000218E File Offset: 0x0000038E
		public AuthorizationDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021A6 File Offset: 0x000003A6
		private void AuthorizationDialog_Load(object sender, EventArgs e)
		{
			this.flatTextBoxID.Text = Key.GetUniqueID();
			Clipboard.SetText(this.flatTextBoxID.Text);
			this.flatLabel3.Text = "Скопировано";
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00008824 File Offset: 0x00006A24
		private void FlatButton2_Click(object sender, EventArgs e)
		{
			Settings.Default.Key = this.flatTextBoxKey.Text;
			Settings.Default.Save();
			bool flag = !Key.CheckKey(this.flatTextBoxKey.Text);
			if (flag)
			{
				MessageBox.Show("Неверный ключ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021DC File Offset: 0x000003DC
		private void FlatButton1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00008888 File Offset: 0x00006A88
		private void FlatTextBoxID_MouseClick(object sender, MouseEventArgs e)
		{
			Clipboard.SetText(this.flatTextBoxID.Text);
			new ToolTip
			{
				ForeColor = Color.White
			}.Show("Ключ скопирован", this.flatTextBoxID, 2000);
		}
	}
}
