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
		public void AddItem(string loginUID, string itemID)
		{
			int WIGAUID = GetNextAvailableWIGAUID();
			using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnString("gcDB")))
			{
				connection.Execute($"INSERT INTO UIGAUserItem VALUES ({ StrToInt(loginUID) },{ StrToInt(itemID) },0,CURRENT_TIMESTAMP,0,{ WIGAUID })");
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

		//Conversion Methods
		private int StrToInt(string str)
		{
			return Utils.Converter.StrToInt(str);
		}
	}
}
