using GCPanelSeasonV.Values;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Model
{
	public class Characters
	{
		public string Login { get; set; }
		public int CharType { get; set; }
		public int Promotion { get; set; }
		public int Exp { get; set; } //Não utilizado >= Season Chaos - usar ExpS4
		public int Level { get; set; }
		public int Win { get; set; }
		public int Lose { get; set; }
		public int LoginUID { get; set; }
		public int ExpS4 { get; set; }

		//Atributos Customizados
		public string CharName
		{
			get => ValueHelper.GetCharNameByCharType(CharType);
		}

		public string ListBoxCharInfo
		{
			get => $"{CharName}  -  Nv. {Level}";
		}

		public Color CharColor
		{
			get => ValueHelper.charColors[CharName];
		}
	}
}
