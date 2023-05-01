using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class LogDTO
	{
		private string username;
		string action;
		DateTime date;
		public LogDTO()
		{
		}

		public LogDTO(string username, string action, DateTime date)
		{
			this.username = username;
			this.action = action;
			this.date = date;
		}

		public string Username { get => username; set => username = value; }
		public string Action { get => action; set => action = value; }
		public DateTime Date { get => date; set => date = value; }
	}
}
