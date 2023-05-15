using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public abstract class BaseDAO
    {
        protected static SqlConnection connection;
        public static SqlConnection Connection { get => connection; }
        public static bool IsConnectDB()
        {
            string connstring;
            ServerConfigDTO server = ServerConfigDAO.ReadConfigFile();
            //   string dataBaseName = "VegetableManager";
            string dataBaseName = server.DatabaseName;
            string serverName = server.ServerName;
            if (server.Integrated_security)
            {
				connstring = @"Data Source="+serverName+";Initial Catalog=" + dataBaseName + ";Integrated Security=True";
            }
            else
            {
                string userName = server.Username;
				string password = server.Password;
                connstring = @"Server=" + serverName + ";Database=" + dataBaseName + ";User Id=" + userName + ";Password=" + password + ";";
			}
            
            if (connection == null)
            {
                try
                {
                    connection = new SqlConnection(connstring);
                    Connection.Open();
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return true;
        }
        public static void Close()
        {
            connection.Close();
        }
    }
}
