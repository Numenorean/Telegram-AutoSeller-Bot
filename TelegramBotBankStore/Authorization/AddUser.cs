using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Authorization.Logic;
using Authorization.Logic.DbContext;
using Authorization.LogicUsersPermission;

namespace Authorization
{
	// Token: 0x02000002 RID: 2
	public partial class AddUser : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AddUser(ApplicationUsers applicationUsers, string userName = null)
		{
			this.InitializeComponent();
			this._applicationUsers = applicationUsers;
			this._userName = userName;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00003F3C File Offset: 0x0000213C
		private void AddUser_Load(object sender, EventArgs e)
		{
			foreach (string item in this._applicationUsers.GetPermissionsDescription())
			{
				this.checkedListBoxRules.Items.Add(item);
			}
			bool flag = !string.IsNullOrEmpty(this._userName);
			if (flag)
			{
				this._user = this._applicationUsers.GetUser(this._userName);
				bool flag2 = this._user != null;
				if (flag2)
				{
					this.Text = "Modify user";
					this.textBoxUserName.Text = this._user.Name;
					this.textBoxUserName.Enabled = false;
					this.button1.Text = "Изменить";
					foreach (UserPermissionDb userPermissionDb in this._user.Permissions)
					{
						for (int i = 0; i < this.checkedListBoxRules.Items.Count; i++)
						{
							bool flag3 = this.checkedListBoxRules.Items[i].ToString() == userPermissionDb.Description;
							if (flag3)
							{
								this.checkedListBoxRules.SetItemChecked(i, true);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000040CC File Offset: 0x000022CC
		private void Button1_Click(object sender, EventArgs e)
		{
			List<UserPermission> list = new List<UserPermission>();
			bool flag = this.checkedListBoxRules.CheckedItems.Count != 0;
			if (flag)
			{
				for (int i = 0; i < this.checkedListBoxRules.CheckedItems.Count; i++)
				{
					string description = this.checkedListBoxRules.CheckedItems[i].ToString();
					list.Add(this._applicationUsers.GetPermissionByDescription(description));
				}
			}
			bool flag2 = this._user == null;
			if (flag2)
			{
				this._applicationUsers.AddUser(this.textBoxUserName.Text, this.textBoxUserPassword.Text, this.textBoxUserPassword2.Text, list.ToArray());
			}
			else
			{
				this._applicationUsers.ModifyUser(this._user.Id, list.ToArray());
			}
			base.Close();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002076 File Offset: 0x00000276
		private void ButtonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x04000001 RID: 1
		private ApplicationUsers _applicationUsers;

		// Token: 0x04000002 RID: 2
		private string _userName;

		// Token: 0x04000003 RID: 3
		private ApplicationUser _user;
	}
}
