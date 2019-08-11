namespace GCPanelSeasonV
{
	partial class Painel
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txt_LoginUID = new System.Windows.Forms.TextBox();
			this.lbl_LoginUID = new System.Windows.Forms.Label();
			this.lbl_ItemID = new System.Windows.Forms.Label();
			this.txt_ItemID = new System.Windows.Forms.TextBox();
			this.btn_AddItem = new System.Windows.Forms.Button();
			this.combo_Grade = new System.Windows.Forms.ComboBox();
			this.lbl_Grade = new System.Windows.Forms.Label();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.lbl_ServerInfo = new System.Windows.Forms.Label();
			this.listBox_ServerInfo = new System.Windows.Forms.ListBox();
			this.btn_AccountSearch = new System.Windows.Forms.Button();
			this.radioLoginEmail = new System.Windows.Forms.RadioButton();
			this.radioAccountLogin = new System.Windows.Forms.RadioButton();
			this.radioAccountNickname = new System.Windows.Forms.RadioButton();
			this.lbl_AccountString = new System.Windows.Forms.Label();
			this.txt_AccountString = new System.Windows.Forms.TextBox();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabCharacters = new System.Windows.Forms.TabPage();
			this.panel_SelectedCharacter = new System.Windows.Forms.Panel();
			this.picture_SelectedCharacter = new System.Windows.Forms.PictureBox();
			this.lbl_DefaultBonus = new System.Windows.Forms.Label();
			this.lbl_CharInventorySize = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterCIGAGamePoint = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterName = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterJob = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterLevelAndPerc = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterExpS4 = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterPanelDivision = new System.Windows.Forms.Label();
			this.listView_Characters = new System.Windows.Forms.ListView();
			this.lbl_Characters_ListBox = new System.Windows.Forms.Label();
			this.tabItems = new System.Windows.Forms.TabPage();
			this.lbl_SqlConnectionStatus = new System.Windows.Forms.Label();
			this.panel_UserInfo = new System.Windows.Forms.Panel();
			this.lbl_UserVP = new System.Windows.Forms.Label();
			this.picture_VP = new System.Windows.Forms.PictureBox();
			this.lbl_UserCASH = new System.Windows.Forms.Label();
			this.picture_CASH = new System.Windows.Forms.PictureBox();
			this.lbl_UserNickname = new System.Windows.Forms.Label();
			this.tabAccountInfo = new System.Windows.Forms.TabPage();
			this.lbl_ChangeNick = new System.Windows.Forms.Label();
			this.txt_ChangeNick = new System.Windows.Forms.TextBox();
			this.btn_ChangeNick = new System.Windows.Forms.Button();
			this.num_ChangeCash = new System.Windows.Forms.NumericUpDown();
			this.panel_Coins = new System.Windows.Forms.Panel();
			this.lbl_CoinsPanel = new System.Windows.Forms.Label();
			this.lbl_ChangeCash = new System.Windows.Forms.Label();
			this.btn_ChangeCash = new System.Windows.Forms.Button();
			this.num_ChangeCharLevel = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_ChangeCharLevel = new System.Windows.Forms.Label();
			this.btn_ChangeCharLevel = new System.Windows.Forms.Button();
			this.headerPanel.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabCharacters.SuspendLayout();
			this.panel_SelectedCharacter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_SelectedCharacter)).BeginInit();
			this.tabItems.SuspendLayout();
			this.panel_UserInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_VP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_CASH)).BeginInit();
			this.tabAccountInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_ChangeCash)).BeginInit();
			this.panel_Coins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_ChangeCharLevel)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_LoginUID
			// 
			this.txt_LoginUID.Location = new System.Drawing.Point(91, 13);
			this.txt_LoginUID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txt_LoginUID.Name = "txt_LoginUID";
			this.txt_LoginUID.Size = new System.Drawing.Size(132, 23);
			this.txt_LoginUID.TabIndex = 0;
			// 
			// lbl_LoginUID
			// 
			this.lbl_LoginUID.AutoSize = true;
			this.lbl_LoginUID.Location = new System.Drawing.Point(10, 16);
			this.lbl_LoginUID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_LoginUID.Name = "lbl_LoginUID";
			this.lbl_LoginUID.Size = new System.Drawing.Size(64, 17);
			this.lbl_LoginUID.TabIndex = 1;
			this.lbl_LoginUID.Text = "LoginUID";
			// 
			// lbl_ItemID
			// 
			this.lbl_ItemID.AutoSize = true;
			this.lbl_ItemID.Location = new System.Drawing.Point(10, 50);
			this.lbl_ItemID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_ItemID.Name = "lbl_ItemID";
			this.lbl_ItemID.Size = new System.Drawing.Size(50, 17);
			this.lbl_ItemID.TabIndex = 3;
			this.lbl_ItemID.Text = "ItemID";
			// 
			// txt_ItemID
			// 
			this.txt_ItemID.Location = new System.Drawing.Point(91, 47);
			this.txt_ItemID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txt_ItemID.Name = "txt_ItemID";
			this.txt_ItemID.Size = new System.Drawing.Size(132, 23);
			this.txt_ItemID.TabIndex = 2;
			// 
			// btn_AddItem
			// 
			this.btn_AddItem.Location = new System.Drawing.Point(244, 13);
			this.btn_AddItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btn_AddItem.Name = "btn_AddItem";
			this.btn_AddItem.Size = new System.Drawing.Size(101, 60);
			this.btn_AddItem.TabIndex = 4;
			this.btn_AddItem.Text = "Add Item";
			this.btn_AddItem.UseVisualStyleBackColor = true;
			this.btn_AddItem.Click += new System.EventHandler(this.Btn_AddItem_Click);
			// 
			// combo_Grade
			// 
			this.combo_Grade.FormattingEnabled = true;
			this.combo_Grade.Location = new System.Drawing.Point(91, 81);
			this.combo_Grade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.combo_Grade.Name = "combo_Grade";
			this.combo_Grade.Size = new System.Drawing.Size(132, 25);
			this.combo_Grade.TabIndex = 5;
			// 
			// lbl_Grade
			// 
			this.lbl_Grade.AutoSize = true;
			this.lbl_Grade.Location = new System.Drawing.Point(10, 84);
			this.lbl_Grade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_Grade.Name = "lbl_Grade";
			this.lbl_Grade.Size = new System.Drawing.Size(67, 17);
			this.lbl_Grade.TabIndex = 6;
			this.lbl_Grade.Text = "Raridade";
			// 
			// headerPanel
			// 
			this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.headerPanel.Controls.Add(this.lbl_ServerInfo);
			this.headerPanel.Controls.Add(this.listBox_ServerInfo);
			this.headerPanel.Controls.Add(this.btn_AccountSearch);
			this.headerPanel.Controls.Add(this.radioLoginEmail);
			this.headerPanel.Controls.Add(this.radioAccountLogin);
			this.headerPanel.Controls.Add(this.radioAccountNickname);
			this.headerPanel.Controls.Add(this.lbl_AccountString);
			this.headerPanel.Controls.Add(this.txt_AccountString);
			this.headerPanel.Location = new System.Drawing.Point(16, 4);
			this.headerPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(1020, 87);
			this.headerPanel.TabIndex = 7;
			// 
			// lbl_ServerInfo
			// 
			this.lbl_ServerInfo.AutoSize = true;
			this.lbl_ServerInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ServerInfo.Location = new System.Drawing.Point(891, -1);
			this.lbl_ServerInfo.Name = "lbl_ServerInfo";
			this.lbl_ServerInfo.Size = new System.Drawing.Size(129, 16);
			this.lbl_ServerInfo.TabIndex = 7;
			this.lbl_ServerInfo.Text = "Lista de Servidores";
			// 
			// listBox_ServerInfo
			// 
			this.listBox_ServerInfo.BackColor = System.Drawing.SystemColors.Control;
			this.listBox_ServerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox_ServerInfo.FormattingEnabled = true;
			this.listBox_ServerInfo.ItemHeight = 17;
			this.listBox_ServerInfo.Location = new System.Drawing.Point(808, 16);
			this.listBox_ServerInfo.Name = "listBox_ServerInfo";
			this.listBox_ServerInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listBox_ServerInfo.Size = new System.Drawing.Size(210, 68);
			this.listBox_ServerInfo.TabIndex = 6;
			this.listBox_ServerInfo.SelectedIndexChanged += new System.EventHandler(this.ListBox_ServerInfo_SelectedIndexChanged);
			// 
			// btn_AccountSearch
			// 
			this.btn_AccountSearch.Enabled = false;
			this.btn_AccountSearch.Location = new System.Drawing.Point(205, 27);
			this.btn_AccountSearch.Name = "btn_AccountSearch";
			this.btn_AccountSearch.Size = new System.Drawing.Size(48, 25);
			this.btn_AccountSearch.TabIndex = 5;
			this.btn_AccountSearch.Text = "OK";
			this.btn_AccountSearch.UseVisualStyleBackColor = true;
			this.btn_AccountSearch.Click += new System.EventHandler(this.Btn_AccountSearch_Click);
			// 
			// radioLoginEmail
			// 
			this.radioLoginEmail.AutoSize = true;
			this.radioLoginEmail.Enabled = false;
			this.radioLoginEmail.Location = new System.Drawing.Point(179, 54);
			this.radioLoginEmail.Name = "radioLoginEmail";
			this.radioLoginEmail.Size = new System.Drawing.Size(65, 21);
			this.radioLoginEmail.TabIndex = 4;
			this.radioLoginEmail.Text = "E-mail";
			this.radioLoginEmail.UseVisualStyleBackColor = true;
			// 
			// radioAccountLogin
			// 
			this.radioAccountLogin.AutoSize = true;
			this.radioAccountLogin.Checked = true;
			this.radioAccountLogin.Location = new System.Drawing.Point(112, 54);
			this.radioAccountLogin.Name = "radioAccountLogin";
			this.radioAccountLogin.Size = new System.Drawing.Size(61, 21);
			this.radioAccountLogin.TabIndex = 3;
			this.radioAccountLogin.TabStop = true;
			this.radioAccountLogin.Text = "Login";
			this.radioAccountLogin.UseVisualStyleBackColor = true;
			// 
			// radioAccountNickname
			// 
			this.radioAccountNickname.AutoSize = true;
			this.radioAccountNickname.Enabled = false;
			this.radioAccountNickname.Location = new System.Drawing.Point(17, 54);
			this.radioAccountNickname.Name = "radioAccountNickname";
			this.radioAccountNickname.Size = new System.Drawing.Size(92, 21);
			this.radioAccountNickname.TabIndex = 2;
			this.radioAccountNickname.Text = "Nickname";
			this.radioAccountNickname.UseVisualStyleBackColor = true;
			// 
			// lbl_AccountString
			// 
			this.lbl_AccountString.AutoSize = true;
			this.lbl_AccountString.Location = new System.Drawing.Point(10, 8);
			this.lbl_AccountString.Name = "lbl_AccountString";
			this.lbl_AccountString.Size = new System.Drawing.Size(163, 17);
			this.lbl_AccountString.TabIndex = 1;
			this.lbl_AccountString.Text = "Pesquise por um usuário";
			// 
			// txt_AccountString
			// 
			this.txt_AccountString.Location = new System.Drawing.Point(13, 28);
			this.txt_AccountString.Name = "txt_AccountString";
			this.txt_AccountString.Size = new System.Drawing.Size(186, 23);
			this.txt_AccountString.TabIndex = 0;
			this.txt_AccountString.Text = "fatal";
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabCharacters);
			this.tabControlMain.Controls.Add(this.tabItems);
			this.tabControlMain.Controls.Add(this.tabAccountInfo);
			this.tabControlMain.Location = new System.Drawing.Point(16, 107);
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1024, 544);
			this.tabControlMain.TabIndex = 8;
			this.tabControlMain.Visible = false;
			// 
			// tabCharacters
			// 
			this.tabCharacters.Controls.Add(this.lbl_CoinsPanel);
			this.tabCharacters.Controls.Add(this.panel_Coins);
			this.tabCharacters.Controls.Add(this.panel_SelectedCharacter);
			this.tabCharacters.Controls.Add(this.listView_Characters);
			this.tabCharacters.Controls.Add(this.lbl_Characters_ListBox);
			this.tabCharacters.Location = new System.Drawing.Point(4, 26);
			this.tabCharacters.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabCharacters.Name = "tabCharacters";
			this.tabCharacters.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabCharacters.Size = new System.Drawing.Size(1016, 514);
			this.tabCharacters.TabIndex = 0;
			this.tabCharacters.Text = "Personagens e Moedas";
			this.tabCharacters.UseVisualStyleBackColor = true;
			// 
			// panel_SelectedCharacter
			// 
			this.panel_SelectedCharacter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.panel_SelectedCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_SelectedCharacter.Controls.Add(this.btn_ChangeCharLevel);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_ChangeCharLevel);
			this.panel_SelectedCharacter.Controls.Add(this.label1);
			this.panel_SelectedCharacter.Controls.Add(this.num_ChangeCharLevel);
			this.panel_SelectedCharacter.Controls.Add(this.picture_SelectedCharacter);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_DefaultBonus);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_CharInventorySize);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_SelectedCharacterCIGAGamePoint);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_SelectedCharacterName);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_SelectedCharacterJob);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_SelectedCharacterLevelAndPerc);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_SelectedCharacterExpS4);
			this.panel_SelectedCharacter.Controls.Add(this.lbl_SelectedCharacterPanelDivision);
			this.panel_SelectedCharacter.Location = new System.Drawing.Point(266, 23);
			this.panel_SelectedCharacter.Name = "panel_SelectedCharacter";
			this.panel_SelectedCharacter.Size = new System.Drawing.Size(240, 463);
			this.panel_SelectedCharacter.TabIndex = 15;
			this.panel_SelectedCharacter.Visible = false;
			// 
			// picture_SelectedCharacter
			// 
			this.picture_SelectedCharacter.Location = new System.Drawing.Point(142, 11);
			this.picture_SelectedCharacter.Name = "picture_SelectedCharacter";
			this.picture_SelectedCharacter.Size = new System.Drawing.Size(75, 75);
			this.picture_SelectedCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_SelectedCharacter.TabIndex = 13;
			this.picture_SelectedCharacter.TabStop = false;
			// 
			// lbl_DefaultBonus
			// 
			this.lbl_DefaultBonus.AutoSize = true;
			this.lbl_DefaultBonus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_DefaultBonus.Location = new System.Drawing.Point(16, 147);
			this.lbl_DefaultBonus.Name = "lbl_DefaultBonus";
			this.lbl_DefaultBonus.Size = new System.Drawing.Size(122, 17);
			this.lbl_DefaultBonus.TabIndex = 18;
			this.lbl_DefaultBonus.Text = "CharInventorySize";
			// 
			// lbl_CharInventorySize
			// 
			this.lbl_CharInventorySize.AutoSize = true;
			this.lbl_CharInventorySize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_CharInventorySize.Location = new System.Drawing.Point(16, 130);
			this.lbl_CharInventorySize.Name = "lbl_CharInventorySize";
			this.lbl_CharInventorySize.Size = new System.Drawing.Size(122, 17);
			this.lbl_CharInventorySize.TabIndex = 17;
			this.lbl_CharInventorySize.Text = "CharInventorySize";
			// 
			// lbl_SelectedCharacterCIGAGamePoint
			// 
			this.lbl_SelectedCharacterCIGAGamePoint.AutoSize = true;
			this.lbl_SelectedCharacterCIGAGamePoint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectedCharacterCIGAGamePoint.Location = new System.Drawing.Point(16, 113);
			this.lbl_SelectedCharacterCIGAGamePoint.Name = "lbl_SelectedCharacterCIGAGamePoint";
			this.lbl_SelectedCharacterCIGAGamePoint.Size = new System.Drawing.Size(83, 17);
			this.lbl_SelectedCharacterCIGAGamePoint.TabIndex = 16;
			this.lbl_SelectedCharacterCIGAGamePoint.Text = "GP Amount";
			// 
			// lbl_SelectedCharacterName
			// 
			this.lbl_SelectedCharacterName.AutoSize = true;
			this.lbl_SelectedCharacterName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectedCharacterName.Location = new System.Drawing.Point(13, 9);
			this.lbl_SelectedCharacterName.Name = "lbl_SelectedCharacterName";
			this.lbl_SelectedCharacterName.Size = new System.Drawing.Size(125, 24);
			this.lbl_SelectedCharacterName.TabIndex = 10;
			this.lbl_SelectedCharacterName.Text = "CharName";
			// 
			// lbl_SelectedCharacterJob
			// 
			this.lbl_SelectedCharacterJob.AutoSize = true;
			this.lbl_SelectedCharacterJob.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectedCharacterJob.Location = new System.Drawing.Point(16, 50);
			this.lbl_SelectedCharacterJob.Name = "lbl_SelectedCharacterJob";
			this.lbl_SelectedCharacterJob.Size = new System.Drawing.Size(32, 17);
			this.lbl_SelectedCharacterJob.TabIndex = 14;
			this.lbl_SelectedCharacterJob.Text = "Job";
			// 
			// lbl_SelectedCharacterLevelAndPerc
			// 
			this.lbl_SelectedCharacterLevelAndPerc.AutoSize = true;
			this.lbl_SelectedCharacterLevelAndPerc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectedCharacterLevelAndPerc.Location = new System.Drawing.Point(16, 33);
			this.lbl_SelectedCharacterLevelAndPerc.Name = "lbl_SelectedCharacterLevelAndPerc";
			this.lbl_SelectedCharacterLevelAndPerc.Size = new System.Drawing.Size(103, 17);
			this.lbl_SelectedCharacterLevelAndPerc.TabIndex = 11;
			this.lbl_SelectedCharacterLevelAndPerc.Text = "Level and Perc";
			// 
			// lbl_SelectedCharacterExpS4
			// 
			this.lbl_SelectedCharacterExpS4.AutoSize = true;
			this.lbl_SelectedCharacterExpS4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectedCharacterExpS4.Location = new System.Drawing.Point(16, 67);
			this.lbl_SelectedCharacterExpS4.Name = "lbl_SelectedCharacterExpS4";
			this.lbl_SelectedCharacterExpS4.Size = new System.Drawing.Size(77, 17);
			this.lbl_SelectedCharacterExpS4.TabIndex = 12;
			this.lbl_SelectedCharacterExpS4.Text = "Experience";
			// 
			// lbl_SelectedCharacterPanelDivision
			// 
			this.lbl_SelectedCharacterPanelDivision.AutoSize = true;
			this.lbl_SelectedCharacterPanelDivision.Location = new System.Drawing.Point(47, 84);
			this.lbl_SelectedCharacterPanelDivision.Name = "lbl_SelectedCharacterPanelDivision";
			this.lbl_SelectedCharacterPanelDivision.Size = new System.Drawing.Size(141, 17);
			this.lbl_SelectedCharacterPanelDivision.TabIndex = 15;
			this.lbl_SelectedCharacterPanelDivision.Text = "___________________";
			// 
			// listView_Characters
			// 
			this.listView_Characters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView_Characters.Location = new System.Drawing.Point(14, 23);
			this.listView_Characters.MultiSelect = false;
			this.listView_Characters.Name = "listView_Characters";
			this.listView_Characters.Size = new System.Drawing.Size(167, 364);
			this.listView_Characters.TabIndex = 9;
			this.listView_Characters.UseCompatibleStateImageBehavior = false;
			this.listView_Characters.View = System.Windows.Forms.View.List;
			this.listView_Characters.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Characters_ItemSelectionChanged);
			// 
			// lbl_Characters_ListBox
			// 
			this.lbl_Characters_ListBox.AutoSize = true;
			this.lbl_Characters_ListBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Characters_ListBox.Location = new System.Drawing.Point(10, 5);
			this.lbl_Characters_ListBox.Name = "lbl_Characters_ListBox";
			this.lbl_Characters_ListBox.Size = new System.Drawing.Size(179, 16);
			this.lbl_Characters_ListBox.TabIndex = 8;
			this.lbl_Characters_ListBox.Text = "Selecione um Personagem";
			// 
			// tabItems
			// 
			this.tabItems.Controls.Add(this.btn_AddItem);
			this.tabItems.Controls.Add(this.lbl_LoginUID);
			this.tabItems.Controls.Add(this.txt_ItemID);
			this.tabItems.Controls.Add(this.txt_LoginUID);
			this.tabItems.Controls.Add(this.combo_Grade);
			this.tabItems.Controls.Add(this.lbl_Grade);
			this.tabItems.Controls.Add(this.lbl_ItemID);
			this.tabItems.Location = new System.Drawing.Point(4, 26);
			this.tabItems.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabItems.Name = "tabItems";
			this.tabItems.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabItems.Size = new System.Drawing.Size(1016, 514);
			this.tabItems.TabIndex = 1;
			this.tabItems.Text = "Itens";
			this.tabItems.UseVisualStyleBackColor = true;
			// 
			// lbl_SqlConnectionStatus
			// 
			this.lbl_SqlConnectionStatus.AutoSize = true;
			this.lbl_SqlConnectionStatus.Location = new System.Drawing.Point(892, 93);
			this.lbl_SqlConnectionStatus.Name = "lbl_SqlConnectionStatus";
			this.lbl_SqlConnectionStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SqlConnectionStatus.Size = new System.Drawing.Size(141, 17);
			this.lbl_SqlConnectionStatus.TabIndex = 8;
			this.lbl_SqlConnectionStatus.Text = "Conectando ao SQL";
			this.lbl_SqlConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel_UserInfo
			// 
			this.panel_UserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_UserInfo.Controls.Add(this.lbl_UserVP);
			this.panel_UserInfo.Controls.Add(this.picture_VP);
			this.panel_UserInfo.Controls.Add(this.lbl_UserCASH);
			this.panel_UserInfo.Controls.Add(this.picture_CASH);
			this.panel_UserInfo.Controls.Add(this.lbl_UserNickname);
			this.panel_UserInfo.Location = new System.Drawing.Point(295, 4);
			this.panel_UserInfo.Name = "panel_UserInfo";
			this.panel_UserInfo.Size = new System.Drawing.Size(583, 87);
			this.panel_UserInfo.TabIndex = 8;
			this.panel_UserInfo.Visible = false;
			// 
			// lbl_UserVP
			// 
			this.lbl_UserVP.AutoSize = true;
			this.lbl_UserVP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_UserVP.Location = new System.Drawing.Point(31, 58);
			this.lbl_UserVP.Name = "lbl_UserVP";
			this.lbl_UserVP.Size = new System.Drawing.Size(36, 17);
			this.lbl_UserVP.TabIndex = 19;
			this.lbl_UserVP.Text = "2000";
			// 
			// picture_VP
			// 
			this.picture_VP.Image = global::GCPanelSeasonV.Properties.Resources.VP;
			this.picture_VP.Location = new System.Drawing.Point(2, 54);
			this.picture_VP.Name = "picture_VP";
			this.picture_VP.Size = new System.Drawing.Size(30, 25);
			this.picture_VP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_VP.TabIndex = 18;
			this.picture_VP.TabStop = false;
			// 
			// lbl_UserCASH
			// 
			this.lbl_UserCASH.AutoSize = true;
			this.lbl_UserCASH.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_UserCASH.Location = new System.Drawing.Point(31, 34);
			this.lbl_UserCASH.Name = "lbl_UserCASH";
			this.lbl_UserCASH.Size = new System.Drawing.Size(36, 17);
			this.lbl_UserCASH.TabIndex = 17;
			this.lbl_UserCASH.Text = "2000";
			// 
			// picture_CASH
			// 
			this.picture_CASH.Image = global::GCPanelSeasonV.Properties.Resources.CASH;
			this.picture_CASH.Location = new System.Drawing.Point(8, 31);
			this.picture_CASH.Name = "picture_CASH";
			this.picture_CASH.Size = new System.Drawing.Size(21, 21);
			this.picture_CASH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picture_CASH.TabIndex = 16;
			this.picture_CASH.TabStop = false;
			// 
			// lbl_UserNickname
			// 
			this.lbl_UserNickname.AutoSize = true;
			this.lbl_UserNickname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_UserNickname.Location = new System.Drawing.Point(5, 4);
			this.lbl_UserNickname.Name = "lbl_UserNickname";
			this.lbl_UserNickname.Size = new System.Drawing.Size(116, 24);
			this.lbl_UserNickname.TabIndex = 0;
			this.lbl_UserNickname.Text = "Nickname";
			// 
			// tabAccountInfo
			// 
			this.tabAccountInfo.Controls.Add(this.btn_ChangeNick);
			this.tabAccountInfo.Controls.Add(this.txt_ChangeNick);
			this.tabAccountInfo.Controls.Add(this.lbl_ChangeNick);
			this.tabAccountInfo.Location = new System.Drawing.Point(4, 26);
			this.tabAccountInfo.Name = "tabAccountInfo";
			this.tabAccountInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tabAccountInfo.Size = new System.Drawing.Size(1016, 514);
			this.tabAccountInfo.TabIndex = 2;
			this.tabAccountInfo.Text = "Conta";
			this.tabAccountInfo.UseVisualStyleBackColor = true;
			// 
			// lbl_ChangeNick
			// 
			this.lbl_ChangeNick.AutoSize = true;
			this.lbl_ChangeNick.Location = new System.Drawing.Point(25, 19);
			this.lbl_ChangeNick.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_ChangeNick.Name = "lbl_ChangeNick";
			this.lbl_ChangeNick.Size = new System.Drawing.Size(104, 17);
			this.lbl_ChangeNick.TabIndex = 2;
			this.lbl_ChangeNick.Text = "Alterar Apelido";
			// 
			// txt_ChangeNick
			// 
			this.txt_ChangeNick.Location = new System.Drawing.Point(28, 39);
			this.txt_ChangeNick.Name = "txt_ChangeNick";
			this.txt_ChangeNick.Size = new System.Drawing.Size(142, 23);
			this.txt_ChangeNick.TabIndex = 3;
			// 
			// btn_ChangeNick
			// 
			this.btn_ChangeNick.Location = new System.Drawing.Point(176, 39);
			this.btn_ChangeNick.Name = "btn_ChangeNick";
			this.btn_ChangeNick.Size = new System.Drawing.Size(75, 23);
			this.btn_ChangeNick.TabIndex = 4;
			this.btn_ChangeNick.Text = "Alterar";
			this.btn_ChangeNick.UseVisualStyleBackColor = true;
			this.btn_ChangeNick.Click += new System.EventHandler(this.Btn_ChangeNick_Click);
			// 
			// num_ChangeCash
			// 
			this.num_ChangeCash.Location = new System.Drawing.Point(17, 22);
			this.num_ChangeCash.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.num_ChangeCash.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
			this.num_ChangeCash.Name = "num_ChangeCash";
			this.num_ChangeCash.Size = new System.Drawing.Size(115, 23);
			this.num_ChangeCash.TabIndex = 16;
			// 
			// panel_Coins
			// 
			this.panel_Coins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.panel_Coins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_Coins.Controls.Add(this.btn_ChangeCash);
			this.panel_Coins.Controls.Add(this.lbl_ChangeCash);
			this.panel_Coins.Controls.Add(this.num_ChangeCash);
			this.panel_Coins.Location = new System.Drawing.Point(776, 23);
			this.panel_Coins.Name = "panel_Coins";
			this.panel_Coins.Size = new System.Drawing.Size(229, 201);
			this.panel_Coins.TabIndex = 17;
			// 
			// lbl_CoinsPanel
			// 
			this.lbl_CoinsPanel.AutoSize = true;
			this.lbl_CoinsPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_CoinsPanel.Location = new System.Drawing.Point(875, 5);
			this.lbl_CoinsPanel.Name = "lbl_CoinsPanel";
			this.lbl_CoinsPanel.Size = new System.Drawing.Size(130, 16);
			this.lbl_CoinsPanel.TabIndex = 18;
			this.lbl_CoinsPanel.Text = "Gerenciar Moedas";
			// 
			// lbl_ChangeCash
			// 
			this.lbl_ChangeCash.AutoSize = true;
			this.lbl_ChangeCash.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ChangeCash.Location = new System.Drawing.Point(14, 5);
			this.lbl_ChangeCash.Name = "lbl_ChangeCash";
			this.lbl_ChangeCash.Size = new System.Drawing.Size(43, 17);
			this.lbl_ChangeCash.TabIndex = 19;
			this.lbl_ChangeCash.Text = "CASH";
			// 
			// btn_ChangeCash
			// 
			this.btn_ChangeCash.Location = new System.Drawing.Point(138, 21);
			this.btn_ChangeCash.Name = "btn_ChangeCash";
			this.btn_ChangeCash.Size = new System.Drawing.Size(72, 25);
			this.btn_ChangeCash.TabIndex = 20;
			this.btn_ChangeCash.Text = "Alterar";
			this.btn_ChangeCash.UseVisualStyleBackColor = true;
			this.btn_ChangeCash.Click += new System.EventHandler(this.Btn_ChangeCash_Click);
			// 
			// num_ChangeCharLevel
			// 
			this.num_ChangeCharLevel.Location = new System.Drawing.Point(50, 221);
			this.num_ChangeCharLevel.Maximum = new decimal(new int[] {
            85,
            0,
            0,
            0});
			this.num_ChangeCharLevel.Name = "num_ChangeCharLevel";
			this.num_ChangeCharLevel.Size = new System.Drawing.Size(57, 23);
			this.num_ChangeCharLevel.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 168);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 17);
			this.label1.TabIndex = 22;
			this.label1.Text = "___________________";
			// 
			// lbl_ChangeCharLevel
			// 
			this.lbl_ChangeCharLevel.AutoSize = true;
			this.lbl_ChangeCharLevel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_ChangeCharLevel.Location = new System.Drawing.Point(47, 202);
			this.lbl_ChangeCharLevel.Name = "lbl_ChangeCharLevel";
			this.lbl_ChangeCharLevel.Size = new System.Drawing.Size(86, 17);
			this.lbl_ChangeCharLevel.TabIndex = 21;
			this.lbl_ChangeCharLevel.Text = "Alterar Nível";
			// 
			// btn_ChangeCharLevel
			// 
			this.btn_ChangeCharLevel.Location = new System.Drawing.Point(114, 220);
			this.btn_ChangeCharLevel.Name = "btn_ChangeCharLevel";
			this.btn_ChangeCharLevel.Size = new System.Drawing.Size(72, 25);
			this.btn_ChangeCharLevel.TabIndex = 21;
			this.btn_ChangeCharLevel.Text = "Alterar";
			this.btn_ChangeCharLevel.UseVisualStyleBackColor = true;
			this.btn_ChangeCharLevel.Click += new System.EventHandler(this.Btn_ChangeCharLevel_Click);
			// 
			// Painel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1053, 662);
			this.Controls.Add(this.panel_UserInfo);
			this.Controls.Add(this.lbl_SqlConnectionStatus);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.headerPanel);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "Painel";
			this.Text = "Painel Grand Chase Season V - EP. 1 | FatalSkull";
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabCharacters.ResumeLayout(false);
			this.tabCharacters.PerformLayout();
			this.panel_SelectedCharacter.ResumeLayout(false);
			this.panel_SelectedCharacter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_SelectedCharacter)).EndInit();
			this.tabItems.ResumeLayout(false);
			this.tabItems.PerformLayout();
			this.panel_UserInfo.ResumeLayout(false);
			this.panel_UserInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picture_VP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_CASH)).EndInit();
			this.tabAccountInfo.ResumeLayout(false);
			this.tabAccountInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_ChangeCash)).EndInit();
			this.panel_Coins.ResumeLayout(false);
			this.panel_Coins.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_ChangeCharLevel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_LoginUID;
		private System.Windows.Forms.Label lbl_LoginUID;
		private System.Windows.Forms.Label lbl_ItemID;
		private System.Windows.Forms.TextBox txt_ItemID;
		private System.Windows.Forms.Button btn_AddItem;
		private System.Windows.Forms.ComboBox combo_Grade;
		private System.Windows.Forms.Label lbl_Grade;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabCharacters;
		private System.Windows.Forms.TabPage tabItems;
		private System.Windows.Forms.RadioButton radioLoginEmail;
		private System.Windows.Forms.RadioButton radioAccountLogin;
		private System.Windows.Forms.RadioButton radioAccountNickname;
		private System.Windows.Forms.Label lbl_AccountString;
		private System.Windows.Forms.TextBox txt_AccountString;
		private System.Windows.Forms.Button btn_AccountSearch;
		private System.Windows.Forms.ListBox listBox_ServerInfo;
		private System.Windows.Forms.Label lbl_ServerInfo;
		private System.Windows.Forms.Label lbl_Characters_ListBox;
		private System.Windows.Forms.ListView listView_Characters;
		private System.Windows.Forms.Label lbl_SqlConnectionStatus;
		private System.Windows.Forms.Label lbl_SelectedCharacterName;
		private System.Windows.Forms.Label lbl_SelectedCharacterLevelAndPerc;
		private System.Windows.Forms.Label lbl_SelectedCharacterExpS4;
		private System.Windows.Forms.PictureBox picture_SelectedCharacter;
		private System.Windows.Forms.Label lbl_SelectedCharacterJob;
		private System.Windows.Forms.Panel panel_SelectedCharacter;
		private System.Windows.Forms.Label lbl_SelectedCharacterPanelDivision;
		private System.Windows.Forms.Label lbl_SelectedCharacterCIGAGamePoint;
		private System.Windows.Forms.Panel panel_UserInfo;
		private System.Windows.Forms.Label lbl_UserNickname;
		private System.Windows.Forms.Label lbl_DefaultBonus;
		private System.Windows.Forms.Label lbl_CharInventorySize;
		private System.Windows.Forms.PictureBox picture_CASH;
		private System.Windows.Forms.Label lbl_UserCASH;
		private System.Windows.Forms.Label lbl_UserVP;
		private System.Windows.Forms.PictureBox picture_VP;
		private System.Windows.Forms.TabPage tabAccountInfo;
		private System.Windows.Forms.Button btn_ChangeNick;
		private System.Windows.Forms.TextBox txt_ChangeNick;
		private System.Windows.Forms.Label lbl_ChangeNick;
		private System.Windows.Forms.Label lbl_CoinsPanel;
		private System.Windows.Forms.Panel panel_Coins;
		private System.Windows.Forms.NumericUpDown num_ChangeCash;
		private System.Windows.Forms.Button btn_ChangeCash;
		private System.Windows.Forms.Label lbl_ChangeCash;
		private System.Windows.Forms.Button btn_ChangeCharLevel;
		private System.Windows.Forms.Label lbl_ChangeCharLevel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown num_ChangeCharLevel;
	}
}

