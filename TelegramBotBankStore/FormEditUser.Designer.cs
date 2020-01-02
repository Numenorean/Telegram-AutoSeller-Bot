namespace TelegramBotBankStore
{
	// Token: 0x0200000D RID: 13
	public partial class FormEditUser : global::System.Windows.Forms.Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000067C4 File Offset: 0x000049C4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000067FC File Offset: 0x000049FC
		private void InitializeComponent()
		{
			this.formSkin1 = new global::FlatUI.FormSkin();
			this.lbNotFoundStatistics = new global::FlatUI.FlatLabel();
			this.flatLabel9 = new global::FlatUI.FlatLabel();
			this.flatLabel8 = new global::FlatUI.FlatLabel();
			this.flatNumeric1 = new global::FlatUI.FlatNumeric();
			this.flatLabel2 = new global::FlatUI.FlatLabel();
			this.flatToggleSapport = new global::FlatUI.FlatToggle();
			this.flatLabel7 = new global::FlatUI.FlatLabel();
			this.flatToggleBan = new global::FlatUI.FlatToggle();
			this.flatLabel4 = new global::FlatUI.FlatLabel();
			this.flatTextBoxLTCAddress = new global::FlatUI.FlatTextBox();
			this.flatLabel5 = new global::FlatUI.FlatLabel();
			this.flatLabel6 = new global::FlatUI.FlatLabel();
			this.flatTextBoxRubComment = new global::FlatUI.FlatTextBox();
			this.flatTextBoxBTCAddress = new global::FlatUI.FlatTextBox();
			this.flatLabel3 = new global::FlatUI.FlatLabel();
			this.textBoxLTC = new global::FlatUI.FlatTextBox();
			this.lbCurrency = new global::FlatUI.FlatLabel();
			this.flatLabel1 = new global::FlatUI.FlatLabel();
			this.textBoxRUB = new global::FlatUI.FlatTextBox();
			this.textBoxBTC = new global::FlatUI.FlatTextBox();
			this.flatButton2 = new global::FlatUI.FlatButton();
			this.flatButton1 = new global::FlatUI.FlatButton();
			this.tbAddressHistory = new global::FlatUI.FlatTextBox();
			this.flatTextBox1 = new global::FlatUI.FlatTextBox();
			this.flatLabel10 = new global::FlatUI.FlatLabel();
			this.formSkin1.SuspendLayout();
			base.SuspendLayout();
			this.formSkin1.BackColor = global::System.Drawing.Color.White;
			this.formSkin1.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkin1.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkin1.Controls.Add(this.flatLabel10);
			this.formSkin1.Controls.Add(this.flatTextBox1);
			this.formSkin1.Controls.Add(this.tbAddressHistory);
			this.formSkin1.Controls.Add(this.lbNotFoundStatistics);
			this.formSkin1.Controls.Add(this.flatLabel9);
			this.formSkin1.Controls.Add(this.flatLabel8);
			this.formSkin1.Controls.Add(this.flatNumeric1);
			this.formSkin1.Controls.Add(this.flatLabel2);
			this.formSkin1.Controls.Add(this.flatToggleSapport);
			this.formSkin1.Controls.Add(this.flatLabel7);
			this.formSkin1.Controls.Add(this.flatToggleBan);
			this.formSkin1.Controls.Add(this.flatLabel4);
			this.formSkin1.Controls.Add(this.flatTextBoxLTCAddress);
			this.formSkin1.Controls.Add(this.flatLabel5);
			this.formSkin1.Controls.Add(this.flatLabel6);
			this.formSkin1.Controls.Add(this.flatTextBoxRubComment);
			this.formSkin1.Controls.Add(this.flatTextBoxBTCAddress);
			this.formSkin1.Controls.Add(this.flatLabel3);
			this.formSkin1.Controls.Add(this.textBoxLTC);
			this.formSkin1.Controls.Add(this.lbCurrency);
			this.formSkin1.Controls.Add(this.flatLabel1);
			this.formSkin1.Controls.Add(this.textBoxRUB);
			this.formSkin1.Controls.Add(this.textBoxBTC);
			this.formSkin1.Controls.Add(this.flatButton2);
			this.formSkin1.Controls.Add(this.flatButton1);
			this.formSkin1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.formSkin1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkin1.HeaderColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new global::System.Drawing.Point(0, 0);
			this.formSkin1.Margin = new global::System.Windows.Forms.Padding(4);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new global::System.Drawing.Size(1112, 636);
			this.formSkin1.TabIndex = 0;
			this.formSkin1.Text = "Юзер";
			this.lbNotFoundStatistics.AutoSize = true;
			this.lbNotFoundStatistics.BackColor = global::System.Drawing.Color.Transparent;
			this.lbNotFoundStatistics.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lbNotFoundStatistics.ForeColor = global::System.Drawing.Color.White;
			this.lbNotFoundStatistics.Location = new global::System.Drawing.Point(410, 252);
			this.lbNotFoundStatistics.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbNotFoundStatistics.Name = "lbNotFoundStatistics";
			this.lbNotFoundStatistics.Size = new global::System.Drawing.Size(13, 19);
			this.lbNotFoundStatistics.TabIndex = 21;
			this.lbNotFoundStatistics.Text = " ";
			this.lbNotFoundStatistics.Visible = false;
			this.flatLabel9.AutoSize = true;
			this.flatLabel9.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel9.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel9.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel9.Location = new global::System.Drawing.Point(236, 252);
			this.flatLabel9.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel9.Name = "flatLabel9";
			this.flatLabel9.Size = new global::System.Drawing.Size(130, 19);
			this.flatLabel9.TabIndex = 20;
			this.flatLabel9.Text = "Процент ненахода:";
			this.flatLabel9.Visible = false;
			this.flatLabel8.AutoSize = true;
			this.flatLabel8.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel8.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel8.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel8.Location = new global::System.Drawing.Point(236, 216);
			this.flatLabel8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel8.Name = "flatLabel8";
			this.flatLabel8.Size = new global::System.Drawing.Size(66, 19);
			this.flatLabel8.TabIndex = 19;
			this.flatLabel8.Text = "Ненаход:";
			this.flatLabel8.Visible = false;
			this.flatNumeric1.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumeric1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumeric1.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumeric1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumeric1.ForeColor = global::System.Drawing.Color.White;
			this.flatNumeric1.Location = new global::System.Drawing.Point(414, 205);
			global::FlatUI.FlatNumeric flatNumeric = this.flatNumeric1;
			int[] array = new int[4];
			array[0] = 1000;
			flatNumeric.Maximum = new decimal(array);
			this.flatNumeric1.Minimum = new decimal(new int[4]);
			this.flatNumeric1.Name = "flatNumeric1";
			this.flatNumeric1.Size = new global::System.Drawing.Size(101, 30);
			this.flatNumeric1.TabIndex = 18;
			this.flatNumeric1.Text = "flatNumeric1";
			this.flatNumeric1.Value = new decimal(new int[4]);
			this.flatNumeric1.Visible = false;
			this.flatLabel2.AutoSize = true;
			this.flatLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel2.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel2.Location = new global::System.Drawing.Point(11, 252);
			this.flatLabel2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel2.Name = "flatLabel2";
			this.flatLabel2.Size = new global::System.Drawing.Size(66, 19);
			this.flatLabel2.TabIndex = 17;
			this.flatLabel2.Text = "Саппорт:";
			this.flatToggleSapport.BackColor = global::System.Drawing.Color.Transparent;
			this.flatToggleSapport.Checked = false;
			this.flatToggleSapport.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatToggleSapport.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatToggleSapport.Location = new global::System.Drawing.Point(84, 246);
			this.flatToggleSapport.Name = "flatToggleSapport";
			this.flatToggleSapport.Options = global::FlatUI.FlatToggle._Options.Style1;
			this.flatToggleSapport.Size = new global::System.Drawing.Size(76, 33);
			this.flatToggleSapport.TabIndex = 16;
			this.flatToggleSapport.Text = "flatToggle1";
			this.flatLabel7.AutoSize = true;
			this.flatLabel7.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel7.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel7.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel7.Location = new global::System.Drawing.Point(11, 213);
			this.flatLabel7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel7.Name = "flatLabel7";
			this.flatLabel7.Size = new global::System.Drawing.Size(35, 19);
			this.flatLabel7.TabIndex = 15;
			this.flatLabel7.Text = "Бан:";
			this.flatToggleBan.BackColor = global::System.Drawing.Color.Transparent;
			this.flatToggleBan.Checked = false;
			this.flatToggleBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatToggleBan.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatToggleBan.Location = new global::System.Drawing.Point(84, 205);
			this.flatToggleBan.Name = "flatToggleBan";
			this.flatToggleBan.Options = global::FlatUI.FlatToggle._Options.Style1;
			this.flatToggleBan.Size = new global::System.Drawing.Size(76, 33);
			this.flatToggleBan.TabIndex = 14;
			this.flatToggleBan.Text = "flatToggle1";
			this.flatLabel4.AutoSize = true;
			this.flatLabel4.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel4.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel4.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel4.Location = new global::System.Drawing.Point(534, 172);
			this.flatLabel4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel4.Name = "flatLabel4";
			this.flatLabel4.Size = new global::System.Drawing.Size(50, 19);
			this.flatLabel4.TabIndex = 13;
			this.flatLabel4.Text = "Адрес:";
			this.flatTextBoxLTCAddress.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxLTCAddress.FocusOnHover = false;
			this.flatTextBoxLTCAddress.Location = new global::System.Drawing.Point(642, 164);
			this.flatTextBoxLTCAddress.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatTextBoxLTCAddress.MaxLength = 32767;
			this.flatTextBoxLTCAddress.Multiline = false;
			this.flatTextBoxLTCAddress.Name = "flatTextBoxLTCAddress";
			this.flatTextBoxLTCAddress.ReadOnly = false;
			this.flatTextBoxLTCAddress.Size = new global::System.Drawing.Size(438, 34);
			this.flatTextBoxLTCAddress.TabIndex = 12;
			this.flatTextBoxLTCAddress.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxLTCAddress.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxLTCAddress.UseSystemPasswordChar = false;
			this.flatLabel5.AutoSize = true;
			this.flatLabel5.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel5.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel5.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel5.Location = new global::System.Drawing.Point(534, 130);
			this.flatLabel5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel5.Name = "flatLabel5";
			this.flatLabel5.Size = new global::System.Drawing.Size(90, 19);
			this.flatLabel5.TabIndex = 11;
			this.flatLabel5.Text = "Коментарий:";
			this.flatLabel6.AutoSize = true;
			this.flatLabel6.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel6.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel6.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel6.Location = new global::System.Drawing.Point(534, 87);
			this.flatLabel6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel6.Name = "flatLabel6";
			this.flatLabel6.Size = new global::System.Drawing.Size(50, 19);
			this.flatLabel6.TabIndex = 10;
			this.flatLabel6.Text = "Адрес:";
			this.flatTextBoxRubComment.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxRubComment.FocusOnHover = false;
			this.flatTextBoxRubComment.Location = new global::System.Drawing.Point(642, 122);
			this.flatTextBoxRubComment.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatTextBoxRubComment.MaxLength = 32767;
			this.flatTextBoxRubComment.Multiline = false;
			this.flatTextBoxRubComment.Name = "flatTextBoxRubComment";
			this.flatTextBoxRubComment.ReadOnly = false;
			this.flatTextBoxRubComment.Size = new global::System.Drawing.Size(438, 34);
			this.flatTextBoxRubComment.TabIndex = 9;
			this.flatTextBoxRubComment.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxRubComment.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxRubComment.UseSystemPasswordChar = false;
			this.flatTextBoxBTCAddress.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxBTCAddress.FocusOnHover = false;
			this.flatTextBoxBTCAddress.Location = new global::System.Drawing.Point(642, 80);
			this.flatTextBoxBTCAddress.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatTextBoxBTCAddress.MaxLength = 32767;
			this.flatTextBoxBTCAddress.Multiline = false;
			this.flatTextBoxBTCAddress.Name = "flatTextBoxBTCAddress";
			this.flatTextBoxBTCAddress.ReadOnly = false;
			this.flatTextBoxBTCAddress.Size = new global::System.Drawing.Size(438, 34);
			this.flatTextBoxBTCAddress.TabIndex = 8;
			this.flatTextBoxBTCAddress.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxBTCAddress.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxBTCAddress.UseSystemPasswordChar = false;
			this.flatLabel3.AutoSize = true;
			this.flatLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel3.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel3.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel3.Location = new global::System.Drawing.Point(13, 172);
			this.flatLabel3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel3.Name = "flatLabel3";
			this.flatLabel3.Size = new global::System.Drawing.Size(33, 19);
			this.flatLabel3.TabIndex = 7;
			this.flatLabel3.Text = "LTC:";
			this.textBoxLTC.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxLTC.FocusOnHover = false;
			this.textBoxLTC.Location = new global::System.Drawing.Point(71, 164);
			this.textBoxLTC.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxLTC.MaxLength = 32767;
			this.textBoxLTC.Multiline = false;
			this.textBoxLTC.Name = "textBoxLTC";
			this.textBoxLTC.ReadOnly = false;
			this.textBoxLTC.Size = new global::System.Drawing.Size(447, 34);
			this.textBoxLTC.TabIndex = 6;
			this.textBoxLTC.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxLTC.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxLTC.UseSystemPasswordChar = false;
			this.lbCurrency.AutoSize = true;
			this.lbCurrency.BackColor = global::System.Drawing.Color.Transparent;
			this.lbCurrency.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lbCurrency.ForeColor = global::System.Drawing.Color.White;
			this.lbCurrency.Location = new global::System.Drawing.Point(13, 130);
			this.lbCurrency.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbCurrency.Name = "lbCurrency";
			this.lbCurrency.Size = new global::System.Drawing.Size(12, 19);
			this.lbCurrency.TabIndex = 5;
			this.lbCurrency.Text = ":";
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel1.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel1.Location = new global::System.Drawing.Point(13, 87);
			this.flatLabel1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new global::System.Drawing.Size(34, 19);
			this.flatLabel1.TabIndex = 4;
			this.flatLabel1.Text = "BTC:";
			this.textBoxRUB.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxRUB.FocusOnHover = false;
			this.textBoxRUB.Location = new global::System.Drawing.Point(71, 122);
			this.textBoxRUB.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxRUB.MaxLength = 32767;
			this.textBoxRUB.Multiline = false;
			this.textBoxRUB.Name = "textBoxRUB";
			this.textBoxRUB.ReadOnly = false;
			this.textBoxRUB.Size = new global::System.Drawing.Size(447, 34);
			this.textBoxRUB.TabIndex = 3;
			this.textBoxRUB.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxRUB.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxRUB.UseSystemPasswordChar = false;
			this.textBoxBTC.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxBTC.FocusOnHover = false;
			this.textBoxBTC.Location = new global::System.Drawing.Point(71, 80);
			this.textBoxBTC.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxBTC.MaxLength = 32767;
			this.textBoxBTC.Multiline = false;
			this.textBoxBTC.Name = "textBoxBTC";
			this.textBoxBTC.ReadOnly = false;
			this.textBoxBTC.Size = new global::System.Drawing.Size(447, 34);
			this.textBoxBTC.TabIndex = 2;
			this.textBoxBTC.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxBTC.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxBTC.UseSystemPasswordChar = false;
			this.flatButton2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton2.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton2.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton2.Location = new global::System.Drawing.Point(959, 582);
			this.flatButton2.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatButton2.Name = "flatButton2";
			this.flatButton2.Rounded = false;
			this.flatButton2.Size = new global::System.Drawing.Size(141, 39);
			this.flatButton2.TabIndex = 1;
			this.flatButton2.Text = "Сохранить";
			this.flatButton2.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton2.Click += new global::System.EventHandler(this.FlatButton2_Click);
			this.flatButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton1.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton1.Location = new global::System.Drawing.Point(810, 582);
			this.flatButton1.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatButton1.Name = "flatButton1";
			this.flatButton1.Rounded = false;
			this.flatButton1.Size = new global::System.Drawing.Size(141, 39);
			this.flatButton1.TabIndex = 0;
			this.flatButton1.Text = "Отмена";
			this.flatButton1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton1.Click += new global::System.EventHandler(this.FlatButton1_Click);
			this.tbAddressHistory.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tbAddressHistory.BackColor = global::System.Drawing.Color.Transparent;
			this.tbAddressHistory.FocusOnHover = false;
			this.tbAddressHistory.Location = new global::System.Drawing.Point(13, 344);
			this.tbAddressHistory.Margin = new global::System.Windows.Forms.Padding(4);
			this.tbAddressHistory.MaxLength = 32767;
			this.tbAddressHistory.Multiline = true;
			this.tbAddressHistory.Name = "tbAddressHistory";
			this.tbAddressHistory.ReadOnly = false;
			this.tbAddressHistory.Size = new global::System.Drawing.Size(787, 277);
			this.tbAddressHistory.TabIndex = 22;
			this.tbAddressHistory.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.tbAddressHistory.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.tbAddressHistory.UseSystemPasswordChar = false;
			this.flatTextBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox1.FocusOnHover = false;
			this.flatTextBox1.Location = new global::System.Drawing.Point(357, 302);
			this.flatTextBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.flatTextBox1.MaxLength = 32767;
			this.flatTextBox1.Multiline = false;
			this.flatTextBox1.Name = "flatTextBox1";
			this.flatTextBox1.ReadOnly = false;
			this.flatTextBox1.Size = new global::System.Drawing.Size(443, 34);
			this.flatTextBox1.TabIndex = 23;
			this.flatTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBox1.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox1.UseSystemPasswordChar = false;
			this.flatTextBox1.TextChanged += new global::System.EventHandler(this.flatTextBox1_TextChanged);
			this.flatLabel10.AutoSize = true;
			this.flatLabel10.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel10.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel10.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel10.Location = new global::System.Drawing.Point(13, 309);
			this.flatLabel10.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel10.Name = "flatLabel10";
			this.flatLabel10.Size = new global::System.Drawing.Size(273, 19);
			this.flatLabel10.TabIndex = 24;
			this.flatLabel10.Text = "История полученных юзером кошельков:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1112, 636);
			base.Controls.Add(this.formSkin1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "FormEditUser";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AuthorizationDialog";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.FormEditUser_Load);
			this.formSkin1.ResumeLayout(false);
			this.formSkin1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000038 RID: 56
		private global::FlatUI.FormSkin formSkin1;

		// Token: 0x04000039 RID: 57
		private global::FlatUI.FlatLabel lbCurrency;

		// Token: 0x0400003A RID: 58
		private global::FlatUI.FlatLabel flatLabel1;

		// Token: 0x0400003B RID: 59
		private global::FlatUI.FlatTextBox textBoxRUB;

		// Token: 0x0400003C RID: 60
		private global::FlatUI.FlatTextBox textBoxBTC;

		// Token: 0x0400003D RID: 61
		private global::FlatUI.FlatButton flatButton2;

		// Token: 0x0400003E RID: 62
		private global::FlatUI.FlatButton flatButton1;

		// Token: 0x0400003F RID: 63
		private global::FlatUI.FlatLabel flatLabel3;

		// Token: 0x04000040 RID: 64
		private global::FlatUI.FlatTextBox textBoxLTC;

		// Token: 0x04000041 RID: 65
		private global::FlatUI.FlatLabel flatLabel4;

		// Token: 0x04000042 RID: 66
		private global::FlatUI.FlatTextBox flatTextBoxLTCAddress;

		// Token: 0x04000043 RID: 67
		private global::FlatUI.FlatLabel flatLabel5;

		// Token: 0x04000044 RID: 68
		private global::FlatUI.FlatLabel flatLabel6;

		// Token: 0x04000045 RID: 69
		private global::FlatUI.FlatTextBox flatTextBoxRubComment;

		// Token: 0x04000046 RID: 70
		private global::FlatUI.FlatTextBox flatTextBoxBTCAddress;

		// Token: 0x04000047 RID: 71
		private global::FlatUI.FlatLabel flatLabel7;

		// Token: 0x04000048 RID: 72
		private global::FlatUI.FlatToggle flatToggleBan;

		// Token: 0x04000049 RID: 73
		private global::FlatUI.FlatLabel flatLabel2;

		// Token: 0x0400004A RID: 74
		private global::FlatUI.FlatToggle flatToggleSapport;

		// Token: 0x0400004B RID: 75
		private global::FlatUI.FlatLabel flatLabel8;

		// Token: 0x0400004C RID: 76
		private global::FlatUI.FlatNumeric flatNumeric1;

		// Token: 0x0400004D RID: 77
		private global::FlatUI.FlatLabel lbNotFoundStatistics;

		// Token: 0x0400004E RID: 78
		private global::FlatUI.FlatLabel flatLabel9;

		// Token: 0x0400004F RID: 79
		private global::FlatUI.FlatTextBox tbAddressHistory;

		// Token: 0x04000050 RID: 80
		private global::FlatUI.FlatTextBox flatTextBox1;

		// Token: 0x04000051 RID: 81
		private global::FlatUI.FlatLabel flatLabel10;
	}
}
