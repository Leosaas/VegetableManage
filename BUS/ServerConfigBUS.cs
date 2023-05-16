using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class ServerConfigBUS
    {
        public static string CreateDatabase()
		{
			return ServerConfigDAO.CreateDatabase();
		}
        public static bool CheckDatabaseExist(ServerConfigDTO server)
		{
			return ServerConfigDAO.CheckDatabaseExist(server);
		}
        public static List<string> GetListInstanceOfServer()
		{
			return ServerConfigDAO.GetListInstanceOfServer();
		}

        public static string WriteConfigFile(ServerConfigDTO server)
		{
			return ServerConfigDAO.WriteConfigFile(server);
		}
		public static ServerConfigDTO ReadConfigFile()
		{
			return ServerConfigDAO.ReadConfigFile();
		}


	}
}
