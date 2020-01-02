using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Authorization.LogicUsersPermission;

namespace Authorization.UsersPermission.Forms
{
	// Token: 0x02000003 RID: 3
	public partial class FormChangePassword : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002080 File Offset: 0x00000280
		public FormChangePassword(ApplicationUsers applicationUsers)
		{
			this.InitializeComponent();
			this._applicationUsers = applicationUsers;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002076 File Offset: 0x00000276
		private void Button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00004814 File Offset: 0x00002A14
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this._applicationUsers.ChangrePassword(this._applicationUsers.GetCurrentUser().Name, this.textBoxOld.Text, this.textBoxUserPassword.Text, this.textBoxUserPassword2.Text);
				base.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0400000F RID: 15
		private ApplicationUsers _applicationUsers;
	}
}
