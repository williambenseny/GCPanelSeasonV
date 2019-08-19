using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Model
{
	public class UIGAUserItem
	{ 
		public int ItemUID { get; set; }
		public int LoginUID { get; set; }
		public int ItemID { get; set; }
		public int GradeID { get; set; }
		public DateTime DelDateA { get; set; }
		public int DelState { get; set; }
		public int WIGAUID { get; set; }
	}
}
