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
			this.panel1 = new System.Windows.Forms.Panel();
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
			this.listView_Characters = new System.Windows.Forms.ListView();
			this.lbl_Characters_ListBox = new System.Windows.Forms.Label();
			this.tabItems = new System.Windows.Forms.TabPage();
			this.lbl_SqlConnectionStatus = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterName = new System.Windows.Forms.Label();
			this.lbl_SelectedCharacterLevelAndJob = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabCharacters.SuspendLayout();
			this.tabItems.SuspendLayout();
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
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lbl_SqlConnectionStatus);
			this.panel1.Controls.Add(this.lbl_ServerInfo);
			this.panel1.Controls.Add(this.listBox_ServerInfo);
			this.panel1.Controls.Add(this.btn_AccountSearch);
			this.panel1.Controls.Add(this.radioLoginEmail);
			this.panel1.Controls.Add(this.radioAccountLogin);
			this.panel1.Controls.Add(this.radioAccountNickname);
			this.panel1.Controls.Add(this.lbl_AccountString);
			this.panel1.Controls.Add(this.txt_AccountString);
			this.panel1.Location = new System.Drawing.Point(16, 4);
			this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1020, 95);
			this.panel1.TabIndex = 7;
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
			this.radioLoginEmail.Location = new System.Drawing.Point(179, 54);
			this.radioLoginEmail.Name = "radioLoginEmail";
			this.radioLoginEmail.Size = new System.Drawing.Size(65, 21);
			this.radioLoginEmail.TabIndex = 4;
			this.radioLoginEmail.TabStop = true;
			this.radioLoginEmail.Text = "E-mail";
			this.radioLoginEmail.UseVisualStyleBackColor = true;
			// 
			// radioAccountLogin
			// 
			this.radioAccountLogin.AutoSize = true;
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
			this.radioAccountNickname.Location = new System.Drawing.Point(17, 54);
			this.radioAccountNickname.Name = "radioAccountNickname";
			this.radioAccountNickname.Size = new System.Drawing.Size(92, 21);
			this.radioAccountNickname.TabIndex = 2;
			this.radioAccountNickname.TabStop = true;
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
			this.tabControlMain.Location = new System.Drawing.Point(16, 107);
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1024, 544);
			this.tabControlMain.TabIndex = 8;
			// 
			// tabCharacters
			// 
			this.tabCharacters.Controls.Add(this.lbl_SelectedCharacterLevelAndJob);
			this.tabCharacters.Controls.Add(this.lbl_SelectedCharacterName);
			this.tabCharacters.Controls.Add(this.listView_Characters);
			this.tabCharacters.Controls.Add(this.lbl_Characters_ListBox);
			this.tabCharacters.Location = new System.Drawing.Point(4, 26);
			this.tabCharacters.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabCharacters.Name = "tabCharacters";
			this.tabCharacters.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tabCharacters.Size = new System.Drawing.Size(1016, 514);
			this.tabCharacters.TabIndex = 0;
			this.tabCharacters.Text = "Personagens";
			this.tabCharacters.UseVisualStyleBackColor = true;
			// 
			// listView_Characters
			// 
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
			this.lbl_Characters_ListBox.Location = new System.Drawing.Point(27, 4);
			this.lbl_Characters_ListBox.Name = "lbl_Characters_ListBox";
			this.lbl_Characters_ListBox.Size = new System.Drawing.Size(144, 16);
			this.lbl_Characters_ListBox.TabIndex = 8;
			this.lbl_Characters_ListBox.Text = "Lista de Personagens";
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
			this.tabItems.Size = new System.Drawing.Size(1016, 525);
			this.tabItems.TabIndex = 1;
			this.tabItems.Text = "Itens";
			this.tabItems.UseVisualStyleBackColor = true;
			// 
			// lbl_SqlConnectionStatus
			// 
			this.lbl_SqlConnectionStatus.AutoSize = true;
			this.lbl_SqlConnectionStatus.Location = new System.Drawing.Point(11, 76);
			this.lbl_SqlConnectionStatus.Name = "lbl_SqlConnectionStatus";
			this.lbl_SqlConnectionStatus.Size = new System.Drawing.Size(279, 17);
			this.lbl_SqlConnectionStatus.TabIndex = 8;
			this.lbl_SqlConnectionStatus.Text = "Estado da Conexão: Conectando ao SQL";
			// 
			// lbl_SelectedCharacterName
			// 
			this.lbl_SelectedCharacterName.AutoSize = true;
			this.lbl_SelectedCharacterName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectedCharacterName.Location = new System.Drawing.Point(220, 25);
			this.lbl_SelectedCharacterName.Name = "lbl_SelectedCharacterName";
			this.lbl_SelectedCharacterName.Size = new System.Drawing.Size(59, 24);
			this.lbl_SelectedCharacterName.TabIndex = 10;
			this.lbl_SelectedCharacterName.Text = "Elesis";
			// 
			// lbl_SelectedCharacterLevelAndJob
			// 
			this.lbl_SelectedCharacterLevelAndJob.AutoSize = true;
			this.lbl_SelectedCharacterLevelAndJob.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectedCharacterLevelAndJob.Location = new System.Drawing.Point(222, 49);
			this.lbl_SelectedCharacterLevelAndJob.Name = "lbl_SelectedCharacterLevelAndJob";
			this.lbl_SelectedCharacterLevelAndJob.Size = new System.Drawing.Size(135, 17);
			this.lbl_SelectedCharacterLevelAndJob.TabIndex = 11;
			this.lbl_SelectedCharacterLevelAndJob.Text = "Nível 85  -  4ª Classe";
			// 
			// Painel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1053, 662);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.MaximizeBox = false;
			this.Name = "Painel";
			this.Text = "Painel Grand Chase Season V - EP. 1 | FatalSkull";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabCharacters.ResumeLayout(false);
			this.tabCharacters.PerformLayout();
			this.tabItems.ResumeLayout(false);
			this.tabItems.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txt_LoginUID;
		private System.Windows.Forms.Label lbl_LoginUID;
		private System.Windows.Forms.Label lbl_ItemID;
		private System.Windows.Forms.TextBox txt_ItemID;
		private System.Windows.Forms.Button btn_AddItem;
		private System.Windows.Forms.ComboBox combo_Grade;
		private System.Windows.Forms.Label lbl_Grade;
		private System.Windows.Forms.Panel panel1;
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
		private System.Windows.Forms.Label lbl_SelectedCharacterLevelAndJob;
	}
}

