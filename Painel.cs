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

		Timer refreshServers = new Timer();
		List<ConnectStatusDB> serverList;

		Users user; //Referência ao usuário encontrado
		List<Characters> characters;
		Characters selectedCharacter;
		List<CIGACharacterInfo> cigaCharactersInfo;
		CIGACharacterInfo selectedCharacterCIGA;
		int charListLastSelectedIndex = -1;

		public Painel()
		{
			InitializeComponent();
			RetrieveServerInfoAsync();
			PopulateComboboxes();
		}

		#region Métodos relacionados a informações do server

		private async Task RetrieveServerInfoAsync()
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
		}

		#endregion


		#region Métodos referentes a contas e seus atributos

		private async void Btn_AccountSearch_Click(object sender, EventArgs e)
		{
			user = db.GetUserByLogin(txt_AccountString.Text);
			HideAccountData();

			if (user != null)
			{
				await GetUserNickName();
				await GetCharacters();
				await GetCashAndVP();
				LoadCharactersToList();
				ShowAccountData();
			}
			else
			{
				MessageBox.Show("Login não encontrado");
			}
		}

		private async Task GetUserNickName()
		{
			await Task.Run(() => user.NickName = db.GetNickName(user));
		}

		private void Btn_ChangeNick_Click(object sender, EventArgs e)
		{
			if(db.ChangeNickName(user, txt_ChangeNick.Text))
			{
				ShowAccountData();
				MessageBox.Show("Apelido Alterado");
			}
			else
			{
				MessageBox.Show("Falha ao alterar apelido");
			}
		}

		#endregion


		#region Métodos referentes a PERSONAGENS
		private async Task GetCharacters()
		{
			characters = await Task.Run(() => db.GetCharacters(user.LoginUID));
			cigaCharactersInfo = await Task.Run(() => db.GetCIGACharactersInfo(user.LoginUID));
		}

		private void Btn_ChangeCharLevel_Click(object sender, EventArgs e)
		{
			int newLevel = (int)num_ChangeCharLevel.Value;
			int exp = ValueHelper.LevelToExp[newLevel];
			if (listView_Characters.SelectedIndices.Count > 0)
			{
				Console.Write(listView_Characters.SelectedIndices);
			}

			if (hasConfirmedChange("Confirmar alteração de nível?", "Alerta:"))
			{
				if (db.ChangeCharLevel(user, selectedCharacter, newLevel, exp))
				{
					selectedCharacter.ExpS4 = exp;
					selectedCharacter.Exp = exp;
					selectedCharacter.Level = newLevel;
					LoadCharactersToList();
					listView_Characters.Items[charListLastSelectedIndex].Focused = true;
					listView_Characters.Items[charListLastSelectedIndex].Selected = true;
				}
			}
		}

		#endregion


		#region Métodos referentes a ITENS
		private void Btn_AddItem_Click(object sender, EventArgs e)
		{
			var grade = combo_Grade.SelectedValue;
			Console.WriteLine(grade);
			//db.AddItem(txt_LoginUID.Text, txt_ItemID.Text);

		}
		#endregion


		#region Métodos referentes a MOEDAS
		private async Task GetCashAndVP()
		{
			List<int> cashVP = await Task.Run(() => db.GetCashAndVP(user));
			user.Cash = cashVP[0];
			user.VP = cashVP[1];
		}

		private void Btn_ChangeCash_Click(object sender, EventArgs e)
		{
			string AdcRem = "adicionar";
			if (num_ChangeCash.Value < 0)
				AdcRem = "debitar";

			if(MessageBox.Show($"Deseja {AdcRem} {num_ChangeCash.Value} CASH na conta de {user.NickName}?", "Alterar CASH",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if(db.ChangeCash(user, (int)num_ChangeCash.Value))
				{
					ShowAccountData();
				}
			}
		}

		#endregion


		#region Métodos responsáveis por setar valores do formulário

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

		/// <summary>
		/// Exibe os valores recuperados da DB no form e exibe alguns componentes
		/// </summary>
		private void ShowAccountData()
		{
			lbl_UserNickname.Text = user.NickName;
			lbl_UserCASH.Text = user.Cash.ToString();
			panel_UserInfo.Visible = true;
			tabControlMain.Visible = true;
		}

		/// <summary>
		/// Esconde todos os valores da conta e alguns componentes do form
		/// </summary>
		private void HideAccountData()
		{
			panel_UserInfo.Visible = false;

			lbl_SelectedCharacterName.Text = "";
			lbl_SelectedCharacterLevelAndPerc.Text = "";
			lbl_SelectedCharacterJob.Text = "";
			lbl_SelectedCharacterExpS4.Text = "";
			picture_SelectedCharacter.Image = null;
			panel_SelectedCharacter.Visible = false;
			tabControlMain.Visible = false;
		}

		private void LoadCharactersToList()
		{
			int index = 0;

			listView_Characters.Clear();
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
				charListLastSelectedIndex = listView_Characters.SelectedIndices[0]; // para uso posterior ao alterar lv

				listView_Characters.FocusedItem.Focused = false;
				selectedCharacter = characters[listView_Characters.SelectedIndices[0]];
				selectedCharacterCIGA = cigaCharactersInfo.Find(ch => ch.CharType == selectedCharacter.CharType);

				picture_SelectedCharacter.Image = selectedCharacter.Image;
				lbl_SelectedCharacterName.ForeColor = selectedCharacter.CharColor;

				//labels
				lbl_SelectedCharacterName.Text = selectedCharacter.CharName;
				lbl_SelectedCharacterLevelAndPerc.Text = 
					$"Nível {selectedCharacter.Level}  ({selectedCharacter.LevelPercentage})";
				lbl_SelectedCharacterJob.Text = $"{selectedCharacter.Promotion + 1}ª Classe";
				lbl_SelectedCharacterExpS4.Text = $"{selectedCharacter.ExpS4} EXP";

				lbl_SelectedCharacterCIGAGamePoint.Text = $"{selectedCharacterCIGA.GamePoint} GP";
				lbl_CharInventorySize.Text = $"Inventário: {selectedCharacterCIGA.InvenSize}";
				lbl_DefaultBonus.Text = $"{selectedCharacterCIGA.DefaultBonus} Recargas de Vida";
				panel_SelectedCharacter.Visible = true;
			}
		}

		public bool hasConfirmedChange(string text, string caption)
		{
			if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				return true;
			return false;
		}
		#endregion
	}
}
