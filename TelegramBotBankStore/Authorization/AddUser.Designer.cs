namespace Authorization
{
	// Token: 0x02000002 RID: 2
	public partial class AddUser : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000041B4 File Offset: 0x000023B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000041EC File Offset: 0x000023EC
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.checkedListBoxRules = new global::System.Windows.Forms.CheckedListBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBoxUserName = new global::System.Windows.Forms.TextBox();
			this.textBoxUserPassword = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBoxUserPassword2 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.buttonClose = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(35, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пароль";
			this.checkedListBoxRules.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.checkedListBoxRules.FormattingEnabled = true;
			this.checkedListBoxRules.Location = new global::System.Drawing.Point(12, 142);
			this.checkedListBoxRules.Name = "checkedListBoxRules";
			this.checkedListBoxRules.Size = new global::System.Drawing.Size(406, 208);
			this.checkedListBoxRules.TabIndex = 2;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(9, 122);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(91, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Разрешения";
			this.textBoxUserName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxUserName.Location = new global::System.Drawing.Point(84, 6);
			this.textBoxUserName.Name = "textBoxUserName";
			this.textBoxUserName.Size = new global::System.Drawing.Size(334, 22);
			this.textBoxUserName.TabIndex = 4;
			this.textBoxUserPassword.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxUserPassword.Location = new global::System.Drawing.Point(84, 42);
			this.textBoxUserPassword.Name = "textBoxUserPassword";
			this.textBoxUserPassword.Size = new global::System.Drawing.Size(334, 22);
			this.textBoxUserPassword.TabIndex = 5;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.BackColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(276, 356);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(142, 39);
			this.button1.TabIndex = 6;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.textBoxUserPassword2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxUserPassword2.Location = new global::System.Drawing.Point(164, 80);
			this.textBoxUserPassword2.Name = "textBoxUserPassword2";
			this.textBoxUserPassword2.Size = new global::System.Drawing.Size(254, 22);
			this.textBoxUserPassword2.TabIndex = 8;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(12, 83);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(146, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Подтвердите пароль";
			this.buttonClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonClose.BackColor = global::System.Drawing.Color.White;
			this.buttonClose.Location = new global::System.Drawing.Point(128, 356);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(142, 39);
			this.buttonClose.TabIndex = 9;
			this.buttonClose.Text = "Отменить";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.ButtonClose_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(120f, 120f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(427, 400);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.textBoxUserPassword2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBoxUserPassword);
			base.Controls.Add(this.textBoxUserName);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.checkedListBoxRules);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Name = "AddUser";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Создать юзера";
			base.TransparencyKey = global::System.Drawing.SystemColors.WindowFrame;
			base.Load += new global::System.EventHandler(this.AddUser_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.CheckedListBox checkedListBoxRules;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.TextBox textBoxUserName;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TextBox textBoxUserPassword;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox textBoxUserPassword2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button buttonClose;
	}
}
