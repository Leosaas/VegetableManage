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
        public static bool CheckDatabaseExist()
		{
			return ServerConfigDAO.CheckDatabaseExist();
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
