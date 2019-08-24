using GCPanelSeasonV.Properties;
using System.Drawing;

namespace GCPanelSeasonV.Values
{
	public class CharactersHelper
	{
		public int CharType { get; set; }
		public string Name { get; set; }
		public Color Color { get; set; }
		public Image Icon { get; set; }
		//ID do 1º desafio (Floresta do Desafio) ou primeira missão de Frostland/trivia
		public int FirstMissionId { get; set; } 
	}

	public class Elesis : CharactersHelper
	{
		public Elesis()
		{
			CharType = 0;
			Name = GetType().Name;
			Color = Color.FromArgb(145, 49, 80);
			Icon = Resources.GC_Elesis_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Lire : CharactersHelper
	{
		public Lire()
		{
			CharType = 1;
			Name = GetType().Name;
			Color = Color.FromArgb(16, 168, 5);
			Icon = Resources.GC_Lire_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Arme : CharactersHelper
	{
		public Arme()
		{
			CharType = 2;
			Name = GetType().Name;
			Color = Color.FromArgb(146, 14, 156);
			Icon = Resources.GC_Arme_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Lass : CharactersHelper
	{
		public Lass()
		{
			CharType = 3;
			Name = GetType().Name;
			Color = Color.FromArgb(16, 132, 204);
			Icon = Resources.GC_Lass_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Ryan : CharactersHelper
	{
		public Ryan()
		{
			CharType = 4;
			Name = GetType().Name;
			Color = Color.FromArgb(196, 129, 4);
			Icon = Resources.GC_Ryan_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Ronan : CharactersHelper
	{
		public Ronan()
		{
			CharType = 5;
			Name = GetType().Name;
			Color = Color.FromArgb(3, 3, 145);
			Icon = Resources.GC_Ronan_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Amy : CharactersHelper
	{
		public Amy()
		{
			CharType = 6;
			Name = GetType().Name;
			Color = Color.FromArgb(196, 4, 190);
			Icon = Resources.GC_Amy_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Jin : CharactersHelper
	{
		public Jin()
		{
			CharType = 7;
			Name = GetType().Name;
			Color = Color.FromArgb(186, 2, 26);
			Icon = Resources.GC_Jin_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Sieghart : CharactersHelper
	{
		public Sieghart()
		{
			CharType = 8;
			Name = GetType().Name;
			Color = Color.Black;
			Icon = Resources.GC_Sieghart_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Mari : CharactersHelper
	{
		public Mari()
		{
			CharType = 9;
			Name = GetType().Name;
			Color = Color.FromArgb(78, 110, 173);
			Icon = Resources.GC_Mari_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Dio : CharactersHelper
	{
		public Dio()
		{
			CharType = 10;
			Name = GetType().Name;
			Color = Color.FromArgb(101, 45, 125);
			Icon = Resources.GC_Dio_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Zero : CharactersHelper
	{
		public Zero()
		{
			CharType = 11;
			Name = GetType().Name;
			Color = Color.FromArgb(64, 135, 84);
			Icon = Resources.GC_Zero_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Rey : CharactersHelper
	{
		public Rey()
		{
			CharType = 12;
			Name = GetType().Name;
			Color = Color.FromArgb(163, 5, 155);
			Icon = Resources.GC_Rey_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Lupus : CharactersHelper
	{
		public Lupus()
		{
			CharType = 13;
			Name = GetType().Name;
			Color = Color.FromArgb(78, 101, 102);
			Icon = Resources.GC_Rufus_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Lin : CharactersHelper
	{
		public Lin()
		{
			CharType =14;
			Name = GetType().Name;
			Color = Color.FromArgb(78, 101, 102);
			Icon = Resources.GC_Lin_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Azin : CharactersHelper
	{
		public Azin()
		{
			CharType = 15;
			Name = GetType().Name;
			Color = Color.FromArgb(7, 157, 163);
			Icon = Resources.GC_Elesis_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Holy : CharactersHelper
	{
		public Holy()
		{
			CharType = 16;
			Name = GetType().Name;
			Color = Color.FromArgb(42, 163, 125);
			Icon = Resources.GC_Elesis_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Edel : CharactersHelper
	{
		public Edel()
		{
			CharType = 17;
			Name = GetType().Name;
			Color = Color.FromArgb(34, 121, 148);
			Icon = Resources.GC_Elesis_Icon;
			FirstMissionId = 1310380;
		}
	}
	public class Veigas : CharactersHelper
	{
		public Veigas()
		{
			CharType = 18;
			Name = GetType().Name;
			Color = Color.FromArgb(68, 2, 97);
			Icon = Resources.GC_Elesis_Icon;
			FirstMissionId = 1310380;
		}
	}
}
