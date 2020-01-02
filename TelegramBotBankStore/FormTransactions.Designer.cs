namespace TelegramBotBankStore
{
	// Token: 0x0200001A RID: 26
	public partial class FormTransactions : global::System.Windows.Forms.Form
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000B2C0 File Offset: 0x000094C0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000B2F8 File Offset: 0x000094F8
		private void InitializeComponent()
		{
			this.formSkin1 = new global::FlatUI.FormSkin();
			this.lbText = new global::System.Windows.Forms.ListBox();
			this.flatMax1 = new global::FlatUI.FlatMax();
			this.flatMini1 = new global::FlatUI.FlatMini();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.formSkin1.SuspendLayout();
			base.SuspendLayout();
			this.formSkin1.BackColor = global::System.Drawing.Color.White;
			this.formSkin1.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkin1.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkin1.Controls.Add(this.buttonClose);
			this.formSkin1.Controls.Add(this.lbText);
			this.formSkin1.Controls.Add(this.flatMax1);
			this.formSkin1.Controls.Add(this.flatMini1);
			this.formSkin1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.formSkin1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkin1.HeaderColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new global::System.Drawing.Point(0, 0);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new global::System.Drawing.Size(800, 450);
			this.formSkin1.TabIndex = 0;
			this.formSkin1.Text = "formSkin1";
			this.lbText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lbText.BackColor = global::System.Drawing.Color.FromArgb(25, 27, 29);
			this.lbText.ForeColor = global::System.Drawing.Color.White;
			this.lbText.FormattingEnabled = true;
			this.lbText.ItemHeight = 28;
			this.lbText.Location = new global::System.Drawing.Point(11, 59);
			this.lbText.Name = "lbText";
			this.lbText.Size = new global::System.Drawing.Size(777, 368);
			this.lbText.TabIndex = 6;
			this.flatMax1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMax1.BackColor = global::System.Drawing.Color.White;
			this.flatMax1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMax1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMax1.Location = new global::System.Drawing.Point(739, 13);
			this.flatMax1.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatMax1.Name = "flatMax1";
			this.flatMax1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMax1.TabIndex = 4;
			this.flatMax1.Text = "flatMax1";
			this.flatMax1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatMini1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMini1.BackColor = global::System.Drawing.Color.White;
			this.flatMini1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMini1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMini1.Location = new global::System.Drawing.Point(707, 12);
			this.flatMini1.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 5;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.buttonClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonClose.BackColor = global::System.Drawing.Color.DarkRed;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.Location = new global::System.Drawing.Point(766, 10);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(22, 21);
			this.buttonClose.TabIndex = 21;
			this.buttonClose.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.formSkin1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "FormTransactions";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormTransactions";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.FormTransactions_Load);
			this.formSkin1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000A2 RID: 162
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000A3 RID: 163
		private global::FlatUI.FormSkin formSkin1;

		// Token: 0x040000A4 RID: 164
		private global::FlatUI.FlatMax flatMax1;

		// Token: 0x040000A5 RID: 165
		private global::FlatUI.FlatMini flatMini1;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.ListBox lbText;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Button buttonClose;
	}
}
