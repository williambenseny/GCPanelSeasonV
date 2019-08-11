using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Model
{
	public class CIGACharacterInfo
	{
		public int LoginUID { get; set; }
		public int CharType { get; set; }
		public int SlotNo { get; set; }
		public int GamePoint { get; set; }
		public int DefaultBonus { get; set; } //verificar o que faz
		public int SpecialBonus { get; set; }//verificar o que faz
		public int InvenSize { get; set; }
		public int CoordiSize { get; set; }
	}
}
