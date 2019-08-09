using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Model
{
	public class ConnectStatusDB
	{
		public string ServerIP { get; set; }
		public int ServerPort { get; set; }
		public string ServerName { get; set; }
		public int UserNum { get; set; }
		public int MaxNum { get; set; }
		public string ServerInfoString
		{
			get => $"{ ServerName } - {UserNum}/{MaxNum}";
		}
	}
}
