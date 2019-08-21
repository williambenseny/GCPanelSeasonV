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
		private static List<CharacterValues> charactersValues = new List<CharacterValues>()
		{
			new CharacterValues{charType = -1, name = "Todos"},
			new CharacterValues{charType = 0, name = "Elesis", color = Color.FromArgb(145, 49, 80), icon = Resources.GC_Elesis_Icon},
			new CharacterValues{charType = 1, name = "Lire", color = Color.FromArgb(16, 168, 5), icon = Resources.GC_Lire_Icon},
			new CharacterValues{charType = 2, name = "Arme", color = Color.FromArgb(146, 14, 156), icon = Resources.GC_Arme_Icon},
			new CharacterValues{charType = 3, name = "Lass", color = Color.FromArgb(16, 132, 204), icon = Resources.GC_Lass_Icon},
			new CharacterValues{charType = 4, name = "Ryan", color = Color.FromArgb(196, 129, 4), icon = Resources.GC_Ryan_Icon},
			new CharacterValues{charType = 5, name = "Ronan", color = Color.FromArgb(3, 3, 145), icon = Resources.GC_Ronan_Icon},
			new CharacterValues{charType = 6, name = "Amy", color = Color.FromArgb(196, 4, 190), icon = Resources.GC_Amy_Icon},
			new CharacterValues{charType = 7, name = "Jin", color = Color.FromArgb(186, 2, 26), icon = Resources.GC_Jin_Icon},
			new CharacterValues{charType = 8, name = "Sieghart", color = Color.Black, icon = Resources.GC_Sieghart_Icon},
			new CharacterValues{charType = 9, name = "Mari", color = Color.FromArgb(78, 110, 173), icon = Resources.GC_Mari_Icon},
			new CharacterValues{charType = 10, name = "Dio", color = Color.FromArgb(101, 45, 125), icon = Resources.GC_Dio_Icon},
			new CharacterValues{charType = 11, name = "Zero", color = Color.FromArgb(64, 135, 84), icon = Resources.GC_Zero_Icon},
			new CharacterValues{charType = 12, name = "Rey", color = Color.FromArgb(163, 5, 155), icon = Resources.GC_Rey_Icon},
			new CharacterValues{charType = 13, name = "Lupus", color = Color.FromArgb(78, 101, 102), icon = Resources.GC_Rufus_Icon},
			new CharacterValues{charType = 14, name = "Lin", color = Color.FromArgb(78, 101, 102), icon = Resources.GC_Lin_Icon},
			new CharacterValues{charType = 15, name = "Azin", color = Color.FromArgb(7, 157, 163), icon = Resources.GC_Elesis_Icon},
			new CharacterValues{charType = 16, name = "Holy", color = Color.FromArgb(42, 163, 125), icon = Resources.GC_Elesis_Icon},
			new CharacterValues{charType = 17, name = "Edel", color = Color.FromArgb(34, 121, 148), icon = Resources.GC_Elesis_Icon},
			new CharacterValues{charType = 18, name = "Veigas", color = Color.FromArgb(68, 2, 97), icon = Resources.GC_Elesis_Icon},
		};
		public static List<CharacterValues> GetCharacterValues()
		{
			return charactersValues;
		}
		public static string GetCharacterName(int charType)
		{
			return GetCharacterValues().Find(x => x.charType == charType).name;
		}

		public static List<object> itemGrades = new List<object>()
		{
			new { name = "Normal", grade = 0 },
			new { name = "Raro", grade = 1 },
			new { name = "Épico", grade = 2 },
			new { name = "Lendário", grade = 3 },
		};

		public static List<object> itemAttributes = new List<object>()
		{
			new { name = "LIVRE", idAttr = -1 },
			new { name = "Ataque", idAttr = 0 },
			new { name = "Defesa", idAttr = 1 },
			new { name = "Vitalidade", idAttr = 2 },
			new { name = "Atq. Especial", idAttr = 3 },
			new { name = "Def. Especial", idAttr = 4 },
			new { name = "Recup. HP", idAttr = 7 },
			new { name = "Recup. MP", idAttr = 8 },
			new { name = "Nível Minimo", idAttr = 9 },
			new { name = "Bônus de GP", idAttr = 10 },
			new { name = "Bônus de EXP", idAttr = 11 },
			new { name = "Atq. Crítico", idAttr = 12 },
			new { name = "Resist. Counter", idAttr = 13 },
			new { name = "!Levant. Rolando", idAttr = 14 },
		};

		public static Dapper.DynamicParameters GetWIGAInsertItemParameters(int LoginUID, int charType, int itemID, int grade, int period, int duration)
		{
			Dapper.DynamicParameters queryParameters = new Dapper.DynamicParameters();
			queryParameters.Add("@01iLoginUID_input", LoginUID);
			queryParameters.Add("@02iCharType_input", charType);
			queryParameters.Add("@03iItemID_input", itemID);
			queryParameters.Add("@04iGradeID_input", grade);
			queryParameters.Add("@05iPeriod_input", period);
			queryParameters.Add("@06iDuration_input", duration);
			queryParameters.Add("@07iGetType_input", 2);
			queryParameters.Add("@08iStatus_input ", 2);
			queryParameters.Add("@09iItemLevel_input", 0);
			queryParameters.Add("@10iStrengthLevel_input", -1);
			return queryParameters;
		}
		public static Dapper.DynamicParameters GetUIGAUserItemParameters(int LoginUID, int itemID, int grade, long wigaUid)
		{
			Dapper.DynamicParameters queryParameters = new Dapper.DynamicParameters();
			queryParameters.Add("@01iLoginUID_input", LoginUID);
			queryParameters.Add("@02iItemID_input", itemID);
			queryParameters.Add("@03iGradeID_input", grade);
			queryParameters.Add("@04iWIGAUID_input", wigaUid);
			return queryParameters;
		}

		public static Dapper.DynamicParameters UIGAUserItemAttributeParameters(int LoginUID, int charType, long ItemUID, int slot, int type, int value, int active)
		{
			Dapper.DynamicParameters queryParameters = new Dapper.DynamicParameters();
			queryParameters.Add("@01iLoginUID_input", LoginUID);
			queryParameters.Add("@02iCharType_input", charType);
			queryParameters.Add("@03iItemUID_input", ItemUID);
			queryParameters.Add("@04iSlotID_input", slot);
			queryParameters.Add("@05iTypeID_input", type);
			queryParameters.Add("@06iValue_input", value * 10000); //besteira da KOG
			queryParameters.Add("@07iAttributeState_input", active);
			return queryParameters;
		}

		public static Dapper.DynamicParameters GetWIGAWaitItemDeleteParameters(long wigaUid)
		{
			Dapper.DynamicParameters queryParameters = new Dapper.DynamicParameters();
			queryParameters.Add("@01iWIGAUID_input", wigaUid);
			return queryParameters;
		}

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

		/// <summary>
		/// Lista de Kinds que não podem receber propriedades
		/// </summary>
		public static List<int> NonPropertyItemKinds = new List<int>
		{
			17, //tornozeleira
			18, //colar
			19	//pedra mágica
		};

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
