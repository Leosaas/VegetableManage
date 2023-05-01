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
		private bool type;
		public AccountDTO()
		{
		}

		public AccountDTO(string username, string password, bool type)
		{
			this.username = username;
			this.password = password;
			this.Type = type;
		}

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public bool Type { get => type; set => type = value; }
	}
}
