using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServerConfigDTO
	{
        string serverName;
        string username;
        string password;
        bool integrated_security;
		string databaseName;
		public string ServerName { get => serverName; set => serverName = value; }
		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public bool Integrated_security { get => integrated_security; set => integrated_security = value; }
        public string DatabaseName { get => databaseName; set => databaseName = value; }
    }
}
