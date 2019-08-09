using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Values
{

	public static class ValueHelper
	{
		public static List<object> itemGrades = new List<object>()
		{
			new { name = "Normal", grade = 0 },
			new { name = "Raro", grade = 1 },
			new { name = "Épico", grade = 2 },
			new { name = "Lendário", grade = 3 },
		};

		public enum CharactersNames
		{
			Elesis,Lire,Arme,Lass,Ryan,Ronan,Amy,Jin,Sieghart,Mari,
			Dio,Zero,Rey,Lupus,Lin,Azin,Holy,Edel,Veigas,Uno
		}

		public static string GetCharNameByCharType(int charType)
		{
			return Enum.GetName(typeof(CharactersNames), charType);
		}

		public static Dictionary<string, Color> charColors = new Dictionary<string, Color>()
		{
			{CharactersNames.Elesis.ToString(), Color.Maroon },
			{CharactersNames.Lire.ToString(), Color.Green },
			{CharactersNames.Arme.ToString(), Color.Purple },
			{CharactersNames.Lass.ToString(), Color.Blue },
			{CharactersNames.Ryan.ToString(), Color.Orange },
			{CharactersNames.Ronan.ToString(), Color.Navy },
			{CharactersNames.Amy.ToString(), Color.Pink },
			{CharactersNames.Jin.ToString(), Color.Red },
			{CharactersNames.Sieghart.ToString(), Color.Black },
			{CharactersNames.Mari.ToString(), Color.Blue }
		};
	}
}
