namespace TelegramBotBankStore
{
	// Token: 0x0200000E RID: 14
	public partial class FormMessage : global::System.Windows.Forms.Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000082C8 File Offset: 0x000064C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00008300 File Offset: 0x00006500
		private void InitializeComponent()
		{
			this.formSkin1 = new global::FlatUI.FormSkin();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.flatTextBoMessage = new global::FlatUI.FlatTextBox();
			this.flatButton1 = new global::FlatUI.FlatButton();
			this.formSkin1.SuspendLayout();
			base.SuspendLayout();
			this.formSkin1.BackColor = global::System.Drawing.Color.White;
			this.formSkin1.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkin1.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkin1.Controls.Add(this.buttonClose);
			this.formSkin1.Controls.Add(this.flatTextBoMessage);
			this.formSkin1.Controls.Add(this.flatButton1);
			this.formSkin1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.formSkin1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkin1.HeaderColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new global::System.Drawing.Point(0, 0);
			this.formSkin1.Margin = new global::System.Windows.Forms.Padding(4);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new global::System.Drawing.Size(549, 252);
			this.formSkin1.TabIndex = 0;
			this.formSkin1.Text = "Сообщение";
			this.buttonClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonClose.BackColor = global::System.Drawing.Color.DarkRed;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.Location = new global::System.Drawing.Point(514, 9);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(22, 21);
			this.buttonClose.TabIndex = 20;
			this.buttonClose.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.button1_Click);
			this.flatTextBoMessage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoMessage.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoMessage.FocusOnHover = false;
			this.flatTextBoMessage.Location = new global::System.Drawing.Point(13, 76);
			this.flatTextBoMessage.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatTextBoMessage.MaxLength = 32767;
			this.flatTextBoMessage.Multiline = true;
			this.flatTextBoMessage.Name = "flatTextBoMessage";
			this.flatTextBoMessage.ReadOnly = false;
			this.flatTextBoMessage.Size = new global::System.Drawing.Size(523, 116);
			this.flatTextBoMessage.TabIndex = 5;
			this.flatTextBoMessage.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoMessage.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoMessage.UseSystemPasswordChar = false;
			this.flatButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton1.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton1.Location = new global::System.Drawing.Point(200, 200);
			this.flatButton1.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatButton1.Name = "flatButton1";
			this.flatButton1.Rounded = false;
			this.flatButton1.Size = new global::System.Drawing.Size(141, 39);
			this.flatButton1.TabIndex = 0;
			this.flatButton1.Text = "Ок";
			this.flatButton1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton1.Click += new global::System.EventHandler(this.FlatButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(549, 252);
			base.Controls.Add(this.formSkin1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "FormMessage";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AuthorizationDialog";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.FormMessage_Load);
			this.formSkin1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000053 RID: 83
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000054 RID: 84
		private global::FlatUI.FormSkin formSkin1;

		// Token: 0x04000055 RID: 85
		private global::FlatUI.FlatButton flatButton1;

		// Token: 0x04000056 RID: 86
		private global::FlatUI.FlatTextBox flatTextBoMessage;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Button buttonClose;
	}
}
