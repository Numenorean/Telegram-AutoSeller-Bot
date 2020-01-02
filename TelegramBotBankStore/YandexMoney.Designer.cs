namespace TelegramBotBankStore
{
	// Token: 0x020000C9 RID: 201
	public partial class YandexMoney : global::System.Windows.Forms.Form
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x00040178 File Offset: 0x0003E378
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000401B0 File Offset: 0x0003E3B0
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.labelHist = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.labelProxy = new global::System.Windows.Forms.Label();
			this.formSkin1 = new global::FlatUI.FormSkin();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.flatMax1 = new global::FlatUI.FlatMax();
			this.flatMini1 = new global::FlatUI.FlatMini();
			this.flatButton4 = new global::FlatUI.FlatButton();
			this.flatButton3 = new global::FlatUI.FlatButton();
			this.flatButton1 = new global::FlatUI.FlatButton();
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.formSkin1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(147, 77);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(23, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "_";
			this.labelHist.AutoSize = true;
			this.labelHist.BackColor = global::System.Drawing.Color.Transparent;
			this.labelHist.ForeColor = global::System.Drawing.Color.White;
			this.labelHist.Location = new global::System.Drawing.Point(12, 127);
			this.labelHist.Name = "labelHist";
			this.labelHist.Size = new global::System.Drawing.Size(20, 28);
			this.labelHist.TabIndex = 11;
			this.labelHist.Text = "_";
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(3, 722);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(65, 28);
			this.label2.TabIndex = 12;
			this.label2.Text = "Proxy:";
			this.labelProxy.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.labelProxy.AutoSize = true;
			this.labelProxy.BackColor = global::System.Drawing.Color.Transparent;
			this.labelProxy.ForeColor = global::System.Drawing.Color.White;
			this.labelProxy.Location = new global::System.Drawing.Point(74, 722);
			this.labelProxy.Name = "labelProxy";
			this.labelProxy.Size = new global::System.Drawing.Size(20, 28);
			this.labelProxy.TabIndex = 13;
			this.labelProxy.Text = "_";
			this.formSkin1.BackColor = global::System.Drawing.Color.White;
			this.formSkin1.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkin1.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkin1.Controls.Add(this.buttonClose);
			this.formSkin1.Controls.Add(this.flatMax1);
			this.formSkin1.Controls.Add(this.flatMini1);
			this.formSkin1.Controls.Add(this.flatButton4);
			this.formSkin1.Controls.Add(this.flatButton3);
			this.formSkin1.Controls.Add(this.flatButton1);
			this.formSkin1.Controls.Add(this.label2);
			this.formSkin1.Controls.Add(this.labelHist);
			this.formSkin1.Controls.Add(this.labelProxy);
			this.formSkin1.Controls.Add(this.label1);
			this.formSkin1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.formSkin1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkin1.HeaderColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new global::System.Drawing.Point(0, 0);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new global::System.Drawing.Size(1396, 751);
			this.formSkin1.TabIndex = 14;
			this.formSkin1.Text = "Яндекс";
			this.buttonClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonClose.BackColor = global::System.Drawing.Color.DarkRed;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.Location = new global::System.Drawing.Point(1362, 13);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(22, 21);
			this.buttonClose.TabIndex = 21;
			this.buttonClose.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.flatMax1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMax1.BackColor = global::System.Drawing.Color.White;
			this.flatMax1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMax1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMax1.Location = new global::System.Drawing.Point(1333, 13);
			this.flatMax1.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatMax1.Name = "flatMax1";
			this.flatMax1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMax1.TabIndex = 19;
			this.flatMax1.Text = "flatMax1";
			this.flatMax1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatMax1.Click += new global::System.EventHandler(this.flatMax1_Click);
			this.flatMini1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMini1.BackColor = global::System.Drawing.Color.White;
			this.flatMini1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMini1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMini1.Location = new global::System.Drawing.Point(1301, 12);
			this.flatMini1.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 20;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButton4.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton4.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton4.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton4.Location = new global::System.Drawing.Point(1250, 67);
			this.flatButton4.Name = "flatButton4";
			this.flatButton4.Rounded = false;
			this.flatButton4.Size = new global::System.Drawing.Size(133, 45);
			this.flatButton4.TabIndex = 17;
			this.flatButton4.Text = "Обнулить сессию";
			this.flatButton4.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton4.Click += new global::System.EventHandler(this.button2_Click);
			this.flatButton3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButton3.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton3.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton3.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton3.Location = new global::System.Drawing.Point(1111, 67);
			this.flatButton3.Name = "flatButton3";
			this.flatButton3.Rounded = false;
			this.flatButton3.Size = new global::System.Drawing.Size(133, 45);
			this.flatButton3.TabIndex = 16;
			this.flatButton3.Text = "Токен API";
			this.flatButton3.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton3.Click += new global::System.EventHandler(this.button4_Click);
			this.flatButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton1.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton1.Location = new global::System.Drawing.Point(8, 67);
			this.flatButton1.Name = "flatButton1";
			this.flatButton1.Rounded = false;
			this.flatButton1.Size = new global::System.Drawing.Size(133, 45);
			this.flatButton1.TabIndex = 14;
			this.flatButton1.Text = "Проверить";
			this.flatButton1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton1.Click += new global::System.EventHandler(this.button1_ClickAsync);
			this.webBrowser1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.webBrowser1.Location = new global::System.Drawing.Point(8, 118);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new global::System.Drawing.Size(1375, 592);
			this.webBrowser1.TabIndex = 21;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1396, 751);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.formSkin1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "YandexMoney";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "YandexMoney";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.YandexMoney_LoadAsync);
			this.formSkin1.ResumeLayout(false);
			this.formSkin1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000723 RID: 1827
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000724 RID: 1828
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000725 RID: 1829
		private global::System.Windows.Forms.Label labelHist;

		// Token: 0x04000726 RID: 1830
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000727 RID: 1831
		private global::System.Windows.Forms.Label labelProxy;

		// Token: 0x04000728 RID: 1832
		private global::FlatUI.FormSkin formSkin1;

		// Token: 0x04000729 RID: 1833
		private global::FlatUI.FlatButton flatButton4;

		// Token: 0x0400072A RID: 1834
		private global::FlatUI.FlatButton flatButton3;

		// Token: 0x0400072B RID: 1835
		private global::FlatUI.FlatButton flatButton1;

		// Token: 0x0400072C RID: 1836
		private global::FlatUI.FlatMax flatMax1;

		// Token: 0x0400072D RID: 1837
		private global::FlatUI.FlatMini flatMini1;

		// Token: 0x0400072E RID: 1838
		private global::System.Windows.Forms.WebBrowser webBrowser1;

		// Token: 0x0400072F RID: 1839
		private global::System.Windows.Forms.Button buttonClose;
	}
}
