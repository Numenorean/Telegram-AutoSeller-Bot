namespace Authorization.UsersPermission.Forms
{
	// Token: 0x02000004 RID: 4
	public partial class FormListUsers : global::System.Windows.Forms.Form
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00004F40 File Offset: 0x00003140
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004F78 File Offset: 0x00003178
		private void InitializeComponent()
		{
			this.listBoxUsers = new global::System.Windows.Forms.ListBox();
			this.buttonAdd = new global::System.Windows.Forms.Button();
			this.buttonModifyUser = new global::System.Windows.Forms.Button();
			this.buttonDeleteUser = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.listBoxUsers.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listBoxUsers.FormattingEnabled = true;
			this.listBoxUsers.ItemHeight = 16;
			this.listBoxUsers.Location = new global::System.Drawing.Point(12, 12);
			this.listBoxUsers.Name = "listBoxUsers";
			this.listBoxUsers.Size = new global::System.Drawing.Size(644, 356);
			this.listBoxUsers.TabIndex = 0;
			this.buttonAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonAdd.BackColor = global::System.Drawing.Color.White;
			this.buttonAdd.Location = new global::System.Drawing.Point(662, 12);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new global::System.Drawing.Size(142, 39);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Добавить юзера";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new global::System.EventHandler(this.ButtonAdd_Click);
			this.buttonModifyUser.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonModifyUser.BackColor = global::System.Drawing.Color.White;
			this.buttonModifyUser.Location = new global::System.Drawing.Point(662, 57);
			this.buttonModifyUser.Name = "buttonModifyUser";
			this.buttonModifyUser.Size = new global::System.Drawing.Size(142, 39);
			this.buttonModifyUser.TabIndex = 2;
			this.buttonModifyUser.Text = "Изменить юзера";
			this.buttonModifyUser.UseVisualStyleBackColor = false;
			this.buttonModifyUser.Click += new global::System.EventHandler(this.ButtonModifyUser_Click);
			this.buttonDeleteUser.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonDeleteUser.BackColor = global::System.Drawing.Color.White;
			this.buttonDeleteUser.Location = new global::System.Drawing.Point(662, 102);
			this.buttonDeleteUser.Name = "buttonDeleteUser";
			this.buttonDeleteUser.Size = new global::System.Drawing.Size(142, 39);
			this.buttonDeleteUser.TabIndex = 3;
			this.buttonDeleteUser.Text = "Удалить юзера";
			this.buttonDeleteUser.UseVisualStyleBackColor = false;
			this.buttonDeleteUser.Click += new global::System.EventHandler(this.ButtonDeleteUser_Click);
			this.buttonClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonClose.BackColor = global::System.Drawing.Color.White;
			this.buttonClose.Location = new global::System.Drawing.Point(662, 398);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(142, 39);
			this.buttonClose.TabIndex = 4;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.ButtonClose_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(120f, 120f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(812, 445);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonDeleteUser);
			base.Controls.Add(this.buttonModifyUser);
			base.Controls.Add(this.buttonAdd);
			base.Controls.Add(this.listBoxUsers);
			base.Name = "FormListUsers";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Список юзеров";
			base.TransparencyKey = global::System.Drawing.SystemColors.WindowFrame;
			base.Load += new global::System.EventHandler(this.FormListUsers_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ListBox listBoxUsers;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button buttonAdd;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button buttonModifyUser;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button buttonDeleteUser;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button buttonClose;
	}
}
