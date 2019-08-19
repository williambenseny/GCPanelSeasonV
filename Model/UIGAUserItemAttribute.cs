using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Model
{
	public class UIGAUserItemAttribute
	{
		//outros atributos são desnecessários pois são pegos no método e inputados como parametros na procedure
		public int SlotID { get; set; }
		public int TypeID { get; set; }
		public int Value { get; set; }
	}
}
