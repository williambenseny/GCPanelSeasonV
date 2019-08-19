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
			get => ValueHelper.GetCharacterValues().Find(x => x.charType == CharType).name;
		}

		public string ListBoxCharInfo
		{
			get => $"{CharName}  -  Nv. {Level}";
		}

		public Color CharColor
		{
			get => ValueHelper.GetCharacterValues().Find(x => x.charType == CharType).color;
		}

		public string LevelPercentage
		{
			get => ValueHelper.GetCharLevelPercentage(Level,ExpS4);
		}

		public Image Image
		{
			get => ValueHelper.GetCharacterValues().Find(x => x.charType == CharType).icon;
		}
	}
}
