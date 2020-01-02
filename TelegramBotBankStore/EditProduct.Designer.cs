namespace TelegramBotBankStore
{
	// Token: 0x02000010 RID: 16
	public partial class EditProduct : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00009840 File Offset: 0x00007A40
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00009878 File Offset: 0x00007A78
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TelegramBotBankStore.EditProduct));
			this.formSkinProduct = new global::FlatUI.FormSkin();
			this.flatLabelCategory = new global::FlatUI.FlatLabel();
			this.flatLabel3 = new global::FlatUI.FlatLabel();
			this.flatTextBoxPositions = new global::FlatUI.FlatTextBox();
			this.flatNumericPrice = new global::FlatUI.FlatNumeric();
			this.flatLabel2 = new global::FlatUI.FlatLabel();
			this.flatTextBoxName = new global::FlatUI.FlatTextBox();
			this.flatLabel1 = new global::FlatUI.FlatLabel();
			this.panelButtons = new global::System.Windows.Forms.Panel();
			this.flatButtonSave = new global::FlatUI.FlatButton();
			this.flatButtonCancel = new global::FlatUI.FlatButton();
			this.flatStatusBarMain = new global::FlatUI.FlatStatusBar();
			this.flatToggle1 = new global::FlatUI.FlatToggle();
			this.flatLabel4 = new global::FlatUI.FlatLabel();
			this.formSkinProduct.SuspendLayout();
			this.panelButtons.SuspendLayout();
			base.SuspendLayout();
			this.formSkinProduct.BackColor = global::System.Drawing.Color.White;
			this.formSkinProduct.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkinProduct.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkinProduct.Controls.Add(this.flatLabel4);
			this.formSkinProduct.Controls.Add(this.flatToggle1);
			this.formSkinProduct.Controls.Add(this.flatLabelCategory);
			this.formSkinProduct.Controls.Add(this.flatLabel3);
			this.formSkinProduct.Controls.Add(this.flatTextBoxPositions);
			this.formSkinProduct.Controls.Add(this.flatNumericPrice);
			this.formSkinProduct.Controls.Add(this.flatLabel2);
			this.formSkinProduct.Controls.Add(this.flatTextBoxName);
			this.formSkinProduct.Controls.Add(this.flatLabel1);
			this.formSkinProduct.Controls.Add(this.panelButtons);
			this.formSkinProduct.Controls.Add(this.flatStatusBarMain);
			this.formSkinProduct.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkinProduct.FlatColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.formSkinProduct.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkinProduct.HeaderColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.formSkinProduct.HeaderMaximize = false;
			this.formSkinProduct.Location = new global::System.Drawing.Point(0, 0);
			this.formSkinProduct.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.formSkinProduct.Name = "formSkinProduct";
			this.formSkinProduct.Padding = new global::System.Windows.Forms.Padding(0, 62, 0, 0);
			this.formSkinProduct.Size = new global::System.Drawing.Size(1067, 554);
			this.formSkinProduct.TabIndex = 0;
			this.formSkinProduct.Text = "Товар";
			this.flatLabelCategory.AutoSize = true;
			this.flatLabelCategory.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabelCategory.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabelCategory.ForeColor = global::System.Drawing.Color.White;
			this.flatLabelCategory.Location = new global::System.Drawing.Point(415, 76);
			this.flatLabelCategory.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabelCategory.Name = "flatLabelCategory";
			this.flatLabelCategory.Size = new global::System.Drawing.Size(15, 19);
			this.flatLabelCategory.TabIndex = 16;
			this.flatLabelCategory.Text = "-";
			this.flatLabel3.AutoSize = true;
			this.flatLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel3.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel3.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel3.Location = new global::System.Drawing.Point(320, 76);
			this.flatLabel3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel3.Name = "flatLabel3";
			this.flatLabel3.Size = new global::System.Drawing.Size(76, 19);
			this.flatLabel3.TabIndex = 15;
			this.flatLabel3.Text = "Категория:";
			this.flatTextBoxPositions.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxPositions.FocusOnHover = false;
			this.flatTextBoxPositions.Location = new global::System.Drawing.Point(16, 210);
			this.flatTextBoxPositions.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatTextBoxPositions.MaxLength = 32767;
			this.flatTextBoxPositions.Multiline = true;
			this.flatTextBoxPositions.Name = "flatTextBoxPositions";
			this.flatTextBoxPositions.ReadOnly = false;
			this.flatTextBoxPositions.Size = new global::System.Drawing.Size(1035, 238);
			this.flatTextBoxPositions.TabIndex = 14;
			this.flatTextBoxPositions.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxPositions.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxPositions.UseSystemPasswordChar = false;
			this.flatNumericPrice.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumericPrice.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumericPrice.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumericPrice.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumericPrice.ForeColor = global::System.Drawing.Color.White;
			this.flatNumericPrice.Location = new global::System.Drawing.Point(415, 155);
			this.flatNumericPrice.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			global::FlatUI.FlatNumeric flatNumeric = this.flatNumericPrice;
			int[] array = new int[4];
			array[0] = 9999999;
			flatNumeric.Maximum = new decimal(array);
			this.flatNumericPrice.Minimum = new decimal(new int[4]);
			this.flatNumericPrice.Name = "flatNumericPrice";
			this.flatNumericPrice.Size = new global::System.Drawing.Size(135, 30);
			this.flatNumericPrice.TabIndex = 13;
			this.flatNumericPrice.Text = "flatNumeric1";
			this.flatNumericPrice.Value = new decimal(new int[4]);
			this.flatLabel2.AutoSize = true;
			this.flatLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel2.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel2.Location = new global::System.Drawing.Point(357, 165);
			this.flatLabel2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel2.Name = "flatLabel2";
			this.flatLabel2.Size = new global::System.Drawing.Size(44, 19);
			this.flatLabel2.TabIndex = 12;
			this.flatLabel2.Text = "Цена:";
			this.flatTextBoxName.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxName.FocusOnHover = false;
			this.flatTextBoxName.Location = new global::System.Drawing.Point(415, 112);
			this.flatTextBoxName.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatTextBoxName.MaxLength = 32767;
			this.flatTextBoxName.Multiline = false;
			this.flatTextBoxName.Name = "flatTextBoxName";
			this.flatTextBoxName.ReadOnly = false;
			this.flatTextBoxName.Size = new global::System.Drawing.Size(307, 34);
			this.flatTextBoxName.TabIndex = 11;
			this.flatTextBoxName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxName.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxName.UseSystemPasswordChar = false;
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel1.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel1.Location = new global::System.Drawing.Point(325, 121);
			this.flatLabel1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new global::System.Drawing.Size(72, 19);
			this.flatLabel1.TabIndex = 10;
			this.flatLabel1.Text = "Название:";
			this.panelButtons.BackColor = global::System.Drawing.Color.Transparent;
			this.panelButtons.Controls.Add(this.flatButtonSave);
			this.panelButtons.Controls.Add(this.flatButtonCancel);
			this.panelButtons.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new global::System.Drawing.Point(0, 456);
			this.panelButtons.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new global::System.Drawing.Size(1067, 70);
			this.panelButtons.TabIndex = 9;
			this.flatButtonSave.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonSave.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonSave.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonSave.Location = new global::System.Drawing.Point(516, 4);
			this.flatButtonSave.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatButtonSave.Name = "flatButtonSave";
			this.flatButtonSave.Rounded = false;
			this.flatButtonSave.Size = new global::System.Drawing.Size(140, 39);
			this.flatButtonSave.TabIndex = 0;
			this.flatButtonSave.Text = "✓Сохранить";
			this.flatButtonSave.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonSave.Click += new global::System.EventHandler(this.flatButtonSave_Click);
			this.flatButtonCancel.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonCancel.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonCancel.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonCancel.Location = new global::System.Drawing.Point(367, 4);
			this.flatButtonCancel.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatButtonCancel.Name = "flatButtonCancel";
			this.flatButtonCancel.Rounded = false;
			this.flatButtonCancel.Size = new global::System.Drawing.Size(140, 39);
			this.flatButtonCancel.TabIndex = 6;
			this.flatButtonCancel.Text = "❌ Отмена";
			this.flatButtonCancel.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonCancel.Click += new global::System.EventHandler(this.flatButtonCancel_Click);
			this.flatStatusBarMain.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatStatusBarMain.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.flatStatusBarMain.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatStatusBarMain.ForeColor = global::System.Drawing.Color.White;
			this.flatStatusBarMain.Location = new global::System.Drawing.Point(0, 526);
			this.flatStatusBarMain.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.flatStatusBarMain.MyTextColor = null;
			this.flatStatusBarMain.Name = "flatStatusBarMain";
			this.flatStatusBarMain.RectColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatStatusBarMain.ShowTimeDate = false;
			this.flatStatusBarMain.Size = new global::System.Drawing.Size(1067, 28);
			this.flatStatusBarMain.TabIndex = 0;
			this.flatStatusBarMain.TextColor = global::System.Drawing.Color.White;
			this.flatToggle1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatToggle1.Checked = false;
			this.flatToggle1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatToggle1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatToggle1.Location = new global::System.Drawing.Point(16, 170);
			this.flatToggle1.Name = "flatToggle1";
			this.flatToggle1.Options = global::FlatUI.FlatToggle._Options.Style1;
			this.flatToggle1.Size = new global::System.Drawing.Size(76, 33);
			this.flatToggle1.TabIndex = 18;
			this.flatToggle1.CheckedChanged += new global::FlatUI.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
			this.flatLabel4.AutoSize = true;
			this.flatLabel4.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel4.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel4.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel4.Location = new global::System.Drawing.Point(12, 148);
			this.flatLabel4.Name = "flatLabel4";
			this.flatLabel4.Size = new global::System.Drawing.Size(194, 19);
			this.flatLabel4.TabIndex = 19;
			this.flatLabel4.Text = "Добавить как одну позицию:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1067, 554);
			base.Controls.Add(this.formSkinProduct);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.Name = "EditProduct";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditProduct";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.EditProduct_Load);
			this.formSkinProduct.ResumeLayout(false);
			this.formSkinProduct.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000064 RID: 100
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000065 RID: 101
		private global::FlatUI.FormSkin formSkinProduct;

		// Token: 0x04000066 RID: 102
		private global::FlatUI.FlatStatusBar flatStatusBarMain;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Panel panelButtons;

		// Token: 0x04000068 RID: 104
		private global::FlatUI.FlatButton flatButtonSave;

		// Token: 0x04000069 RID: 105
		private global::FlatUI.FlatButton flatButtonCancel;

		// Token: 0x0400006A RID: 106
		private global::FlatUI.FlatTextBox flatTextBoxName;

		// Token: 0x0400006B RID: 107
		private global::FlatUI.FlatLabel flatLabel1;

		// Token: 0x0400006C RID: 108
		private global::FlatUI.FlatLabel flatLabel2;

		// Token: 0x0400006D RID: 109
		private global::FlatUI.FlatNumeric flatNumericPrice;

		// Token: 0x0400006E RID: 110
		private global::FlatUI.FlatTextBox flatTextBoxPositions;

		// Token: 0x0400006F RID: 111
		private global::FlatUI.FlatLabel flatLabelCategory;

		// Token: 0x04000070 RID: 112
		private global::FlatUI.FlatLabel flatLabel3;

		// Token: 0x04000071 RID: 113
		private global::FlatUI.FlatLabel flatLabel4;

		// Token: 0x04000072 RID: 114
		private global::FlatUI.FlatToggle flatToggle1;
	}
}
