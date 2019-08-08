using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Values
{

	public static class ItemGrade
	{
		public static List<object> itemGrades = new List<object>()
		{
			new { name = "Normal", grade = 0 },
			new { name = "Raro", grade = 1 },
			new { name = "Épico", grade = 2 },
			new { name = "Lendário", grade = 3 },
		};
	}
}
