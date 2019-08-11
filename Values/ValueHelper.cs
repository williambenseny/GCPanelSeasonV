using GCPanelSeasonV.Properties;
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
			{CharactersNames.Elesis.ToString(), Color.FromArgb(145, 49, 80) },
			{CharactersNames.Lire.ToString(), Color.FromArgb(40, 207, 6) },
			{CharactersNames.Arme.ToString(), Color.FromArgb(146, 14, 156) },
			{CharactersNames.Lass.ToString(), Color.FromArgb(16, 132, 204) },
			{CharactersNames.Ryan.ToString(), Color.FromArgb(163, 128, 11) },
			{CharactersNames.Ronan.ToString(), Color.FromArgb(3, 3, 145) },
			{CharactersNames.Amy.ToString(), Color.FromArgb(196, 4, 190) },
			{CharactersNames.Jin.ToString(), Color.FromArgb(186, 2, 26) },
			{CharactersNames.Sieghart.ToString(), Color.Black },
			{CharactersNames.Mari.ToString(), Color.FromArgb(78, 110, 173) },
			{CharactersNames.Dio.ToString(), Color.FromArgb(101, 45, 125) },
			{CharactersNames.Zero.ToString(), Color.FromArgb(64, 135, 84) },
			{CharactersNames.Rey.ToString(), Color.FromArgb(163, 5, 155) },
			{CharactersNames.Lupus.ToString(), Color.FromArgb(138, 41, 34) },
			{CharactersNames.Lin.ToString(), Color.FromArgb(78, 101, 102) },
			{CharactersNames.Azin.ToString(), Color.FromArgb(7, 157, 163) },
			{CharactersNames.Holy.ToString(), Color.FromArgb(42, 163, 125) },
			{CharactersNames.Edel.ToString(), Color.FromArgb(34, 121, 148) },
			{CharactersNames.Veigas.ToString(), Color.FromArgb(68, 2, 97) },
			{CharactersNames.Uno.ToString(), Color.Navy }
		};

		public static Dictionary<string, Image> charIcons = new Dictionary<string, Image>()
		{
			{CharactersNames.Elesis.ToString(), Resources.GC_Elesis_Icon },
			{CharactersNames.Lire.ToString(), Resources.GC_Lire_Icon },
			{CharactersNames.Arme.ToString(), Resources.GC_Arme_Icon },
			{CharactersNames.Lass.ToString(), Resources.GC_Lass_Icon },
			{CharactersNames.Ryan.ToString(), Resources.GC_Ryan_Icon },
			{CharactersNames.Ronan.ToString(), Resources.GC_Ronan_Icon },
			{CharactersNames.Amy.ToString(), Resources.GC_Amy_Icon },
			{CharactersNames.Jin.ToString(), Resources.GC_Jin_Icon },
			{CharactersNames.Sieghart.ToString(), Resources.GC_Sieghart_Icon },
			{CharactersNames.Mari.ToString(), Resources.GC_Mari_Icon },
			{CharactersNames.Dio.ToString(), Resources.GC_Dio_Icon },
			{CharactersNames.Zero.ToString(), Resources.GC_Zero_Icon },
			{CharactersNames.Rey.ToString(), Resources.GC_Rey_Icon },
			{CharactersNames.Lupus.ToString(), Resources.GC_Rufus_Icon },
			{CharactersNames.Lin.ToString(), Resources.GC_Lin_Icon },
			{CharactersNames.Azin.ToString(), Resources.GC_Elesis_Icon },
			{CharactersNames.Holy.ToString(), Resources.GC_Elesis_Icon },
			{CharactersNames.Edel.ToString(), Resources.GC_Elesis_Icon },
			{CharactersNames.Veigas.ToString(), Resources.GC_Elesis_Icon },
			{CharactersNames.Uno.ToString(), Resources.GC_Elesis_Icon }
		};
		//Image myImage = Resources.myImage;

		public static string GetCharLevelPercentage(int charLevel, int expS4)
		{
			if(charLevel < 85)
			{
				int charLevelZeroPercent = LevelToExp[charLevel];
				int nextLevelZeroPercent = LevelToExp[charLevel + 1];
				int expDifferenceInLevels = nextLevelZeroPercent - charLevelZeroPercent;

				int summedExpInCurrentLevel = expS4 - charLevelZeroPercent;

				return (((double)summedExpInCurrentLevel / expDifferenceInLevels) * 100).ToString("0.00") + "%";
			}
			return "0.00%";

		}

		public static Dictionary<int, int> LevelToExp = new Dictionary<int, int>()
		{
				{ 0  , 0},
				{ 1  , 100},
				{ 2  , 140},
				{ 3  , 422},
				{ 4  , 863},
				{ 5  , 1314},
				{ 6  , 1995},
				{ 7  , 2625},
				{ 8  , 3424},
				{ 9  , 4202},
				{ 10 , 5156},
				{ 11 , 6090},
				{ 12 , 7930},
				{ 13 , 9491},
				{ 14 , 11824},
				{ 15 , 14630},
				{ 16 , 16487},
				{ 17 , 19613},
				{ 18 , 21740},
				{ 19 , 24444},
				{ 20 , 28655},
				{ 21 , 33733},
				{ 22 , 38598},
				{ 23 , 46099},
				{ 24 , 53437},
				{ 25 , 60997},
				{ 26 , 69229},
				{ 27 , 78301},
				{ 28 , 88297},
				{ 29 , 99301},
				{ 30 , 112405},
				{ 31 , 127987},
				{ 32 , 146257},
				{ 33 , 167761},
				{ 34 , 192870},
				{ 35 , 222102},
				{ 36 , 254232},
				{ 37 , 301440},
				{ 38 , 353352},
				{ 39 , 410472},
				{ 40 , 473304},
				{ 41 , 542352},
				{ 42 , 618456},
				{ 43 , 702120},
				{ 44 , 794184},
				{ 45 , 895320},
				{ 46 , 1006704},
				{ 47 , 1159794},
				{ 48 , 1328214},
				{ 49 , 1513434},
				{ 50 , 1717134},
				{ 51 , 1941204},
				{ 52 , 2187744},
				{ 53 , 2458854},
				{ 54 , 2757054},
				{ 55 , 3150678},
				{ 56 , 3583866},
				{ 57 , 4060398},
				{ 58 , 4584558},
				{ 59 , 5161134},
				{ 60 , 5795166},
				{ 61 , 6608958},
				{ 62 , 7504188},
				{ 63 , 8488794},
				{ 64 , 9571890},
				{ 65 , 10933698},
				{ 66 , 12431586},
				{ 67 , 14285298},
				{ 68 , 16324230},
				{ 69 , 18816090},
				{ 70 , 21557430},
				{ 71 , 24874590},
				{ 72 , 28523004},
				{ 73 , 32901252},
				{ 74 , 37717476},
				{ 75 , 43457028},
				{ 76 , 49770426},
				{ 77 , 57249198},
				{ 78 , 65475906},
				{ 79 , 75171606},
				{ 80 , 89391966 },
				{ 81 , 108802350},
				{ 82 , 129137038},
				{ 83 , 150396030},
				{ 84 , 174427934},
				{ 85 , 203081358 }
		};
	}
}
