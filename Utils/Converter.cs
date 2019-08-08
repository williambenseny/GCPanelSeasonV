using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Utils
{
	public static class Converter
	{
		public static int StrToInt(string str)
		{
			try
			{
				return Int32.Parse(str);
			}
			catch (Exception ex)
			{
				return -1;
			}
		}

		public static string IntSoStr(int integer)
		{
			try
			{
				return integer.ToString();
			}
			catch (Exception ex)
			{
				return "fail";
			}
		}
	}
}
