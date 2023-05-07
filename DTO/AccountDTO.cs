using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class AccountDTO
	{
		private string username;
		private string password;
		private int type;
		public AccountDTO()
		{
		}

		public AccountDTO(string username, string password, int type)
		{
			this.username = username;
			this.password = password;
			this.Type = type;
		}

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public int Type { get => type; set => type = value; }
	}
}
