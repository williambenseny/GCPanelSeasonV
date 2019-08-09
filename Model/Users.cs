using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPanelSeasonV.Model
{
	/*
	 * Login str
		LoginUID int
		LastLogin date
		IPAddress str
		Connecting bool
		email str
	 */
	public class Users
	{
		public string Login { get; set; }
		public int LoginUID { get; set; }
		public string LastLogin { get; set; }
		public string IPAddress { get; set; }
		public bool Connecting { get; set; }
		public string Email { get; set; }
	}
}
