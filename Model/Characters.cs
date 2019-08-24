using GCPanelSeasonV.Values;
using System.Drawing;

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
			get => ValueHelper.GetCharacterValues().Find(x => x.CharType == CharType).Name;
		}

		public string ListBoxCharInfo
		{
			get => $"{CharName}  -  Nv. {Level}";
		}

		public Color CharColor
		{
			get => ValueHelper.GetCharacterValues().Find(x => x.CharType == CharType).Color;
		}

		public string LevelPercentage
		{
			get => ValueHelper.GetCharLevelPercentage(Level,ExpS4);
		}

		public Image Image
		{
			get => ValueHelper.GetCharacterValues().Find(x => x.CharType == CharType).Icon;
		}
	}
}
