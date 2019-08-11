using GCPanelSeasonV.Model;
using GCPanelSeasonV.ConnectionHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;

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
					Console.WriteLine(user.IPAddress);
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

		/* Itens */
		public void AddItem(int loginUID, string itemID)
		{
			int WIGAUID = GetNextAvailableWIGAUID();
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				connection.Execute($"INSERT INTO UIGAUserItem VALUES ({ loginUID },{ StrToInt(itemID) },0,CURRENT_TIMESTAMP,0,{ WIGAUID })");
			}
		}

		private int GetNextAvailableWIGAUID()
		{
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				int biggestWIGAUID = connection.Query<int>($"SELECT MAX(WIGAUID) FROM UIGAUserItem").First();
				return biggestWIGAUID + 1;
			}
		}

		//Conversões
		private int StrToInt(string str)
		{
			return Utils.Converter.StrToInt(str);
		}
	}
}
