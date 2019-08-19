using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Model
{
	public class GoodsInfoList
	{
		public int GoodsID { get; set; }
		public string GoodsName { get; set; }
		public int Duration { get; set; }
		public int CharType { get; set; }

		public string ItemText
		{
			get => $"ID {GoodsID} | {GoodsName}";
		}
	}
}
