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
            string dataBaseName = "VegetableManager";
            string server = "localhost";
            string userName = "root";
            string password = "anhldt2002";
            if (connection == null)
            {
                try
                {
                    string connstring = @"Data Source=(local);Initial Catalog="+dataBaseName+";Integrated Security=True";
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
