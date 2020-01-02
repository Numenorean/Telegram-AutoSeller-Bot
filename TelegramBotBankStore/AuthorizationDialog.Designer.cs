namespace TelegramBotBankStore
{
	// Token: 0x0200000F RID: 15
	public partial class AuthorizationDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000088D0 File Offset: 0x00006AD0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00008908 File Offset: 0x00006B08
		private void InitializeComponent()
		{
			this.formSkin1 = new global::FlatUI.FormSkin();
			this.flatLabel2 = new global::FlatUI.FlatLabel();
			this.flatLabel1 = new global::FlatUI.FlatLabel();
			this.flatTextBoxKey = new global::FlatUI.FlatTextBox();
			this.flatTextBoxID = new global::FlatUI.FlatTextBox();
			this.flatButton2 = new global::FlatUI.FlatButton();
			this.flatButton1 = new global::FlatUI.FlatButton();
			this.flatLabel3 = new global::FlatUI.FlatLabel();
			this.formSkin1.SuspendLayout();
			base.SuspendLayout();
			this.formSkin1.BackColor = global::System.Drawing.Color.White;
			this.formSkin1.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkin1.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkin1.Controls.Add(this.flatLabel3);
			this.formSkin1.Controls.Add(this.flatLabel2);
			this.formSkin1.Controls.Add(this.flatLabel1);
			this.formSkin1.Controls.Add(this.flatTextBoxKey);
			this.formSkin1.Controls.Add(this.flatTextBoxID);
			this.formSkin1.Controls.Add(this.flatButton2);
			this.formSkin1.Controls.Add(this.flatButton1);
			this.formSkin1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.formSkin1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkin1.HeaderColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new global::System.Drawing.Point(0, 0);
			this.formSkin1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new global::System.Drawing.Size(549, 252);
			this.formSkin1.TabIndex = 0;
			this.formSkin1.Text = "Ключ";
			this.flatLabel2.AutoSize = true;
			this.flatLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel2.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel2.Location = new global::System.Drawing.Point(9, 142);
			this.flatLabel2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel2.Name = "flatLabel2";
			this.flatLabel2.Size = new global::System.Drawing.Size(46, 19);
			this.flatLabel2.TabIndex = 5;
			this.flatLabel2.Text = "Ключ:";
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel1.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel1.Location = new global::System.Drawing.Point(9, 96);
			this.flatLabel1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new global::System.Drawing.Size(26, 19);
			this.flatLabel1.TabIndex = 4;
			this.flatLabel1.Text = "ID:";
			this.flatTextBoxKey.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxKey.FocusOnHover = false;
			this.flatTextBoxKey.Location = new global::System.Drawing.Point(68, 135);
			this.flatTextBoxKey.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatTextBoxKey.MaxLength = 32767;
			this.flatTextBoxKey.Multiline = false;
			this.flatTextBoxKey.Name = "flatTextBoxKey";
			this.flatTextBoxKey.ReadOnly = false;
			this.flatTextBoxKey.Size = new global::System.Drawing.Size(468, 34);
			this.flatTextBoxKey.TabIndex = 3;
			this.flatTextBoxKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxKey.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxKey.UseSystemPasswordChar = false;
			this.flatTextBoxID.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxID.FocusOnHover = false;
			this.flatTextBoxID.Location = new global::System.Drawing.Point(68, 93);
			this.flatTextBoxID.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatTextBoxID.MaxLength = 32767;
			this.flatTextBoxID.Multiline = false;
			this.flatTextBoxID.Name = "flatTextBoxID";
			this.flatTextBoxID.ReadOnly = true;
			this.flatTextBoxID.Size = new global::System.Drawing.Size(305, 34);
			this.flatTextBoxID.TabIndex = 2;
			this.flatTextBoxID.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxID.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxID.UseSystemPasswordChar = false;
			this.flatTextBoxID.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.FlatTextBoxID_MouseClick);
			this.flatButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton2.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton2.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton2.Location = new global::System.Drawing.Point(281, 187);
			this.flatButton2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatButton2.Name = "flatButton2";
			this.flatButton2.Rounded = false;
			this.flatButton2.Size = new global::System.Drawing.Size(141, 39);
			this.flatButton2.TabIndex = 1;
			this.flatButton2.Text = "Вход";
			this.flatButton2.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton2.Click += new global::System.EventHandler(this.FlatButton2_Click);
			this.flatButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton1.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton1.Location = new global::System.Drawing.Point(132, 187);
			this.flatButton1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatButton1.Name = "flatButton1";
			this.flatButton1.Rounded = false;
			this.flatButton1.Size = new global::System.Drawing.Size(141, 39);
			this.flatButton1.TabIndex = 0;
			this.flatButton1.Text = "Отмена";
			this.flatButton1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton1.Click += new global::System.EventHandler(this.FlatButton1_Click);
			this.flatLabel3.AutoSize = true;
			this.flatLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel3.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel3.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel3.Location = new global::System.Drawing.Point(381, 101);
			this.flatLabel3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel3.Name = "flatLabel3";
			this.flatLabel3.Size = new global::System.Drawing.Size(0, 19);
			this.flatLabel3.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(549, 252);
			base.Controls.Add(this.formSkin1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "AuthorizationDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AuthorizationDialog";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.AuthorizationDialog_Load);
			this.formSkin1.ResumeLayout(false);
			this.formSkin1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000058 RID: 88
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000059 RID: 89
		private global::FlatUI.FormSkin formSkin1;

		// Token: 0x0400005A RID: 90
		private global::FlatUI.FlatLabel flatLabel2;

		// Token: 0x0400005B RID: 91
		private global::FlatUI.FlatLabel flatLabel1;

		// Token: 0x0400005C RID: 92
		private global::FlatUI.FlatTextBox flatTextBoxKey;

		// Token: 0x0400005D RID: 93
		private global::FlatUI.FlatTextBox flatTextBoxID;

		// Token: 0x0400005E RID: 94
		private global::FlatUI.FlatButton flatButton2;

		// Token: 0x0400005F RID: 95
		private global::FlatUI.FlatButton flatButton1;

		// Token: 0x04000060 RID: 96
		private global::FlatUI.FlatLabel flatLabel3;
	}
}
