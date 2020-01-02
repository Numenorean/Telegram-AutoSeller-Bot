namespace Authorization.UsersPermission.Forms
{
	// Token: 0x02000003 RID: 3
	public partial class FormChangePassword : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000488C File Offset: 0x00002A8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000048C4 File Offset: 0x00002AC4
		private void InitializeComponent()
		{
			this.textBoxUserPassword2 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBoxUserPassword = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxOld = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.textBoxUserPassword2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxUserPassword2.Location = new global::System.Drawing.Point(164, 74);
			this.textBoxUserPassword2.Name = "textBoxUserPassword2";
			this.textBoxUserPassword2.Size = new global::System.Drawing.Size(306, 22);
			this.textBoxUserPassword2.TabIndex = 12;
			this.textBoxUserPassword2.UseSystemPasswordChar = true;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(12, 77);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(146, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Подтвердите пароль";
			this.textBoxUserPassword.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxUserPassword.Location = new global::System.Drawing.Point(164, 46);
			this.textBoxUserPassword.Name = "textBoxUserPassword";
			this.textBoxUserPassword.Size = new global::System.Drawing.Size(306, 22);
			this.textBoxUserPassword.TabIndex = 10;
			this.textBoxUserPassword.UseSystemPasswordChar = true;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(102, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Новый пароль";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(109, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Старый пароль";
			this.textBoxOld.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxOld.Location = new global::System.Drawing.Point(164, 17);
			this.textBoxOld.Name = "textBoxOld";
			this.textBoxOld.Size = new global::System.Drawing.Size(306, 22);
			this.textBoxOld.TabIndex = 14;
			this.textBoxOld.UseSystemPasswordChar = true;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.BackColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new global::System.Drawing.Point(328, 129);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(142, 39);
			this.button1.TabIndex = 15;
			this.button1.Text = "Ок";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.BackColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new global::System.Drawing.Point(180, 129);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(142, 39);
			this.button2.TabIndex = 16;
			this.button2.Text = "Закрыть";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.Button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(120f, 120f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(475, 176);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBoxOld);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBoxUserPassword2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.textBoxUserPassword);
			base.Controls.Add(this.label2);
			base.Name = "FormChangePassword";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormChangePassword";
			base.TransparencyKey = global::System.Drawing.SystemColors.ControlDark;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.TextBox textBoxUserPassword2;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.TextBox textBoxUserPassword;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TextBox textBoxOld;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button2;
	}
}
