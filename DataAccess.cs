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
