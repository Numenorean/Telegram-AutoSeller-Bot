namespace TelegramBotBankStore
{
	// Token: 0x02000023 RID: 35
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00012C60 File Offset: 0x00010E60
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00012C98 File Offset: 0x00010E98
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new global::System.Windows.Forms.DataVisualization.Charting.ChartArea();
			global::System.Windows.Forms.DataVisualization.Charting.Legend legend = new global::System.Windows.Forms.DataVisualization.Charting.Legend();
			global::System.Windows.Forms.DataVisualization.Charting.Series series = new global::System.Windows.Forms.DataVisualization.Charting.Series();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TelegramBotBankStore.Main));
			this.formSkinMain = new global::FlatUI.FormSkin();
			this.flatMax1 = new global::FlatUI.FlatMax();
			this.flatTabControlMain = new global::FlatUI.FlatTabControl();
			this.tabPageAutorization = new global::System.Windows.Forms.TabPage();
			this.flatButtonUserEnter = new global::FlatUI.FlatButton();
			this.flatButtonUserChangePassword = new global::FlatUI.FlatButton();
			this.flatButtonUsers = new global::FlatUI.FlatButton();
			this.labelUserExit = new global::System.Windows.Forms.Label();
			this.flatComboBoxUsers = new global::FlatUI.FlatComboBox();
			this.flatLabel17 = new global::FlatUI.FlatLabel();
			this.flatTextBoxUserPassword = new global::FlatUI.FlatTextBox();
			this.flatLabel18 = new global::FlatUI.FlatLabel();
			this.tabPageMain = new global::System.Windows.Forms.TabPage();
			this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dataGridViewUsers = new global::System.Windows.Forms.DataGridView();
			this.panel24 = new global::System.Windows.Forms.Panel();
			this.flatTextBoxSearchUsername = new global::FlatUI.FlatTextBox();
			this.splitContainer2 = new global::System.Windows.Forms.SplitContainer();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.dataGridViewProductsUser = new global::System.Windows.Forms.DataGridView();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.dataGridViewTransactions = new global::System.Windows.Forms.DataGridView();
			this.tabPageCategory = new global::System.Windows.Forms.TabPage();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.treeViewCategories = new global::System.Windows.Forms.TreeView();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.flatButtonUpCategory = new global::FlatUI.FlatButton();
			this.flatButtonDownCategory = new global::FlatUI.FlatButton();
			this.flatButtonDeleteCategory = new global::FlatUI.FlatButton();
			this.flatButtonSaveCategory = new global::FlatUI.FlatButton();
			this.flatButtonAddCategory = new global::FlatUI.FlatButton();
			this.flatTextBoxCategoryName = new global::FlatUI.FlatTextBox();
			this.panel28 = new global::System.Windows.Forms.Panel();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.dataGridViewProducts = new global::System.Windows.Forms.DataGridView();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.flatButtonUpProduct = new global::FlatUI.FlatButton();
			this.flatButtonDownProduct = new global::FlatUI.FlatButton();
			this.flatButtonAddProduct = new global::FlatUI.FlatButton();
			this.tabPagePolicy = new global::System.Windows.Forms.TabPage();
			this.groupBox9 = new global::System.Windows.Forms.GroupBox();
			this.flatTextBoxPolicyValue = new global::FlatUI.FlatTextBox();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.panel11 = new global::System.Windows.Forms.Panel();
			this.groupBox8 = new global::System.Windows.Forms.GroupBox();
			this.dataGridViewPolicies = new global::System.Windows.Forms.DataGridView();
			this.panel12 = new global::System.Windows.Forms.Panel();
			this.flatButtonSavePolicy = new global::FlatUI.FlatButton();
			this.flatButtonAddPolicy = new global::FlatUI.FlatButton();
			this.flatTextBoxPolicyName = new global::FlatUI.FlatTextBox();
			this.tabPageSettings = new global::System.Windows.Forms.TabPage();
			this.groupBox19 = new global::System.Windows.Forms.GroupBox();
			this.cbIsNotFoundAvailable = new global::System.Windows.Forms.CheckBox();
			this.bNotFoundChennelTest = new global::FlatUI.FlatButton();
			this.tbNotFoundText = new global::FlatUI.FlatTextBox();
			this.tbNotFoundChennel = new global::FlatUI.FlatTextBox();
			this.label23 = new global::System.Windows.Forms.Label();
			this.groupBox17 = new global::System.Windows.Forms.GroupBox();
			this.IsReferalAvailable = new global::System.Windows.Forms.CheckBox();
			this.flatTextBoxReferral = new global::FlatUI.FlatTextBox();
			this.numericUpDownRefferal = new global::FlatUI.FlatNumeric();
			this.flatLabel30 = new global::FlatUI.FlatLabel();
			this.flatLabel29 = new global::FlatUI.FlatLabel();
			this.Exmo = new global::System.Windows.Forms.GroupBox();
			this.IsExmoAvailable1 = new global::System.Windows.Forms.CheckBox();
			this.flatButtonExmoInit = new global::FlatUI.FlatButton();
			this.flatTextBoxExmoKey = new global::FlatUI.FlatTextBox();
			this.flatLabel11 = new global::FlatUI.FlatLabel();
			this.flatTextBoxExmoSecret = new global::FlatUI.FlatTextBox();
			this.flatLabel12 = new global::FlatUI.FlatLabel();
			this.groupBox12 = new global::System.Windows.Forms.GroupBox();
			this.label27 = new global::System.Windows.Forms.Label();
			this.checkBoxApironePayLTC = new global::System.Windows.Forms.CheckBox();
			this.checkBoxApironePayBTC = new global::System.Windows.Forms.CheckBox();
			this.IsApironeAvailable = new global::System.Windows.Forms.CheckBox();
			this.flatButtonApirone = new global::FlatUI.FlatButton();
			this.flatTextBoxApironeBTCWallet = new global::FlatUI.FlatTextBox();
			this.flatLabel15 = new global::FlatUI.FlatLabel();
			this.flatTextBoxApironeLTCWallet = new global::FlatUI.FlatTextBox();
			this.flatLabel16 = new global::FlatUI.FlatLabel();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.flatLabel20 = new global::FlatUI.FlatLabel();
			this.flatButtonDeleteImage = new global::FlatUI.FlatButton();
			this.groupBox13 = new global::System.Windows.Forms.GroupBox();
			this.flatRadioButtonRUB = new global::FlatUI.FlatRadioButton();
			this.flatRadioButtonUSD = new global::FlatUI.FlatRadioButton();
			this.flatButtonSelectImage = new global::FlatUI.FlatButton();
			this.settingPictureBoxImage = new global::System.Windows.Forms.PictureBox();
			this.flatTextBoxPositionOutOfStock = new global::FlatUI.FlatTextBox();
			this.flatLabel3 = new global::FlatUI.FlatLabel();
			this.flatTextBoxGreeting = new global::FlatUI.FlatTextBox();
			this.flatLabel6 = new global::FlatUI.FlatLabel();
			this.groupBox10 = new global::System.Windows.Forms.GroupBox();
			this.flatButtonBlockChainArchiv = new global::FlatUI.FlatButton();
			this.label2 = new global::System.Windows.Forms.Label();
			this.flatButtonInitBlockchain = new global::FlatUI.FlatButton();
			this.flatTextBoxServiceHost = new global::FlatUI.FlatTextBox();
			this.flatLabel5 = new global::FlatUI.FlatLabel();
			this.flatTextBoxPassword = new global::FlatUI.FlatTextBox();
			this.flatLabel8 = new global::FlatUI.FlatLabel();
			this.flatTextBoxApiKey = new global::FlatUI.FlatTextBox();
			this.flatLabel9 = new global::FlatUI.FlatLabel();
			this.flatTextBoxIdWallet = new global::FlatUI.FlatTextBox();
			this.flatLabel10 = new global::FlatUI.FlatLabel();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.label22 = new global::System.Windows.Forms.Label();
			this.cbIsSendMoneyButtonAvailabile = new global::System.Windows.Forms.CheckBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.cbIsButtonAvailability = new global::System.Windows.Forms.CheckBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.cbIsButtonStatistic = new global::System.Windows.Forms.CheckBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.cbIsLockCheckPayment = new global::System.Windows.Forms.CheckBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.cbButtonIPaidForElse = new global::System.Windows.Forms.CheckBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.cbButtonIPaidForCard = new global::System.Windows.Forms.CheckBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.cbIsEnterAmountToBuy = new global::System.Windows.Forms.CheckBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.checkBoxIsButtonLanguageAvailable = new global::System.Windows.Forms.CheckBox();
			this.flatNumericTimeToCancelOrder = new global::FlatUI.FlatNumeric();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.checkBoxIsReservAndPayInTheEndAvailable = new global::System.Windows.Forms.CheckBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.checkBoxIsUserPayWalletAvailable = new global::System.Windows.Forms.CheckBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.IsReviewAvailable = new global::System.Windows.Forms.CheckBox();
			this.flatNumericDicountPayLTC = new global::FlatUI.FlatNumeric();
			this.label7 = new global::System.Windows.Forms.Label();
			this.flatNumericDicountPayBTC = new global::FlatUI.FlatNumeric();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.checkBoxIsWithoutLogin = new global::System.Windows.Forms.CheckBox();
			this.flatTextBoxCommandSupport = new global::FlatUI.FlatTextBox();
			this.flatLabel7 = new global::FlatUI.FlatLabel();
			this.flatTextBoxSupport = new global::FlatUI.FlatTextBox();
			this.flatLabel4 = new global::FlatUI.FlatLabel();
			this.flatButtonTestMessage = new global::FlatUI.FlatButton();
			this.flatTextBoxBotToken = new global::FlatUI.FlatTextBox();
			this.flatLabel2 = new global::FlatUI.FlatLabel();
			this.flatTextBoxChanell = new global::FlatUI.FlatTextBox();
			this.flatLabel1 = new global::FlatUI.FlatLabel();
			this.tabPageSettingQiwi = new global::System.Windows.Forms.TabPage();
			this.groupBox11 = new global::System.Windows.Forms.GroupBox();
			this.IsCardAvailable1 = new global::System.Windows.Forms.CheckBox();
			this.textBoxCard = new global::FlatUI.FlatTextBox();
			this.flatLabel22 = new global::FlatUI.FlatLabel();
			this.groupBox18 = new global::System.Windows.Forms.GroupBox();
			this.flatLabel32 = new global::FlatUI.FlatLabel();
			this.buttonTele2Init = new global::FlatUI.FlatButton();
			this.textBoxTele2Password = new global::FlatUI.FlatTextBox();
			this.IsTele2Available = new global::System.Windows.Forms.CheckBox();
			this.textBoxTele2Number = new global::FlatUI.FlatTextBox();
			this.flatLabel31 = new global::FlatUI.FlatLabel();
			this.groupBox14 = new global::System.Windows.Forms.GroupBox();
			this.flatLabel27 = new global::FlatUI.FlatLabel();
			this.textBoxYandexProxyName = new global::FlatUI.FlatTextBox();
			this.textBoxYandexProxyPort = new global::FlatUI.FlatTextBox();
			this.flatLabel28 = new global::FlatUI.FlatLabel();
			this.flatLabel26 = new global::FlatUI.FlatLabel();
			this.textBoxYansexRedirectUri = new global::FlatUI.FlatTextBox();
			this.IsYandexAvailable = new global::System.Windows.Forms.CheckBox();
			this.flatButton1 = new global::FlatUI.FlatButton();
			this.textBoxYandexAddress = new global::FlatUI.FlatTextBox();
			this.flatLabel24 = new global::FlatUI.FlatLabel();
			this.textBoxYansexClientId = new global::FlatUI.FlatTextBox();
			this.flatLabel25 = new global::FlatUI.FlatLabel();
			this.textNumber10 = new global::FlatUI.FlatTextBox();
			this.textAPI10 = new global::FlatUI.FlatTextBox();
			this.labelF10 = new global::System.Windows.Forms.Label();
			this.textPass10 = new global::FlatUI.FlatTextBox();
			this.textProxy10 = new global::FlatUI.FlatTextBox();
			this.textNumber9 = new global::FlatUI.FlatTextBox();
			this.textAPI9 = new global::FlatUI.FlatTextBox();
			this.labelF9 = new global::System.Windows.Forms.Label();
			this.textPass9 = new global::FlatUI.FlatTextBox();
			this.textProxy9 = new global::FlatUI.FlatTextBox();
			this.textNumber8 = new global::FlatUI.FlatTextBox();
			this.textAPI8 = new global::FlatUI.FlatTextBox();
			this.labelF8 = new global::System.Windows.Forms.Label();
			this.labelF7 = new global::System.Windows.Forms.Label();
			this.textNumber7 = new global::FlatUI.FlatTextBox();
			this.textAPI7 = new global::FlatUI.FlatTextBox();
			this.textPass8 = new global::FlatUI.FlatTextBox();
			this.textProxy8 = new global::FlatUI.FlatTextBox();
			this.textPass7 = new global::FlatUI.FlatTextBox();
			this.textProxy7 = new global::FlatUI.FlatTextBox();
			this.textNumber6 = new global::FlatUI.FlatTextBox();
			this.textAPI6 = new global::FlatUI.FlatTextBox();
			this.labelF6 = new global::System.Windows.Forms.Label();
			this.textPass6 = new global::FlatUI.FlatTextBox();
			this.textProxy6 = new global::FlatUI.FlatTextBox();
			this.textNumber5 = new global::FlatUI.FlatTextBox();
			this.textAPI5 = new global::FlatUI.FlatTextBox();
			this.labelF5 = new global::System.Windows.Forms.Label();
			this.textPass5 = new global::FlatUI.FlatTextBox();
			this.textProxy5 = new global::FlatUI.FlatTextBox();
			this.flatLabel19 = new global::FlatUI.FlatLabel();
			this.IsQiwiAvailable1 = new global::System.Windows.Forms.CheckBox();
			this.radioButtonIsQiwiNumber = new global::System.Windows.Forms.RadioButton();
			this.textNumber4 = new global::FlatUI.FlatTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.radioButtonIsQiwiCode = new global::System.Windows.Forms.RadioButton();
			this.flatButtonQiwiInit = new global::FlatUI.FlatButton();
			this.textAPI4 = new global::FlatUI.FlatTextBox();
			this.labelF4 = new global::System.Windows.Forms.Label();
			this.labelF3 = new global::System.Windows.Forms.Label();
			this.textNumber3 = new global::FlatUI.FlatTextBox();
			this.labelF2 = new global::System.Windows.Forms.Label();
			this.labelF1 = new global::System.Windows.Forms.Label();
			this.textAPI3 = new global::FlatUI.FlatTextBox();
			this.textNumber2 = new global::FlatUI.FlatTextBox();
			this.textPass4 = new global::FlatUI.FlatTextBox();
			this.textProxy4 = new global::FlatUI.FlatTextBox();
			this.textAPI2 = new global::FlatUI.FlatTextBox();
			this.textPass3 = new global::FlatUI.FlatTextBox();
			this.textProxy3 = new global::FlatUI.FlatTextBox();
			this.textNumber1 = new global::FlatUI.FlatTextBox();
			this.textPass2 = new global::FlatUI.FlatTextBox();
			this.flatLabel13 = new global::FlatUI.FlatLabel();
			this.textProxy2 = new global::FlatUI.FlatTextBox();
			this.textAPI1 = new global::FlatUI.FlatTextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.flatLabel14 = new global::FlatUI.FlatLabel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textPass1 = new global::FlatUI.FlatTextBox();
			this.textProxy1 = new global::FlatUI.FlatTextBox();
			this.tabPageSender = new global::System.Windows.Forms.TabPage();
			this.flatButtonSender = new global::FlatUI.FlatButton();
			this.flatTextBoxSender = new global::FlatUI.FlatTextBox();
			this.tabPageStatistic = new global::System.Windows.Forms.TabPage();
			this.bStatisticsCommonProduct = new global::FlatUI.FlatButton();
			this.bStatisticsCommonЗкщвгсе = new global::FlatUI.FlatButton();
			this.bStatisticsCommonCategories = new global::FlatUI.FlatButton();
			this.bStatisticsCommon = new global::FlatUI.FlatButton();
			this.flatLabel33 = new global::FlatUI.FlatLabel();
			this.bStatisticsPromoCodes = new global::FlatUI.FlatButton();
			this.flatButtonChart2 = new global::FlatUI.FlatButton();
			this.flatButtonChart1 = new global::FlatUI.FlatButton();
			this.chartStatistics = new global::System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPageReviwers = new global::System.Windows.Forms.TabPage();
			this.dataGridViewReviews = new global::System.Windows.Forms.DataGridView();
			this.tabPageAddButton = new global::System.Windows.Forms.TabPage();
			this.bTelegramPageSave = new global::FlatUI.FlatButton();
			this.groupBox16 = new global::System.Windows.Forms.GroupBox();
			this.tvTelegramPages = new global::System.Windows.Forms.TreeView();
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.bTelegramPagesDelete = new global::FlatUI.FlatButton();
			this.bTelegramPagesAdd = new global::FlatUI.FlatButton();
			this.tbTelegramPagesNameToAdd = new global::FlatUI.FlatTextBox();
			this.groupBoxTelegramPage = new global::System.Windows.Forms.GroupBox();
			this.lbTelegramPagePicPath = new global::System.Windows.Forms.Label();
			this.bTelegramPagePicDelete = new global::FlatUI.FlatButton();
			this.bTelegramPagePicSelect = new global::FlatUI.FlatButton();
			this.pbTelegramPagePic = new global::System.Windows.Forms.PictureBox();
			this.tbTelegramPageText = new global::FlatUI.FlatTextBox();
			this.flatLabel21 = new global::FlatUI.FlatLabel();
			this.cbIsTelegramPageAvailable = new global::System.Windows.Forms.CheckBox();
			this.tbTelegramPageName = new global::FlatUI.FlatTextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.tabPagePromoCodes = new global::System.Windows.Forms.TabPage();
			this.flatLabel23 = new global::FlatUI.FlatLabel();
			this.cbIsPromoCodeAvailable = new global::System.Windows.Forms.CheckBox();
			this.groupBox15 = new global::System.Windows.Forms.GroupBox();
			this.lbPromoCodeFrom = new global::System.Windows.Forms.Label();
			this.flatNumericPromocodeFrom = new global::FlatUI.FlatNumeric();
			this.flatButtonPromoCodeCopyRef = new global::FlatUI.FlatButton();
			this.flatNumericPromocodeMaxNumber = new global::FlatUI.FlatNumeric();
			this.label19 = new global::System.Windows.Forms.Label();
			this.flatButtonPromoCodeCopy = new global::FlatUI.FlatButton();
			this.label15 = new global::System.Windows.Forms.Label();
			this.labelPromoCodeValue = new global::System.Windows.Forms.Label();
			this.flatNumericPromocodeValue = new global::FlatUI.FlatNumeric();
			this.radioButtonPromoCodeDiscount = new global::System.Windows.Forms.RadioButton();
			this.radioButtonPromoCodeAddToWallet = new global::System.Windows.Forms.RadioButton();
			this.flatTextBoxPromoCode = new global::FlatUI.FlatTextBox();
			this.flatButtonGeneratePromoCodes = new global::FlatUI.FlatButton();
			this.dataGridViewPromoCodes = new global::System.Windows.Forms.DataGridView();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.bHistoryTransaction = new global::FlatUI.FlatButton();
			this.panel9 = new global::System.Windows.Forms.Panel();
			this.flatButtonRefreshBalance = new global::FlatUI.FlatButton();
			this.panel10 = new global::System.Windows.Forms.Panel();
			this.panel8 = new global::System.Windows.Forms.Panel();
			this.flatLabelBalance = new global::FlatUI.FlatLabel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.flatButtonStop = new global::FlatUI.FlatButton();
			this.flatButtonStart = new global::FlatUI.FlatButton();
			this.flatProgressBarMain = new global::FlatUI.FlatProgressBar();
			this.flatStatusBarMain = new global::FlatUI.FlatStatusBar();
			this.flatMini1 = new global::FlatUI.FlatMini();
			this.flatClose1 = new global::FlatUI.FlatClose();
			this.timerMain = new global::System.Windows.Forms.Timer(this.components);
			this.formSkinMain.SuspendLayout();
			this.flatTabControlMain.SuspendLayout();
			this.tabPageAutorization.SuspendLayout();
			this.tabPageMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewUsers).BeginInit();
			this.panel24.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewProductsUser).BeginInit();
			this.groupBox7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewTransactions).BeginInit();
			this.tabPageCategory.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewProducts).BeginInit();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.tabPagePolicy.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			this.groupBox8.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewPolicies).BeginInit();
			this.panel12.SuspendLayout();
			this.tabPageSettings.SuspendLayout();
			this.groupBox19.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.Exmo.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox13.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.settingPictureBoxImage).BeginInit();
			this.groupBox10.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPageSettingQiwi.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.tabPageSender.SuspendLayout();
			this.tabPageStatistic.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chartStatistics).BeginInit();
			this.tabPageReviwers.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewReviews).BeginInit();
			this.tabPageAddButton.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.panel6.SuspendLayout();
			this.groupBoxTelegramPage.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pbTelegramPagePic).BeginInit();
			this.tabPagePromoCodes.SuspendLayout();
			this.groupBox15.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewPromoCodes).BeginInit();
			this.panel1.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.formSkinMain.BackColor = global::System.Drawing.Color.White;
			this.formSkinMain.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkinMain.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkinMain.Controls.Add(this.flatMax1);
			this.formSkinMain.Controls.Add(this.flatTabControlMain);
			this.formSkinMain.Controls.Add(this.panel1);
			this.formSkinMain.Controls.Add(this.flatProgressBarMain);
			this.formSkinMain.Controls.Add(this.flatStatusBarMain);
			this.formSkinMain.Controls.Add(this.flatMini1);
			this.formSkinMain.Controls.Add(this.flatClose1);
			this.formSkinMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkinMain.FlatColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.formSkinMain.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkinMain.HeaderColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.formSkinMain.HeaderMaximize = false;
			this.formSkinMain.Location = new global::System.Drawing.Point(0, 0);
			this.formSkinMain.Name = "formSkinMain";
			this.formSkinMain.Padding = new global::System.Windows.Forms.Padding(0, 50, 0, 0);
			this.formSkinMain.Size = new global::System.Drawing.Size(1280, 768);
			this.formSkinMain.TabIndex = 0;
			this.formSkinMain.Text = "TelegramBotBankStore";
			this.flatMax1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMax1.BackColor = global::System.Drawing.Color.White;
			this.flatMax1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMax1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMax1.Location = new global::System.Drawing.Point(1226, 13);
			this.flatMax1.Name = "flatMax1";
			this.flatMax1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMax1.TabIndex = 1;
			this.flatMax1.Text = "flatMax1";
			this.flatMax1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatMax1.Click += new global::System.EventHandler(this.FlatMax1_Click);
			this.flatTabControlMain.ActiveColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatTabControlMain.Appearance = global::System.Windows.Forms.TabAppearance.FlatButtons;
			this.flatTabControlMain.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatTabControlMain.Controls.Add(this.tabPageAutorization);
			this.flatTabControlMain.Controls.Add(this.tabPageMain);
			this.flatTabControlMain.Controls.Add(this.tabPageCategory);
			this.flatTabControlMain.Controls.Add(this.tabPagePolicy);
			this.flatTabControlMain.Controls.Add(this.tabPageSettings);
			this.flatTabControlMain.Controls.Add(this.tabPageSettingQiwi);
			this.flatTabControlMain.Controls.Add(this.tabPageSender);
			this.flatTabControlMain.Controls.Add(this.tabPageStatistic);
			this.flatTabControlMain.Controls.Add(this.tabPageReviwers);
			this.flatTabControlMain.Controls.Add(this.tabPageAddButton);
			this.flatTabControlMain.Controls.Add(this.tabPagePromoCodes);
			this.flatTabControlMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flatTabControlMain.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatTabControlMain.ItemSize = new global::System.Drawing.Size(120, 40);
			this.flatTabControlMain.Location = new global::System.Drawing.Point(0, 116);
			this.flatTabControlMain.Name = "flatTabControlMain";
			this.flatTabControlMain.SelectedIndex = 0;
			this.flatTabControlMain.Size = new global::System.Drawing.Size(1280, 587);
			this.flatTabControlMain.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.flatTabControlMain.TabIndex = 3;
			this.flatTabControlMain.SelectedIndexChanged += new global::System.EventHandler(this.flatTabControlMain_SelectedIndexChanged);
			this.flatTabControlMain.Selecting += new global::System.Windows.Forms.TabControlCancelEventHandler(this.FlatTabControlMain_Selecting);
			this.tabPageAutorization.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageAutorization.Controls.Add(this.flatButtonUserEnter);
			this.tabPageAutorization.Controls.Add(this.flatButtonUserChangePassword);
			this.tabPageAutorization.Controls.Add(this.flatButtonUsers);
			this.tabPageAutorization.Controls.Add(this.labelUserExit);
			this.tabPageAutorization.Controls.Add(this.flatComboBoxUsers);
			this.tabPageAutorization.Controls.Add(this.flatLabel17);
			this.tabPageAutorization.Controls.Add(this.flatTextBoxUserPassword);
			this.tabPageAutorization.Controls.Add(this.flatLabel18);
			this.tabPageAutorization.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageAutorization.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabPageAutorization.Name = "tabPageAutorization";
			this.tabPageAutorization.Padding = new global::System.Windows.Forms.Padding(2);
			this.tabPageAutorization.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageAutorization.TabIndex = 0;
			this.tabPageAutorization.Text = "Авторизация";
			this.flatButtonUserEnter.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonUserEnter.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonUserEnter.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonUserEnter.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonUserEnter.Location = new global::System.Drawing.Point(530, 284);
			this.flatButtonUserEnter.Name = "flatButtonUserEnter";
			this.flatButtonUserEnter.Rounded = false;
			this.flatButtonUserEnter.Size = new global::System.Drawing.Size(303, 32);
			this.flatButtonUserEnter.TabIndex = 34;
			this.flatButtonUserEnter.Text = "Войти";
			this.flatButtonUserEnter.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonUserEnter.Click += new global::System.EventHandler(this.FlatButton1_Click);
			this.flatButtonUserChangePassword.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonUserChangePassword.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonUserChangePassword.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonUserChangePassword.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonUserChangePassword.Location = new global::System.Drawing.Point(7, 84);
			this.flatButtonUserChangePassword.Name = "flatButtonUserChangePassword";
			this.flatButtonUserChangePassword.Rounded = false;
			this.flatButtonUserChangePassword.Size = new global::System.Drawing.Size(158, 32);
			this.flatButtonUserChangePassword.TabIndex = 33;
			this.flatButtonUserChangePassword.Text = "Изменить пароль";
			this.flatButtonUserChangePassword.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonUserChangePassword.Click += new global::System.EventHandler(this.FlatButtonUserChangePassword_Click);
			this.flatButtonUsers.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonUsers.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonUsers.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonUsers.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonUsers.Location = new global::System.Drawing.Point(7, 123);
			this.flatButtonUsers.Name = "flatButtonUsers";
			this.flatButtonUsers.Rounded = false;
			this.flatButtonUsers.Size = new global::System.Drawing.Size(158, 32);
			this.flatButtonUsers.TabIndex = 32;
			this.flatButtonUsers.Text = "Юзеры";
			this.flatButtonUsers.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonUsers.Click += new global::System.EventHandler(this.FlatButtonUsers_Click);
			this.labelUserExit.AutoSize = true;
			this.labelUserExit.Font = new global::System.Drawing.Font("Segoe UI", 20f);
			this.labelUserExit.ForeColor = global::System.Drawing.Color.White;
			this.labelUserExit.Location = new global::System.Drawing.Point(40, 28);
			this.labelUserExit.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelUserExit.Name = "labelUserExit";
			this.labelUserExit.Size = new global::System.Drawing.Size(94, 37);
			this.labelUserExit.TabIndex = 31;
			this.labelUserExit.Text = "Выйти";
			this.labelUserExit.Visible = false;
			this.labelUserExit.Click += new global::System.EventHandler(this.LabelUserExit_Click);
			this.flatComboBoxUsers.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 48);
			this.flatComboBoxUsers.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatComboBoxUsers.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.flatComboBoxUsers.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.flatComboBoxUsers.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatComboBoxUsers.ForeColor = global::System.Drawing.Color.White;
			this.flatComboBoxUsers.FormattingEnabled = true;
			this.flatComboBoxUsers.HoverColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatComboBoxUsers.ItemHeight = 20;
			this.flatComboBoxUsers.Location = new global::System.Drawing.Point(530, 222);
			this.flatComboBoxUsers.Margin = new global::System.Windows.Forms.Padding(2);
			this.flatComboBoxUsers.Name = "flatComboBoxUsers";
			this.flatComboBoxUsers.Size = new global::System.Drawing.Size(304, 26);
			this.flatComboBoxUsers.TabIndex = 30;
			this.flatLabel17.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatLabel17.AutoSize = true;
			this.flatLabel17.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel17.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel17.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel17.Location = new global::System.Drawing.Point(476, 254);
			this.flatLabel17.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel17.Name = "flatLabel17";
			this.flatLabel17.Size = new global::System.Drawing.Size(50, 13);
			this.flatLabel17.TabIndex = 28;
			this.flatLabel17.Text = "Пароль:";
			this.flatTextBoxUserPassword.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxUserPassword.FocusOnHover = false;
			this.flatTextBoxUserPassword.Location = new global::System.Drawing.Point(530, 249);
			this.flatTextBoxUserPassword.MaxLength = 32767;
			this.flatTextBoxUserPassword.Multiline = false;
			this.flatTextBoxUserPassword.Name = "flatTextBoxUserPassword";
			this.flatTextBoxUserPassword.ReadOnly = false;
			this.flatTextBoxUserPassword.Size = new global::System.Drawing.Size(303, 29);
			this.flatTextBoxUserPassword.TabIndex = 29;
			this.flatTextBoxUserPassword.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxUserPassword.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxUserPassword.UseSystemPasswordChar = true;
			this.flatLabel18.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatLabel18.AutoSize = true;
			this.flatLabel18.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel18.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel18.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel18.Location = new global::System.Drawing.Point(476, 224);
			this.flatLabel18.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel18.Name = "flatLabel18";
			this.flatLabel18.Size = new global::System.Drawing.Size(39, 13);
			this.flatLabel18.TabIndex = 26;
			this.flatLabel18.Text = "Юзер:";
			this.tabPageMain.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageMain.Controls.Add(this.splitContainer1);
			this.tabPageMain.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageMain.Name = "tabPageMain";
			this.tabPageMain.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageMain.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageMain.TabIndex = 5;
			this.tabPageMain.Text = "Главная";
			this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new global::System.Drawing.Point(3, 3);
			this.splitContainer1.Margin = new global::System.Windows.Forms.Padding(2);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new global::System.Drawing.Size(1266, 533);
			this.splitContainer1.SplitterDistance = 448;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 22;
			this.groupBox1.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.groupBox1.Controls.Add(this.dataGridViewUsers);
			this.groupBox1.Controls.Add(this.panel24);
			this.groupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox1.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(448, 533);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Пользователи";
			this.dataGridViewUsers.AllowUserToAddRows = false;
			this.dataGridViewUsers.AllowUserToDeleteRows = false;
			this.dataGridViewUsers.AllowUserToResizeRows = false;
			this.dataGridViewUsers.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridViewUsers.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewUsers.Location = new global::System.Drawing.Point(3, 59);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.ReadOnly = true;
			this.dataGridViewUsers.RowHeadersVisible = false;
			this.dataGridViewUsers.RowHeadersWidth = 51;
			this.dataGridViewUsers.Size = new global::System.Drawing.Size(442, 471);
			this.dataGridViewUsers.TabIndex = 14;
			this.dataGridViewUsers.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
			this.panel24.Controls.Add(this.flatTextBoxSearchUsername);
			this.panel24.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel24.Location = new global::System.Drawing.Point(3, 21);
			this.panel24.Name = "panel24";
			this.panel24.Padding = new global::System.Windows.Forms.Padding(3, 0, 3, 0);
			this.panel24.Size = new global::System.Drawing.Size(442, 38);
			this.panel24.TabIndex = 13;
			this.flatTextBoxSearchUsername.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxSearchUsername.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxSearchUsername.FocusOnHover = false;
			this.flatTextBoxSearchUsername.Location = new global::System.Drawing.Point(3, 4);
			this.flatTextBoxSearchUsername.Margin = new global::System.Windows.Forms.Padding(0, 3, 3, 3);
			this.flatTextBoxSearchUsername.MaxLength = 32767;
			this.flatTextBoxSearchUsername.Multiline = false;
			this.flatTextBoxSearchUsername.Name = "flatTextBoxSearchUsername";
			this.flatTextBoxSearchUsername.ReadOnly = false;
			this.flatTextBoxSearchUsername.Size = new global::System.Drawing.Size(261, 29);
			this.flatTextBoxSearchUsername.TabIndex = 0;
			this.flatTextBoxSearchUsername.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxSearchUsername.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxSearchUsername.UseSystemPasswordChar = false;
			this.flatTextBoxSearchUsername.TextChanged += new global::System.EventHandler(this.flatTextBoxSearchUsername_TextChanged);
			this.splitContainer2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new global::System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new global::System.Windows.Forms.Padding(2);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
			this.splitContainer2.Panel1.Controls.Add(this.groupBox6);
			this.splitContainer2.Panel2.Controls.Add(this.groupBox7);
			this.splitContainer2.Size = new global::System.Drawing.Size(817, 533);
			this.splitContainer2.SplitterDistance = 160;
			this.splitContainer2.SplitterWidth = 1;
			this.splitContainer2.TabIndex = 23;
			this.groupBox6.Controls.Add(this.dataGridViewProductsUser);
			this.groupBox6.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox6.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox6.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox6.Location = new global::System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(817, 160);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Покупки";
			this.dataGridViewProductsUser.AllowUserToAddRows = false;
			this.dataGridViewProductsUser.AllowUserToDeleteRows = false;
			this.dataGridViewProductsUser.AllowUserToResizeRows = false;
			this.dataGridViewProductsUser.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridViewProductsUser.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridViewProductsUser.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductsUser.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewProductsUser.Location = new global::System.Drawing.Point(3, 21);
			this.dataGridViewProductsUser.Name = "dataGridViewProductsUser";
			this.dataGridViewProductsUser.ReadOnly = true;
			this.dataGridViewProductsUser.RowHeadersVisible = false;
			this.dataGridViewProductsUser.RowHeadersWidth = 51;
			this.dataGridViewProductsUser.Size = new global::System.Drawing.Size(811, 136);
			this.dataGridViewProductsUser.TabIndex = 14;
			this.dataGridViewProductsUser.CellMouseClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProductsUser_CellMouseClick);
			this.groupBox7.Controls.Add(this.dataGridViewTransactions);
			this.groupBox7.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox7.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox7.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox7.Location = new global::System.Drawing.Point(0, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(817, 372);
			this.groupBox7.TabIndex = 22;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Транзакции";
			this.dataGridViewTransactions.AllowUserToAddRows = false;
			this.dataGridViewTransactions.AllowUserToDeleteRows = false;
			this.dataGridViewTransactions.AllowUserToResizeRows = false;
			this.dataGridViewTransactions.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridViewTransactions.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTransactions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTransactions.Location = new global::System.Drawing.Point(3, 21);
			this.dataGridViewTransactions.Name = "dataGridViewTransactions";
			this.dataGridViewTransactions.ReadOnly = true;
			this.dataGridViewTransactions.RowHeadersVisible = false;
			this.dataGridViewTransactions.RowHeadersWidth = 51;
			this.dataGridViewTransactions.Size = new global::System.Drawing.Size(811, 348);
			this.dataGridViewTransactions.TabIndex = 14;
			this.tabPageCategory.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageCategory.Controls.Add(this.groupBox4);
			this.tabPageCategory.Controls.Add(this.panel28);
			this.tabPageCategory.Controls.Add(this.groupBox5);
			this.tabPageCategory.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageCategory.Name = "tabPageCategory";
			this.tabPageCategory.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageCategory.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageCategory.TabIndex = 2;
			this.tabPageCategory.Text = "Товары";
			this.groupBox4.Controls.Add(this.treeViewCategories);
			this.groupBox4.Controls.Add(this.panel3);
			this.groupBox4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox4.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox4.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(663, 533);
			this.groupBox4.TabIndex = 17;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Категория";
			this.treeViewCategories.BackColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.treeViewCategories.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.treeViewCategories.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeViewCategories.ForeColor = global::System.Drawing.Color.White;
			this.treeViewCategories.HideSelection = false;
			this.treeViewCategories.LineColor = global::System.Drawing.Color.FromArgb(25, 27, 29);
			this.treeViewCategories.Location = new global::System.Drawing.Point(3, 59);
			this.treeViewCategories.Name = "treeViewCategories";
			this.treeViewCategories.Size = new global::System.Drawing.Size(657, 471);
			this.treeViewCategories.TabIndex = 18;
			this.treeViewCategories.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
			this.panel3.Controls.Add(this.flatButtonUpCategory);
			this.panel3.Controls.Add(this.flatButtonDownCategory);
			this.panel3.Controls.Add(this.flatButtonDeleteCategory);
			this.panel3.Controls.Add(this.flatButtonSaveCategory);
			this.panel3.Controls.Add(this.flatButtonAddCategory);
			this.panel3.Controls.Add(this.flatTextBoxCategoryName);
			this.panel3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new global::System.Drawing.Point(3, 21);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new global::System.Windows.Forms.Padding(3, 0, 3, 0);
			this.panel3.Size = new global::System.Drawing.Size(657, 38);
			this.panel3.TabIndex = 13;
			this.flatButtonUpCategory.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonUpCategory.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonUpCategory.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonUpCategory.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonUpCategory.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonUpCategory.Location = new global::System.Drawing.Point(541, 3);
			this.flatButtonUpCategory.Name = "flatButtonUpCategory";
			this.flatButtonUpCategory.Rounded = false;
			this.flatButtonUpCategory.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonUpCategory.TabIndex = 23;
			this.flatButtonUpCategory.Text = "⬆U";
			this.flatButtonUpCategory.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonUpCategory.Click += new global::System.EventHandler(this.flatButtonUpCategory_Click);
			this.flatButtonDownCategory.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonDownCategory.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonDownCategory.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonDownCategory.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonDownCategory.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonDownCategory.Location = new global::System.Drawing.Point(580, 3);
			this.flatButtonDownCategory.Name = "flatButtonDownCategory";
			this.flatButtonDownCategory.Rounded = false;
			this.flatButtonDownCategory.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonDownCategory.TabIndex = 22;
			this.flatButtonDownCategory.Text = "⬇D";
			this.flatButtonDownCategory.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonDownCategory.Click += new global::System.EventHandler(this.flatButtonDownCategory_Click);
			this.flatButtonDeleteCategory.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonDeleteCategory.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonDeleteCategory.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonDeleteCategory.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonDeleteCategory.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonDeleteCategory.Location = new global::System.Drawing.Point(619, 3);
			this.flatButtonDeleteCategory.Name = "flatButtonDeleteCategory";
			this.flatButtonDeleteCategory.Rounded = false;
			this.flatButtonDeleteCategory.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonDeleteCategory.TabIndex = 19;
			this.flatButtonDeleteCategory.Text = "X";
			this.flatButtonDeleteCategory.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonDeleteCategory.Click += new global::System.EventHandler(this.flatButtonDeleteCategory_Click);
			this.flatButtonSaveCategory.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonSaveCategory.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonSaveCategory.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonSaveCategory.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonSaveCategory.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonSaveCategory.Location = new global::System.Drawing.Point(502, 3);
			this.flatButtonSaveCategory.Name = "flatButtonSaveCategory";
			this.flatButtonSaveCategory.Rounded = false;
			this.flatButtonSaveCategory.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonSaveCategory.TabIndex = 8;
			this.flatButtonSaveCategory.Text = "✓";
			this.flatButtonSaveCategory.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonSaveCategory.Click += new global::System.EventHandler(this.flatButtonSaveCategory_Click);
			this.flatButtonAddCategory.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonAddCategory.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonAddCategory.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonAddCategory.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonAddCategory.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonAddCategory.Location = new global::System.Drawing.Point(463, 3);
			this.flatButtonAddCategory.Name = "flatButtonAddCategory";
			this.flatButtonAddCategory.Rounded = false;
			this.flatButtonAddCategory.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonAddCategory.TabIndex = 7;
			this.flatButtonAddCategory.Text = "+";
			this.flatButtonAddCategory.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonAddCategory.Click += new global::System.EventHandler(this.flatButtonAddCategory_Click);
			this.flatTextBoxCategoryName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxCategoryName.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxCategoryName.FocusOnHover = false;
			this.flatTextBoxCategoryName.Location = new global::System.Drawing.Point(3, 6);
			this.flatTextBoxCategoryName.MaxLength = 32767;
			this.flatTextBoxCategoryName.Multiline = false;
			this.flatTextBoxCategoryName.Name = "flatTextBoxCategoryName";
			this.flatTextBoxCategoryName.ReadOnly = false;
			this.flatTextBoxCategoryName.Size = new global::System.Drawing.Size(454, 29);
			this.flatTextBoxCategoryName.TabIndex = 0;
			this.flatTextBoxCategoryName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxCategoryName.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxCategoryName.UseSystemPasswordChar = false;
			this.panel28.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel28.Location = new global::System.Drawing.Point(666, 3);
			this.panel28.Name = "panel28";
			this.panel28.Size = new global::System.Drawing.Size(6, 533);
			this.panel28.TabIndex = 18;
			this.groupBox5.Controls.Add(this.dataGridViewProducts);
			this.groupBox5.Controls.Add(this.panel4);
			this.groupBox5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.groupBox5.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox5.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox5.Location = new global::System.Drawing.Point(672, 3);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(597, 533);
			this.groupBox5.TabIndex = 19;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Товар";
			this.dataGridViewProducts.AllowUserToAddRows = false;
			this.dataGridViewProducts.AllowUserToDeleteRows = false;
			this.dataGridViewProducts.AllowUserToResizeRows = false;
			this.dataGridViewProducts.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridViewProducts.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewProducts.Location = new global::System.Drawing.Point(3, 59);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.ReadOnly = true;
			this.dataGridViewProducts.RowHeadersVisible = false;
			this.dataGridViewProducts.RowHeadersWidth = 51;
			this.dataGridViewProducts.Size = new global::System.Drawing.Size(591, 471);
			this.dataGridViewProducts.TabIndex = 15;
			this.dataGridViewProducts.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new global::System.Drawing.Point(3, 21);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new global::System.Windows.Forms.Padding(3, 0, 3, 0);
			this.panel4.Size = new global::System.Drawing.Size(591, 38);
			this.panel4.TabIndex = 13;
			this.panel5.Controls.Add(this.flatButtonUpProduct);
			this.panel5.Controls.Add(this.flatButtonDownProduct);
			this.panel5.Controls.Add(this.flatButtonAddProduct);
			this.panel5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new global::System.Drawing.Point(430, 0);
			this.panel5.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(158, 38);
			this.panel5.TabIndex = 8;
			this.flatButtonUpProduct.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonUpProduct.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonUpProduct.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonUpProduct.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonUpProduct.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonUpProduct.Location = new global::System.Drawing.Point(45, 3);
			this.flatButtonUpProduct.Name = "flatButtonUpProduct";
			this.flatButtonUpProduct.Rounded = false;
			this.flatButtonUpProduct.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonUpProduct.TabIndex = 25;
			this.flatButtonUpProduct.Text = "⬆U";
			this.flatButtonUpProduct.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonUpProduct.Click += new global::System.EventHandler(this.flatButtonUpProduct_Click);
			this.flatButtonDownProduct.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonDownProduct.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonDownProduct.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonDownProduct.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonDownProduct.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonDownProduct.Location = new global::System.Drawing.Point(83, 3);
			this.flatButtonDownProduct.Name = "flatButtonDownProduct";
			this.flatButtonDownProduct.Rounded = false;
			this.flatButtonDownProduct.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonDownProduct.TabIndex = 24;
			this.flatButtonDownProduct.Text = "⬇D";
			this.flatButtonDownProduct.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonDownProduct.Click += new global::System.EventHandler(this.flatButtonDownProduct_Click);
			this.flatButtonAddProduct.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonAddProduct.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonAddProduct.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonAddProduct.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonAddProduct.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonAddProduct.Location = new global::System.Drawing.Point(122, 3);
			this.flatButtonAddProduct.Name = "flatButtonAddProduct";
			this.flatButtonAddProduct.Rounded = false;
			this.flatButtonAddProduct.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonAddProduct.TabIndex = 7;
			this.flatButtonAddProduct.Text = "+";
			this.flatButtonAddProduct.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonAddProduct.Click += new global::System.EventHandler(this.flatButtonAddProduct_Click);
			this.tabPagePolicy.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPagePolicy.Controls.Add(this.groupBox9);
			this.tabPagePolicy.Controls.Add(this.panel11);
			this.tabPagePolicy.Controls.Add(this.groupBox8);
			this.tabPagePolicy.Location = new global::System.Drawing.Point(4, 44);
			this.tabPagePolicy.Name = "tabPagePolicy";
			this.tabPagePolicy.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPagePolicy.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPagePolicy.TabIndex = 3;
			this.tabPagePolicy.Text = "Доп. инф.";
			this.groupBox9.Controls.Add(this.flatTextBoxPolicyValue);
			this.groupBox9.Controls.Add(this.dataGridView1);
			this.groupBox9.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox9.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox9.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox9.Location = new global::System.Drawing.Point(303, 3);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new global::System.Drawing.Size(966, 533);
			this.groupBox9.TabIndex = 19;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Текст";
			this.flatTextBoxPolicyValue.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxPolicyValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flatTextBoxPolicyValue.FocusOnHover = false;
			this.flatTextBoxPolicyValue.Location = new global::System.Drawing.Point(3, 21);
			this.flatTextBoxPolicyValue.MaxLength = 32767;
			this.flatTextBoxPolicyValue.Multiline = true;
			this.flatTextBoxPolicyValue.Name = "flatTextBoxPolicyValue";
			this.flatTextBoxPolicyValue.ReadOnly = false;
			this.flatTextBoxPolicyValue.Size = new global::System.Drawing.Size(960, 509);
			this.flatTextBoxPolicyValue.TabIndex = 16;
			this.flatTextBoxPolicyValue.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxPolicyValue.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxPolicyValue.UseSystemPasswordChar = false;
			this.flatTextBoxPolicyValue.TextChanged += new global::System.EventHandler(this.flatTextBoxPolicyValue_TextChanged);
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new global::System.Drawing.Point(3, 21);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new global::System.Drawing.Size(960, 509);
			this.dataGridView1.TabIndex = 15;
			this.panel11.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel11.Location = new global::System.Drawing.Point(297, 3);
			this.panel11.Name = "panel11";
			this.panel11.Size = new global::System.Drawing.Size(6, 533);
			this.panel11.TabIndex = 20;
			this.groupBox8.Controls.Add(this.dataGridViewPolicies);
			this.groupBox8.Controls.Add(this.panel12);
			this.groupBox8.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.groupBox8.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox8.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox8.Location = new global::System.Drawing.Point(3, 3);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new global::System.Drawing.Size(294, 533);
			this.groupBox8.TabIndex = 18;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Кнопки";
			this.dataGridViewPolicies.AllowUserToAddRows = false;
			this.dataGridViewPolicies.AllowUserToDeleteRows = false;
			this.dataGridViewPolicies.AllowUserToResizeRows = false;
			this.dataGridViewPolicies.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridViewPolicies.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridViewPolicies.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPolicies.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewPolicies.Location = new global::System.Drawing.Point(3, 59);
			this.dataGridViewPolicies.Name = "dataGridViewPolicies";
			this.dataGridViewPolicies.ReadOnly = true;
			this.dataGridViewPolicies.RowHeadersVisible = false;
			this.dataGridViewPolicies.RowHeadersWidth = 51;
			this.dataGridViewPolicies.Size = new global::System.Drawing.Size(288, 471);
			this.dataGridViewPolicies.TabIndex = 15;
			this.dataGridViewPolicies.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolicies_CellClick);
			this.panel12.Controls.Add(this.flatButtonSavePolicy);
			this.panel12.Controls.Add(this.flatButtonAddPolicy);
			this.panel12.Controls.Add(this.flatTextBoxPolicyName);
			this.panel12.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel12.Location = new global::System.Drawing.Point(3, 21);
			this.panel12.Name = "panel12";
			this.panel12.Padding = new global::System.Windows.Forms.Padding(3, 0, 3, 0);
			this.panel12.Size = new global::System.Drawing.Size(288, 38);
			this.panel12.TabIndex = 16;
			this.flatButtonSavePolicy.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonSavePolicy.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonSavePolicy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonSavePolicy.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonSavePolicy.Location = new global::System.Drawing.Point(247, 0);
			this.flatButtonSavePolicy.Name = "flatButtonSavePolicy";
			this.flatButtonSavePolicy.Rounded = false;
			this.flatButtonSavePolicy.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonSavePolicy.TabIndex = 8;
			this.flatButtonSavePolicy.Text = "✓";
			this.flatButtonSavePolicy.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonSavePolicy.Click += new global::System.EventHandler(this.flatButtonSavePolicy_Click);
			this.flatButtonAddPolicy.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonAddPolicy.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonAddPolicy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonAddPolicy.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonAddPolicy.Location = new global::System.Drawing.Point(206, 0);
			this.flatButtonAddPolicy.Name = "flatButtonAddPolicy";
			this.flatButtonAddPolicy.Rounded = false;
			this.flatButtonAddPolicy.Size = new global::System.Drawing.Size(35, 32);
			this.flatButtonAddPolicy.TabIndex = 7;
			this.flatButtonAddPolicy.Text = "+";
			this.flatButtonAddPolicy.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonAddPolicy.Click += new global::System.EventHandler(this.flatButtonAddPolicy_Click);
			this.flatTextBoxPolicyName.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxPolicyName.FocusOnHover = false;
			this.flatTextBoxPolicyName.Location = new global::System.Drawing.Point(0, 3);
			this.flatTextBoxPolicyName.MaxLength = 32767;
			this.flatTextBoxPolicyName.Multiline = false;
			this.flatTextBoxPolicyName.Name = "flatTextBoxPolicyName";
			this.flatTextBoxPolicyName.ReadOnly = false;
			this.flatTextBoxPolicyName.Size = new global::System.Drawing.Size(200, 29);
			this.flatTextBoxPolicyName.TabIndex = 0;
			this.flatTextBoxPolicyName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxPolicyName.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxPolicyName.UseSystemPasswordChar = false;
			this.tabPageSettings.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageSettings.Controls.Add(this.groupBox19);
			this.tabPageSettings.Controls.Add(this.groupBox17);
			this.tabPageSettings.Controls.Add(this.Exmo);
			this.tabPageSettings.Controls.Add(this.groupBox12);
			this.tabPageSettings.Controls.Add(this.groupBox3);
			this.tabPageSettings.Controls.Add(this.groupBox10);
			this.tabPageSettings.Controls.Add(this.groupBox2);
			this.tabPageSettings.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageSettings.Name = "tabPageSettings";
			this.tabPageSettings.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPageSettings.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageSettings.TabIndex = 1;
			this.tabPageSettings.Text = "Настройки";
			this.groupBox19.Controls.Add(this.cbIsNotFoundAvailable);
			this.groupBox19.Controls.Add(this.bNotFoundChennelTest);
			this.groupBox19.Controls.Add(this.tbNotFoundText);
			this.groupBox19.Controls.Add(this.tbNotFoundChennel);
			this.groupBox19.Controls.Add(this.label23);
			this.groupBox19.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox19.Location = new global::System.Drawing.Point(358, 392);
			this.groupBox19.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox19.Size = new global::System.Drawing.Size(367, 86);
			this.groupBox19.TabIndex = 75;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "      Ненаход";
			this.cbIsNotFoundAvailable.AutoSize = true;
			this.cbIsNotFoundAvailable.Location = new global::System.Drawing.Point(8, 2);
			this.cbIsNotFoundAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsNotFoundAvailable.Name = "cbIsNotFoundAvailable";
			this.cbIsNotFoundAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsNotFoundAvailable.TabIndex = 70;
			this.cbIsNotFoundAvailable.UseVisualStyleBackColor = true;
			this.cbIsNotFoundAvailable.CheckedChanged += new global::System.EventHandler(this.cbIsNotFoundAvailable_CheckedChanged);
			this.bNotFoundChennelTest.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bNotFoundChennelTest.BackColor = global::System.Drawing.Color.Transparent;
			this.bNotFoundChennelTest.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bNotFoundChennelTest.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bNotFoundChennelTest.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.bNotFoundChennelTest.Location = new global::System.Drawing.Point(296, 50);
			this.bNotFoundChennelTest.Name = "bNotFoundChennelTest";
			this.bNotFoundChennelTest.Rounded = false;
			this.bNotFoundChennelTest.Size = new global::System.Drawing.Size(66, 29);
			this.bNotFoundChennelTest.TabIndex = 74;
			this.bNotFoundChennelTest.Text = "→ Тест";
			this.bNotFoundChennelTest.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bNotFoundChennelTest.Click += new global::System.EventHandler(this.bNotFoundChennelTest_Click);
			this.tbNotFoundText.BackColor = global::System.Drawing.Color.Transparent;
			this.tbNotFoundText.FocusOnHover = false;
			this.tbNotFoundText.Location = new global::System.Drawing.Point(6, 19);
			this.tbNotFoundText.MaxLength = 32767;
			this.tbNotFoundText.Multiline = true;
			this.tbNotFoundText.Name = "tbNotFoundText";
			this.tbNotFoundText.ReadOnly = false;
			this.tbNotFoundText.Size = new global::System.Drawing.Size(356, 27);
			this.tbNotFoundText.TabIndex = 66;
			this.tbNotFoundText.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.tbNotFoundText.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.tbNotFoundText.UseSystemPasswordChar = false;
			this.tbNotFoundText.TextChanged += new global::System.EventHandler(this.tbNotFoundText_TextChanged);
			this.tbNotFoundChennel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tbNotFoundChennel.BackColor = global::System.Drawing.Color.Transparent;
			this.tbNotFoundChennel.FocusOnHover = false;
			this.tbNotFoundChennel.Location = new global::System.Drawing.Point(130, 52);
			this.tbNotFoundChennel.MaxLength = 32767;
			this.tbNotFoundChennel.Multiline = false;
			this.tbNotFoundChennel.Name = "tbNotFoundChennel";
			this.tbNotFoundChennel.ReadOnly = false;
			this.tbNotFoundChennel.Size = new global::System.Drawing.Size(157, 29);
			this.tbNotFoundChennel.TabIndex = 72;
			this.tbNotFoundChennel.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.tbNotFoundChennel.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.tbNotFoundChennel.UseSystemPasswordChar = false;
			this.tbNotFoundChennel.TextChanged += new global::System.EventHandler(this.tbNotFoundChennel_TextChanged);
			this.label23.AutoSize = true;
			this.label23.ForeColor = global::System.Drawing.Color.White;
			this.label23.Location = new global::System.Drawing.Point(4, 55);
			this.label23.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(129, 19);
			this.label23.TabIndex = 73;
			this.label23.Text = "Канал для репоста:";
			this.groupBox17.Controls.Add(this.IsReferalAvailable);
			this.groupBox17.Controls.Add(this.flatTextBoxReferral);
			this.groupBox17.Controls.Add(this.numericUpDownRefferal);
			this.groupBox17.Controls.Add(this.flatLabel30);
			this.groupBox17.Controls.Add(this.flatLabel29);
			this.groupBox17.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox17.Location = new global::System.Drawing.Point(730, 334);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new global::System.Drawing.Size(368, 145);
			this.groupBox17.TabIndex = 65;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "      Реферальные начисления";
			this.IsReferalAvailable.AutoSize = true;
			this.IsReferalAvailable.Location = new global::System.Drawing.Point(8, 4);
			this.IsReferalAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsReferalAvailable.Name = "IsReferalAvailable";
			this.IsReferalAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.IsReferalAvailable.TabIndex = 64;
			this.IsReferalAvailable.UseVisualStyleBackColor = true;
			this.IsReferalAvailable.CheckedChanged += new global::System.EventHandler(this.IsReferalAvailable_CheckedChanged);
			this.flatTextBoxReferral.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxReferral.FocusOnHover = false;
			this.flatTextBoxReferral.Location = new global::System.Drawing.Point(8, 62);
			this.flatTextBoxReferral.MaxLength = 32767;
			this.flatTextBoxReferral.Multiline = true;
			this.flatTextBoxReferral.Name = "flatTextBoxReferral";
			this.flatTextBoxReferral.ReadOnly = false;
			this.flatTextBoxReferral.Size = new global::System.Drawing.Size(355, 72);
			this.flatTextBoxReferral.TabIndex = 62;
			this.flatTextBoxReferral.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxReferral.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxReferral.UseSystemPasswordChar = false;
			this.flatTextBoxReferral.TextChanged += new global::System.EventHandler(this.flatTextBoxReferral_TextChanged);
			this.numericUpDownRefferal.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.numericUpDownRefferal.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.numericUpDownRefferal.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.numericUpDownRefferal.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.numericUpDownRefferal.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDownRefferal.Location = new global::System.Drawing.Point(202, 15);
			this.numericUpDownRefferal.Margin = new global::System.Windows.Forms.Padding(2);
			global::FlatUI.FlatNumeric flatNumeric = this.numericUpDownRefferal;
			int[] array = new int[4];
			array[0] = 9999999;
			flatNumeric.Maximum = new decimal(array);
			this.numericUpDownRefferal.Minimum = new decimal(new int[4]);
			this.numericUpDownRefferal.Name = "numericUpDownRefferal";
			this.numericUpDownRefferal.Size = new global::System.Drawing.Size(74, 30);
			this.numericUpDownRefferal.TabIndex = 63;
			this.numericUpDownRefferal.Text = "flatNumeric1";
			this.numericUpDownRefferal.Value = new decimal(new int[4]);
			this.numericUpDownRefferal.Click += new global::System.EventHandler(this.numericUpDownRefferal_Click);
			this.flatLabel30.AutoSize = true;
			this.flatLabel30.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel30.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel30.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel30.Location = new global::System.Drawing.Point(5, 41);
			this.flatLabel30.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel30.Name = "flatLabel30";
			this.flatLabel30.Size = new global::System.Drawing.Size(216, 13);
			this.flatLabel30.TabIndex = 61;
			this.flatLabel30.Text = "Текст сообщения реферального меню:";
			this.flatLabel29.AutoSize = true;
			this.flatLabel29.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel29.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel29.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel29.Location = new global::System.Drawing.Point(5, 24);
			this.flatLabel29.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel29.Name = "flatLabel29";
			this.flatLabel29.Size = new global::System.Drawing.Size(74, 13);
			this.flatLabel29.TabIndex = 59;
			this.flatLabel29.Text = "Реферала %:";
			this.Exmo.Controls.Add(this.IsExmoAvailable1);
			this.Exmo.Controls.Add(this.flatButtonExmoInit);
			this.Exmo.Controls.Add(this.flatTextBoxExmoKey);
			this.Exmo.Controls.Add(this.flatLabel11);
			this.Exmo.Controls.Add(this.flatTextBoxExmoSecret);
			this.Exmo.Controls.Add(this.flatLabel12);
			this.Exmo.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.Exmo.Location = new global::System.Drawing.Point(358, 306);
			this.Exmo.Margin = new global::System.Windows.Forms.Padding(2);
			this.Exmo.Name = "Exmo";
			this.Exmo.Padding = new global::System.Windows.Forms.Padding(2);
			this.Exmo.Size = new global::System.Drawing.Size(367, 84);
			this.Exmo.TabIndex = 42;
			this.Exmo.TabStop = false;
			this.Exmo.Text = "      Exmo";
			this.IsExmoAvailable1.AutoSize = true;
			this.IsExmoAvailable1.Location = new global::System.Drawing.Point(10, 2);
			this.IsExmoAvailable1.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsExmoAvailable1.Name = "IsExmoAvailable1";
			this.IsExmoAvailable1.Size = new global::System.Drawing.Size(15, 14);
			this.IsExmoAvailable1.TabIndex = 40;
			this.IsExmoAvailable1.UseVisualStyleBackColor = true;
			this.IsExmoAvailable1.CheckedChanged += new global::System.EventHandler(this.IsExmoAvailable_CheckedChanged);
			this.flatButtonExmoInit.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonExmoInit.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonExmoInit.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonExmoInit.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonExmoInit.Location = new global::System.Drawing.Point(222, 52);
			this.flatButtonExmoInit.Name = "flatButtonExmoInit";
			this.flatButtonExmoInit.Rounded = false;
			this.flatButtonExmoInit.Size = new global::System.Drawing.Size(139, 29);
			this.flatButtonExmoInit.TabIndex = 38;
			this.flatButtonExmoInit.Text = "→ Подключиться";
			this.flatButtonExmoInit.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonExmoInit.Click += new global::System.EventHandler(this.flatButtonExmoInit_Click);
			this.flatTextBoxExmoKey.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxExmoKey.FocusOnHover = false;
			this.flatTextBoxExmoKey.Location = new global::System.Drawing.Point(81, 21);
			this.flatTextBoxExmoKey.MaxLength = 32767;
			this.flatTextBoxExmoKey.Multiline = false;
			this.flatTextBoxExmoKey.Name = "flatTextBoxExmoKey";
			this.flatTextBoxExmoKey.ReadOnly = false;
			this.flatTextBoxExmoKey.Size = new global::System.Drawing.Size(281, 29);
			this.flatTextBoxExmoKey.TabIndex = 27;
			this.flatTextBoxExmoKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxExmoKey.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxExmoKey.UseSystemPasswordChar = false;
			this.flatTextBoxExmoKey.TextChanged += new global::System.EventHandler(this.flatTextBoxExmoKey_TextChanged);
			this.flatLabel11.AutoSize = true;
			this.flatLabel11.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel11.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel11.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel11.Location = new global::System.Drawing.Point(9, 52);
			this.flatLabel11.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel11.Name = "flatLabel11";
			this.flatLabel11.Size = new global::System.Drawing.Size(41, 13);
			this.flatLabel11.TabIndex = 28;
			this.flatLabel11.Text = "Secret:";
			this.flatTextBoxExmoSecret.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxExmoSecret.FocusOnHover = false;
			this.flatTextBoxExmoSecret.Location = new global::System.Drawing.Point(81, 52);
			this.flatTextBoxExmoSecret.MaxLength = 32767;
			this.flatTextBoxExmoSecret.Multiline = false;
			this.flatTextBoxExmoSecret.Name = "flatTextBoxExmoSecret";
			this.flatTextBoxExmoSecret.ReadOnly = false;
			this.flatTextBoxExmoSecret.Size = new global::System.Drawing.Size(135, 29);
			this.flatTextBoxExmoSecret.TabIndex = 29;
			this.flatTextBoxExmoSecret.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxExmoSecret.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxExmoSecret.UseSystemPasswordChar = true;
			this.flatTextBoxExmoSecret.TextChanged += new global::System.EventHandler(this.flatTextBoxExmoSecret_TextChanged);
			this.flatLabel12.AutoSize = true;
			this.flatLabel12.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel12.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel12.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel12.Location = new global::System.Drawing.Point(10, 28);
			this.flatLabel12.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel12.Name = "flatLabel12";
			this.flatLabel12.Size = new global::System.Drawing.Size(27, 13);
			this.flatLabel12.TabIndex = 26;
			this.flatLabel12.Text = "Key:";
			this.groupBox12.Controls.Add(this.label27);
			this.groupBox12.Controls.Add(this.checkBoxApironePayLTC);
			this.groupBox12.Controls.Add(this.checkBoxApironePayBTC);
			this.groupBox12.Controls.Add(this.IsApironeAvailable);
			this.groupBox12.Controls.Add(this.flatButtonApirone);
			this.groupBox12.Controls.Add(this.flatTextBoxApironeBTCWallet);
			this.groupBox12.Controls.Add(this.flatLabel15);
			this.groupBox12.Controls.Add(this.flatTextBoxApironeLTCWallet);
			this.groupBox12.Controls.Add(this.flatLabel16);
			this.groupBox12.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox12.Location = new global::System.Drawing.Point(358, 186);
			this.groupBox12.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox12.Size = new global::System.Drawing.Size(367, 118);
			this.groupBox12.TabIndex = 39;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "      Apirone";
			this.label27.AutoSize = true;
			this.label27.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 254);
			this.label27.ForeColor = global::System.Drawing.Color.White;
			this.label27.Location = new global::System.Drawing.Point(5, 91);
			this.label27.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(84, 13);
			this.label27.TabIndex = 42;
			this.label27.Text = "Способ оплаты";
			this.checkBoxApironePayLTC.AutoSize = true;
			this.checkBoxApironePayLTC.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxApironePayLTC.Location = new global::System.Drawing.Point(153, 85);
			this.checkBoxApironePayLTC.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkBoxApironePayLTC.Name = "checkBoxApironePayLTC";
			this.checkBoxApironePayLTC.Size = new global::System.Drawing.Size(49, 23);
			this.checkBoxApironePayLTC.TabIndex = 41;
			this.checkBoxApironePayLTC.Text = "LTC";
			this.checkBoxApironePayLTC.UseVisualStyleBackColor = true;
			this.checkBoxApironePayLTC.CheckedChanged += new global::System.EventHandler(this.CheckBoxApironePayLTC_CheckedChanged);
			this.checkBoxApironePayBTC.AutoSize = true;
			this.checkBoxApironePayBTC.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxApironePayBTC.Location = new global::System.Drawing.Point(95, 85);
			this.checkBoxApironePayBTC.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkBoxApironePayBTC.Name = "checkBoxApironePayBTC";
			this.checkBoxApironePayBTC.Size = new global::System.Drawing.Size(50, 23);
			this.checkBoxApironePayBTC.TabIndex = 40;
			this.checkBoxApironePayBTC.Text = "BTC";
			this.checkBoxApironePayBTC.UseVisualStyleBackColor = true;
			this.checkBoxApironePayBTC.CheckedChanged += new global::System.EventHandler(this.CheckBoxApironePayBTC_CheckedChanged);
			this.IsApironeAvailable.AutoSize = true;
			this.IsApironeAvailable.Location = new global::System.Drawing.Point(10, 4);
			this.IsApironeAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsApironeAvailable.Name = "IsApironeAvailable";
			this.IsApironeAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.IsApironeAvailable.TabIndex = 39;
			this.IsApironeAvailable.UseVisualStyleBackColor = true;
			this.IsApironeAvailable.CheckedChanged += new global::System.EventHandler(this.IsApironeAvailable_CheckedChanged);
			this.flatButtonApirone.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonApirone.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonApirone.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonApirone.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonApirone.Location = new global::System.Drawing.Point(222, 82);
			this.flatButtonApirone.Name = "flatButtonApirone";
			this.flatButtonApirone.Rounded = false;
			this.flatButtonApirone.Size = new global::System.Drawing.Size(139, 29);
			this.flatButtonApirone.TabIndex = 38;
			this.flatButtonApirone.Text = "→ Подключиться";
			this.flatButtonApirone.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonApirone.Click += new global::System.EventHandler(this.FlatButtonApirone_Click);
			this.flatTextBoxApironeBTCWallet.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxApironeBTCWallet.FocusOnHover = false;
			this.flatTextBoxApironeBTCWallet.Location = new global::System.Drawing.Point(81, 21);
			this.flatTextBoxApironeBTCWallet.MaxLength = 32767;
			this.flatTextBoxApironeBTCWallet.Multiline = false;
			this.flatTextBoxApironeBTCWallet.Name = "flatTextBoxApironeBTCWallet";
			this.flatTextBoxApironeBTCWallet.ReadOnly = false;
			this.flatTextBoxApironeBTCWallet.Size = new global::System.Drawing.Size(281, 29);
			this.flatTextBoxApironeBTCWallet.TabIndex = 27;
			this.flatTextBoxApironeBTCWallet.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxApironeBTCWallet.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxApironeBTCWallet.UseSystemPasswordChar = true;
			this.flatTextBoxApironeBTCWallet.TextChanged += new global::System.EventHandler(this.FlatTextBoxApironeBTCWallet_TextChanged);
			this.flatLabel15.AutoSize = true;
			this.flatLabel15.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel15.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel15.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel15.Location = new global::System.Drawing.Point(5, 58);
			this.flatLabel15.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel15.Name = "flatLabel15";
			this.flatLabel15.Size = new global::System.Drawing.Size(58, 13);
			this.flatLabel15.TabIndex = 28;
			this.flatLabel15.Text = "LTC адрес:";
			this.flatTextBoxApironeLTCWallet.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxApironeLTCWallet.FocusOnHover = false;
			this.flatTextBoxApironeLTCWallet.Location = new global::System.Drawing.Point(81, 51);
			this.flatTextBoxApironeLTCWallet.MaxLength = 32767;
			this.flatTextBoxApironeLTCWallet.Multiline = false;
			this.flatTextBoxApironeLTCWallet.Name = "flatTextBoxApironeLTCWallet";
			this.flatTextBoxApironeLTCWallet.ReadOnly = false;
			this.flatTextBoxApironeLTCWallet.Size = new global::System.Drawing.Size(281, 29);
			this.flatTextBoxApironeLTCWallet.TabIndex = 29;
			this.flatTextBoxApironeLTCWallet.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxApironeLTCWallet.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxApironeLTCWallet.UseSystemPasswordChar = true;
			this.flatTextBoxApironeLTCWallet.TextChanged += new global::System.EventHandler(this.FlatTextBoxApironeLTCWallet_TextChanged);
			this.flatLabel16.AutoSize = true;
			this.flatLabel16.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel16.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel16.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel16.Location = new global::System.Drawing.Point(5, 28);
			this.flatLabel16.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel16.Name = "flatLabel16";
			this.flatLabel16.Size = new global::System.Drawing.Size(61, 13);
			this.flatLabel16.TabIndex = 26;
			this.flatLabel16.Text = "BTC адрес:";
			this.groupBox3.Controls.Add(this.flatLabel20);
			this.groupBox3.Controls.Add(this.flatButtonDeleteImage);
			this.groupBox3.Controls.Add(this.groupBox13);
			this.groupBox3.Controls.Add(this.flatButtonSelectImage);
			this.groupBox3.Controls.Add(this.settingPictureBoxImage);
			this.groupBox3.Controls.Add(this.flatTextBoxPositionOutOfStock);
			this.groupBox3.Controls.Add(this.flatLabel3);
			this.groupBox3.Controls.Add(this.flatTextBoxGreeting);
			this.groupBox3.Controls.Add(this.flatLabel6);
			this.groupBox3.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox3.Location = new global::System.Drawing.Point(730, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(368, 330);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Сообщения";
			this.flatLabel20.AutoSize = true;
			this.flatLabel20.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel20.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel20.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel20.Location = new global::System.Drawing.Point(193, 74);
			this.flatLabel20.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel20.Name = "flatLabel20";
			this.flatLabel20.Size = new global::System.Drawing.Size(107, 13);
			this.flatLabel20.TabIndex = 41;
			this.flatLabel20.Text = "Картинка на старт:";
			this.flatButtonDeleteImage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonDeleteImage.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonDeleteImage.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonDeleteImage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonDeleteImage.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonDeleteImage.Location = new global::System.Drawing.Point(283, 291);
			this.flatButtonDeleteImage.Name = "flatButtonDeleteImage";
			this.flatButtonDeleteImage.Rounded = false;
			this.flatButtonDeleteImage.Size = new global::System.Drawing.Size(80, 29);
			this.flatButtonDeleteImage.TabIndex = 40;
			this.flatButtonDeleteImage.Text = "Удалить";
			this.flatButtonDeleteImage.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonDeleteImage.Click += new global::System.EventHandler(this.flatButtonDeleteImage_Click);
			this.groupBox13.Controls.Add(this.flatRadioButtonRUB);
			this.groupBox13.Controls.Add(this.flatRadioButtonUSD);
			this.groupBox13.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox13.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.groupBox13.Location = new global::System.Drawing.Point(196, 14);
			this.groupBox13.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox13.Size = new global::System.Drawing.Size(167, 54);
			this.groupBox13.TabIndex = 58;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Валюта";
			this.flatRadioButtonRUB.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatRadioButtonRUB.Checked = false;
			this.flatRadioButtonRUB.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatRadioButtonRUB.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatRadioButtonRUB.Location = new global::System.Drawing.Point(10, 21);
			this.flatRadioButtonRUB.Margin = new global::System.Windows.Forms.Padding(2);
			this.flatRadioButtonRUB.Name = "flatRadioButtonRUB";
			this.flatRadioButtonRUB.Options = global::FlatUI.FlatRadioButton._Options.Style1;
			this.flatRadioButtonRUB.Size = new global::System.Drawing.Size(48, 22);
			this.flatRadioButtonRUB.TabIndex = 57;
			this.flatRadioButtonRUB.Text = "RUB";
			this.flatRadioButtonRUB.CheckedChanged += new global::FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.flatRadioButtonRUB_CheckedChanged);
			this.flatRadioButtonUSD.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatRadioButtonUSD.Checked = false;
			this.flatRadioButtonUSD.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatRadioButtonUSD.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatRadioButtonUSD.Location = new global::System.Drawing.Point(81, 21);
			this.flatRadioButtonUSD.Margin = new global::System.Windows.Forms.Padding(2);
			this.flatRadioButtonUSD.Name = "flatRadioButtonUSD";
			this.flatRadioButtonUSD.Options = global::FlatUI.FlatRadioButton._Options.Style1;
			this.flatRadioButtonUSD.Size = new global::System.Drawing.Size(60, 22);
			this.flatRadioButtonUSD.TabIndex = 56;
			this.flatRadioButtonUSD.Text = "USD";
			this.flatRadioButtonUSD.CheckedChanged += new global::FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.flatRadioButtonUSD_CheckedChanged);
			this.flatButtonSelectImage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonSelectImage.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonSelectImage.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonSelectImage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonSelectImage.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonSelectImage.Location = new global::System.Drawing.Point(196, 290);
			this.flatButtonSelectImage.Name = "flatButtonSelectImage";
			this.flatButtonSelectImage.Rounded = false;
			this.flatButtonSelectImage.Size = new global::System.Drawing.Size(80, 29);
			this.flatButtonSelectImage.TabIndex = 39;
			this.flatButtonSelectImage.Text = "Выбрать";
			this.flatButtonSelectImage.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonSelectImage.Click += new global::System.EventHandler(this.flatButtonSelectImage_Click);
			this.settingPictureBoxImage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.settingPictureBoxImage.Location = new global::System.Drawing.Point(196, 91);
			this.settingPictureBoxImage.Margin = new global::System.Windows.Forms.Padding(2);
			this.settingPictureBoxImage.Name = "settingPictureBoxImage";
			this.settingPictureBoxImage.Size = new global::System.Drawing.Size(167, 195);
			this.settingPictureBoxImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.settingPictureBoxImage.TabIndex = 27;
			this.settingPictureBoxImage.TabStop = false;
			this.flatTextBoxPositionOutOfStock.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxPositionOutOfStock.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxPositionOutOfStock.FocusOnHover = false;
			this.flatTextBoxPositionOutOfStock.Location = new global::System.Drawing.Point(8, 186);
			this.flatTextBoxPositionOutOfStock.MaxLength = 32767;
			this.flatTextBoxPositionOutOfStock.Multiline = true;
			this.flatTextBoxPositionOutOfStock.Name = "flatTextBoxPositionOutOfStock";
			this.flatTextBoxPositionOutOfStock.ReadOnly = false;
			this.flatTextBoxPositionOutOfStock.Size = new global::System.Drawing.Size(182, 134);
			this.flatTextBoxPositionOutOfStock.TabIndex = 26;
			this.flatTextBoxPositionOutOfStock.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxPositionOutOfStock.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxPositionOutOfStock.UseSystemPasswordChar = false;
			this.flatTextBoxPositionOutOfStock.TextChanged += new global::System.EventHandler(this.flatTextBoxPositionOutOfStock_TextChanged);
			this.flatLabel3.AutoSize = true;
			this.flatLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel3.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel3.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel3.Location = new global::System.Drawing.Point(4, 167);
			this.flatLabel3.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel3.Name = "flatLabel3";
			this.flatLabel3.Size = new global::System.Drawing.Size(79, 13);
			this.flatLabel3.TabIndex = 4;
			this.flatLabel3.Text = "Нет позиций:";
			this.flatTextBoxGreeting.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxGreeting.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxGreeting.FocusOnHover = false;
			this.flatTextBoxGreeting.Location = new global::System.Drawing.Point(8, 43);
			this.flatTextBoxGreeting.MaxLength = 32767;
			this.flatTextBoxGreeting.Multiline = true;
			this.flatTextBoxGreeting.Name = "flatTextBoxGreeting";
			this.flatTextBoxGreeting.ReadOnly = false;
			this.flatTextBoxGreeting.Size = new global::System.Drawing.Size(182, 122);
			this.flatTextBoxGreeting.TabIndex = 3;
			this.flatTextBoxGreeting.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxGreeting.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxGreeting.UseSystemPasswordChar = false;
			this.flatTextBoxGreeting.TextChanged += new global::System.EventHandler(this.flatTextBoxGreeting_TextChanged);
			this.flatLabel6.AutoSize = true;
			this.flatLabel6.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel6.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel6.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel6.Location = new global::System.Drawing.Point(5, 20);
			this.flatLabel6.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel6.Name = "flatLabel6";
			this.flatLabel6.Size = new global::System.Drawing.Size(78, 13);
			this.flatLabel6.TabIndex = 2;
			this.flatLabel6.Text = "Приветствие:";
			this.groupBox10.Controls.Add(this.flatButtonBlockChainArchiv);
			this.groupBox10.Controls.Add(this.label2);
			this.groupBox10.Controls.Add(this.flatButtonInitBlockchain);
			this.groupBox10.Controls.Add(this.flatTextBoxServiceHost);
			this.groupBox10.Controls.Add(this.flatLabel5);
			this.groupBox10.Controls.Add(this.flatTextBoxPassword);
			this.groupBox10.Controls.Add(this.flatLabel8);
			this.groupBox10.Controls.Add(this.flatTextBoxApiKey);
			this.groupBox10.Controls.Add(this.flatLabel9);
			this.groupBox10.Controls.Add(this.flatTextBoxIdWallet);
			this.groupBox10.Controls.Add(this.flatLabel10);
			this.groupBox10.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox10.Location = new global::System.Drawing.Point(358, 3);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new global::System.Drawing.Size(367, 182);
			this.groupBox10.TabIndex = 14;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Blockchain";
			this.flatButtonBlockChainArchiv.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonBlockChainArchiv.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonBlockChainArchiv.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonBlockChainArchiv.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonBlockChainArchiv.Location = new global::System.Drawing.Point(81, 145);
			this.flatButtonBlockChainArchiv.Name = "flatButtonBlockChainArchiv";
			this.flatButtonBlockChainArchiv.Rounded = false;
			this.flatButtonBlockChainArchiv.Size = new global::System.Drawing.Size(139, 29);
			this.flatButtonBlockChainArchiv.TabIndex = 41;
			this.flatButtonBlockChainArchiv.Text = "→ Архивировать";
			this.flatButtonBlockChainArchiv.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonBlockChainArchiv.Click += new global::System.EventHandler(this.flatButtonBlockChainArchiv_Click);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(5, 155);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(32, 19);
			this.label2.TabIndex = 40;
			this.label2.Text = "или";
			this.flatButtonInitBlockchain.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonInitBlockchain.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonInitBlockchain.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonInitBlockchain.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonInitBlockchain.Location = new global::System.Drawing.Point(222, 145);
			this.flatButtonInitBlockchain.Name = "flatButtonInitBlockchain";
			this.flatButtonInitBlockchain.Rounded = false;
			this.flatButtonInitBlockchain.Size = new global::System.Drawing.Size(139, 29);
			this.flatButtonInitBlockchain.TabIndex = 37;
			this.flatButtonInitBlockchain.Text = "→ Подключиться";
			this.flatButtonInitBlockchain.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonInitBlockchain.Click += new global::System.EventHandler(this.flatButtonInitBlockchain_Click);
			this.flatTextBoxServiceHost.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxServiceHost.FocusOnHover = false;
			this.flatTextBoxServiceHost.Location = new global::System.Drawing.Point(81, 113);
			this.flatTextBoxServiceHost.MaxLength = 32767;
			this.flatTextBoxServiceHost.Multiline = false;
			this.flatTextBoxServiceHost.Name = "flatTextBoxServiceHost";
			this.flatTextBoxServiceHost.ReadOnly = false;
			this.flatTextBoxServiceHost.Size = new global::System.Drawing.Size(281, 29);
			this.flatTextBoxServiceHost.TabIndex = 36;
			this.flatTextBoxServiceHost.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxServiceHost.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxServiceHost.UseSystemPasswordChar = false;
			this.flatTextBoxServiceHost.TextChanged += new global::System.EventHandler(this.flatTextBoxServiceHost_TextChanged);
			this.flatLabel5.AutoSize = true;
			this.flatLabel5.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel5.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel5.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel5.Location = new global::System.Drawing.Point(6, 121);
			this.flatLabel5.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel5.Name = "flatLabel5";
			this.flatLabel5.Size = new global::System.Drawing.Size(71, 13);
			this.flatLabel5.TabIndex = 35;
			this.flatLabel5.Text = "Service host:";
			this.flatTextBoxPassword.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxPassword.FocusOnHover = false;
			this.flatTextBoxPassword.Location = new global::System.Drawing.Point(81, 83);
			this.flatTextBoxPassword.MaxLength = 32767;
			this.flatTextBoxPassword.Multiline = false;
			this.flatTextBoxPassword.Name = "flatTextBoxPassword";
			this.flatTextBoxPassword.ReadOnly = false;
			this.flatTextBoxPassword.Size = new global::System.Drawing.Size(281, 29);
			this.flatTextBoxPassword.TabIndex = 34;
			this.flatTextBoxPassword.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxPassword.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxPassword.UseSystemPasswordChar = true;
			this.flatTextBoxPassword.TextChanged += new global::System.EventHandler(this.flatTextBoxPassword_TextChanged);
			this.flatLabel8.AutoSize = true;
			this.flatLabel8.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel8.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel8.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel8.Location = new global::System.Drawing.Point(5, 91);
			this.flatLabel8.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel8.Name = "flatLabel8";
			this.flatLabel8.Size = new global::System.Drawing.Size(59, 13);
			this.flatLabel8.TabIndex = 33;
			this.flatLabel8.Text = "Password:";
			this.flatTextBoxApiKey.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxApiKey.FocusOnHover = false;
			this.flatTextBoxApiKey.Location = new global::System.Drawing.Point(81, 23);
			this.flatTextBoxApiKey.MaxLength = 32767;
			this.flatTextBoxApiKey.Multiline = false;
			this.flatTextBoxApiKey.Name = "flatTextBoxApiKey";
			this.flatTextBoxApiKey.ReadOnly = false;
			this.flatTextBoxApiKey.Size = new global::System.Drawing.Size(281, 29);
			this.flatTextBoxApiKey.TabIndex = 3;
			this.flatTextBoxApiKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxApiKey.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxApiKey.UseSystemPasswordChar = false;
			this.flatTextBoxApiKey.TextChanged += new global::System.EventHandler(this.flatTextBoxApiKey_TextChanged);
			this.flatLabel9.AutoSize = true;
			this.flatLabel9.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel9.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel9.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel9.Location = new global::System.Drawing.Point(6, 61);
			this.flatLabel9.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel9.Name = "flatLabel9";
			this.flatLabel9.Size = new global::System.Drawing.Size(56, 13);
			this.flatLabel9.TabIndex = 24;
			this.flatLabel9.Text = "Id Wallet:";
			this.flatTextBoxIdWallet.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxIdWallet.FocusOnHover = false;
			this.flatTextBoxIdWallet.Location = new global::System.Drawing.Point(81, 53);
			this.flatTextBoxIdWallet.MaxLength = 32767;
			this.flatTextBoxIdWallet.Multiline = false;
			this.flatTextBoxIdWallet.Name = "flatTextBoxIdWallet";
			this.flatTextBoxIdWallet.ReadOnly = false;
			this.flatTextBoxIdWallet.Size = new global::System.Drawing.Size(281, 29);
			this.flatTextBoxIdWallet.TabIndex = 25;
			this.flatTextBoxIdWallet.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxIdWallet.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxIdWallet.UseSystemPasswordChar = false;
			this.flatTextBoxIdWallet.TextChanged += new global::System.EventHandler(this.flatTextBoxIdWallet_TextChanged);
			this.flatLabel10.AutoSize = true;
			this.flatLabel10.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel10.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel10.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel10.Location = new global::System.Drawing.Point(6, 31);
			this.flatLabel10.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel10.Name = "flatLabel10";
			this.flatLabel10.Size = new global::System.Drawing.Size(44, 13);
			this.flatLabel10.TabIndex = 2;
			this.flatLabel10.Text = "ApiKey:";
			this.groupBox2.Controls.Add(this.label22);
			this.groupBox2.Controls.Add(this.cbIsSendMoneyButtonAvailabile);
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.cbIsButtonAvailability);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.cbIsButtonStatistic);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.cbIsLockCheckPayment);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.cbButtonIPaidForElse);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.cbButtonIPaidForCard);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.cbIsEnterAmountToBuy);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.checkBoxIsButtonLanguageAvailable);
			this.groupBox2.Controls.Add(this.flatNumericTimeToCancelOrder);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.checkBoxIsReservAndPayInTheEndAvailable);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.checkBoxIsUserPayWalletAvailable);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.IsReviewAvailable);
			this.groupBox2.Controls.Add(this.flatNumericDicountPayLTC);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.flatNumericDicountPayBTC);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.checkBoxIsWithoutLogin);
			this.groupBox2.Controls.Add(this.flatTextBoxCommandSupport);
			this.groupBox2.Controls.Add(this.flatLabel7);
			this.groupBox2.Controls.Add(this.flatTextBoxSupport);
			this.groupBox2.Controls.Add(this.flatLabel4);
			this.groupBox2.Controls.Add(this.flatButtonTestMessage);
			this.groupBox2.Controls.Add(this.flatTextBoxBotToken);
			this.groupBox2.Controls.Add(this.flatLabel2);
			this.groupBox2.Controls.Add(this.flatTextBoxChanell);
			this.groupBox2.Controls.Add(this.flatLabel1);
			this.groupBox2.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox2.Location = new global::System.Drawing.Point(4, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(348, 475);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Общие";
			this.label22.AutoSize = true;
			this.label22.ForeColor = global::System.Drawing.Color.White;
			this.label22.Location = new global::System.Drawing.Point(10, 453);
			this.label22.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(120, 19);
			this.label22.TabIndex = 71;
			this.label22.Text = "Пересылка денег:";
			this.cbIsSendMoneyButtonAvailabile.AutoSize = true;
			this.cbIsSendMoneyButtonAvailabile.Location = new global::System.Drawing.Point(327, 456);
			this.cbIsSendMoneyButtonAvailabile.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsSendMoneyButtonAvailabile.Name = "cbIsSendMoneyButtonAvailabile";
			this.cbIsSendMoneyButtonAvailabile.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsSendMoneyButtonAvailabile.TabIndex = 70;
			this.cbIsSendMoneyButtonAvailabile.UseVisualStyleBackColor = true;
			this.cbIsSendMoneyButtonAvailabile.CheckedChanged += new global::System.EventHandler(this.cbIsSendMoneyButtonAvailabile_CheckedChanged);
			this.label21.AutoSize = true;
			this.label21.ForeColor = global::System.Drawing.Color.White;
			this.label21.Location = new global::System.Drawing.Point(10, 436);
			this.label21.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(123, 19);
			this.label21.TabIndex = 69;
			this.label21.Text = "Кнопка 'Наличие':";
			this.cbIsButtonAvailability.AutoSize = true;
			this.cbIsButtonAvailability.Location = new global::System.Drawing.Point(327, 440);
			this.cbIsButtonAvailability.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsButtonAvailability.Name = "cbIsButtonAvailability";
			this.cbIsButtonAvailability.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsButtonAvailability.TabIndex = 68;
			this.cbIsButtonAvailability.UseVisualStyleBackColor = true;
			this.cbIsButtonAvailability.CheckedChanged += new global::System.EventHandler(this.cbIsButtonAvailability_CheckedChanged);
			this.label20.AutoSize = true;
			this.label20.ForeColor = global::System.Drawing.Color.White;
			this.label20.Location = new global::System.Drawing.Point(10, 418);
			this.label20.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(218, 19);
			this.label20.TabIndex = 67;
			this.label20.Text = "Кнопка 'Статистика' для сапорта:";
			this.cbIsButtonStatistic.AutoSize = true;
			this.cbIsButtonStatistic.Location = new global::System.Drawing.Point(327, 421);
			this.cbIsButtonStatistic.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsButtonStatistic.Name = "cbIsButtonStatistic";
			this.cbIsButtonStatistic.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsButtonStatistic.TabIndex = 66;
			this.cbIsButtonStatistic.UseVisualStyleBackColor = true;
			this.cbIsButtonStatistic.CheckedChanged += new global::System.EventHandler(this.cbIsButtonStatistic_CheckedChanged);
			this.label18.AutoSize = true;
			this.label18.ForeColor = global::System.Drawing.Color.White;
			this.label18.Location = new global::System.Drawing.Point(9, 398);
			this.label18.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(236, 19);
			this.label18.TabIndex = 65;
			this.label18.Text = "Заблокировать проверку платежей:";
			this.cbIsLockCheckPayment.AutoSize = true;
			this.cbIsLockCheckPayment.Location = new global::System.Drawing.Point(327, 401);
			this.cbIsLockCheckPayment.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsLockCheckPayment.Name = "cbIsLockCheckPayment";
			this.cbIsLockCheckPayment.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsLockCheckPayment.TabIndex = 64;
			this.cbIsLockCheckPayment.UseVisualStyleBackColor = true;
			this.cbIsLockCheckPayment.CheckedChanged += new global::System.EventHandler(this.cbLockCheckPayment_CheckedChanged);
			this.label17.AutoSize = true;
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.Location = new global::System.Drawing.Point(9, 379);
			this.label17.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(257, 19);
			this.label17.TabIndex = 63;
			this.label17.Text = "Кнопка 'Я оплатил' в остальных местах:";
			this.cbButtonIPaidForElse.AutoSize = true;
			this.cbButtonIPaidForElse.Location = new global::System.Drawing.Point(327, 382);
			this.cbButtonIPaidForElse.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbButtonIPaidForElse.Name = "cbButtonIPaidForElse";
			this.cbButtonIPaidForElse.Size = new global::System.Drawing.Size(15, 14);
			this.cbButtonIPaidForElse.TabIndex = 62;
			this.cbButtonIPaidForElse.UseVisualStyleBackColor = true;
			this.cbButtonIPaidForElse.CheckedChanged += new global::System.EventHandler(this.cbButtonIPaidForElse_CheckedChanged);
			this.label16.AutoSize = true;
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.Location = new global::System.Drawing.Point(9, 359);
			this.label16.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(199, 19);
			this.label16.TabIndex = 61;
			this.label16.Text = "Кнопка 'Я оплатил' для карты:";
			this.cbButtonIPaidForCard.AutoSize = true;
			this.cbButtonIPaidForCard.Location = new global::System.Drawing.Point(327, 362);
			this.cbButtonIPaidForCard.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbButtonIPaidForCard.Name = "cbButtonIPaidForCard";
			this.cbButtonIPaidForCard.Size = new global::System.Drawing.Size(15, 14);
			this.cbButtonIPaidForCard.TabIndex = 60;
			this.cbButtonIPaidForCard.UseVisualStyleBackColor = true;
			this.cbButtonIPaidForCard.CheckedChanged += new global::System.EventHandler(this.cbButtonIPaidForCard_CheckedChanged);
			this.label14.AutoSize = true;
			this.label14.ForeColor = global::System.Drawing.Color.White;
			this.label14.Location = new global::System.Drawing.Point(8, 339);
			this.label14.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(248, 19);
			this.label14.TabIndex = 59;
			this.label14.Text = "Убрать ввод количества для покупки:";
			this.cbIsEnterAmountToBuy.AutoSize = true;
			this.cbIsEnterAmountToBuy.Location = new global::System.Drawing.Point(327, 342);
			this.cbIsEnterAmountToBuy.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsEnterAmountToBuy.Name = "cbIsEnterAmountToBuy";
			this.cbIsEnterAmountToBuy.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsEnterAmountToBuy.TabIndex = 58;
			this.cbIsEnterAmountToBuy.UseVisualStyleBackColor = true;
			this.cbIsEnterAmountToBuy.CheckedChanged += new global::System.EventHandler(this.cbIsEnterAmountToBuy_CheckedChanged);
			this.label12.AutoSize = true;
			this.label12.ForeColor = global::System.Drawing.Color.White;
			this.label12.Location = new global::System.Drawing.Point(8, 318);
			this.label12.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(152, 19);
			this.label12.TabIndex = 57;
			this.label12.Text = "Кнопка смены языков:";
			this.checkBoxIsButtonLanguageAvailable.AutoSize = true;
			this.checkBoxIsButtonLanguageAvailable.Location = new global::System.Drawing.Point(327, 321);
			this.checkBoxIsButtonLanguageAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkBoxIsButtonLanguageAvailable.Name = "checkBoxIsButtonLanguageAvailable";
			this.checkBoxIsButtonLanguageAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.checkBoxIsButtonLanguageAvailable.TabIndex = 56;
			this.checkBoxIsButtonLanguageAvailable.UseVisualStyleBackColor = true;
			this.checkBoxIsButtonLanguageAvailable.CheckedChanged += new global::System.EventHandler(this.checkBoxIsButtonLanguageAvailable_CheckedChanged);
			this.flatNumericTimeToCancelOrder.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumericTimeToCancelOrder.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumericTimeToCancelOrder.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumericTimeToCancelOrder.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumericTimeToCancelOrder.ForeColor = global::System.Drawing.Color.White;
			this.flatNumericTimeToCancelOrder.Location = new global::System.Drawing.Point(265, 288);
			this.flatNumericTimeToCancelOrder.Margin = new global::System.Windows.Forms.Padding(2);
			global::FlatUI.FlatNumeric flatNumeric2 = this.flatNumericTimeToCancelOrder;
			int[] array2 = new int[4];
			array2[0] = 9999999;
			flatNumeric2.Maximum = new decimal(array2);
			this.flatNumericTimeToCancelOrder.Minimum = new decimal(new int[4]);
			this.flatNumericTimeToCancelOrder.Name = "flatNumericTimeToCancelOrder";
			this.flatNumericTimeToCancelOrder.Size = new global::System.Drawing.Size(74, 30);
			this.flatNumericTimeToCancelOrder.TabIndex = 55;
			this.flatNumericTimeToCancelOrder.Text = "flatNumeric1";
			this.flatNumericTimeToCancelOrder.Value = new decimal(new int[4]);
			this.flatNumericTimeToCancelOrder.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.flatNumericTimeToCancelOrder_KeyUp);
			this.flatNumericTimeToCancelOrder.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.flatNumericTimeToCancelOrder_MouseUp);
			this.label11.AutoSize = true;
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(8, 292);
			this.label11.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(171, 19);
			this.label11.TabIndex = 54;
			this.label11.Text = "Минут до отмены заказа:";
			this.label10.AutoSize = true;
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.Location = new global::System.Drawing.Point(8, 267);
			this.label10.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(266, 19);
			this.label10.TabIndex = 53;
			this.label10.Text = "Резерв и прямая оплата товара активен:";
			this.checkBoxIsReservAndPayInTheEndAvailable.AutoSize = true;
			this.checkBoxIsReservAndPayInTheEndAvailable.Location = new global::System.Drawing.Point(327, 271);
			this.checkBoxIsReservAndPayInTheEndAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkBoxIsReservAndPayInTheEndAvailable.Name = "checkBoxIsReservAndPayInTheEndAvailable";
			this.checkBoxIsReservAndPayInTheEndAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.checkBoxIsReservAndPayInTheEndAvailable.TabIndex = 52;
			this.checkBoxIsReservAndPayInTheEndAvailable.UseVisualStyleBackColor = true;
			this.checkBoxIsReservAndPayInTheEndAvailable.CheckedChanged += new global::System.EventHandler(this.checkBoxIsReservAndPayInTheEndAvailable_CheckedChanged);
			this.label9.AutoSize = true;
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(8, 246);
			this.label9.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(164, 19);
			this.label9.TabIndex = 51;
			this.label9.Text = "Кошелек юзера активен:";
			this.checkBoxIsUserPayWalletAvailable.AutoSize = true;
			this.checkBoxIsUserPayWalletAvailable.Location = new global::System.Drawing.Point(327, 249);
			this.checkBoxIsUserPayWalletAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkBoxIsUserPayWalletAvailable.Name = "checkBoxIsUserPayWalletAvailable";
			this.checkBoxIsUserPayWalletAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.checkBoxIsUserPayWalletAvailable.TabIndex = 50;
			this.checkBoxIsUserPayWalletAvailable.UseVisualStyleBackColor = true;
			this.checkBoxIsUserPayWalletAvailable.CheckedChanged += new global::System.EventHandler(this.checkBoxIsUserPayWalletAvailable_CheckedChanged);
			this.label8.AutoSize = true;
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(8, 226);
			this.label8.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(258, 19);
			this.label8.TabIndex = 49;
			this.label8.Text = "Оставить комментарий после покупки:";
			this.IsReviewAvailable.AutoSize = true;
			this.IsReviewAvailable.Location = new global::System.Drawing.Point(327, 229);
			this.IsReviewAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsReviewAvailable.Name = "IsReviewAvailable";
			this.IsReviewAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.IsReviewAvailable.TabIndex = 48;
			this.IsReviewAvailable.UseVisualStyleBackColor = true;
			this.IsReviewAvailable.CheckedChanged += new global::System.EventHandler(this.IsReviewAvailable_CheckedChanged);
			this.flatNumericDicountPayLTC.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumericDicountPayLTC.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumericDicountPayLTC.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumericDicountPayLTC.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumericDicountPayLTC.ForeColor = global::System.Drawing.Color.White;
			this.flatNumericDicountPayLTC.Location = new global::System.Drawing.Point(265, 197);
			this.flatNumericDicountPayLTC.Margin = new global::System.Windows.Forms.Padding(2);
			global::FlatUI.FlatNumeric flatNumeric3 = this.flatNumericDicountPayLTC;
			int[] array3 = new int[4];
			array3[0] = 9999999;
			flatNumeric3.Maximum = new decimal(array3);
			this.flatNumericDicountPayLTC.Minimum = new decimal(new int[4]);
			this.flatNumericDicountPayLTC.Name = "flatNumericDicountPayLTC";
			this.flatNumericDicountPayLTC.Size = new global::System.Drawing.Size(74, 30);
			this.flatNumericDicountPayLTC.TabIndex = 47;
			this.flatNumericDicountPayLTC.Text = "flatNumeric1";
			this.flatNumericDicountPayLTC.Value = new decimal(new int[4]);
			this.flatNumericDicountPayLTC.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.flatNumericDicountPayLTC_KeyUp);
			this.flatNumericDicountPayLTC.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.flatNumericDicountPayLTC_MouseUp);
			this.label7.AutoSize = true;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(8, 201);
			this.label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(155, 19);
			this.label7.TabIndex = 46;
			this.label7.Text = "Скидка при оплате LTC";
			this.flatNumericDicountPayBTC.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumericDicountPayBTC.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumericDicountPayBTC.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumericDicountPayBTC.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumericDicountPayBTC.ForeColor = global::System.Drawing.Color.White;
			this.flatNumericDicountPayBTC.Location = new global::System.Drawing.Point(265, 167);
			this.flatNumericDicountPayBTC.Margin = new global::System.Windows.Forms.Padding(2);
			global::FlatUI.FlatNumeric flatNumeric4 = this.flatNumericDicountPayBTC;
			int[] array4 = new int[4];
			array4[0] = 9999999;
			flatNumeric4.Maximum = new decimal(array4);
			this.flatNumericDicountPayBTC.Minimum = new decimal(new int[4]);
			this.flatNumericDicountPayBTC.Name = "flatNumericDicountPayBTC";
			this.flatNumericDicountPayBTC.Size = new global::System.Drawing.Size(74, 30);
			this.flatNumericDicountPayBTC.TabIndex = 45;
			this.flatNumericDicountPayBTC.Text = "flatNumeric1";
			this.flatNumericDicountPayBTC.Value = new decimal(new int[4]);
			this.flatNumericDicountPayBTC.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.flatNumericDicountPayBTC_KeyUp);
			this.flatNumericDicountPayBTC.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.flatNumericDicountPayBTC_MouseUp);
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(8, 172);
			this.label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(156, 19);
			this.label6.TabIndex = 42;
			this.label6.Text = "Скидка при оплате BTC";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(8, 147);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(233, 19);
			this.label3.TabIndex = 41;
			this.label3.Text = "Отменить авторизацию по паролю";
			this.checkBoxIsWithoutLogin.AutoSize = true;
			this.checkBoxIsWithoutLogin.Location = new global::System.Drawing.Point(326, 150);
			this.checkBoxIsWithoutLogin.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkBoxIsWithoutLogin.Name = "checkBoxIsWithoutLogin";
			this.checkBoxIsWithoutLogin.Size = new global::System.Drawing.Size(15, 14);
			this.checkBoxIsWithoutLogin.TabIndex = 40;
			this.checkBoxIsWithoutLogin.UseVisualStyleBackColor = true;
			this.checkBoxIsWithoutLogin.CheckedChanged += new global::System.EventHandler(this.CheckBoxIsWithoutLogin_CheckedChanged);
			this.flatTextBoxCommandSupport.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxCommandSupport.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxCommandSupport.FocusOnHover = false;
			this.flatTextBoxCommandSupport.Location = new global::System.Drawing.Point(84, 115);
			this.flatTextBoxCommandSupport.MaxLength = 32767;
			this.flatTextBoxCommandSupport.Multiline = false;
			this.flatTextBoxCommandSupport.Name = "flatTextBoxCommandSupport";
			this.flatTextBoxCommandSupport.ReadOnly = false;
			this.flatTextBoxCommandSupport.Size = new global::System.Drawing.Size(255, 29);
			this.flatTextBoxCommandSupport.TabIndex = 36;
			this.flatTextBoxCommandSupport.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxCommandSupport.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxCommandSupport.UseSystemPasswordChar = false;
			this.flatTextBoxCommandSupport.TextChanged += new global::System.EventHandler(this.flatTextBoxCommandSupport_TextChanged);
			this.flatLabel7.AutoSize = true;
			this.flatLabel7.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel7.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel7.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel7.Location = new global::System.Drawing.Point(8, 115);
			this.flatLabel7.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel7.Name = "flatLabel7";
			this.flatLabel7.Size = new global::System.Drawing.Size(61, 26);
			this.flatLabel7.TabIndex = 35;
			this.flatLabel7.Text = "Комманда\r\nсаппорта:";
			this.flatTextBoxSupport.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxSupport.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxSupport.FocusOnHover = false;
			this.flatTextBoxSupport.Location = new global::System.Drawing.Point(84, 84);
			this.flatTextBoxSupport.MaxLength = 32767;
			this.flatTextBoxSupport.Multiline = false;
			this.flatTextBoxSupport.Name = "flatTextBoxSupport";
			this.flatTextBoxSupport.ReadOnly = false;
			this.flatTextBoxSupport.Size = new global::System.Drawing.Size(255, 29);
			this.flatTextBoxSupport.TabIndex = 34;
			this.flatTextBoxSupport.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxSupport.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxSupport.UseSystemPasswordChar = false;
			this.flatTextBoxSupport.TextChanged += new global::System.EventHandler(this.flatTextBoxSupport_TextChanged);
			this.flatLabel4.AutoSize = true;
			this.flatLabel4.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel4.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel4.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel4.Location = new global::System.Drawing.Point(10, 90);
			this.flatLabel4.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel4.Name = "flatLabel4";
			this.flatLabel4.Size = new global::System.Drawing.Size(49, 13);
			this.flatLabel4.TabIndex = 33;
			this.flatLabel4.Text = "Сапорт:";
			this.flatButtonTestMessage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonTestMessage.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonTestMessage.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonTestMessage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonTestMessage.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonTestMessage.Location = new global::System.Drawing.Point(273, 52);
			this.flatButtonTestMessage.Name = "flatButtonTestMessage";
			this.flatButtonTestMessage.Rounded = false;
			this.flatButtonTestMessage.Size = new global::System.Drawing.Size(66, 29);
			this.flatButtonTestMessage.TabIndex = 26;
			this.flatButtonTestMessage.Text = "→ Тест";
			this.flatButtonTestMessage.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonTestMessage.Click += new global::System.EventHandler(this.flatButtonTestMessage_Click);
			this.flatTextBoxBotToken.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxBotToken.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxBotToken.FocusOnHover = false;
			this.flatTextBoxBotToken.Location = new global::System.Drawing.Point(84, 23);
			this.flatTextBoxBotToken.MaxLength = 32767;
			this.flatTextBoxBotToken.Multiline = false;
			this.flatTextBoxBotToken.Name = "flatTextBoxBotToken";
			this.flatTextBoxBotToken.ReadOnly = false;
			this.flatTextBoxBotToken.Size = new global::System.Drawing.Size(255, 29);
			this.flatTextBoxBotToken.TabIndex = 3;
			this.flatTextBoxBotToken.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxBotToken.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxBotToken.UseSystemPasswordChar = false;
			this.flatTextBoxBotToken.TextChanged += new global::System.EventHandler(this.flatTextBoxBotToken_TextChanged);
			this.flatLabel2.AutoSize = true;
			this.flatLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel2.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel2.Location = new global::System.Drawing.Point(10, 60);
			this.flatLabel2.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel2.Name = "flatLabel2";
			this.flatLabel2.Size = new global::System.Drawing.Size(41, 13);
			this.flatLabel2.TabIndex = 24;
			this.flatLabel2.Text = "Канал:";
			this.flatTextBoxChanell.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxChanell.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxChanell.FocusOnHover = false;
			this.flatTextBoxChanell.Location = new global::System.Drawing.Point(84, 53);
			this.flatTextBoxChanell.MaxLength = 32767;
			this.flatTextBoxChanell.Multiline = false;
			this.flatTextBoxChanell.Name = "flatTextBoxChanell";
			this.flatTextBoxChanell.ReadOnly = false;
			this.flatTextBoxChanell.Size = new global::System.Drawing.Size(184, 29);
			this.flatTextBoxChanell.TabIndex = 25;
			this.flatTextBoxChanell.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxChanell.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxChanell.UseSystemPasswordChar = false;
			this.flatTextBoxChanell.TextChanged += new global::System.EventHandler(this.flatTextBoxChanell_TextChanged);
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel1.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel1.Location = new global::System.Drawing.Point(8, 30);
			this.flatLabel1.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new global::System.Drawing.Size(69, 13);
			this.flatLabel1.TabIndex = 2;
			this.flatLabel1.Text = "Токен бота:";
			this.tabPageSettingQiwi.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageSettingQiwi.Controls.Add(this.groupBox11);
			this.tabPageSettingQiwi.Controls.Add(this.groupBox18);
			this.tabPageSettingQiwi.Controls.Add(this.groupBox14);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber10);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI10);
			this.tabPageSettingQiwi.Controls.Add(this.labelF10);
			this.tabPageSettingQiwi.Controls.Add(this.textPass10);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy10);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber9);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI9);
			this.tabPageSettingQiwi.Controls.Add(this.labelF9);
			this.tabPageSettingQiwi.Controls.Add(this.textPass9);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy9);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber8);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI8);
			this.tabPageSettingQiwi.Controls.Add(this.labelF8);
			this.tabPageSettingQiwi.Controls.Add(this.labelF7);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber7);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI7);
			this.tabPageSettingQiwi.Controls.Add(this.textPass8);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy8);
			this.tabPageSettingQiwi.Controls.Add(this.textPass7);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy7);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber6);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI6);
			this.tabPageSettingQiwi.Controls.Add(this.labelF6);
			this.tabPageSettingQiwi.Controls.Add(this.textPass6);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy6);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber5);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI5);
			this.tabPageSettingQiwi.Controls.Add(this.labelF5);
			this.tabPageSettingQiwi.Controls.Add(this.textPass5);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy5);
			this.tabPageSettingQiwi.Controls.Add(this.flatLabel19);
			this.tabPageSettingQiwi.Controls.Add(this.IsQiwiAvailable1);
			this.tabPageSettingQiwi.Controls.Add(this.radioButtonIsQiwiNumber);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber4);
			this.tabPageSettingQiwi.Controls.Add(this.label1);
			this.tabPageSettingQiwi.Controls.Add(this.radioButtonIsQiwiCode);
			this.tabPageSettingQiwi.Controls.Add(this.flatButtonQiwiInit);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI4);
			this.tabPageSettingQiwi.Controls.Add(this.labelF4);
			this.tabPageSettingQiwi.Controls.Add(this.labelF3);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber3);
			this.tabPageSettingQiwi.Controls.Add(this.labelF2);
			this.tabPageSettingQiwi.Controls.Add(this.labelF1);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI3);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber2);
			this.tabPageSettingQiwi.Controls.Add(this.textPass4);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy4);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI2);
			this.tabPageSettingQiwi.Controls.Add(this.textPass3);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy3);
			this.tabPageSettingQiwi.Controls.Add(this.textNumber1);
			this.tabPageSettingQiwi.Controls.Add(this.textPass2);
			this.tabPageSettingQiwi.Controls.Add(this.flatLabel13);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy2);
			this.tabPageSettingQiwi.Controls.Add(this.textAPI1);
			this.tabPageSettingQiwi.Controls.Add(this.label5);
			this.tabPageSettingQiwi.Controls.Add(this.flatLabel14);
			this.tabPageSettingQiwi.Controls.Add(this.label4);
			this.tabPageSettingQiwi.Controls.Add(this.textPass1);
			this.tabPageSettingQiwi.Controls.Add(this.textProxy1);
			this.tabPageSettingQiwi.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageSettingQiwi.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabPageSettingQiwi.Name = "tabPageSettingQiwi";
			this.tabPageSettingQiwi.Padding = new global::System.Windows.Forms.Padding(2);
			this.tabPageSettingQiwi.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageSettingQiwi.TabIndex = 7;
			this.tabPageSettingQiwi.Text = "Настройки платежек";
			this.groupBox11.Controls.Add(this.IsCardAvailable1);
			this.groupBox11.Controls.Add(this.textBoxCard);
			this.groupBox11.Controls.Add(this.flatLabel22);
			this.groupBox11.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox11.Location = new global::System.Drawing.Point(2, 432);
			this.groupBox11.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox11.Size = new global::System.Drawing.Size(304, 55);
			this.groupBox11.TabIndex = 96;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "      Карта";
			this.IsCardAvailable1.AutoSize = true;
			this.IsCardAvailable1.Location = new global::System.Drawing.Point(10, 3);
			this.IsCardAvailable1.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsCardAvailable1.Name = "IsCardAvailable1";
			this.IsCardAvailable1.Size = new global::System.Drawing.Size(15, 14);
			this.IsCardAvailable1.TabIndex = 41;
			this.IsCardAvailable1.UseVisualStyleBackColor = true;
			this.IsCardAvailable1.CheckedChanged += new global::System.EventHandler(this.IsCardAvailable_CheckedChanged);
			this.textBoxCard.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxCard.FocusOnHover = false;
			this.textBoxCard.Location = new global::System.Drawing.Point(80, 21);
			this.textBoxCard.MaxLength = 32767;
			this.textBoxCard.Multiline = false;
			this.textBoxCard.Name = "textBoxCard";
			this.textBoxCard.ReadOnly = false;
			this.textBoxCard.Size = new global::System.Drawing.Size(218, 29);
			this.textBoxCard.TabIndex = 27;
			this.textBoxCard.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxCard.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxCard.UseSystemPasswordChar = false;
			this.textBoxCard.TextChanged += new global::System.EventHandler(this.textBoxCard_TextChanged);
			this.flatLabel22.AutoSize = true;
			this.flatLabel22.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel22.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel22.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel22.Location = new global::System.Drawing.Point(10, 24);
			this.flatLabel22.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel22.Name = "flatLabel22";
			this.flatLabel22.Size = new global::System.Drawing.Size(40, 13);
			this.flatLabel22.TabIndex = 26;
			this.flatLabel22.Text = "Карта:";
			this.groupBox18.Controls.Add(this.flatLabel32);
			this.groupBox18.Controls.Add(this.buttonTele2Init);
			this.groupBox18.Controls.Add(this.textBoxTele2Password);
			this.groupBox18.Controls.Add(this.IsTele2Available);
			this.groupBox18.Controls.Add(this.textBoxTele2Number);
			this.groupBox18.Controls.Add(this.flatLabel31);
			this.groupBox18.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox18.Location = new global::System.Drawing.Point(1, 310);
			this.groupBox18.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox18.Size = new global::System.Drawing.Size(305, 118);
			this.groupBox18.TabIndex = 95;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "      Tele2";
			this.flatLabel32.AutoSize = true;
			this.flatLabel32.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel32.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel32.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel32.Location = new global::System.Drawing.Point(5, 58);
			this.flatLabel32.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel32.Name = "flatLabel32";
			this.flatLabel32.Size = new global::System.Drawing.Size(50, 13);
			this.flatLabel32.TabIndex = 44;
			this.flatLabel32.Text = "Пароль:";
			this.buttonTele2Init.BackColor = global::System.Drawing.Color.Transparent;
			this.buttonTele2Init.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.buttonTele2Init.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.buttonTele2Init.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.buttonTele2Init.Location = new global::System.Drawing.Point(161, 82);
			this.buttonTele2Init.Name = "buttonTele2Init";
			this.buttonTele2Init.Rounded = false;
			this.buttonTele2Init.Size = new global::System.Drawing.Size(139, 29);
			this.buttonTele2Init.TabIndex = 43;
			this.buttonTele2Init.Text = "→ Подключиться";
			this.buttonTele2Init.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.buttonTele2Init.Click += new global::System.EventHandler(this.buttonTele2Init_Click);
			this.textBoxTele2Password.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxTele2Password.FocusOnHover = false;
			this.textBoxTele2Password.Location = new global::System.Drawing.Point(82, 51);
			this.textBoxTele2Password.MaxLength = 32767;
			this.textBoxTele2Password.Multiline = false;
			this.textBoxTele2Password.Name = "textBoxTele2Password";
			this.textBoxTele2Password.ReadOnly = false;
			this.textBoxTele2Password.Size = new global::System.Drawing.Size(218, 29);
			this.textBoxTele2Password.TabIndex = 42;
			this.textBoxTele2Password.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxTele2Password.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxTele2Password.UseSystemPasswordChar = true;
			this.textBoxTele2Password.TextChanged += new global::System.EventHandler(this.textBoxTele2Password_TextChanged);
			this.IsTele2Available.AutoSize = true;
			this.IsTele2Available.Location = new global::System.Drawing.Point(10, 3);
			this.IsTele2Available.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsTele2Available.Name = "IsTele2Available";
			this.IsTele2Available.Size = new global::System.Drawing.Size(15, 14);
			this.IsTele2Available.TabIndex = 41;
			this.IsTele2Available.UseVisualStyleBackColor = true;
			this.IsTele2Available.CheckedChanged += new global::System.EventHandler(this.IsTele2Available_CheckedChanged);
			this.textBoxTele2Number.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxTele2Number.FocusOnHover = false;
			this.textBoxTele2Number.Location = new global::System.Drawing.Point(82, 20);
			this.textBoxTele2Number.MaxLength = 32767;
			this.textBoxTele2Number.Multiline = false;
			this.textBoxTele2Number.Name = "textBoxTele2Number";
			this.textBoxTele2Number.ReadOnly = false;
			this.textBoxTele2Number.Size = new global::System.Drawing.Size(220, 29);
			this.textBoxTele2Number.TabIndex = 27;
			this.textBoxTele2Number.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxTele2Number.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxTele2Number.UseSystemPasswordChar = false;
			this.textBoxTele2Number.TextChanged += new global::System.EventHandler(this.textBoxTele2Number_TextChanged);
			this.flatLabel31.AutoSize = true;
			this.flatLabel31.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel31.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel31.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel31.Location = new global::System.Drawing.Point(4, 27);
			this.flatLabel31.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel31.Name = "flatLabel31";
			this.flatLabel31.Size = new global::System.Drawing.Size(46, 13);
			this.flatLabel31.TabIndex = 26;
			this.flatLabel31.Text = "Номер:";
			this.groupBox14.Controls.Add(this.flatLabel27);
			this.groupBox14.Controls.Add(this.textBoxYandexProxyName);
			this.groupBox14.Controls.Add(this.textBoxYandexProxyPort);
			this.groupBox14.Controls.Add(this.flatLabel28);
			this.groupBox14.Controls.Add(this.flatLabel26);
			this.groupBox14.Controls.Add(this.textBoxYansexRedirectUri);
			this.groupBox14.Controls.Add(this.IsYandexAvailable);
			this.groupBox14.Controls.Add(this.flatButton1);
			this.groupBox14.Controls.Add(this.textBoxYandexAddress);
			this.groupBox14.Controls.Add(this.flatLabel24);
			this.groupBox14.Controls.Add(this.textBoxYansexClientId);
			this.groupBox14.Controls.Add(this.flatLabel25);
			this.groupBox14.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox14.Location = new global::System.Drawing.Point(1, 89);
			this.groupBox14.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox14.Size = new global::System.Drawing.Size(305, 223);
			this.groupBox14.TabIndex = 94;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "      Yandex";
			this.flatLabel27.AutoSize = true;
			this.flatLabel27.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel27.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel27.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel27.Location = new global::System.Drawing.Point(5, 159);
			this.flatLabel27.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel27.Name = "flatLabel27";
			this.flatLabel27.Size = new global::System.Drawing.Size(75, 13);
			this.flatLabel27.TabIndex = 45;
			this.flatLabel27.Text = "Имя:Пароль:";
			this.textBoxYandexProxyName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxYandexProxyName.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxYandexProxyName.FocusOnHover = false;
			this.textBoxYandexProxyName.Location = new global::System.Drawing.Point(82, 154);
			this.textBoxYandexProxyName.MaxLength = 32767;
			this.textBoxYandexProxyName.Multiline = false;
			this.textBoxYandexProxyName.Name = "textBoxYandexProxyName";
			this.textBoxYandexProxyName.ReadOnly = false;
			this.textBoxYandexProxyName.Size = new global::System.Drawing.Size(218, 29);
			this.textBoxYandexProxyName.TabIndex = 44;
			this.textBoxYandexProxyName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxYandexProxyName.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxYandexProxyName.UseSystemPasswordChar = false;
			this.textBoxYandexProxyName.TextChanged += new global::System.EventHandler(this.textBoxYandexProxyName_TextChanged);
			this.textBoxYandexProxyPort.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxYandexProxyPort.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxYandexProxyPort.FocusOnHover = false;
			this.textBoxYandexProxyPort.Location = new global::System.Drawing.Point(82, 122);
			this.textBoxYandexProxyPort.MaxLength = 32767;
			this.textBoxYandexProxyPort.Multiline = false;
			this.textBoxYandexProxyPort.Name = "textBoxYandexProxyPort";
			this.textBoxYandexProxyPort.ReadOnly = false;
			this.textBoxYandexProxyPort.Size = new global::System.Drawing.Size(218, 29);
			this.textBoxYandexProxyPort.TabIndex = 43;
			this.textBoxYandexProxyPort.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxYandexProxyPort.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxYandexProxyPort.UseSystemPasswordChar = false;
			this.textBoxYandexProxyPort.TextChanged += new global::System.EventHandler(this.textBoxYandexProxyPort_TextChanged);
			this.flatLabel28.AutoSize = true;
			this.flatLabel28.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel28.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel28.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel28.Location = new global::System.Drawing.Point(5, 128);
			this.flatLabel28.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel28.Name = "flatLabel28";
			this.flatLabel28.Size = new global::System.Drawing.Size(79, 13);
			this.flatLabel28.TabIndex = 42;
			this.flatLabel28.Text = "Прокси:порт:";
			this.flatLabel26.AutoSize = true;
			this.flatLabel26.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel26.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel26.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel26.Location = new global::System.Drawing.Point(5, 59);
			this.flatLabel26.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel26.Name = "flatLabel26";
			this.flatLabel26.Size = new global::System.Drawing.Size(28, 13);
			this.flatLabel26.TabIndex = 41;
			this.flatLabel26.Text = "URI:";
			this.textBoxYansexRedirectUri.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxYansexRedirectUri.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxYansexRedirectUri.FocusOnHover = false;
			this.textBoxYansexRedirectUri.Location = new global::System.Drawing.Point(82, 54);
			this.textBoxYansexRedirectUri.MaxLength = 32767;
			this.textBoxYansexRedirectUri.Multiline = false;
			this.textBoxYansexRedirectUri.Name = "textBoxYansexRedirectUri";
			this.textBoxYansexRedirectUri.ReadOnly = false;
			this.textBoxYansexRedirectUri.Size = new global::System.Drawing.Size(218, 29);
			this.textBoxYansexRedirectUri.TabIndex = 40;
			this.textBoxYansexRedirectUri.Text = "http://";
			this.textBoxYansexRedirectUri.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxYansexRedirectUri.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxYansexRedirectUri.UseSystemPasswordChar = false;
			this.textBoxYansexRedirectUri.TextChanged += new global::System.EventHandler(this.textBoxYansexRedirectUri_TextChanged);
			this.IsYandexAvailable.AutoSize = true;
			this.IsYandexAvailable.Location = new global::System.Drawing.Point(10, 4);
			this.IsYandexAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsYandexAvailable.Name = "IsYandexAvailable";
			this.IsYandexAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.IsYandexAvailable.TabIndex = 39;
			this.IsYandexAvailable.UseVisualStyleBackColor = true;
			this.IsYandexAvailable.CheckedChanged += new global::System.EventHandler(this.IsYandexAvailable_CheckedChanged);
			this.flatButton1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButton1.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButton1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButton1.Location = new global::System.Drawing.Point(161, 187);
			this.flatButton1.Name = "flatButton1";
			this.flatButton1.Rounded = false;
			this.flatButton1.Size = new global::System.Drawing.Size(139, 29);
			this.flatButton1.TabIndex = 38;
			this.flatButton1.Text = "→ Подключиться";
			this.flatButton1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButton1.Click += new global::System.EventHandler(this.flatButton1_Click);
			this.textBoxYandexAddress.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxYandexAddress.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxYandexAddress.FocusOnHover = false;
			this.textBoxYandexAddress.Location = new global::System.Drawing.Point(82, 21);
			this.textBoxYandexAddress.MaxLength = 32767;
			this.textBoxYandexAddress.Multiline = false;
			this.textBoxYandexAddress.Name = "textBoxYandexAddress";
			this.textBoxYandexAddress.ReadOnly = false;
			this.textBoxYandexAddress.Size = new global::System.Drawing.Size(218, 29);
			this.textBoxYandexAddress.TabIndex = 27;
			this.textBoxYandexAddress.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxYandexAddress.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxYandexAddress.UseSystemPasswordChar = false;
			this.textBoxYandexAddress.TextChanged += new global::System.EventHandler(this.textBoxYandexAddress_TextChanged);
			this.flatLabel24.AutoSize = true;
			this.flatLabel24.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel24.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel24.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel24.Location = new global::System.Drawing.Point(4, 93);
			this.flatLabel24.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel24.Name = "flatLabel24";
			this.flatLabel24.Size = new global::System.Drawing.Size(81, 13);
			this.flatLabel24.TabIndex = 28;
			this.flatLabel24.Text = "Идентефикат:";
			this.textBoxYansexClientId.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBoxYansexClientId.BackColor = global::System.Drawing.Color.Transparent;
			this.textBoxYansexClientId.FocusOnHover = false;
			this.textBoxYansexClientId.Location = new global::System.Drawing.Point(82, 88);
			this.textBoxYansexClientId.MaxLength = 32767;
			this.textBoxYansexClientId.Multiline = false;
			this.textBoxYansexClientId.Name = "textBoxYansexClientId";
			this.textBoxYansexClientId.ReadOnly = false;
			this.textBoxYansexClientId.Size = new global::System.Drawing.Size(218, 29);
			this.textBoxYansexClientId.TabIndex = 29;
			this.textBoxYansexClientId.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textBoxYansexClientId.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textBoxYansexClientId.UseSystemPasswordChar = false;
			this.textBoxYansexClientId.TextChanged += new global::System.EventHandler(this.textBoxYansexClientId_TextChanged);
			this.flatLabel25.AutoSize = true;
			this.flatLabel25.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel25.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel25.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel25.Location = new global::System.Drawing.Point(5, 27);
			this.flatLabel25.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel25.Name = "flatLabel25";
			this.flatLabel25.Size = new global::System.Drawing.Size(56, 13);
			this.flatLabel25.TabIndex = 26;
			this.flatLabel25.Text = "Кошелек:";
			this.textNumber10.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber10.FocusOnHover = false;
			this.textNumber10.Location = new global::System.Drawing.Point(311, 444);
			this.textNumber10.MaxLength = 32767;
			this.textNumber10.Multiline = false;
			this.textNumber10.Name = "textNumber10";
			this.textNumber10.ReadOnly = false;
			this.textNumber10.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber10.TabIndex = 91;
			this.textNumber10.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber10.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber10.UseSystemPasswordChar = false;
			this.textAPI10.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI10.FocusOnHover = false;
			this.textAPI10.Location = new global::System.Drawing.Point(513, 444);
			this.textAPI10.MaxLength = 32767;
			this.textAPI10.Multiline = false;
			this.textAPI10.Name = "textAPI10";
			this.textAPI10.ReadOnly = false;
			this.textAPI10.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI10.TabIndex = 92;
			this.textAPI10.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI10.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI10.UseSystemPasswordChar = true;
			this.labelF10.AutoSize = true;
			this.labelF10.ForeColor = global::System.Drawing.Color.White;
			this.labelF10.Location = new global::System.Drawing.Point(314, 471);
			this.labelF10.Name = "labelF10";
			this.labelF10.Size = new global::System.Drawing.Size(19, 19);
			this.labelF10.TabIndex = 93;
			this.labelF10.Text = " _";
			this.textPass10.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass10.FocusOnHover = false;
			this.textPass10.Location = new global::System.Drawing.Point(923, 444);
			this.textPass10.MaxLength = 32767;
			this.textPass10.Multiline = false;
			this.textPass10.Name = "textPass10";
			this.textPass10.ReadOnly = false;
			this.textPass10.Size = new global::System.Drawing.Size(174, 29);
			this.textPass10.TabIndex = 90;
			this.textPass10.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass10.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass10.UseSystemPasswordChar = false;
			this.textProxy10.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy10.FocusOnHover = false;
			this.textProxy10.Location = new global::System.Drawing.Point(715, 444);
			this.textProxy10.MaxLength = 32767;
			this.textProxy10.Multiline = false;
			this.textProxy10.Name = "textProxy10";
			this.textProxy10.ReadOnly = false;
			this.textProxy10.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy10.TabIndex = 89;
			this.textProxy10.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy10.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy10.UseSystemPasswordChar = false;
			this.textNumber9.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber9.FocusOnHover = false;
			this.textNumber9.Location = new global::System.Drawing.Point(311, 396);
			this.textNumber9.MaxLength = 32767;
			this.textNumber9.Multiline = false;
			this.textNumber9.Name = "textNumber9";
			this.textNumber9.ReadOnly = false;
			this.textNumber9.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber9.TabIndex = 86;
			this.textNumber9.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber9.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber9.UseSystemPasswordChar = false;
			this.textAPI9.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI9.FocusOnHover = false;
			this.textAPI9.Location = new global::System.Drawing.Point(513, 396);
			this.textAPI9.MaxLength = 32767;
			this.textAPI9.Multiline = false;
			this.textAPI9.Name = "textAPI9";
			this.textAPI9.ReadOnly = false;
			this.textAPI9.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI9.TabIndex = 87;
			this.textAPI9.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI9.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI9.UseSystemPasswordChar = true;
			this.labelF9.AutoSize = true;
			this.labelF9.ForeColor = global::System.Drawing.Color.White;
			this.labelF9.Location = new global::System.Drawing.Point(314, 427);
			this.labelF9.Name = "labelF9";
			this.labelF9.Size = new global::System.Drawing.Size(19, 19);
			this.labelF9.TabIndex = 88;
			this.labelF9.Text = " _";
			this.textPass9.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass9.FocusOnHover = false;
			this.textPass9.Location = new global::System.Drawing.Point(923, 396);
			this.textPass9.MaxLength = 32767;
			this.textPass9.Multiline = false;
			this.textPass9.Name = "textPass9";
			this.textPass9.ReadOnly = false;
			this.textPass9.Size = new global::System.Drawing.Size(174, 29);
			this.textPass9.TabIndex = 85;
			this.textPass9.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass9.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass9.UseSystemPasswordChar = false;
			this.textProxy9.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy9.FocusOnHover = false;
			this.textProxy9.Location = new global::System.Drawing.Point(715, 396);
			this.textProxy9.MaxLength = 32767;
			this.textProxy9.Multiline = false;
			this.textProxy9.Name = "textProxy9";
			this.textProxy9.ReadOnly = false;
			this.textProxy9.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy9.TabIndex = 84;
			this.textProxy9.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy9.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy9.UseSystemPasswordChar = false;
			this.textNumber8.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber8.FocusOnHover = false;
			this.textNumber8.Location = new global::System.Drawing.Point(311, 348);
			this.textNumber8.MaxLength = 32767;
			this.textNumber8.Multiline = false;
			this.textNumber8.Name = "textNumber8";
			this.textNumber8.ReadOnly = false;
			this.textNumber8.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber8.TabIndex = 80;
			this.textNumber8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber8.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber8.UseSystemPasswordChar = false;
			this.textAPI8.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI8.FocusOnHover = false;
			this.textAPI8.Location = new global::System.Drawing.Point(512, 348);
			this.textAPI8.MaxLength = 32767;
			this.textAPI8.Multiline = false;
			this.textAPI8.Name = "textAPI8";
			this.textAPI8.ReadOnly = false;
			this.textAPI8.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI8.TabIndex = 81;
			this.textAPI8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI8.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI8.UseSystemPasswordChar = true;
			this.labelF8.AutoSize = true;
			this.labelF8.ForeColor = global::System.Drawing.Color.White;
			this.labelF8.Location = new global::System.Drawing.Point(313, 378);
			this.labelF8.Name = "labelF8";
			this.labelF8.Size = new global::System.Drawing.Size(19, 19);
			this.labelF8.TabIndex = 83;
			this.labelF8.Text = " _";
			this.labelF7.AutoSize = true;
			this.labelF7.ForeColor = global::System.Drawing.Color.White;
			this.labelF7.Location = new global::System.Drawing.Point(313, 330);
			this.labelF7.Name = "labelF7";
			this.labelF7.Size = new global::System.Drawing.Size(19, 19);
			this.labelF7.TabIndex = 82;
			this.labelF7.Text = " _";
			this.textNumber7.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber7.FocusOnHover = false;
			this.textNumber7.Location = new global::System.Drawing.Point(311, 300);
			this.textNumber7.MaxLength = 32767;
			this.textNumber7.Multiline = false;
			this.textNumber7.Name = "textNumber7";
			this.textNumber7.ReadOnly = false;
			this.textNumber7.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber7.TabIndex = 78;
			this.textNumber7.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber7.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber7.UseSystemPasswordChar = false;
			this.textAPI7.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI7.FocusOnHover = false;
			this.textAPI7.Location = new global::System.Drawing.Point(512, 300);
			this.textAPI7.MaxLength = 32767;
			this.textAPI7.Multiline = false;
			this.textAPI7.Name = "textAPI7";
			this.textAPI7.ReadOnly = false;
			this.textAPI7.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI7.TabIndex = 79;
			this.textAPI7.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI7.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI7.UseSystemPasswordChar = true;
			this.textPass8.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass8.FocusOnHover = false;
			this.textPass8.Location = new global::System.Drawing.Point(923, 348);
			this.textPass8.MaxLength = 32767;
			this.textPass8.Multiline = false;
			this.textPass8.Name = "textPass8";
			this.textPass8.ReadOnly = false;
			this.textPass8.Size = new global::System.Drawing.Size(174, 29);
			this.textPass8.TabIndex = 77;
			this.textPass8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass8.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass8.UseSystemPasswordChar = false;
			this.textProxy8.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy8.FocusOnHover = false;
			this.textProxy8.Location = new global::System.Drawing.Point(715, 348);
			this.textProxy8.MaxLength = 32767;
			this.textProxy8.Multiline = false;
			this.textProxy8.Name = "textProxy8";
			this.textProxy8.ReadOnly = false;
			this.textProxy8.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy8.TabIndex = 76;
			this.textProxy8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy8.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy8.UseSystemPasswordChar = false;
			this.textPass7.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass7.FocusOnHover = false;
			this.textPass7.Location = new global::System.Drawing.Point(923, 300);
			this.textPass7.MaxLength = 32767;
			this.textPass7.Multiline = false;
			this.textPass7.Name = "textPass7";
			this.textPass7.ReadOnly = false;
			this.textPass7.Size = new global::System.Drawing.Size(174, 29);
			this.textPass7.TabIndex = 75;
			this.textPass7.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass7.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass7.UseSystemPasswordChar = false;
			this.textProxy7.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy7.FocusOnHover = false;
			this.textProxy7.Location = new global::System.Drawing.Point(715, 300);
			this.textProxy7.MaxLength = 32767;
			this.textProxy7.Multiline = false;
			this.textProxy7.Name = "textProxy7";
			this.textProxy7.ReadOnly = false;
			this.textProxy7.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy7.TabIndex = 74;
			this.textProxy7.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy7.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy7.UseSystemPasswordChar = false;
			this.textNumber6.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber6.FocusOnHover = false;
			this.textNumber6.Location = new global::System.Drawing.Point(311, 254);
			this.textNumber6.MaxLength = 32767;
			this.textNumber6.Multiline = false;
			this.textNumber6.Name = "textNumber6";
			this.textNumber6.ReadOnly = false;
			this.textNumber6.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber6.TabIndex = 71;
			this.textNumber6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber6.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber6.UseSystemPasswordChar = false;
			this.textAPI6.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI6.FocusOnHover = false;
			this.textAPI6.Location = new global::System.Drawing.Point(512, 254);
			this.textAPI6.MaxLength = 32767;
			this.textAPI6.Multiline = false;
			this.textAPI6.Name = "textAPI6";
			this.textAPI6.ReadOnly = false;
			this.textAPI6.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI6.TabIndex = 72;
			this.textAPI6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI6.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI6.UseSystemPasswordChar = true;
			this.labelF6.AutoSize = true;
			this.labelF6.ForeColor = global::System.Drawing.Color.White;
			this.labelF6.Location = new global::System.Drawing.Point(313, 283);
			this.labelF6.Name = "labelF6";
			this.labelF6.Size = new global::System.Drawing.Size(19, 19);
			this.labelF6.TabIndex = 73;
			this.labelF6.Text = " _";
			this.textPass6.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass6.FocusOnHover = false;
			this.textPass6.Location = new global::System.Drawing.Point(923, 254);
			this.textPass6.MaxLength = 32767;
			this.textPass6.Multiline = false;
			this.textPass6.Name = "textPass6";
			this.textPass6.ReadOnly = false;
			this.textPass6.Size = new global::System.Drawing.Size(174, 29);
			this.textPass6.TabIndex = 70;
			this.textPass6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass6.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass6.UseSystemPasswordChar = false;
			this.textProxy6.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy6.FocusOnHover = false;
			this.textProxy6.Location = new global::System.Drawing.Point(715, 254);
			this.textProxy6.MaxLength = 32767;
			this.textProxy6.Multiline = false;
			this.textProxy6.Name = "textProxy6";
			this.textProxy6.ReadOnly = false;
			this.textProxy6.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy6.TabIndex = 69;
			this.textProxy6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy6.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy6.UseSystemPasswordChar = false;
			this.textNumber5.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber5.FocusOnHover = false;
			this.textNumber5.Location = new global::System.Drawing.Point(311, 206);
			this.textNumber5.MaxLength = 32767;
			this.textNumber5.Multiline = false;
			this.textNumber5.Name = "textNumber5";
			this.textNumber5.ReadOnly = false;
			this.textNumber5.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber5.TabIndex = 66;
			this.textNumber5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber5.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber5.UseSystemPasswordChar = false;
			this.textAPI5.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI5.FocusOnHover = false;
			this.textAPI5.Location = new global::System.Drawing.Point(512, 206);
			this.textAPI5.MaxLength = 32767;
			this.textAPI5.Multiline = false;
			this.textAPI5.Name = "textAPI5";
			this.textAPI5.ReadOnly = false;
			this.textAPI5.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI5.TabIndex = 67;
			this.textAPI5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI5.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI5.UseSystemPasswordChar = true;
			this.labelF5.AutoSize = true;
			this.labelF5.ForeColor = global::System.Drawing.Color.White;
			this.labelF5.Location = new global::System.Drawing.Point(313, 236);
			this.labelF5.Name = "labelF5";
			this.labelF5.Size = new global::System.Drawing.Size(19, 19);
			this.labelF5.TabIndex = 68;
			this.labelF5.Text = " _";
			this.textPass5.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass5.FocusOnHover = false;
			this.textPass5.Location = new global::System.Drawing.Point(923, 206);
			this.textPass5.MaxLength = 32767;
			this.textPass5.Multiline = false;
			this.textPass5.Name = "textPass5";
			this.textPass5.ReadOnly = false;
			this.textPass5.Size = new global::System.Drawing.Size(174, 29);
			this.textPass5.TabIndex = 65;
			this.textPass5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass5.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass5.UseSystemPasswordChar = false;
			this.textProxy5.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy5.FocusOnHover = false;
			this.textProxy5.Location = new global::System.Drawing.Point(715, 206);
			this.textProxy5.MaxLength = 32767;
			this.textProxy5.Multiline = false;
			this.textProxy5.Name = "textProxy5";
			this.textProxy5.ReadOnly = false;
			this.textProxy5.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy5.TabIndex = 64;
			this.textProxy5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy5.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy5.UseSystemPasswordChar = false;
			this.flatLabel19.AutoSize = true;
			this.flatLabel19.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel19.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatLabel19.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel19.Location = new global::System.Drawing.Point(6, 7);
			this.flatLabel19.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel19.Name = "flatLabel19";
			this.flatLabel19.Size = new global::System.Drawing.Size(178, 19);
			this.flatLabel19.TabIndex = 63;
			this.flatLabel19.Text = "Активировать оплату Qiwi:";
			this.IsQiwiAvailable1.AutoSize = true;
			this.IsQiwiAvailable1.Location = new global::System.Drawing.Point(176, 12);
			this.IsQiwiAvailable1.Margin = new global::System.Windows.Forms.Padding(2);
			this.IsQiwiAvailable1.Name = "IsQiwiAvailable1";
			this.IsQiwiAvailable1.Size = new global::System.Drawing.Size(15, 14);
			this.IsQiwiAvailable1.TabIndex = 62;
			this.IsQiwiAvailable1.UseVisualStyleBackColor = true;
			this.IsQiwiAvailable1.CheckedChanged += new global::System.EventHandler(this.IsQiwiAvailable_CheckedChanged);
			this.radioButtonIsQiwiNumber.AutoSize = true;
			this.radioButtonIsQiwiNumber.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonIsQiwiNumber.Location = new global::System.Drawing.Point(228, 29);
			this.radioButtonIsQiwiNumber.Margin = new global::System.Windows.Forms.Padding(2);
			this.radioButtonIsQiwiNumber.Name = "radioButtonIsQiwiNumber";
			this.radioButtonIsQiwiNumber.Size = new global::System.Drawing.Size(77, 23);
			this.radioButtonIsQiwiNumber.TabIndex = 1;
			this.radioButtonIsQiwiNumber.Text = "Number";
			this.radioButtonIsQiwiNumber.UseVisualStyleBackColor = true;
			this.radioButtonIsQiwiNumber.CheckedChanged += new global::System.EventHandler(this.radioButtonIsQiwiNumber_CheckedChanged);
			this.textNumber4.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber4.FocusOnHover = false;
			this.textNumber4.Location = new global::System.Drawing.Point(310, 159);
			this.textNumber4.MaxLength = 32767;
			this.textNumber4.Multiline = false;
			this.textNumber4.Name = "textNumber4";
			this.textNumber4.ReadOnly = false;
			this.textNumber4.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber4.TabIndex = 51;
			this.textNumber4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber4.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber4.UseSystemPasswordChar = false;
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(6, 30);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(114, 19);
			this.label1.TabIndex = 41;
			this.label1.Text = "Вариант оплаты:";
			this.radioButtonIsQiwiCode.AutoSize = true;
			this.radioButtonIsQiwiCode.Checked = true;
			this.radioButtonIsQiwiCode.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonIsQiwiCode.Location = new global::System.Drawing.Point(166, 29);
			this.radioButtonIsQiwiCode.Margin = new global::System.Windows.Forms.Padding(2);
			this.radioButtonIsQiwiCode.Name = "radioButtonIsQiwiCode";
			this.radioButtonIsQiwiCode.Size = new global::System.Drawing.Size(59, 23);
			this.radioButtonIsQiwiCode.TabIndex = 0;
			this.radioButtonIsQiwiCode.TabStop = true;
			this.radioButtonIsQiwiCode.Text = "Code";
			this.radioButtonIsQiwiCode.UseVisualStyleBackColor = true;
			this.radioButtonIsQiwiCode.CheckedChanged += new global::System.EventHandler(this.radioButtonIsQiwiNumber_CheckedChanged);
			this.flatButtonQiwiInit.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonQiwiInit.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonQiwiInit.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonQiwiInit.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonQiwiInit.Location = new global::System.Drawing.Point(164, 58);
			this.flatButtonQiwiInit.Name = "flatButtonQiwiInit";
			this.flatButtonQiwiInit.Rounded = false;
			this.flatButtonQiwiInit.Size = new global::System.Drawing.Size(139, 32);
			this.flatButtonQiwiInit.TabIndex = 38;
			this.flatButtonQiwiInit.Text = "→ Подключиться";
			this.flatButtonQiwiInit.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonQiwiInit.Click += new global::System.EventHandler(this.FlatButtonQiwiProxy_Click);
			this.textAPI4.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI4.FocusOnHover = false;
			this.textAPI4.Location = new global::System.Drawing.Point(511, 159);
			this.textAPI4.MaxLength = 32767;
			this.textAPI4.Multiline = false;
			this.textAPI4.Name = "textAPI4";
			this.textAPI4.ReadOnly = false;
			this.textAPI4.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI4.TabIndex = 53;
			this.textAPI4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI4.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI4.UseSystemPasswordChar = true;
			this.labelF4.AutoSize = true;
			this.labelF4.ForeColor = global::System.Drawing.Color.White;
			this.labelF4.Location = new global::System.Drawing.Point(313, 188);
			this.labelF4.Name = "labelF4";
			this.labelF4.Size = new global::System.Drawing.Size(19, 19);
			this.labelF4.TabIndex = 60;
			this.labelF4.Text = " _";
			this.labelF3.AutoSize = true;
			this.labelF3.ForeColor = global::System.Drawing.Color.White;
			this.labelF3.Location = new global::System.Drawing.Point(313, 141);
			this.labelF3.Name = "labelF3";
			this.labelF3.Size = new global::System.Drawing.Size(19, 19);
			this.labelF3.TabIndex = 59;
			this.labelF3.Text = " _";
			this.textNumber3.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber3.FocusOnHover = false;
			this.textNumber3.Location = new global::System.Drawing.Point(310, 113);
			this.textNumber3.MaxLength = 32767;
			this.textNumber3.Multiline = false;
			this.textNumber3.Name = "textNumber3";
			this.textNumber3.ReadOnly = false;
			this.textNumber3.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber3.TabIndex = 47;
			this.textNumber3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber3.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber3.UseSystemPasswordChar = false;
			this.labelF2.AutoSize = true;
			this.labelF2.ForeColor = global::System.Drawing.Color.White;
			this.labelF2.Location = new global::System.Drawing.Point(313, 94);
			this.labelF2.Name = "labelF2";
			this.labelF2.Size = new global::System.Drawing.Size(19, 19);
			this.labelF2.TabIndex = 58;
			this.labelF2.Text = " _";
			this.labelF1.AutoSize = true;
			this.labelF1.ForeColor = global::System.Drawing.Color.White;
			this.labelF1.Location = new global::System.Drawing.Point(313, 48);
			this.labelF1.Name = "labelF1";
			this.labelF1.Size = new global::System.Drawing.Size(19, 19);
			this.labelF1.TabIndex = 57;
			this.labelF1.Text = " _";
			this.textAPI3.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI3.FocusOnHover = false;
			this.textAPI3.Location = new global::System.Drawing.Point(511, 113);
			this.textAPI3.MaxLength = 32767;
			this.textAPI3.Multiline = false;
			this.textAPI3.Name = "textAPI3";
			this.textAPI3.ReadOnly = false;
			this.textAPI3.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI3.TabIndex = 49;
			this.textAPI3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI3.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI3.UseSystemPasswordChar = true;
			this.textNumber2.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber2.FocusOnHover = false;
			this.textNumber2.Location = new global::System.Drawing.Point(310, 66);
			this.textNumber2.MaxLength = 32767;
			this.textNumber2.Multiline = false;
			this.textNumber2.Name = "textNumber2";
			this.textNumber2.ReadOnly = false;
			this.textNumber2.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber2.TabIndex = 43;
			this.textNumber2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber2.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber2.UseSystemPasswordChar = false;
			this.textPass4.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass4.FocusOnHover = false;
			this.textPass4.Location = new global::System.Drawing.Point(922, 159);
			this.textPass4.MaxLength = 32767;
			this.textPass4.Multiline = false;
			this.textPass4.Name = "textPass4";
			this.textPass4.ReadOnly = false;
			this.textPass4.Size = new global::System.Drawing.Size(174, 29);
			this.textPass4.TabIndex = 19;
			this.textPass4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass4.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass4.UseSystemPasswordChar = false;
			this.textProxy4.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy4.FocusOnHover = false;
			this.textProxy4.Location = new global::System.Drawing.Point(714, 159);
			this.textProxy4.MaxLength = 32767;
			this.textProxy4.Multiline = false;
			this.textProxy4.Name = "textProxy4";
			this.textProxy4.ReadOnly = false;
			this.textProxy4.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy4.TabIndex = 18;
			this.textProxy4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy4.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy4.UseSystemPasswordChar = false;
			this.textAPI2.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI2.FocusOnHover = false;
			this.textAPI2.Location = new global::System.Drawing.Point(511, 66);
			this.textAPI2.MaxLength = 32767;
			this.textAPI2.Multiline = false;
			this.textAPI2.Name = "textAPI2";
			this.textAPI2.ReadOnly = false;
			this.textAPI2.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI2.TabIndex = 45;
			this.textAPI2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI2.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI2.UseSystemPasswordChar = true;
			this.textPass3.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass3.FocusOnHover = false;
			this.textPass3.Location = new global::System.Drawing.Point(922, 113);
			this.textPass3.MaxLength = 32767;
			this.textPass3.Multiline = false;
			this.textPass3.Name = "textPass3";
			this.textPass3.ReadOnly = false;
			this.textPass3.Size = new global::System.Drawing.Size(174, 29);
			this.textPass3.TabIndex = 15;
			this.textPass3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass3.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass3.UseSystemPasswordChar = false;
			this.textProxy3.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy3.FocusOnHover = false;
			this.textProxy3.Location = new global::System.Drawing.Point(714, 113);
			this.textProxy3.MaxLength = 32767;
			this.textProxy3.Multiline = false;
			this.textProxy3.Name = "textProxy3";
			this.textProxy3.ReadOnly = false;
			this.textProxy3.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy3.TabIndex = 14;
			this.textProxy3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy3.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy3.UseSystemPasswordChar = false;
			this.textNumber1.BackColor = global::System.Drawing.Color.Transparent;
			this.textNumber1.FocusOnHover = false;
			this.textNumber1.Location = new global::System.Drawing.Point(310, 21);
			this.textNumber1.MaxLength = 32767;
			this.textNumber1.Multiline = false;
			this.textNumber1.Name = "textNumber1";
			this.textNumber1.ReadOnly = false;
			this.textNumber1.Size = new global::System.Drawing.Size(178, 29);
			this.textNumber1.TabIndex = 27;
			this.textNumber1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textNumber1.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textNumber1.UseSystemPasswordChar = false;
			this.textPass2.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass2.FocusOnHover = false;
			this.textPass2.Location = new global::System.Drawing.Point(922, 66);
			this.textPass2.MaxLength = 32767;
			this.textPass2.Multiline = false;
			this.textPass2.Name = "textPass2";
			this.textPass2.ReadOnly = false;
			this.textPass2.Size = new global::System.Drawing.Size(174, 29);
			this.textPass2.TabIndex = 11;
			this.textPass2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass2.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass2.UseSystemPasswordChar = false;
			this.flatLabel13.AutoSize = true;
			this.flatLabel13.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel13.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel13.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel13.Location = new global::System.Drawing.Point(508, 4);
			this.flatLabel13.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel13.Name = "flatLabel13";
			this.flatLabel13.Size = new global::System.Drawing.Size(27, 13);
			this.flatLabel13.TabIndex = 28;
			this.flatLabel13.Text = "Api:";
			this.textProxy2.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy2.FocusOnHover = false;
			this.textProxy2.Location = new global::System.Drawing.Point(714, 66);
			this.textProxy2.MaxLength = 32767;
			this.textProxy2.Multiline = false;
			this.textProxy2.Name = "textProxy2";
			this.textProxy2.ReadOnly = false;
			this.textProxy2.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy2.TabIndex = 10;
			this.textProxy2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy2.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy2.UseSystemPasswordChar = false;
			this.textAPI1.BackColor = global::System.Drawing.Color.Transparent;
			this.textAPI1.FocusOnHover = false;
			this.textAPI1.Location = new global::System.Drawing.Point(511, 21);
			this.textAPI1.MaxLength = 32767;
			this.textAPI1.Multiline = false;
			this.textAPI1.Name = "textAPI1";
			this.textAPI1.ReadOnly = false;
			this.textAPI1.Size = new global::System.Drawing.Size(178, 29);
			this.textAPI1.TabIndex = 29;
			this.textAPI1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textAPI1.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textAPI1.UseSystemPasswordChar = true;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(920, 4);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(72, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Имя:Пароль";
			this.flatLabel14.AutoSize = true;
			this.flatLabel14.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel14.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel14.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel14.Location = new global::System.Drawing.Point(308, 4);
			this.flatLabel14.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel14.Name = "flatLabel14";
			this.flatLabel14.Size = new global::System.Drawing.Size(51, 13);
			this.flatLabel14.TabIndex = 26;
			this.flatLabel14.Text = "Number:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(712, 4);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(76, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Прокси:порт";
			this.textPass1.BackColor = global::System.Drawing.Color.Transparent;
			this.textPass1.FocusOnHover = false;
			this.textPass1.Location = new global::System.Drawing.Point(922, 21);
			this.textPass1.MaxLength = 32767;
			this.textPass1.Multiline = false;
			this.textPass1.Name = "textPass1";
			this.textPass1.ReadOnly = false;
			this.textPass1.Size = new global::System.Drawing.Size(174, 29);
			this.textPass1.TabIndex = 5;
			this.textPass1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textPass1.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textPass1.UseSystemPasswordChar = false;
			this.textProxy1.BackColor = global::System.Drawing.Color.Transparent;
			this.textProxy1.FocusOnHover = false;
			this.textProxy1.Location = new global::System.Drawing.Point(714, 21);
			this.textProxy1.MaxLength = 32767;
			this.textProxy1.Multiline = false;
			this.textProxy1.Name = "textProxy1";
			this.textProxy1.ReadOnly = false;
			this.textProxy1.Size = new global::System.Drawing.Size(178, 29);
			this.textProxy1.TabIndex = 4;
			this.textProxy1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.textProxy1.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.textProxy1.UseSystemPasswordChar = false;
			this.tabPageSender.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageSender.Controls.Add(this.flatButtonSender);
			this.tabPageSender.Controls.Add(this.flatTextBoxSender);
			this.tabPageSender.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageSender.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabPageSender.Name = "tabPageSender";
			this.tabPageSender.Padding = new global::System.Windows.Forms.Padding(2);
			this.tabPageSender.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageSender.TabIndex = 4;
			this.tabPageSender.Text = "Рассылка";
			this.flatButtonSender.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonSender.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonSender.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonSender.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonSender.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonSender.Location = new global::System.Drawing.Point(1158, 519);
			this.flatButtonSender.Name = "flatButtonSender";
			this.flatButtonSender.Rounded = false;
			this.flatButtonSender.Size = new global::System.Drawing.Size(111, 32);
			this.flatButtonSender.TabIndex = 5;
			this.flatButtonSender.Text = "Разослать";
			this.flatButtonSender.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonSender.Click += new global::System.EventHandler(this.FlatButtonSender_Click);
			this.flatTextBoxSender.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxSender.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxSender.FocusOnHover = false;
			this.flatTextBoxSender.Location = new global::System.Drawing.Point(4, 5);
			this.flatTextBoxSender.MaxLength = 32767;
			this.flatTextBoxSender.Multiline = true;
			this.flatTextBoxSender.Name = "flatTextBoxSender";
			this.flatTextBoxSender.ReadOnly = false;
			this.flatTextBoxSender.Size = new global::System.Drawing.Size(1264, 508);
			this.flatTextBoxSender.TabIndex = 4;
			this.flatTextBoxSender.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxSender.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxSender.UseSystemPasswordChar = false;
			this.tabPageStatistic.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageStatistic.Controls.Add(this.bStatisticsCommonProduct);
			this.tabPageStatistic.Controls.Add(this.bStatisticsCommonЗкщвгсе);
			this.tabPageStatistic.Controls.Add(this.bStatisticsCommonCategories);
			this.tabPageStatistic.Controls.Add(this.bStatisticsCommon);
			this.tabPageStatistic.Controls.Add(this.flatLabel33);
			this.tabPageStatistic.Controls.Add(this.bStatisticsPromoCodes);
			this.tabPageStatistic.Controls.Add(this.flatButtonChart2);
			this.tabPageStatistic.Controls.Add(this.flatButtonChart1);
			this.tabPageStatistic.Controls.Add(this.chartStatistics);
			this.tabPageStatistic.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageStatistic.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabPageStatistic.Name = "tabPageStatistic";
			this.tabPageStatistic.Padding = new global::System.Windows.Forms.Padding(2);
			this.tabPageStatistic.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageStatistic.TabIndex = 6;
			this.tabPageStatistic.Text = "Статистика";
			this.bStatisticsCommonProduct.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.bStatisticsCommonProduct.BackColor = global::System.Drawing.Color.Transparent;
			this.bStatisticsCommonProduct.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bStatisticsCommonProduct.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bStatisticsCommonProduct.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.bStatisticsCommonProduct.Location = new global::System.Drawing.Point(1111, 439);
			this.bStatisticsCommonProduct.Name = "bStatisticsCommonProduct";
			this.bStatisticsCommonProduct.Rounded = false;
			this.bStatisticsCommonProduct.Size = new global::System.Drawing.Size(161, 53);
			this.bStatisticsCommonProduct.TabIndex = 9;
			this.bStatisticsCommonProduct.Text = "По продуктам";
			this.bStatisticsCommonProduct.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bStatisticsCommonProduct.Click += new global::System.EventHandler(this.bStatisticsCommonProduct_Click);
			this.bStatisticsCommonЗкщвгсе.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.bStatisticsCommonЗкщвгсе.BackColor = global::System.Drawing.Color.Transparent;
			this.bStatisticsCommonЗкщвгсе.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bStatisticsCommonЗкщвгсе.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bStatisticsCommonЗкщвгсе.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.bStatisticsCommonЗкщвгсе.Location = new global::System.Drawing.Point(1110, 379);
			this.bStatisticsCommonЗкщвгсе.Name = "bStatisticsCommonЗкщвгсе";
			this.bStatisticsCommonЗкщвгсе.Rounded = false;
			this.bStatisticsCommonЗкщвгсе.Size = new global::System.Drawing.Size(161, 53);
			this.bStatisticsCommonЗкщвгсе.TabIndex = 8;
			this.bStatisticsCommonЗкщвгсе.Text = "По ветке категорий";
			this.bStatisticsCommonЗкщвгсе.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bStatisticsCommonЗкщвгсе.Click += new global::System.EventHandler(this.bStatisticsCommonЗкщвгсе_Click);
			this.bStatisticsCommonCategories.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.bStatisticsCommonCategories.BackColor = global::System.Drawing.Color.Transparent;
			this.bStatisticsCommonCategories.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bStatisticsCommonCategories.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bStatisticsCommonCategories.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.bStatisticsCommonCategories.Location = new global::System.Drawing.Point(1111, 498);
			this.bStatisticsCommonCategories.Name = "bStatisticsCommonCategories";
			this.bStatisticsCommonCategories.Rounded = false;
			this.bStatisticsCommonCategories.Size = new global::System.Drawing.Size(161, 53);
			this.bStatisticsCommonCategories.TabIndex = 7;
			this.bStatisticsCommonCategories.Text = "По категориям 'Наличие'";
			this.bStatisticsCommonCategories.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bStatisticsCommonCategories.Click += new global::System.EventHandler(this.bStatisticsCommonCategories_Click);
			this.bStatisticsCommon.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.bStatisticsCommon.BackColor = global::System.Drawing.Color.Transparent;
			this.bStatisticsCommon.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bStatisticsCommon.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bStatisticsCommon.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.bStatisticsCommon.Location = new global::System.Drawing.Point(1110, 320);
			this.bStatisticsCommon.Name = "bStatisticsCommon";
			this.bStatisticsCommon.Rounded = false;
			this.bStatisticsCommon.Size = new global::System.Drawing.Size(161, 53);
			this.bStatisticsCommon.TabIndex = 6;
			this.bStatisticsCommon.Text = "Статистика транзакций";
			this.bStatisticsCommon.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bStatisticsCommon.Click += new global::System.EventHandler(this.bStatisticsCommon_Click);
			this.flatLabel33.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatLabel33.AutoSize = true;
			this.flatLabel33.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel33.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel33.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel33.Location = new global::System.Drawing.Point(1111, 301);
			this.flatLabel33.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.flatLabel33.Name = "flatLabel33";
			this.flatLabel33.Size = new global::System.Drawing.Size(81, 13);
			this.flatLabel33.TabIndex = 5;
			this.flatLabel33.Text = "Сообщением:";
			this.bStatisticsPromoCodes.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bStatisticsPromoCodes.BackColor = global::System.Drawing.Color.Transparent;
			this.bStatisticsPromoCodes.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bStatisticsPromoCodes.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bStatisticsPromoCodes.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.bStatisticsPromoCodes.Location = new global::System.Drawing.Point(1108, 124);
			this.bStatisticsPromoCodes.Name = "bStatisticsPromoCodes";
			this.bStatisticsPromoCodes.Rounded = false;
			this.bStatisticsPromoCodes.Size = new global::System.Drawing.Size(161, 53);
			this.bStatisticsPromoCodes.TabIndex = 4;
			this.bStatisticsPromoCodes.Text = "Промокоды";
			this.bStatisticsPromoCodes.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bStatisticsPromoCodes.Click += new global::System.EventHandler(this.bStatisticsPromoCodes_Click);
			this.flatButtonChart2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonChart2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonChart2.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonChart2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonChart2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatButtonChart2.Location = new global::System.Drawing.Point(1108, 65);
			this.flatButtonChart2.Name = "flatButtonChart2";
			this.flatButtonChart2.Rounded = false;
			this.flatButtonChart2.Size = new global::System.Drawing.Size(161, 53);
			this.flatButtonChart2.TabIndex = 3;
			this.flatButtonChart2.Text = "Активные товары и их продажи";
			this.flatButtonChart2.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonChart2.Click += new global::System.EventHandler(this.FlatButtonChart2_Click);
			this.flatButtonChart1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonChart1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonChart1.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonChart1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonChart1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatButtonChart1.Location = new global::System.Drawing.Point(1108, 6);
			this.flatButtonChart1.Name = "flatButtonChart1";
			this.flatButtonChart1.Rounded = false;
			this.flatButtonChart1.Size = new global::System.Drawing.Size(161, 53);
			this.flatButtonChart1.TabIndex = 2;
			this.flatButtonChart1.Text = "По всем проданным товарам";
			this.flatButtonChart1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonChart1.Click += new global::System.EventHandler(this.FlatButtonChart1_Click);
			this.chartStatistics.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			chartArea.Name = "ChartArea1";
			this.chartStatistics.ChartAreas.Add(chartArea);
			legend.Name = "Legend1";
			this.chartStatistics.Legends.Add(legend);
			this.chartStatistics.Location = new global::System.Drawing.Point(-3, 0);
			this.chartStatistics.Margin = new global::System.Windows.Forms.Padding(2);
			this.chartStatistics.Name = "chartStatistics";
			series.ChartArea = "ChartArea1";
			series.Legend = "Legend1";
			series.Name = "Series1";
			this.chartStatistics.Series.Add(series);
			this.chartStatistics.Size = new global::System.Drawing.Size(1106, 551);
			this.chartStatistics.TabIndex = 0;
			this.chartStatistics.Text = "chart1";
			this.tabPageReviwers.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageReviwers.Controls.Add(this.dataGridViewReviews);
			this.tabPageReviwers.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageReviwers.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabPageReviwers.Name = "tabPageReviwers";
			this.tabPageReviwers.Padding = new global::System.Windows.Forms.Padding(2);
			this.tabPageReviwers.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageReviwers.TabIndex = 8;
			this.tabPageReviwers.Text = "Отзывы";
			this.dataGridViewReviews.AllowUserToAddRows = false;
			this.dataGridViewReviews.AllowUserToDeleteRows = false;
			this.dataGridViewReviews.AllowUserToResizeRows = false;
			this.dataGridViewReviews.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridViewReviews.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridViewReviews.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReviews.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewReviews.Location = new global::System.Drawing.Point(2, 2);
			this.dataGridViewReviews.Name = "dataGridViewReviews";
			this.dataGridViewReviews.ReadOnly = true;
			this.dataGridViewReviews.RowHeadersVisible = false;
			this.dataGridViewReviews.RowHeadersWidth = 51;
			this.dataGridViewReviews.Size = new global::System.Drawing.Size(1268, 535);
			this.dataGridViewReviews.TabIndex = 15;
			this.tabPageAddButton.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPageAddButton.Controls.Add(this.bTelegramPageSave);
			this.tabPageAddButton.Controls.Add(this.groupBox16);
			this.tabPageAddButton.Controls.Add(this.groupBoxTelegramPage);
			this.tabPageAddButton.Location = new global::System.Drawing.Point(4, 44);
			this.tabPageAddButton.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabPageAddButton.Name = "tabPageAddButton";
			this.tabPageAddButton.Padding = new global::System.Windows.Forms.Padding(2);
			this.tabPageAddButton.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPageAddButton.TabIndex = 9;
			this.tabPageAddButton.Text = "Доп кнопки";
			this.bTelegramPageSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bTelegramPageSave.BackColor = global::System.Drawing.Color.Transparent;
			this.bTelegramPageSave.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bTelegramPageSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bTelegramPageSave.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.bTelegramPageSave.Location = new global::System.Drawing.Point(371, 523);
			this.bTelegramPageSave.Name = "bTelegramPageSave";
			this.bTelegramPageSave.Rounded = false;
			this.bTelegramPageSave.Size = new global::System.Drawing.Size(416, 24);
			this.bTelegramPageSave.TabIndex = 43;
			this.bTelegramPageSave.Text = "Сохранить";
			this.bTelegramPageSave.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bTelegramPageSave.Click += new global::System.EventHandler(this.bTelegramPageSave_Click);
			this.groupBox16.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.groupBox16.Controls.Add(this.tvTelegramPages);
			this.groupBox16.Controls.Add(this.panel6);
			this.groupBox16.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.groupBox16.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox16.Location = new global::System.Drawing.Point(5, 5);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new global::System.Drawing.Size(361, 546);
			this.groupBox16.TabIndex = 18;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Cтраницы";
			this.tvTelegramPages.BackColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.tvTelegramPages.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.tvTelegramPages.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tvTelegramPages.ForeColor = global::System.Drawing.Color.White;
			this.tvTelegramPages.HideSelection = false;
			this.tvTelegramPages.LineColor = global::System.Drawing.Color.FromArgb(25, 27, 29);
			this.tvTelegramPages.Location = new global::System.Drawing.Point(3, 51);
			this.tvTelegramPages.Name = "tvTelegramPages";
			this.tvTelegramPages.Size = new global::System.Drawing.Size(355, 492);
			this.tvTelegramPages.TabIndex = 18;
			this.tvTelegramPages.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.tvTelegramPages_AfterSelect);
			this.panel6.Controls.Add(this.bTelegramPagesDelete);
			this.panel6.Controls.Add(this.bTelegramPagesAdd);
			this.panel6.Controls.Add(this.tbTelegramPagesNameToAdd);
			this.panel6.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new global::System.Drawing.Point(3, 21);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new global::System.Windows.Forms.Padding(3, 0, 3, 0);
			this.panel6.Size = new global::System.Drawing.Size(355, 30);
			this.panel6.TabIndex = 13;
			this.bTelegramPagesDelete.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bTelegramPagesDelete.BackColor = global::System.Drawing.Color.Transparent;
			this.bTelegramPagesDelete.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bTelegramPagesDelete.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bTelegramPagesDelete.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.bTelegramPagesDelete.Location = new global::System.Drawing.Point(319, 0);
			this.bTelegramPagesDelete.Name = "bTelegramPagesDelete";
			this.bTelegramPagesDelete.Rounded = false;
			this.bTelegramPagesDelete.Size = new global::System.Drawing.Size(35, 32);
			this.bTelegramPagesDelete.TabIndex = 19;
			this.bTelegramPagesDelete.Text = "X";
			this.bTelegramPagesDelete.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bTelegramPagesDelete.Click += new global::System.EventHandler(this.bTelegramPagesDelete_Click);
			this.bTelegramPagesAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bTelegramPagesAdd.BackColor = global::System.Drawing.Color.Transparent;
			this.bTelegramPagesAdd.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bTelegramPagesAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bTelegramPagesAdd.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.bTelegramPagesAdd.Location = new global::System.Drawing.Point(278, 0);
			this.bTelegramPagesAdd.Name = "bTelegramPagesAdd";
			this.bTelegramPagesAdd.Rounded = false;
			this.bTelegramPagesAdd.Size = new global::System.Drawing.Size(35, 32);
			this.bTelegramPagesAdd.TabIndex = 7;
			this.bTelegramPagesAdd.Text = "+";
			this.bTelegramPagesAdd.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bTelegramPagesAdd.Click += new global::System.EventHandler(this.bTelegramPagesAdd_Click);
			this.tbTelegramPagesNameToAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tbTelegramPagesNameToAdd.BackColor = global::System.Drawing.Color.Transparent;
			this.tbTelegramPagesNameToAdd.FocusOnHover = false;
			this.tbTelegramPagesNameToAdd.Location = new global::System.Drawing.Point(0, 1);
			this.tbTelegramPagesNameToAdd.MaxLength = 32767;
			this.tbTelegramPagesNameToAdd.Multiline = false;
			this.tbTelegramPagesNameToAdd.Name = "tbTelegramPagesNameToAdd";
			this.tbTelegramPagesNameToAdd.ReadOnly = false;
			this.tbTelegramPagesNameToAdd.Size = new global::System.Drawing.Size(274, 29);
			this.tbTelegramPagesNameToAdd.TabIndex = 0;
			this.tbTelegramPagesNameToAdd.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.tbTelegramPagesNameToAdd.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.tbTelegramPagesNameToAdd.UseSystemPasswordChar = false;
			this.groupBoxTelegramPage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.groupBoxTelegramPage.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.groupBoxTelegramPage.Controls.Add(this.lbTelegramPagePicPath);
			this.groupBoxTelegramPage.Controls.Add(this.bTelegramPagePicDelete);
			this.groupBoxTelegramPage.Controls.Add(this.bTelegramPagePicSelect);
			this.groupBoxTelegramPage.Controls.Add(this.pbTelegramPagePic);
			this.groupBoxTelegramPage.Controls.Add(this.tbTelegramPageText);
			this.groupBoxTelegramPage.Controls.Add(this.flatLabel21);
			this.groupBoxTelegramPage.Controls.Add(this.cbIsTelegramPageAvailable);
			this.groupBoxTelegramPage.Controls.Add(this.tbTelegramPageName);
			this.groupBoxTelegramPage.Controls.Add(this.label13);
			this.groupBoxTelegramPage.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBoxTelegramPage.Location = new global::System.Drawing.Point(371, 5);
			this.groupBoxTelegramPage.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBoxTelegramPage.Name = "groupBoxTelegramPage";
			this.groupBoxTelegramPage.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBoxTelegramPage.Size = new global::System.Drawing.Size(416, 517);
			this.groupBoxTelegramPage.TabIndex = 0;
			this.groupBoxTelegramPage.TabStop = false;
			this.groupBoxTelegramPage.Text = "      Настройки страницы";
			this.lbTelegramPagePicPath.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lbTelegramPagePicPath.AutoSize = true;
			this.lbTelegramPagePicPath.ForeColor = global::System.Drawing.Color.White;
			this.lbTelegramPagePicPath.Location = new global::System.Drawing.Point(6, 492);
			this.lbTelegramPagePicPath.Name = "lbTelegramPagePicPath";
			this.lbTelegramPagePicPath.Size = new global::System.Drawing.Size(15, 19);
			this.lbTelegramPagePicPath.TabIndex = 44;
			this.lbTelegramPagePicPath.Text = "_";
			this.bTelegramPagePicDelete.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bTelegramPagePicDelete.BackColor = global::System.Drawing.Color.Transparent;
			this.bTelegramPagePicDelete.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bTelegramPagePicDelete.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bTelegramPagePicDelete.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.bTelegramPagePicDelete.Location = new global::System.Drawing.Point(92, 465);
			this.bTelegramPagePicDelete.Name = "bTelegramPagePicDelete";
			this.bTelegramPagePicDelete.Rounded = false;
			this.bTelegramPagePicDelete.Size = new global::System.Drawing.Size(81, 24);
			this.bTelegramPagePicDelete.TabIndex = 43;
			this.bTelegramPagePicDelete.Text = "Удалить";
			this.bTelegramPagePicDelete.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bTelegramPagePicDelete.Click += new global::System.EventHandler(this.buttonDeleteImageAddBut_Click);
			this.bTelegramPagePicSelect.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.bTelegramPagePicSelect.BackColor = global::System.Drawing.Color.Transparent;
			this.bTelegramPagePicSelect.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bTelegramPagePicSelect.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bTelegramPagePicSelect.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.bTelegramPagePicSelect.Location = new global::System.Drawing.Point(5, 465);
			this.bTelegramPagePicSelect.Name = "bTelegramPagePicSelect";
			this.bTelegramPagePicSelect.Rounded = false;
			this.bTelegramPagePicSelect.Size = new global::System.Drawing.Size(81, 24);
			this.bTelegramPagePicSelect.TabIndex = 42;
			this.bTelegramPagePicSelect.Text = "Выбрать";
			this.bTelegramPagePicSelect.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bTelegramPagePicSelect.Click += new global::System.EventHandler(this.buttonSelectImageAddBut_Click);
			this.pbTelegramPagePic.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pbTelegramPagePic.Location = new global::System.Drawing.Point(6, 249);
			this.pbTelegramPagePic.Margin = new global::System.Windows.Forms.Padding(2);
			this.pbTelegramPagePic.Name = "pbTelegramPagePic";
			this.pbTelegramPagePic.Size = new global::System.Drawing.Size(405, 211);
			this.pbTelegramPagePic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTelegramPagePic.TabIndex = 41;
			this.pbTelegramPagePic.TabStop = false;
			this.tbTelegramPageText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tbTelegramPageText.BackColor = global::System.Drawing.Color.Transparent;
			this.tbTelegramPageText.FocusOnHover = false;
			this.tbTelegramPageText.Location = new global::System.Drawing.Point(5, 73);
			this.tbTelegramPageText.MaxLength = 32767;
			this.tbTelegramPageText.Multiline = true;
			this.tbTelegramPageText.Name = "tbTelegramPageText";
			this.tbTelegramPageText.ReadOnly = false;
			this.tbTelegramPageText.Size = new global::System.Drawing.Size(405, 171);
			this.tbTelegramPageText.TabIndex = 5;
			this.tbTelegramPageText.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.tbTelegramPageText.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.tbTelegramPageText.UseSystemPasswordChar = false;
			this.flatLabel21.AutoSize = true;
			this.flatLabel21.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel21.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel21.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel21.Location = new global::System.Drawing.Point(6, 54);
			this.flatLabel21.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel21.Name = "flatLabel21";
			this.flatLabel21.Size = new global::System.Drawing.Size(37, 13);
			this.flatLabel21.TabIndex = 4;
			this.flatLabel21.Text = "Текст:";
			this.cbIsTelegramPageAvailable.AutoSize = true;
			this.cbIsTelegramPageAvailable.Location = new global::System.Drawing.Point(9, 2);
			this.cbIsTelegramPageAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsTelegramPageAvailable.Name = "cbIsTelegramPageAvailable";
			this.cbIsTelegramPageAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsTelegramPageAvailable.TabIndex = 2;
			this.cbIsTelegramPageAvailable.UseVisualStyleBackColor = true;
			this.cbIsTelegramPageAvailable.CheckedChanged += new global::System.EventHandler(this.checkBoxIsAddButtonAvailable_CheckedChanged);
			this.tbTelegramPageName.BackColor = global::System.Drawing.Color.Transparent;
			this.tbTelegramPageName.FocusOnHover = false;
			this.tbTelegramPageName.Location = new global::System.Drawing.Point(74, 24);
			this.tbTelegramPageName.Margin = new global::System.Windows.Forms.Padding(2);
			this.tbTelegramPageName.MaxLength = 32767;
			this.tbTelegramPageName.Multiline = false;
			this.tbTelegramPageName.Name = "tbTelegramPageName";
			this.tbTelegramPageName.ReadOnly = false;
			this.tbTelegramPageName.Size = new global::System.Drawing.Size(336, 29);
			this.tbTelegramPageName.TabIndex = 1;
			this.tbTelegramPageName.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.tbTelegramPageName.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.tbTelegramPageName.UseSystemPasswordChar = false;
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.label13.ForeColor = global::System.Drawing.Color.White;
			this.label13.Location = new global::System.Drawing.Point(6, 30);
			this.label13.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(61, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Название:";
			this.tabPagePromoCodes.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.tabPagePromoCodes.Controls.Add(this.flatLabel23);
			this.tabPagePromoCodes.Controls.Add(this.cbIsPromoCodeAvailable);
			this.tabPagePromoCodes.Controls.Add(this.groupBox15);
			this.tabPagePromoCodes.Controls.Add(this.dataGridViewPromoCodes);
			this.tabPagePromoCodes.Location = new global::System.Drawing.Point(4, 44);
			this.tabPagePromoCodes.Margin = new global::System.Windows.Forms.Padding(2);
			this.tabPagePromoCodes.Name = "tabPagePromoCodes";
			this.tabPagePromoCodes.Padding = new global::System.Windows.Forms.Padding(2);
			this.tabPagePromoCodes.Size = new global::System.Drawing.Size(1272, 539);
			this.tabPagePromoCodes.TabIndex = 10;
			this.tabPagePromoCodes.Text = "Промокоды";
			this.flatLabel23.AutoSize = true;
			this.flatLabel23.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel23.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel23.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel23.Location = new global::System.Drawing.Point(3, 5);
			this.flatLabel23.Margin = new global::System.Windows.Forms.Padding(6, 10, 3, 0);
			this.flatLabel23.Name = "flatLabel23";
			this.flatLabel23.Size = new global::System.Drawing.Size(151, 13);
			this.flatLabel23.TabIndex = 64;
			this.flatLabel23.Text = "Активировать промокоды:";
			this.cbIsPromoCodeAvailable.AutoSize = true;
			this.cbIsPromoCodeAvailable.Location = new global::System.Drawing.Point(158, 7);
			this.cbIsPromoCodeAvailable.Margin = new global::System.Windows.Forms.Padding(2);
			this.cbIsPromoCodeAvailable.Name = "cbIsPromoCodeAvailable";
			this.cbIsPromoCodeAvailable.Size = new global::System.Drawing.Size(15, 14);
			this.cbIsPromoCodeAvailable.TabIndex = 41;
			this.cbIsPromoCodeAvailable.UseVisualStyleBackColor = true;
			this.cbIsPromoCodeAvailable.CheckedChanged += new global::System.EventHandler(this.cbIsPromoCodeAvailable_CheckedChanged);
			this.groupBox15.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox15.Controls.Add(this.lbPromoCodeFrom);
			this.groupBox15.Controls.Add(this.flatNumericPromocodeFrom);
			this.groupBox15.Controls.Add(this.flatButtonPromoCodeCopyRef);
			this.groupBox15.Controls.Add(this.flatNumericPromocodeMaxNumber);
			this.groupBox15.Controls.Add(this.label19);
			this.groupBox15.Controls.Add(this.flatButtonPromoCodeCopy);
			this.groupBox15.Controls.Add(this.label15);
			this.groupBox15.Controls.Add(this.labelPromoCodeValue);
			this.groupBox15.Controls.Add(this.flatNumericPromocodeValue);
			this.groupBox15.Controls.Add(this.radioButtonPromoCodeDiscount);
			this.groupBox15.Controls.Add(this.radioButtonPromoCodeAddToWallet);
			this.groupBox15.Controls.Add(this.flatTextBoxPromoCode);
			this.groupBox15.Controls.Add(this.flatButtonGeneratePromoCodes);
			this.groupBox15.ForeColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.groupBox15.Location = new global::System.Drawing.Point(3, 459);
			this.groupBox15.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox15.Size = new global::System.Drawing.Size(1267, 76);
			this.groupBox15.TabIndex = 21;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "Создать промокод";
			this.lbPromoCodeFrom.AutoSize = true;
			this.lbPromoCodeFrom.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.lbPromoCodeFrom.ForeColor = global::System.Drawing.Color.White;
			this.lbPromoCodeFrom.Location = new global::System.Drawing.Point(419, 19);
			this.lbPromoCodeFrom.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbPromoCodeFrom.Name = "lbPromoCodeFrom";
			this.lbPromoCodeFrom.Size = new global::System.Drawing.Size(26, 19);
			this.lbPromoCodeFrom.TabIndex = 31;
			this.lbPromoCodeFrom.Text = "От";
			this.flatNumericPromocodeFrom.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumericPromocodeFrom.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumericPromocodeFrom.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumericPromocodeFrom.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumericPromocodeFrom.ForeColor = global::System.Drawing.Color.White;
			this.flatNumericPromocodeFrom.Location = new global::System.Drawing.Point(422, 40);
			this.flatNumericPromocodeFrom.Margin = new global::System.Windows.Forms.Padding(2);
			global::FlatUI.FlatNumeric flatNumeric5 = this.flatNumericPromocodeFrom;
			int[] array5 = new int[4];
			array5[0] = 9999999;
			flatNumeric5.Maximum = new decimal(array5);
			this.flatNumericPromocodeFrom.Minimum = new decimal(new int[4]);
			this.flatNumericPromocodeFrom.Name = "flatNumericPromocodeFrom";
			this.flatNumericPromocodeFrom.Size = new global::System.Drawing.Size(106, 30);
			this.flatNumericPromocodeFrom.TabIndex = 30;
			this.flatNumericPromocodeFrom.Text = "flatNumeric1";
			this.flatNumericPromocodeFrom.Value = new decimal(new int[4]);
			this.flatButtonPromoCodeCopyRef.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonPromoCodeCopyRef.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonPromoCodeCopyRef.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonPromoCodeCopyRef.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonPromoCodeCopyRef.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonPromoCodeCopyRef.Location = new global::System.Drawing.Point(1147, 43);
			this.flatButtonPromoCodeCopyRef.Margin = new global::System.Windows.Forms.Padding(2);
			this.flatButtonPromoCodeCopyRef.Name = "flatButtonPromoCodeCopyRef";
			this.flatButtonPromoCodeCopyRef.Rounded = false;
			this.flatButtonPromoCodeCopyRef.Size = new global::System.Drawing.Size(116, 27);
			this.flatButtonPromoCodeCopyRef.TabIndex = 29;
			this.flatButtonPromoCodeCopyRef.Text = "Реф ссылка";
			this.flatButtonPromoCodeCopyRef.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonPromoCodeCopyRef.Click += new global::System.EventHandler(this.flatButtonPromoCodeCopyRef_Click);
			this.flatNumericPromocodeMaxNumber.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumericPromocodeMaxNumber.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumericPromocodeMaxNumber.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumericPromocodeMaxNumber.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumericPromocodeMaxNumber.ForeColor = global::System.Drawing.Color.White;
			this.flatNumericPromocodeMaxNumber.Location = new global::System.Drawing.Point(548, 41);
			this.flatNumericPromocodeMaxNumber.Margin = new global::System.Windows.Forms.Padding(2);
			global::FlatUI.FlatNumeric flatNumeric6 = this.flatNumericPromocodeMaxNumber;
			int[] array6 = new int[4];
			array6[0] = 9999999;
			flatNumeric6.Maximum = new decimal(array6);
			this.flatNumericPromocodeMaxNumber.Minimum = new decimal(new int[4]);
			this.flatNumericPromocodeMaxNumber.Name = "flatNumericPromocodeMaxNumber";
			this.flatNumericPromocodeMaxNumber.Size = new global::System.Drawing.Size(106, 30);
			this.flatNumericPromocodeMaxNumber.TabIndex = 28;
			this.flatNumericPromocodeMaxNumber.Text = "flatNumeric1";
			this.flatNumericPromocodeMaxNumber.Value = new decimal(new int[4]);
			this.label19.AutoSize = true;
			this.label19.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.label19.ForeColor = global::System.Drawing.Color.White;
			this.label19.Location = new global::System.Drawing.Point(544, 19);
			this.label19.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(241, 19);
			this.label19.TabIndex = 27;
			this.label19.Text = "Число дополнительных промокодов";
			this.flatButtonPromoCodeCopy.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonPromoCodeCopy.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonPromoCodeCopy.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonPromoCodeCopy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonPromoCodeCopy.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonPromoCodeCopy.Location = new global::System.Drawing.Point(1147, 14);
			this.flatButtonPromoCodeCopy.Margin = new global::System.Windows.Forms.Padding(2);
			this.flatButtonPromoCodeCopy.Name = "flatButtonPromoCodeCopy";
			this.flatButtonPromoCodeCopy.Rounded = false;
			this.flatButtonPromoCodeCopy.Size = new global::System.Drawing.Size(116, 27);
			this.flatButtonPromoCodeCopy.TabIndex = 26;
			this.flatButtonPromoCodeCopy.Text = "Скопировать";
			this.flatButtonPromoCodeCopy.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonPromoCodeCopy.Click += new global::System.EventHandler(this.flatButtonPromoCodeCopy_Click);
			this.label15.AutoSize = true;
			this.label15.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.label15.ForeColor = global::System.Drawing.Color.White;
			this.label15.Location = new global::System.Drawing.Point(4, 21);
			this.label15.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(111, 19);
			this.label15.TabIndex = 25;
			this.label15.Text = "Тип промокода:";
			this.labelPromoCodeValue.AutoSize = true;
			this.labelPromoCodeValue.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.labelPromoCodeValue.ForeColor = global::System.Drawing.Color.White;
			this.labelPromoCodeValue.Location = new global::System.Drawing.Point(290, 19);
			this.labelPromoCodeValue.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPromoCodeValue.Name = "labelPromoCodeValue";
			this.labelPromoCodeValue.Size = new global::System.Drawing.Size(70, 19);
			this.labelPromoCodeValue.TabIndex = 24;
			this.labelPromoCodeValue.Text = "Значение";
			this.flatNumericPromocodeValue.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatNumericPromocodeValue.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatNumericPromocodeValue.ButtonColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatNumericPromocodeValue.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatNumericPromocodeValue.ForeColor = global::System.Drawing.Color.White;
			this.flatNumericPromocodeValue.Location = new global::System.Drawing.Point(293, 40);
			this.flatNumericPromocodeValue.Margin = new global::System.Windows.Forms.Padding(2);
			global::FlatUI.FlatNumeric flatNumeric7 = this.flatNumericPromocodeValue;
			int[] array7 = new int[4];
			array7[0] = 9999999;
			flatNumeric7.Maximum = new decimal(array7);
			this.flatNumericPromocodeValue.Minimum = new decimal(new int[4]);
			this.flatNumericPromocodeValue.Name = "flatNumericPromocodeValue";
			this.flatNumericPromocodeValue.Size = new global::System.Drawing.Size(106, 30);
			this.flatNumericPromocodeValue.TabIndex = 23;
			this.flatNumericPromocodeValue.Text = "flatNumeric1";
			this.flatNumericPromocodeValue.Value = new decimal(new int[4]);
			this.radioButtonPromoCodeDiscount.AutoSize = true;
			this.radioButtonPromoCodeDiscount.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonPromoCodeDiscount.Location = new global::System.Drawing.Point(129, 46);
			this.radioButtonPromoCodeDiscount.Margin = new global::System.Windows.Forms.Padding(2);
			this.radioButtonPromoCodeDiscount.Name = "radioButtonPromoCodeDiscount";
			this.radioButtonPromoCodeDiscount.Size = new global::System.Drawing.Size(148, 23);
			this.radioButtonPromoCodeDiscount.TabIndex = 21;
			this.radioButtonPromoCodeDiscount.TabStop = true;
			this.radioButtonPromoCodeDiscount.Text = "Скидка на покупку";
			this.radioButtonPromoCodeDiscount.UseVisualStyleBackColor = true;
			this.radioButtonPromoCodeDiscount.CheckedChanged += new global::System.EventHandler(this.radioButtonPromoCode_CheckedChanged);
			this.radioButtonPromoCodeAddToWallet.AutoSize = true;
			this.radioButtonPromoCodeAddToWallet.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonPromoCodeAddToWallet.Location = new global::System.Drawing.Point(129, 20);
			this.radioButtonPromoCodeAddToWallet.Margin = new global::System.Windows.Forms.Padding(2);
			this.radioButtonPromoCodeAddToWallet.Name = "radioButtonPromoCodeAddToWallet";
			this.radioButtonPromoCodeAddToWallet.Size = new global::System.Drawing.Size(89, 23);
			this.radioButtonPromoCodeAddToWallet.TabIndex = 20;
			this.radioButtonPromoCodeAddToWallet.TabStop = true;
			this.radioButtonPromoCodeAddToWallet.Text = "К балансу";
			this.radioButtonPromoCodeAddToWallet.UseVisualStyleBackColor = true;
			this.radioButtonPromoCodeAddToWallet.CheckedChanged += new global::System.EventHandler(this.radioButtonPromoCode_CheckedChanged);
			this.flatTextBoxPromoCode.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatTextBoxPromoCode.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBoxPromoCode.FocusOnHover = false;
			this.flatTextBoxPromoCode.Location = new global::System.Drawing.Point(893, 43);
			this.flatTextBoxPromoCode.Margin = new global::System.Windows.Forms.Padding(2);
			this.flatTextBoxPromoCode.MaxLength = 32767;
			this.flatTextBoxPromoCode.Multiline = false;
			this.flatTextBoxPromoCode.Name = "flatTextBoxPromoCode";
			this.flatTextBoxPromoCode.ReadOnly = false;
			this.flatTextBoxPromoCode.Size = new global::System.Drawing.Size(249, 29);
			this.flatTextBoxPromoCode.TabIndex = 19;
			this.flatTextBoxPromoCode.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBoxPromoCode.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBoxPromoCode.UseSystemPasswordChar = false;
			this.flatButtonGeneratePromoCodes.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatButtonGeneratePromoCodes.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonGeneratePromoCodes.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonGeneratePromoCodes.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonGeneratePromoCodes.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatButtonGeneratePromoCodes.Location = new global::System.Drawing.Point(894, 14);
			this.flatButtonGeneratePromoCodes.Margin = new global::System.Windows.Forms.Padding(2);
			this.flatButtonGeneratePromoCodes.Name = "flatButtonGeneratePromoCodes";
			this.flatButtonGeneratePromoCodes.Rounded = false;
			this.flatButtonGeneratePromoCodes.Size = new global::System.Drawing.Size(248, 27);
			this.flatButtonGeneratePromoCodes.TabIndex = 18;
			this.flatButtonGeneratePromoCodes.Text = "Сгенерировать промокод (рендомный или впишите название)";
			this.flatButtonGeneratePromoCodes.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonGeneratePromoCodes.Click += new global::System.EventHandler(this.flatButtonGeneratePromoCodes_Click);
			this.dataGridViewPromoCodes.AllowUserToAddRows = false;
			this.dataGridViewPromoCodes.AllowUserToDeleteRows = false;
			this.dataGridViewPromoCodes.AllowUserToResizeRows = false;
			this.dataGridViewPromoCodes.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.dataGridViewPromoCodes.BackgroundColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.dataGridViewPromoCodes.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.dataGridViewPromoCodes.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPromoCodes.Location = new global::System.Drawing.Point(6, 27);
			this.dataGridViewPromoCodes.Name = "dataGridViewPromoCodes";
			this.dataGridViewPromoCodes.ReadOnly = true;
			this.dataGridViewPromoCodes.RowHeadersVisible = false;
			this.dataGridViewPromoCodes.RowHeadersWidth = 51;
			this.dataGridViewPromoCodes.Size = new global::System.Drawing.Size(1262, 435);
			this.dataGridViewPromoCodes.TabIndex = 17;
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.bHistoryTransaction);
			this.panel1.Controls.Add(this.panel9);
			this.panel1.Controls.Add(this.panel10);
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1280, 66);
			this.panel1.TabIndex = 9;
			this.bHistoryTransaction.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.bHistoryTransaction.BackColor = global::System.Drawing.Color.Transparent;
			this.bHistoryTransaction.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.bHistoryTransaction.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bHistoryTransaction.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.bHistoryTransaction.Location = new global::System.Drawing.Point(938, 17);
			this.bHistoryTransaction.Name = "bHistoryTransaction";
			this.bHistoryTransaction.Rounded = false;
			this.bHistoryTransaction.Size = new global::System.Drawing.Size(155, 32);
			this.bHistoryTransaction.TabIndex = 5;
			this.bHistoryTransaction.Text = "История тнанз BTC";
			this.bHistoryTransaction.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bHistoryTransaction.Click += new global::System.EventHandler(this.bHistoryTransaction_Click);
			this.panel9.BackColor = global::System.Drawing.Color.Transparent;
			this.panel9.Controls.Add(this.flatButtonRefreshBalance);
			this.panel9.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel9.Location = new global::System.Drawing.Point(195, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new global::System.Drawing.Size(130, 66);
			this.panel9.TabIndex = 4;
			this.flatButtonRefreshBalance.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonRefreshBalance.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonRefreshBalance.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonRefreshBalance.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonRefreshBalance.Location = new global::System.Drawing.Point(16, 17);
			this.flatButtonRefreshBalance.Name = "flatButtonRefreshBalance";
			this.flatButtonRefreshBalance.Rounded = false;
			this.flatButtonRefreshBalance.Size = new global::System.Drawing.Size(111, 32);
			this.flatButtonRefreshBalance.TabIndex = 1;
			this.flatButtonRefreshBalance.Text = "⟳ Обновить";
			this.flatButtonRefreshBalance.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonRefreshBalance.Click += new global::System.EventHandler(this.flatButtonRefreshBalance_Click);
			this.panel10.AutoSize = true;
			this.panel10.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel10.Location = new global::System.Drawing.Point(195, 0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new global::System.Drawing.Size(0, 66);
			this.panel10.TabIndex = 4;
			this.panel8.AutoSize = true;
			this.panel8.Controls.Add(this.flatLabelBalance);
			this.panel8.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel8.Location = new global::System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new global::System.Drawing.Size(195, 66);
			this.panel8.TabIndex = 3;
			this.flatLabelBalance.AutoSize = true;
			this.flatLabelBalance.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabelBalance.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.flatLabelBalance.ForeColor = global::System.Drawing.Color.White;
			this.flatLabelBalance.Location = new global::System.Drawing.Point(12, 25);
			this.flatLabelBalance.Name = "flatLabelBalance";
			this.flatLabelBalance.Size = new global::System.Drawing.Size(180, 19);
			this.flatLabelBalance.TabIndex = 2;
			this.flatLabelBalance.Text = "Баланс: {0}   |   Курс BTC: {1}";
			this.panel2.Controls.Add(this.flatButtonStop);
			this.panel2.Controls.Add(this.flatButtonStart);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new global::System.Drawing.Point(1096, 0);
			this.panel2.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(184, 66);
			this.panel2.TabIndex = 0;
			this.flatButtonStop.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonStop.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonStop.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonStop.Enabled = false;
			this.flatButtonStop.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonStop.Location = new global::System.Drawing.Point(14, 17);
			this.flatButtonStop.Name = "flatButtonStop";
			this.flatButtonStop.Rounded = false;
			this.flatButtonStop.Size = new global::System.Drawing.Size(76, 32);
			this.flatButtonStop.TabIndex = 1;
			this.flatButtonStop.Text = "◼ Стоп";
			this.flatButtonStop.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonStop.Click += new global::System.EventHandler(this.flatButtonStop_Click);
			this.flatButtonStart.BackColor = global::System.Drawing.Color.Transparent;
			this.flatButtonStart.BaseColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatButtonStart.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatButtonStart.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatButtonStart.Location = new global::System.Drawing.Point(96, 17);
			this.flatButtonStart.Name = "flatButtonStart";
			this.flatButtonStart.Rounded = false;
			this.flatButtonStart.Size = new global::System.Drawing.Size(76, 32);
			this.flatButtonStart.TabIndex = 0;
			this.flatButtonStart.Text = "▶ Старт";
			this.flatButtonStart.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatButtonStart.Click += new global::System.EventHandler(this.flatButtonStart_Click);
			this.flatProgressBarMain.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.flatProgressBarMain.DarkerProgress = global::System.Drawing.Color.FromArgb(23, 148, 92);
			this.flatProgressBarMain.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.flatProgressBarMain.Location = new global::System.Drawing.Point(0, 703);
			this.flatProgressBarMain.Maximum = 100;
			this.flatProgressBarMain.Name = "flatProgressBarMain";
			this.flatProgressBarMain.Pattern = true;
			this.flatProgressBarMain.PercentSign = false;
			this.flatProgressBarMain.ProgressColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatProgressBarMain.ShowBalloon = true;
			this.flatProgressBarMain.Size = new global::System.Drawing.Size(1280, 42);
			this.flatProgressBarMain.TabIndex = 5;
			this.flatProgressBarMain.Text = "flatProgressBar1";
			this.flatProgressBarMain.Value = 0;
			this.flatStatusBarMain.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatStatusBarMain.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.flatStatusBarMain.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatStatusBarMain.ForeColor = global::System.Drawing.Color.White;
			this.flatStatusBarMain.Location = new global::System.Drawing.Point(0, 745);
			this.flatStatusBarMain.MyTextColor = null;
			this.flatStatusBarMain.Name = "flatStatusBarMain";
			this.flatStatusBarMain.RectColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.flatStatusBarMain.ShowTimeDate = false;
			this.flatStatusBarMain.Size = new global::System.Drawing.Size(1280, 23);
			this.flatStatusBarMain.TabIndex = 4;
			this.flatStatusBarMain.TextColor = global::System.Drawing.Color.White;
			this.flatMini1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMini1.BackColor = global::System.Drawing.Color.White;
			this.flatMini1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMini1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMini1.Location = new global::System.Drawing.Point(1202, 12);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 2;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatClose1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatClose1.BackColor = global::System.Drawing.Color.White;
			this.flatClose1.BaseColor = global::System.Drawing.Color.FromArgb(168, 35, 35);
			this.flatClose1.Font = new global::System.Drawing.Font("Marlett", 10f);
			this.flatClose1.Location = new global::System.Drawing.Point(1250, 13);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new global::System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 0;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatClose1.Click += new global::System.EventHandler(this.flatClose1_Click);
			this.timerMain.Interval = 60000;
			this.timerMain.Tick += new global::System.EventHandler(this.timerMain_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1280, 768);
			base.Controls.Add(this.formSkinMain);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(1280, 768);
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			base.Load += new global::System.EventHandler(this.Main_Load);
			this.formSkinMain.ResumeLayout(false);
			this.flatTabControlMain.ResumeLayout(false);
			this.tabPageAutorization.ResumeLayout(false);
			this.tabPageAutorization.PerformLayout();
			this.tabPageMain.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewUsers).EndInit();
			this.panel24.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.splitContainer2).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewProductsUser).EndInit();
			this.groupBox7.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewTransactions).EndInit();
			this.tabPageCategory.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewProducts).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.tabPagePolicy.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			this.groupBox8.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewPolicies).EndInit();
			this.panel12.ResumeLayout(false);
			this.tabPageSettings.ResumeLayout(false);
			this.groupBox19.ResumeLayout(false);
			this.groupBox19.PerformLayout();
			this.groupBox17.ResumeLayout(false);
			this.groupBox17.PerformLayout();
			this.Exmo.ResumeLayout(false);
			this.Exmo.PerformLayout();
			this.groupBox12.ResumeLayout(false);
			this.groupBox12.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox13.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.settingPictureBoxImage).EndInit();
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPageSettingQiwi.ResumeLayout(false);
			this.tabPageSettingQiwi.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			this.groupBox14.ResumeLayout(false);
			this.groupBox14.PerformLayout();
			this.tabPageSender.ResumeLayout(false);
			this.tabPageStatistic.ResumeLayout(false);
			this.tabPageStatistic.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.chartStatistics).EndInit();
			this.tabPageReviwers.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewReviews).EndInit();
			this.tabPageAddButton.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.groupBoxTelegramPage.ResumeLayout(false);
			this.groupBoxTelegramPage.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pbTelegramPagePic).EndInit();
			this.tabPagePromoCodes.ResumeLayout(false);
			this.tabPagePromoCodes.PerformLayout();
			this.groupBox15.ResumeLayout(false);
			this.groupBox15.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewPromoCodes).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000112 RID: 274
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000113 RID: 275
		private global::FlatUI.FormSkin formSkinMain;

		// Token: 0x04000114 RID: 276
		private global::FlatUI.FlatProgressBar flatProgressBarMain;

		// Token: 0x04000115 RID: 277
		private global::FlatUI.FlatStatusBar flatStatusBarMain;

		// Token: 0x04000116 RID: 278
		private global::FlatUI.FlatTabControl flatTabControlMain;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.TabPage tabPageMain;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.TabPage tabPageSettings;

		// Token: 0x04000119 RID: 281
		private global::FlatUI.FlatMini flatMini1;

		// Token: 0x0400011A RID: 282
		private global::FlatUI.FlatClose flatClose1;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400011D RID: 285
		private global::FlatUI.FlatButton flatButtonStop;

		// Token: 0x0400011E RID: 286
		private global::FlatUI.FlatButton flatButtonStart;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000120 RID: 288
		private global::FlatUI.FlatButton flatButtonTestMessage;

		// Token: 0x04000121 RID: 289
		private global::FlatUI.FlatTextBox flatTextBoxBotToken;

		// Token: 0x04000122 RID: 290
		private global::FlatUI.FlatLabel flatLabel2;

		// Token: 0x04000123 RID: 291
		private global::FlatUI.FlatTextBox flatTextBoxChanell;

		// Token: 0x04000124 RID: 292
		private global::FlatUI.FlatLabel flatLabel1;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000126 RID: 294
		private global::FlatUI.FlatTextBox flatTextBoxGreeting;

		// Token: 0x04000127 RID: 295
		private global::FlatUI.FlatLabel flatLabel6;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.TabPage tabPageCategory;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400012B RID: 299
		private global::FlatUI.FlatTextBox flatTextBoxCategoryName;

		// Token: 0x0400012C RID: 300
		private global::FlatUI.FlatButton flatButtonSaveCategory;

		// Token: 0x0400012D RID: 301
		private global::FlatUI.FlatButton flatButtonAddCategory;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.TreeView treeViewCategories;

		// Token: 0x0400012F RID: 303
		private global::FlatUI.FlatButton flatButtonDeleteCategory;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.Panel panel28;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000133 RID: 307
		private global::FlatUI.FlatButton flatButtonAddProduct;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.DataGridView dataGridViewProducts;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.DataGridView dataGridViewProductsUser;

		// Token: 0x04000138 RID: 312
		private global::FlatUI.FlatTextBox flatTextBoxPositionOutOfStock;

		// Token: 0x04000139 RID: 313
		private global::FlatUI.FlatLabel flatLabel3;

		// Token: 0x0400013A RID: 314
		private global::FlatUI.FlatLabel flatLabelBalance;

		// Token: 0x0400013B RID: 315
		private global::FlatUI.FlatButton flatButtonRefreshBalance;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.Panel panel9;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.Panel panel10;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.Timer timerMain;

		// Token: 0x04000140 RID: 320
		private global::FlatUI.FlatTextBox flatTextBoxSupport;

		// Token: 0x04000141 RID: 321
		private global::FlatUI.FlatLabel flatLabel4;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.TabPage tabPagePolicy;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.GroupBox groupBox8;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.DataGridView dataGridViewPolicies;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.Panel panel11;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.GroupBox groupBox9;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000148 RID: 328
		private global::FlatUI.FlatTextBox flatTextBoxPolicyValue;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.Panel panel12;

		// Token: 0x0400014A RID: 330
		private global::FlatUI.FlatButton flatButtonSavePolicy;

		// Token: 0x0400014B RID: 331
		private global::FlatUI.FlatButton flatButtonAddPolicy;

		// Token: 0x0400014C RID: 332
		private global::FlatUI.FlatTextBox flatTextBoxPolicyName;

		// Token: 0x0400014D RID: 333
		private global::FlatUI.FlatTextBox flatTextBoxCommandSupport;

		// Token: 0x0400014E RID: 334
		private global::FlatUI.FlatLabel flatLabel7;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.GroupBox groupBox10;

		// Token: 0x04000150 RID: 336
		private global::FlatUI.FlatTextBox flatTextBoxServiceHost;

		// Token: 0x04000151 RID: 337
		private global::FlatUI.FlatLabel flatLabel5;

		// Token: 0x04000152 RID: 338
		private global::FlatUI.FlatTextBox flatTextBoxPassword;

		// Token: 0x04000153 RID: 339
		private global::FlatUI.FlatLabel flatLabel8;

		// Token: 0x04000154 RID: 340
		private global::FlatUI.FlatTextBox flatTextBoxApiKey;

		// Token: 0x04000155 RID: 341
		private global::FlatUI.FlatLabel flatLabel9;

		// Token: 0x04000156 RID: 342
		private global::FlatUI.FlatTextBox flatTextBoxIdWallet;

		// Token: 0x04000157 RID: 343
		private global::FlatUI.FlatLabel flatLabel10;

		// Token: 0x04000158 RID: 344
		private global::FlatUI.FlatButton flatButtonInitBlockchain;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.SplitContainer splitContainer1;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.DataGridView dataGridViewUsers;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.Panel panel24;

		// Token: 0x0400015D RID: 349
		private global::FlatUI.FlatTextBox flatTextBoxSearchUsername;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.DataGridView dataGridViewTransactions;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.SplitContainer splitContainer2;

		// Token: 0x04000161 RID: 353
		private global::FlatUI.FlatMax flatMax1;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.GroupBox groupBox12;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.CheckBox IsApironeAvailable;

		// Token: 0x04000164 RID: 356
		private global::FlatUI.FlatButton flatButtonApirone;

		// Token: 0x04000165 RID: 357
		private global::FlatUI.FlatTextBox flatTextBoxApironeBTCWallet;

		// Token: 0x04000166 RID: 358
		private global::FlatUI.FlatLabel flatLabel15;

		// Token: 0x04000167 RID: 359
		private global::FlatUI.FlatTextBox flatTextBoxApironeLTCWallet;

		// Token: 0x04000168 RID: 360
		private global::FlatUI.FlatLabel flatLabel16;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Forms.CheckBox checkBoxApironePayLTC;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.CheckBox checkBoxApironePayBTC;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.TabPage tabPageSender;

		// Token: 0x0400016E RID: 366
		private global::FlatUI.FlatButton flatButtonSender;

		// Token: 0x0400016F RID: 367
		private global::FlatUI.FlatTextBox flatTextBoxSender;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.TabPage tabPageAutorization;

		// Token: 0x04000171 RID: 369
		private global::FlatUI.FlatComboBox flatComboBoxUsers;

		// Token: 0x04000172 RID: 370
		private global::FlatUI.FlatLabel flatLabel17;

		// Token: 0x04000173 RID: 371
		private global::FlatUI.FlatTextBox flatTextBoxUserPassword;

		// Token: 0x04000174 RID: 372
		private global::FlatUI.FlatLabel flatLabel18;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.Label labelUserExit;

		// Token: 0x04000176 RID: 374
		private global::FlatUI.FlatButton flatButtonUsers;

		// Token: 0x04000177 RID: 375
		private global::FlatUI.FlatButton flatButtonUserChangePassword;

		// Token: 0x04000178 RID: 376
		private global::FlatUI.FlatButton flatButtonUserEnter;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.TabPage tabPageStatistic;

		// Token: 0x0400017A RID: 378
		private global::FlatUI.FlatButton flatButtonChart2;

		// Token: 0x0400017B RID: 379
		private global::FlatUI.FlatButton flatButtonChart1;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.CheckBox checkBoxIsWithoutLogin;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.GroupBox Exmo;

		// Token: 0x04000180 RID: 384
		private global::FlatUI.FlatButton flatButtonExmoInit;

		// Token: 0x04000181 RID: 385
		private global::FlatUI.FlatTextBox flatTextBoxExmoKey;

		// Token: 0x04000182 RID: 386
		private global::FlatUI.FlatLabel flatLabel11;

		// Token: 0x04000183 RID: 387
		private global::FlatUI.FlatTextBox flatTextBoxExmoSecret;

		// Token: 0x04000184 RID: 388
		private global::FlatUI.FlatLabel flatLabel12;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.CheckBox IsExmoAvailable1;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.TabPage tabPageSettingQiwi;

		// Token: 0x04000187 RID: 391
		private global::FlatUI.FlatTextBox textPass4;

		// Token: 0x04000188 RID: 392
		private global::FlatUI.FlatTextBox textProxy4;

		// Token: 0x04000189 RID: 393
		private global::FlatUI.FlatTextBox textPass3;

		// Token: 0x0400018A RID: 394
		private global::FlatUI.FlatTextBox textProxy3;

		// Token: 0x0400018B RID: 395
		private global::FlatUI.FlatTextBox textPass2;

		// Token: 0x0400018C RID: 396
		private global::FlatUI.FlatTextBox textProxy2;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400018F RID: 399
		private global::FlatUI.FlatTextBox textPass1;

		// Token: 0x04000190 RID: 400
		private global::FlatUI.FlatTextBox textProxy1;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.Label labelF4;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.Label labelF3;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.Label labelF2;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.Label labelF1;

		// Token: 0x04000195 RID: 405
		private global::FlatUI.FlatTextBox textNumber4;

		// Token: 0x04000196 RID: 406
		private global::FlatUI.FlatTextBox textAPI4;

		// Token: 0x04000197 RID: 407
		private global::FlatUI.FlatTextBox textNumber3;

		// Token: 0x04000198 RID: 408
		private global::FlatUI.FlatTextBox textAPI3;

		// Token: 0x04000199 RID: 409
		private global::FlatUI.FlatTextBox textNumber2;

		// Token: 0x0400019A RID: 410
		private global::FlatUI.FlatTextBox textAPI2;

		// Token: 0x0400019B RID: 411
		private global::System.Windows.Forms.RadioButton radioButtonIsQiwiNumber;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400019D RID: 413
		private global::System.Windows.Forms.RadioButton radioButtonIsQiwiCode;

		// Token: 0x0400019E RID: 414
		private global::FlatUI.FlatButton flatButtonQiwiInit;

		// Token: 0x0400019F RID: 415
		private global::FlatUI.FlatTextBox textNumber1;

		// Token: 0x040001A0 RID: 416
		private global::FlatUI.FlatLabel flatLabel13;

		// Token: 0x040001A1 RID: 417
		private global::FlatUI.FlatTextBox textAPI1;

		// Token: 0x040001A2 RID: 418
		private global::FlatUI.FlatLabel flatLabel14;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Forms.CheckBox IsQiwiAvailable1;

		// Token: 0x040001A4 RID: 420
		private global::FlatUI.FlatLabel flatLabel19;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Forms.PictureBox settingPictureBoxImage;

		// Token: 0x040001A6 RID: 422
		private global::FlatUI.FlatButton flatButtonDeleteImage;

		// Token: 0x040001A7 RID: 423
		private global::FlatUI.FlatButton flatButtonSelectImage;

		// Token: 0x040001A8 RID: 424
		private global::FlatUI.FlatLabel flatLabel20;

		// Token: 0x040001A9 RID: 425
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040001AA RID: 426
		private global::FlatUI.FlatNumeric flatNumericDicountPayBTC;

		// Token: 0x040001AB RID: 427
		private global::FlatUI.FlatNumeric flatNumericDicountPayLTC;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.CheckBox IsReviewAvailable;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.TabPage tabPageReviwers;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.DataGridView dataGridViewReviews;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.CheckBox checkBoxIsReservAndPayInTheEndAvailable;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.CheckBox checkBoxIsUserPayWalletAvailable;

		// Token: 0x040001B5 RID: 437
		private global::FlatUI.FlatNumeric flatNumericTimeToCancelOrder;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.GroupBox groupBox13;

		// Token: 0x040001B8 RID: 440
		private global::FlatUI.FlatRadioButton flatRadioButtonRUB;

		// Token: 0x040001B9 RID: 441
		private global::FlatUI.FlatRadioButton flatRadioButtonUSD;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.CheckBox checkBoxIsButtonLanguageAvailable;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.TabPage tabPageAddButton;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.GroupBox groupBoxTelegramPage;

		// Token: 0x040001BE RID: 446
		private global::FlatUI.FlatTextBox tbTelegramPageText;

		// Token: 0x040001BF RID: 447
		private global::FlatUI.FlatLabel flatLabel21;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.CheckBox cbIsTelegramPageAvailable;

		// Token: 0x040001C1 RID: 449
		private global::FlatUI.FlatTextBox tbTelegramPageName;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040001C3 RID: 451
		private global::FlatUI.FlatButton bTelegramPagePicDelete;

		// Token: 0x040001C4 RID: 452
		private global::FlatUI.FlatButton bTelegramPagePicSelect;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Forms.PictureBox pbTelegramPagePic;

		// Token: 0x040001C6 RID: 454
		private global::FlatUI.FlatTextBox textNumber5;

		// Token: 0x040001C7 RID: 455
		private global::FlatUI.FlatTextBox textAPI5;

		// Token: 0x040001C8 RID: 456
		private global::System.Windows.Forms.Label labelF5;

		// Token: 0x040001C9 RID: 457
		private global::FlatUI.FlatTextBox textPass5;

		// Token: 0x040001CA RID: 458
		private global::FlatUI.FlatTextBox textProxy5;

		// Token: 0x040001CB RID: 459
		private global::FlatUI.FlatTextBox textNumber6;

		// Token: 0x040001CC RID: 460
		private global::FlatUI.FlatTextBox textAPI6;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Forms.Label labelF6;

		// Token: 0x040001CE RID: 462
		private global::FlatUI.FlatTextBox textPass6;

		// Token: 0x040001CF RID: 463
		private global::FlatUI.FlatTextBox textProxy6;

		// Token: 0x040001D0 RID: 464
		private global::FlatUI.FlatTextBox textNumber10;

		// Token: 0x040001D1 RID: 465
		private global::FlatUI.FlatTextBox textAPI10;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.Label labelF10;

		// Token: 0x040001D3 RID: 467
		private global::FlatUI.FlatTextBox textPass10;

		// Token: 0x040001D4 RID: 468
		private global::FlatUI.FlatTextBox textProxy10;

		// Token: 0x040001D5 RID: 469
		private global::FlatUI.FlatTextBox textNumber9;

		// Token: 0x040001D6 RID: 470
		private global::FlatUI.FlatTextBox textAPI9;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.Label labelF9;

		// Token: 0x040001D8 RID: 472
		private global::FlatUI.FlatTextBox textPass9;

		// Token: 0x040001D9 RID: 473
		private global::FlatUI.FlatTextBox textProxy9;

		// Token: 0x040001DA RID: 474
		private global::FlatUI.FlatTextBox textNumber8;

		// Token: 0x040001DB RID: 475
		private global::FlatUI.FlatTextBox textAPI8;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.Label labelF8;

		// Token: 0x040001DD RID: 477
		private global::System.Windows.Forms.Label labelF7;

		// Token: 0x040001DE RID: 478
		private global::FlatUI.FlatTextBox textNumber7;

		// Token: 0x040001DF RID: 479
		private global::FlatUI.FlatTextBox textAPI7;

		// Token: 0x040001E0 RID: 480
		private global::FlatUI.FlatTextBox textPass8;

		// Token: 0x040001E1 RID: 481
		private global::FlatUI.FlatTextBox textProxy8;

		// Token: 0x040001E2 RID: 482
		private global::FlatUI.FlatTextBox textPass7;

		// Token: 0x040001E3 RID: 483
		private global::FlatUI.FlatTextBox textProxy7;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.TabPage tabPagePromoCodes;

		// Token: 0x040001E5 RID: 485
		private global::System.Windows.Forms.DataGridView dataGridViewPromoCodes;

		// Token: 0x040001E6 RID: 486
		private global::FlatUI.FlatButton flatButtonGeneratePromoCodes;

		// Token: 0x040001E7 RID: 487
		private global::FlatUI.FlatTextBox flatTextBoxPromoCode;

		// Token: 0x040001E8 RID: 488
		private global::System.Windows.Forms.Label labelPromoCodeValue;

		// Token: 0x040001E9 RID: 489
		private global::FlatUI.FlatNumeric flatNumericPromocodeValue;

		// Token: 0x040001EA RID: 490
		private global::System.Windows.Forms.GroupBox groupBox15;

		// Token: 0x040001EB RID: 491
		private global::System.Windows.Forms.RadioButton radioButtonPromoCodeDiscount;

		// Token: 0x040001EC RID: 492
		private global::System.Windows.Forms.RadioButton radioButtonPromoCodeAddToWallet;

		// Token: 0x040001ED RID: 493
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040001EE RID: 494
		private global::System.Windows.Forms.CheckBox cbIsPromoCodeAvailable;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.CheckBox cbIsEnterAmountToBuy;

		// Token: 0x040001F1 RID: 497
		private global::FlatUI.FlatLabel flatLabel23;

		// Token: 0x040001F2 RID: 498
		private global::FlatUI.FlatButton flatButtonPromoCodeCopy;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Forms.CheckBox cbButtonIPaidForCard;

		// Token: 0x040001F5 RID: 501
		private global::System.Windows.Forms.GroupBox groupBox16;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Forms.TreeView tvTelegramPages;

		// Token: 0x040001F7 RID: 503
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x040001F8 RID: 504
		private global::FlatUI.FlatButton bTelegramPagesDelete;

		// Token: 0x040001F9 RID: 505
		private global::FlatUI.FlatButton bTelegramPagesAdd;

		// Token: 0x040001FA RID: 506
		private global::FlatUI.FlatTextBox tbTelegramPagesNameToAdd;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.Forms.Label lbTelegramPagePicPath;

		// Token: 0x040001FC RID: 508
		private global::FlatUI.FlatButton bTelegramPageSave;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.CheckBox cbButtonIPaidForElse;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.CheckBox cbIsLockCheckPayment;

		// Token: 0x04000201 RID: 513
		private global::FlatUI.FlatButton flatButtonBlockChainArchiv;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.GroupBox groupBox14;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.CheckBox IsYandexAvailable;

		// Token: 0x04000204 RID: 516
		private global::FlatUI.FlatButton flatButton1;

		// Token: 0x04000205 RID: 517
		private global::FlatUI.FlatTextBox textBoxYandexAddress;

		// Token: 0x04000206 RID: 518
		private global::FlatUI.FlatLabel flatLabel24;

		// Token: 0x04000207 RID: 519
		private global::FlatUI.FlatTextBox textBoxYansexClientId;

		// Token: 0x04000208 RID: 520
		private global::FlatUI.FlatLabel flatLabel25;

		// Token: 0x04000209 RID: 521
		private global::FlatUI.FlatLabel flatLabel26;

		// Token: 0x0400020A RID: 522
		private global::FlatUI.FlatTextBox textBoxYansexRedirectUri;

		// Token: 0x0400020B RID: 523
		private global::FlatUI.FlatLabel flatLabel27;

		// Token: 0x0400020C RID: 524
		private global::FlatUI.FlatTextBox textBoxYandexProxyName;

		// Token: 0x0400020D RID: 525
		private global::FlatUI.FlatTextBox textBoxYandexProxyPort;

		// Token: 0x0400020E RID: 526
		private global::FlatUI.FlatLabel flatLabel28;

		// Token: 0x0400020F RID: 527
		private global::FlatUI.FlatButton flatButtonUpCategory;

		// Token: 0x04000210 RID: 528
		private global::FlatUI.FlatButton flatButtonDownCategory;

		// Token: 0x04000211 RID: 529
		private global::FlatUI.FlatButton flatButtonUpProduct;

		// Token: 0x04000212 RID: 530
		private global::FlatUI.FlatButton flatButtonDownProduct;

		// Token: 0x04000213 RID: 531
		private global::FlatUI.FlatTextBox flatTextBoxReferral;

		// Token: 0x04000214 RID: 532
		private global::FlatUI.FlatLabel flatLabel30;

		// Token: 0x04000215 RID: 533
		private global::FlatUI.FlatLabel flatLabel29;

		// Token: 0x04000216 RID: 534
		private global::FlatUI.FlatNumeric numericUpDownRefferal;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.Forms.CheckBox IsReferalAvailable;

		// Token: 0x04000218 RID: 536
		private global::System.Windows.Forms.GroupBox groupBox17;

		// Token: 0x04000219 RID: 537
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400021A RID: 538
		private global::FlatUI.FlatNumeric flatNumericPromocodeMaxNumber;

		// Token: 0x0400021B RID: 539
		private global::FlatUI.FlatButton flatButtonPromoCodeCopyRef;

		// Token: 0x0400021C RID: 540
		private global::FlatUI.FlatButton bStatisticsPromoCodes;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.GroupBox groupBox18;

		// Token: 0x0400021E RID: 542
		private global::FlatUI.FlatButton buttonTele2Init;

		// Token: 0x0400021F RID: 543
		private global::FlatUI.FlatTextBox textBoxTele2Password;

		// Token: 0x04000220 RID: 544
		private global::System.Windows.Forms.CheckBox IsTele2Available;

		// Token: 0x04000221 RID: 545
		private global::FlatUI.FlatTextBox textBoxTele2Number;

		// Token: 0x04000222 RID: 546
		private global::FlatUI.FlatLabel flatLabel31;

		// Token: 0x04000223 RID: 547
		private global::FlatUI.FlatLabel flatLabel32;

		// Token: 0x04000224 RID: 548
		private global::FlatUI.FlatLabel flatLabel33;

		// Token: 0x04000225 RID: 549
		private global::FlatUI.FlatButton bStatisticsCommon;

		// Token: 0x04000226 RID: 550
		private global::FlatUI.FlatButton bStatisticsCommonCategories;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.GroupBox groupBox11;

		// Token: 0x04000228 RID: 552
		private global::System.Windows.Forms.CheckBox IsCardAvailable1;

		// Token: 0x04000229 RID: 553
		private global::FlatUI.FlatTextBox textBoxCard;

		// Token: 0x0400022A RID: 554
		private global::FlatUI.FlatLabel flatLabel22;

		// Token: 0x0400022B RID: 555
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400022C RID: 556
		private global::System.Windows.Forms.CheckBox cbIsButtonAvailability;

		// Token: 0x0400022D RID: 557
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400022E RID: 558
		private global::System.Windows.Forms.CheckBox cbIsButtonStatistic;

		// Token: 0x0400022F RID: 559
		private global::System.Windows.Forms.CheckBox cbIsNotFoundAvailable;

		// Token: 0x04000230 RID: 560
		private global::FlatUI.FlatTextBox tbNotFoundText;

		// Token: 0x04000231 RID: 561
		private global::FlatUI.FlatButton bStatisticsCommonЗкщвгсе;

		// Token: 0x04000232 RID: 562
		private global::FlatUI.FlatButton bNotFoundChennelTest;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000234 RID: 564
		private global::FlatUI.FlatTextBox tbNotFoundChennel;

		// Token: 0x04000235 RID: 565
		private global::FlatUI.FlatButton bStatisticsCommonProduct;

		// Token: 0x04000236 RID: 566
		private global::System.Windows.Forms.GroupBox groupBox19;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.CheckBox cbIsSendMoneyButtonAvailabile;

		// Token: 0x04000239 RID: 569
		private global::FlatUI.FlatButton bHistoryTransaction;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.Label lbPromoCodeFrom;

		// Token: 0x0400023B RID: 571
		private global::FlatUI.FlatNumeric flatNumericPromocodeFrom;
	}
}
