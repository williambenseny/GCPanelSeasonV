using System;
using GCPanelSeasonV.Model;
using GCPanelSeasonV.Values;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCPanelSeasonV
{
	public partial class Painel : Form
	{
		DataAccess db = new DataAccess();
		List<ConnectStatusDB> serverList;
		Users user; //Referência ao usuário encontrado
		List<Characters> characters;
		Characters selectedCharacter;

		public Painel()
		{
			InitializeComponent();
			RetrieveServerInfoAsync();
			PopulateComboboxes();
			Console.WriteLine(ValueHelper.CharactersNames.Elesis.ToString());
		}

		/*Informações do Servidor*/

		private async Task<string> RetrieveServerInfoAsync()
		{

			serverList = await Task.Run(() => db.RetrieveServerInfo());
			if (serverList != null)
			{
				btn_AccountSearch.Enabled = true;
				listBox_ServerInfo.DataSource = serverList;
				listBox_ServerInfo.DisplayMember = "ServerInfoString";
			}
			else
			{
				MessageBox.Show("Não foi possível estabelecer conexão com o servidor");
			}
			return "feito";
		}

		/*Conta e seus atributos*/

		private void Btn_AccountSearch_Click(object sender, EventArgs e)
		{
			user = db.GetUserByLogin(txt_AccountString.Text);

			if(user != null)
			{
				characters = GetCharacters();
				LoadCharactersToList();
			}
			else
			{
				MessageBox.Show("Login não encontrado");
			}
		}

		/*Personagens*/

		private List<Characters> GetCharacters()
		{
			return db.GetCharacters(user.LoginUID);
		}


		/*Itens*/
		private void Btn_AddItem_Click(object sender, EventArgs e)
		{
			var grade = combo_Grade.SelectedValue;
			Console.WriteLine(grade);
			//db.AddItem(txt_LoginUID.Text, txt_ItemID.Text);

		}


		/* Métodos Assistentes do Form, preenchimento de Valores e Enumeração*/
		private void ListBox_ServerInfo_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox_ServerInfo.SelectedIndex = -1;
		}

		private void PopulateComboboxes()
		{
			combo_Grade.DataSource = ValueHelper.itemGrades;
			combo_Grade.DisplayMember = "name";
			combo_Grade.ValueMember = "grade";
		}

		private void LoadCharactersToList()
		{
			int index = 0;
			foreach (Characters character in characters)
			{
				listView_Characters.Items.Add(character.ListBoxCharInfo);
				listView_Characters.Items[index].ForeColor = character.CharColor;
				index++;
			}
		}

		private void ListView_Characters_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if(listView_Characters.SelectedItems.Count == 1) //pois ListView seleciona "nada" antes de selecionar outro item.
			{
				listView_Characters.FocusedItem.Focused = false;
				selectedCharacter = characters[listView_Characters.SelectedIndices[0]];
				lbl_SelectedCharacterName.Text = selectedCharacter.CharName;
				lbl_SelectedCharacterName.ForeColor = selectedCharacter.CharColor;
				lbl_SelectedCharacterLevelAndJob.Text = $"Nível {selectedCharacter.Level}  -  {selectedCharacter.Promotion + 1}ª Classe";
			}
		}
	}
}
