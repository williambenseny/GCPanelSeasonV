using GCPanelSeasonV.Model;
using GCPanelSeasonV.ConnectionHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;

namespace GCPanelSeasonV
{
	public class DataAccess
	{

		/* Informações do Servidor */

		public List<ConnectStatusDB> RetrieveServerInfo()
		{
			using (IDbConnection connection =  new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					return connection.Query<ConnectStatusDB>($"SELECT * FROM connectStatusDB").ToList();
				}
				catch (System.Data.SqlClient.SqlException sqlex)
				{
					return null;
				}
			}
		}

		/* Conta */ 

		public Users GetUserByLogin(string login)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					Users user = connection.Query<Users>($"SELECT * FROM users where Login = '{ login }'").First();
					return user;
				}
				catch (InvalidOperationException accountNotFound)
				{
					return null;
				}
			}
		}

		public string GetNickName(Users user)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					return connection.Query($"SELECT NickName FROM UNGAUserNickname where LoginUID = '{ user.LoginUID }'").First().NickName;
				}
				catch (InvalidOperationException noNickname)
				{
					return "Sem Apelido";
				}
			}
		}

		public List<int> GetCashAndVP(Users user)
		{
			int cash, vp;
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					cash = connection.Query($"SELECT Cash FROM CashUsers where Login = '{ user.Login }'").First().Cash;
					vp = connection.Query($"SELECT VCPoint FROM VCGAVirtualCash where LoginUID = '{ user.LoginUID }'").First().VCPoint;
					return new List<int>() { cash,vp };
				}
				catch (InvalidOperationException coinRetrieveError)
				{
					return new List<int>() { 0,0};
				}
			}
		}

		public bool ChangeNickName(Users user, string newNick)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					connection.Execute($"UPDATE UNGAUserNickName SET NickName='{newNick}' WHERE LoginUID={user.LoginUID}");
					user.NickName = newNick;
					return true;
				}
				catch (System.Data.SqlClient.SqlException e)
				{
					return false;
				}
			}
		}
		/* Moedas */

		public bool ChangeCash(Users user, int amount)
		{
			int newCashValue = user.Cash + amount;
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					connection.Execute($"UPDATE CashUsers SET Cash={newCashValue} WHERE Login='{user.Login}'");
					user.Cash = newCashValue;
					return true;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
			}
		}
		public bool ChangeVP(Users user, int amount)
		{
			int newVPValue = user.VP + amount;
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					connection.Execute($"UPDATE VCGAVirtualCash SET VCPoint={newVPValue} WHERE LoginUID='{user.LoginUID}'");
					user.VP = newVPValue;
					Console.WriteLine("bom! " + user.VP);
					return true;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
			}
		}

		/* Personagens */

		public List<Characters> GetCharacters(int loginUID)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					return connection.Query<Characters>($"SELECT * FROM Characters where LoginUID = '{ loginUID }'").ToList();
				}
				catch (InvalidOperationException noCharactersFound)
				{
					return new List<Characters>();
				}
			}
		}

		public List<CIGACharacterInfo> GetCIGACharactersInfo (int loginUID)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					return connection.Query<CIGACharacterInfo>($"SELECT * FROM CIGACharacterInfo where LoginUID = '{ loginUID }'").ToList();
				}
				catch (InvalidOperationException noCharactersFound)
				{
					return new List<CIGACharacterInfo>();
				}
			}
		}

		public bool ChangeCharLevel(Users user, Characters character, int level, int exp)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					connection.Execute($"UPDATE CHARACTERS SET Level={level} , ExpS4={exp}" +
					$"WHERE Login='{user.Login}' AND CharType={character.CharType}");
					return true;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
			}
		}

		public bool ClearAllDungeons(Users user, int charType)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				for(int i = 7; i <= 95; i++)
				{
					try
					{
						connection.Execute($"INSERT INTO DCGADungeonClear VALUES({user.LoginUID},{charType},{i},0,CURRENT_TIMESTAMP)");
					}
					catch(Exception e)
					{
						Console.WriteLine(e.Message);
					}

				}
				return true;
			}
		}

		/* Itens */
		public bool AddItem(Users user, int itemId, int charType, int grade, List<UIGAUserItemAttribute> itemAttributes)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					//procedure 1(WIGAWaitItem_insert_20130402) - inserir item na lista de espera
					DynamicParameters wigaInsertParameters = Values.ValueHelper.GetWIGAInsertItemParameters(user.LoginUID, charType, itemId, grade, -1, -1);
					long nextWIGAUID = Convert.ToInt64(connection.Query("SELECT IDENT_CURRENT( 'WIGAWaitItem20130402' ) + 1 as WIGAUID").First().WIGAUID);
					connection.Execute("WIGAWaitItem_insert_20130402", wigaInsertParameters, commandType: CommandType.StoredProcedure);

					//procedure 2 (UIGAUserItem_merge_20130415) - adicionar na UIGAUserItem
					DynamicParameters uigaUserItemParameters = Values.ValueHelper.GetUIGAUserItemParameters(user.LoginUID, itemId, grade, nextWIGAUID);
					connection.Execute("UIGAUserItem_merge_20130415", uigaUserItemParameters, commandType: CommandType.StoredProcedure);

					var insertedItemUID = (connection.Query
					($"SELECT ItemUID FROM UIGAUserItem where LoginUID = {user.LoginUID} order by ItemUID desc").First().ItemUID);

					//procedure 3(WIGAWaitItem_delete_20130402) - deletar item da lista de espera
					DynamicParameters wigaDeleteParameters = Values.ValueHelper.GetWIGAWaitItemDeleteParameters(nextWIGAUID);
					connection.Execute("WIGAWaitItem_delete_20130402", wigaDeleteParameters, commandType: CommandType.StoredProcedure);

					//Inserir na tabela UIGAUseItemCharacter - adicionar ao personagem especifico p/ evitar erro de inventário
					connection.Execute($"INSERT INTO UIGAUserItemCharacter VALUES ({user.LoginUID},{charType},{insertedItemUID})");


					//Verificar se é um item que NÃO pode receber props (como Colares [kind=18], Tornozeleiras [kind=17] etc)
					int kind = (connection.Query ($"SELECT Kind FROM GoodsInfoList where GoodsID = {itemId}").First().Kind);

					if(!Values.ValueHelper.NonPropertyItemKinds.Contains(kind)) 
						foreach (UIGAUserItemAttribute itemAttribute in itemAttributes)
						{
							AddItemAttribute(user.LoginUID, charType, insertedItemUID, itemAttribute);
						}

					return true;
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
					return false;
				}
			}
		}

		private void AddItemAttribute(int LoginUID, int charType, long ItemUID, UIGAUserItemAttribute attr)
		{
			int active = 1;
			if (attr.TypeID == -1) //garante que propriedade "livre" possa ser selecionada pelo usuário
			{
				attr.Value = 0;
				active = 0;
			}

			DynamicParameters uigaUserItemParameters =
				Values.ValueHelper.UIGAUserItemAttributeParameters(LoginUID, charType, ItemUID, attr.SlotID, attr.TypeID, attr.Value, active);

			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					connection.Execute("UIGAUserItemAttribute_merge_20130415", uigaUserItemParameters, commandType: CommandType.StoredProcedure);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}

		public List<GoodsInfoList> searchItems(string name, int charType)
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				try
				{
					return connection.Query<GoodsInfoList>
						($"SELECT * FROM GoodsInfoList where GoodsName Like '%{name}%' and CharType = {charType}").ToList();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					return null;
				}
			}
		}

		//Conversões
		private int StrToInt(string str)
		{
			return Utils.Converter.StrToInt(str);
		}
	}
}
