using System;
using GCPanelSeasonV.Model;
using GCPanelSeasonV.Values;
using System.Collections.Generic;
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
			SetFixedValuesToCombosAndLists();
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
				lbl_SqlConnectionStatus.Visible = false;
			}
			else
			{
				displayErrorMessage("Não foi possível estabelecer conexão com o servidor");
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
				displayErrorMessage("Login não encontrado");
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
				displaySuccessMessage("Apelido Alterado");
			}
			else
			{
				displayErrorMessage("Falha ao alterar apelido");
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

			if (hasConfirmedChange("Confirmar alteração de nível?", "Alerta:"))
			{
				if (db.ChangeCharLevel(user, selectedCharacter, newLevel, exp))
				{
					selectedCharacter.ExpS4 = exp;
					selectedCharacter.Exp = exp;
					selectedCharacter.Level = newLevel;
					ReselectCharacterOnList();
					displaySuccessMessage("Nível alterado");
					return;
				}
				displayErrorMessage("Falha ao alterar nível");
			}
		}

		private void Btn_ChangeCharJob_Click(object sender, EventArgs e)
		{
			int newJob = (int)num_ChangeCharJob.Value - 1;

			if (hasConfirmedChange("Confirmar alteração de classe?", "Alerta:"))
			{
				if (db.ChangeCharJob(user, selectedCharacter, newJob))
				{
					selectedCharacter.Promotion = newJob;
					ReselectCharacterOnList();
					displaySuccessMessage("Classe alterada");
					return;
				}
				displayErrorMessage("Falha ao alterar classe");
			}
		}

		private async void Btn_UnlockCharacter_Click(object sender, EventArgs e)
		{
			int charType = (int)combo_UnlockCharacter.SelectedValue;
			string charName = ValueHelper.GetCharacterName(charType);
			string appendCustomInfo = "";
			int level = 1;
			int promotion = 0;
			int slotId = cigaCharactersInfo.Count;

			if (check_UnlockCharacterLevel.Checked)
			{
				appendCustomInfo += $"{check_UnlockCharacterLevel.Text} ";
				level = 85;
			}
			if (check_UnlockCharacterMaxJob.Checked)
			{
				appendCustomInfo += $"{check_UnlockCharacterMaxJob.Text} ";
				promotion = 3;
			}

			if (hasConfirmedChange($"Deseja abrir {charName} {appendCustomInfo}para {user.NickName}?", "Desbloquear"))
			{
				if(await Task.Run(() => db.UnlockCharacter(user, charType, level, promotion, slotId)))
				{
					await GetCharacters();
					LoadCharactersToList();
					displaySuccessMessage($"{charName} adicionado");
				}
				else
				{
					displayErrorMessage("Erro ao adicionar personagem");
				}
			}
		}

		private async void Btn_ClearDungeons_Click(object sender, EventArgs e)
		{
			await Task.Run(() => db.ClearAllDungeons(user, selectedCharacter));
		}
		#endregion


		#region Métodos referentes a ITENS
		private async void Btn_AddItem_Click(object sender, EventArgs e)
		{
			int grade = (int)combo_Grade.SelectedValue;
			List<UIGAUserItemAttribute> itemAttributes = new List<UIGAUserItemAttribute>();
			switch (grade)
			{
				case 1:
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr1.SelectedValue, Value = (int)num_ItemAttrVal1.Value, SlotID = 0 });
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr2.SelectedValue, Value = (int)num_ItemAttrVal2.Value, SlotID = 1 });
					break;
				case 2:
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr1.SelectedValue, Value = (int)num_ItemAttrVal1.Value, SlotID = 0 });
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr2.SelectedValue, Value = (int)num_ItemAttrVal2.Value, SlotID = 1 });
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr3.SelectedValue, Value = (int)num_ItemAttrVal3.Value, SlotID = 2 });
					break;
				case 3:
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr1.SelectedValue, Value = (int)num_ItemAttrVal1.Value, SlotID = 0 });
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr2.SelectedValue, Value = (int)num_ItemAttrVal2.Value, SlotID = 1 });
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr3.SelectedValue, Value = (int)num_ItemAttrVal3.Value, SlotID = 2 });
					itemAttributes.Add(new UIGAUserItemAttribute { TypeID = (int)combo_ItemAttr4.SelectedValue, Value = (int)num_ItemAttrVal4.Value, SlotID = 3 });
					break;
			}
			try
			{
				int selectedCharType = (int)combo_ItemCharType.SelectedValue;
				if(await Task.Run(()=> db.AddItem(user, Convert.ToInt32(txt_ItemID.Text), selectedCharType, grade, itemAttributes)))
				{
					displaySuccessMessage("Item Adicionado");
				}
				else
				{
					displayErrorMessage("Houve um erro ao adicionar o item");
				}
			}
			catch (FormatException)
			{
				displayErrorMessage("O formato do ItemID está incorreto");
			}
			catch (NullReferenceException)
			{
				displayErrorMessage("Selecione um personagem");
			}
		}

		private async void Btn_SearchItem_Click(object sender, EventArgs e)
		{
			string itemName = txt_SearchItemName.Text;
			int charType = (int)combo_SearchItemCharType.SelectedValue;

			listBox_FoundItems.DataSource = await Task.Run(() => db.searchItems(itemName, charType));

			txt_ItemID.Text = ""; //evita a cópia automática do ID do primeiro item encontrado sem o user clicar em cima antes
		}

		private void ListBox_FoundItems_SelectedValueChanged(object sender, EventArgs e)
		{
			if (check_CopyItem.Checked)
			{
				if (listBox_FoundItems.SelectedValue != null)
					txt_ItemID.Text = listBox_FoundItems.SelectedValue.ToString();
			}

			if (check_CopyCharacter.Checked)
			{
				combo_ItemCharType.SelectedIndex = (int)combo_SearchItemCharType.SelectedValue;
			}

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

			if(hasConfirmedChange($"Deseja {AdcRem} {num_ChangeCash.Value} CASH na conta de {user.NickName}?", "Alterar CASH"))
			{ 
				if(db.ChangeCash(user, (int)num_ChangeCash.Value))
				{
					ShowAccountData();
				}
			}
		}
		private void Btn_ChangeVP_Click(object sender, EventArgs e)
		{
			string AdcRem = "adicionar";
			if (num_ChangeVP.Value < 0)
				AdcRem = "debitar";

			if (hasConfirmedChange($"Deseja {AdcRem} {num_ChangeVP.Value} VP na conta de {user.NickName}?", "Alterar VP"))
			{
				if (db.ChangeVP(user, (int)num_ChangeVP.Value))
				{
					ShowAccountData();
				}
			}
		}
		private void Btn_ChangeGP_Click(object sender, EventArgs e)
		{
			if(selectedCharacterCIGA != null)
			{
				string AdcRem = "adicionar";
				if (num_ChangeGP.Value < 0)
					AdcRem = "debitar";

				if (hasConfirmedChange($"Deseja {AdcRem} {num_ChangeGP.Value} GP para o personagem selecionado" +
					$" na conta de {user.NickName}?", "Alterar GP"))
				{
					if (db.ChangeGP(user, selectedCharacterCIGA, (int)num_ChangeGP.Value))
					{
						ShowAccountData();
						ReselectCharacterOnList();
					}
				}
			}		
		}

		#endregion


		#region Métodos responsáveis por setar valores do formulário

		private void ListBox_ServerInfo_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBox_ServerInfo.SelectedIndex = -1;
		}

		/// <summary>
		/// Exibe os valores recuperados da DB no form e exibe alguns componentes
		/// </summary>
		private void ShowAccountData()
		{
			lbl_UserNickname.Text = user.NickName;
			lbl_UserCASH.Text = user.Cash.ToString();
			lbl_UserVP.Text = user.VP.ToString();
			panel_UserInfo.Visible = true;
			tabControlMain.Visible = true;
		}

		/// <summary>
		/// Esconde todos os valores da conta e alguns componentes do form
		/// </summary>
		private void HideAccountData()
		{
			panel_UserInfo.Visible = false;

			lbl_CharacterName.Text = "";
			lbl_CharacterLevelAndPerc.Text = "";
			lbl_CharacterJob.Text = "";
			lbl_CharacterExpS4.Text = "";
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
			ShowSelectedCharacterInfo();
		}

		private void ShowSelectedCharacterInfo()
		{
			if (listView_Characters.SelectedItems.Count == 1) //pois ListView seleciona "nada" antes de selecionar outro item.
			{
				charListLastSelectedIndex = listView_Characters.SelectedIndices[0]; // para uso posterior ao alterar lv

				listView_Characters.FocusedItem.Focused = false;
				selectedCharacter = characters[listView_Characters.SelectedIndices[0]];
				selectedCharacterCIGA = cigaCharactersInfo.Find(ch => ch.CharType == selectedCharacter.CharType);

				picture_SelectedCharacter.Image = selectedCharacter.Image;
				lbl_CharacterName.ForeColor = selectedCharacter.CharColor;

				//labels
				lbl_CharacterName.Text = selectedCharacter.CharName;
				lbl_CharacterLevelAndPerc.Text =
					$"Nível {selectedCharacter.Level}  ({selectedCharacter.LevelPercentage})";
				lbl_CharacterJob.Text = $"{selectedCharacter.Promotion + 1}ª Classe";
				lbl_CharacterExpS4.Text = $"{selectedCharacter.ExpS4} EXP";
				lbl_CharacterWinLoss.Text = $"Win: {selectedCharacter.Win} | Lose: {selectedCharacter.Lose}";

				lbl_CharacterCIGAGamePoint.Text = $"{selectedCharacterCIGA.GamePoint} GP";
				lbl_CharacterInventorySize.Text = $"Inventário: {selectedCharacterCIGA.InvenSize}";
				lbl_CharacterDefaultBonus.Text = $"{selectedCharacterCIGA.DefaultBonus} Recargas de Vida";
				panel_SelectedCharacter.Visible = true;
			}
		}

		private void SetFixedValuesToCombosAndLists()
		{
			List<object> attr1 = new List<object>(ValueHelper.itemAttributes);
			List<object> attr2 = new List<object>(ValueHelper.itemAttributes);
			List<object> attr3 = new List<object>(ValueHelper.itemAttributes);
			List<object> attr4 = new List<object>(ValueHelper.itemAttributes);
			List<CharactersHelper> addItemCharCombo = new List<CharactersHelper>(ValueHelper.GetCharacterValues());
			List<CharactersHelper> unlockCharacters = new List<CharactersHelper>(ValueHelper.GetCharacterValues());
			addItemCharCombo.RemoveAt(0); //remove a opção 'todos'
			List<CharactersHelper> searchItemCharCombo = new List<CharactersHelper>(ValueHelper.GetCharacterValues());

			combo_Grade.DataSource = ValueHelper.itemGrades;
			combo_Grade.DisplayMember = "name";
			combo_Grade.ValueMember = "grade";
			combo_ItemAttr1.DataSource = attr1;
			combo_ItemAttr1.DisplayMember = "name";
			combo_ItemAttr1.ValueMember = "idAttr";
			combo_ItemAttr2.DataSource = attr2;
			combo_ItemAttr2.DisplayMember = "name";
			combo_ItemAttr2.ValueMember = "idAttr";
			combo_ItemAttr3.DataSource = attr3;
			combo_ItemAttr3.DisplayMember = "name";
			combo_ItemAttr3.ValueMember = "idAttr";
			combo_ItemAttr4.DataSource = attr4;
			combo_ItemAttr4.DisplayMember = "name";
			combo_ItemAttr4.ValueMember = "idAttr";
			combo_ItemCharType.DataSource = addItemCharCombo;
			combo_ItemCharType.DisplayMember = "name";
			combo_ItemCharType.ValueMember = "charType";
			combo_SearchItemCharType.DataSource = searchItemCharCombo;
			combo_SearchItemCharType.DisplayMember = "name";
			combo_SearchItemCharType.ValueMember = "charType";
			combo_UnlockCharacter.DataSource = unlockCharacters;
			combo_UnlockCharacter.DisplayMember = "name";
			combo_UnlockCharacter.ValueMember = "charType";
			listBox_FoundItems.DisplayMember = "ItemText";
			listBox_FoundItems.ValueMember = "GoodsID";
		}
		#endregion

		private void Combo_Grade_SelectedValueChanged(object sender, EventArgs e)
		{
			switch (combo_Grade.SelectedValue)
			{
				case 0:
					combo_ItemAttr1.Enabled = false; num_ItemAttrVal1.Enabled = false;
					combo_ItemAttr2.Enabled = false; num_ItemAttrVal2.Enabled = false;
					combo_ItemAttr3.Enabled = false; num_ItemAttrVal3.Enabled = false;
					combo_ItemAttr4.Enabled = false; num_ItemAttrVal4.Enabled = false;
				break;
				case 1:
					combo_ItemAttr1.Enabled = true; num_ItemAttrVal1.Enabled = true;
					combo_ItemAttr2.Enabled = true; num_ItemAttrVal2.Enabled = true;
					combo_ItemAttr3.Enabled = false; num_ItemAttrVal3.Enabled = false;
					combo_ItemAttr4.Enabled = false; num_ItemAttrVal4.Enabled = false;
					break;
				case 2:
					combo_ItemAttr1.Enabled = true; num_ItemAttrVal1.Enabled = true;
					combo_ItemAttr2.Enabled = true; num_ItemAttrVal2.Enabled = true;
					combo_ItemAttr3.Enabled = true; num_ItemAttrVal3.Enabled = true;
					combo_ItemAttr4.Enabled = false; num_ItemAttrVal4.Enabled = false;
					break;
				case 3:
					combo_ItemAttr1.Enabled = true; num_ItemAttrVal1.Enabled = true;
					combo_ItemAttr2.Enabled = true; num_ItemAttrVal2.Enabled = true;
					combo_ItemAttr3.Enabled = true; num_ItemAttrVal3.Enabled = true;
					combo_ItemAttr4.Enabled = true; num_ItemAttrVal4.Enabled = true;
					break;
			}
		}

		private bool hasConfirmedChange(string text, string caption)
		{
			if (MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				return true;
			return false;
		}

		private void displayErrorMessage(string error)
		{
			MessageBox.Show(error, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void displaySuccessMessage(string message)
		{
			MessageBox.Show(message);
		}

		private void ReselectCharacterOnList()
		{
			LoadCharactersToList();
			listView_Characters.Items[charListLastSelectedIndex].Focused = true;
			listView_Characters.Items[charListLastSelectedIndex].Selected = true;
		}

		private void Btn_AttrInfo_Click(object sender, EventArgs e)
		{
			string attrDisclaimer = "1- Propriedades com ** NÃO terão valores considerados." +
				"\n2- Propriedades com % recebem valores percentuais" +
				"\n\n3- Você DEVE deixar TODAS as propriedades livres ou setar TODAS as disponíveis de acordo com a raridade." +
				"\nSe houver mistura de Livre/Setada, o item bugará e não poderá ter as outras propriedades selecionadas a menos que sejam resetadas." +
				"\n\nPor esse motivo, é recomendável OU setar todas as disponíveis, OU nenhuma.";
			MessageBox.Show(attrDisclaimer, "Informações Sobre Propriedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
