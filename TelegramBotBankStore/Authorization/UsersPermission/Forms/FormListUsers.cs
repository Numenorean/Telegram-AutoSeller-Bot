using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Authorization.Logic.DbContext;
using Authorization.LogicUsersPermission;

namespace Authorization.UsersPermission.Forms
{
	// Token: 0x02000004 RID: 4
	public partial class FormListUsers : Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000209F File Offset: 0x0000029F
		public FormListUsers(ApplicationUsers applicationUsers)
		{
			this.InitializeComponent();
			this._applicationUsers = applicationUsers;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004E00 File Offset: 0x00003000
		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			AddUser addUser = new AddUser(this._applicationUsers, null);
			addUser.ShowDialog();
			this.InitList();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004E2C File Offset: 0x0000302C
		private void ButtonModifyUser_Click(object sender, EventArgs e)
		{
			bool flag = this.listBoxUsers.SelectedItem != null;
			if (flag)
			{
				AddUser addUser = new AddUser(this._applicationUsers, this.listBoxUsers.SelectedItem.ToString());
				addUser.ShowDialog();
				this.InitList();
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004E78 File Offset: 0x00003078
		private void ButtonDeleteUser_Click(object sender, EventArgs e)
		{
			bool flag = this.listBoxUsers.SelectedItem != null;
			if (flag)
			{
				this._applicationUsers.DeleteUser(this.listBoxUsers.SelectedItem.ToString());
				this.InitList();
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020BE File Offset: 0x000002BE
		private void FormListUsers_Load(object sender, EventArgs e)
		{
			this.InitList();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004EC0 File Offset: 0x000030C0
		private void InitList()
		{
			this.listBoxUsers.Items.Clear();
			List<ApplicationUser> usersList = this._applicationUsers.GetUsersList();
			foreach (ApplicationUser applicationUser in usersList)
			{
				this.listBoxUsers.Items.Add(applicationUser.Name);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002076 File Offset: 0x00000276
		private void ButtonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x04000019 RID: 25
		private ApplicationUsers _applicationUsers;
	}
}
