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
			this.SuspendLayout();
			// 
			// txt_LoginUID
			// 
			this.txt_LoginUID.Location = new System.Drawing.Point(73, 6);
			this.txt_LoginUID.Name = "txt_LoginUID";
			this.txt_LoginUID.Size = new System.Drawing.Size(100, 20);
			this.txt_LoginUID.TabIndex = 0;
			// 
			// lbl_LoginUID
			// 
			this.lbl_LoginUID.AutoSize = true;
			this.lbl_LoginUID.Location = new System.Drawing.Point(12, 9);
			this.lbl_LoginUID.Name = "lbl_LoginUID";
			this.lbl_LoginUID.Size = new System.Drawing.Size(52, 13);
			this.lbl_LoginUID.TabIndex = 1;
			this.lbl_LoginUID.Text = "LoginUID";
			// 
			// lbl_ItemID
			// 
			this.lbl_ItemID.AutoSize = true;
			this.lbl_ItemID.Location = new System.Drawing.Point(12, 35);
			this.lbl_ItemID.Name = "lbl_ItemID";
			this.lbl_ItemID.Size = new System.Drawing.Size(38, 13);
			this.lbl_ItemID.TabIndex = 3;
			this.lbl_ItemID.Text = "ItemID";
			// 
			// txt_ItemID
			// 
			this.txt_ItemID.Location = new System.Drawing.Point(73, 32);
			this.txt_ItemID.Name = "txt_ItemID";
			this.txt_ItemID.Size = new System.Drawing.Size(100, 20);
			this.txt_ItemID.TabIndex = 2;
			// 
			// btn_AddItem
			// 
			this.btn_AddItem.Location = new System.Drawing.Point(188, 6);
			this.btn_AddItem.Name = "btn_AddItem";
			this.btn_AddItem.Size = new System.Drawing.Size(75, 46);
			this.btn_AddItem.TabIndex = 4;
			this.btn_AddItem.Text = "Add Item";
			this.btn_AddItem.UseVisualStyleBackColor = true;
			this.btn_AddItem.Click += new System.EventHandler(this.Btn_AddItem_Click);
			// 
			// combo_Grade
			// 
			this.combo_Grade.FormattingEnabled = true;
			this.combo_Grade.Location = new System.Drawing.Point(73, 58);
			this.combo_Grade.Name = "combo_Grade";
			this.combo_Grade.Size = new System.Drawing.Size(100, 21);
			this.combo_Grade.TabIndex = 5;
			// 
			// lbl_Grade
			// 
			this.lbl_Grade.AutoSize = true;
			this.lbl_Grade.Location = new System.Drawing.Point(12, 61);
			this.lbl_Grade.Name = "lbl_Grade";
			this.lbl_Grade.Size = new System.Drawing.Size(50, 13);
			this.lbl_Grade.TabIndex = 6;
			this.lbl_Grade.Text = "Raridade";
			// 
			// Painel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbl_Grade);
			this.Controls.Add(this.combo_Grade);
			this.Controls.Add(this.btn_AddItem);
			this.Controls.Add(this.lbl_ItemID);
			this.Controls.Add(this.txt_ItemID);
			this.Controls.Add(this.lbl_LoginUID);
			this.Controls.Add(this.txt_LoginUID);
			this.Name = "Painel";
			this.Text = "Painel Grand Chase Season V - EP. 1 | FatalSkull";
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
	}
}

