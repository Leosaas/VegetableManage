using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace DAO
{
    public class ServerConfigDAO
    {
		public static List<string> GetListInstanceOfServer()
		{
			List<string> list = null;
            string ServerName = Environment.MachineName;
            Microsoft.Win32.RegistryView registryView = Environment.Is64BitOperatingSystem ? Microsoft.Win32.RegistryView.Registry64 : Microsoft.Win32.RegistryView.Registry32;
            using (Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, registryView))
            {
                Microsoft.Win32.RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
					list = new List<string>();
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        if (instanceName == "MSSQLSERVER")
                        {
                            list.Add(ServerName);

                        }
                        else
                        {
							list.Add(ServerName + "\\" + instanceName);
                        }
                    }
                }
            }
			return list;
        }
		public static bool CheckDatabaseExist()
        {
            string sqlCreateDBQuery;
            bool result = false;
            ServerConfigDTO server = ReadConfigFile();
            try
            {
                SqlConnection myConn = new SqlConnection("Server=" + server.ServerName + ";Integrated security=SSPI;database=master");

                sqlCreateDBQuery = string.Format(@"SELECT database_id FROM sys.databases WHERE Name 
                = '{0}'", "VegetableManager");
        
            using (myConn)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, myConn))
                    {
                        myConn.Open();

                        object resultObj = sqlCmd.ExecuteScalar();

                        int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }

                        myConn.Close();

                        result = (databaseID > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
        public static string InitTableInDatabase()
		{
			return "";
		}
		public static string CreateDatabase()
		{

            if(CheckDatabaseExist())
            {
                return null;
            }
            ServerConfigDTO server = ReadConfigFile();
			string workingDirectory = Environment.CurrentDirectory;
			string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
			string path = Directory.GetParent(projectDirectory).Parent.FullName + @"\VegetableManage\Data\Database\";
			string filename = path + "\\DatabaseData.mdf";
			string logname = path + "\\DatabaseLog.ldf";
			string str;
			SqlConnection myConn = new SqlConnection("Server="+server.ServerName+";Integrated security=SSPI;database=master");

			str = string.Format(@"
IF DB_ID('VegetableManager') IS NULL 
Begin
CREATE DATABASE {0} ON
(NAME = {1},
    FILENAME = '{2}',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5)
LOG ON
(NAME = {3},
    FILENAME = '{4}',
    SIZE = 5 MB,
    MAXSIZE = 25 MB,
    FILEGROWTH = 5 MB);
end
", server.DatabaseName, "Database_dat", filename, "Database_log", logname);
			SqlCommand myCommand = new SqlCommand(str, myConn);


			try
			{
				myConn.Open();
				myCommand.ExecuteNonQuery();

                string script = File.ReadAllText(path+"InitScript.sql");

                // split script on GO command
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (string commandString in commandStrings)
                {
                    if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                    {
                        using (var command = new SqlCommand(commandString, myConn))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                myConn.Close();
                return null;
			}
			catch (System.Exception ex)
			{
				return ex.Message;
			}
			finally
			{
				if (myConn.State == ConnectionState.Open)
				{
					myConn.Close();
				}
			}
		}
		public static ServerConfigDTO ReadConfigFile()
		{
			string workingDirectory = Environment.CurrentDirectory;
			string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
			string path = Directory.GetParent(projectDirectory).Parent.FullName + @"\VegetableManage\Data\";
			try
			{
				string readText = File.ReadAllText(path+"ServerConfig.txt");
				string[] configString = readText.Split('\n');
				ServerConfigDTO server = new ServerConfigDTO();
				server.ServerName = configString[0];
				server.Username = configString[1];
				server.Password = configString[2];
				server.Integrated_security = bool.Parse(configString[3]);
                server.DatabaseName = configString[4];
				return server;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
		public static string WriteConfigFile(ServerConfigDTO server)
        {
			string workingDirectory = Environment.CurrentDirectory;
			string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
			string path = Directory.GetParent(projectDirectory).Parent.FullName + @"\VegetableManage\Data\";
			try
			{
				using (StreamWriter writer = new StreamWriter(path + "ServerConfig.txt"))
				{
					writer.WriteLine(server.ServerName);
					writer.WriteLine(server.Username);
					writer.WriteLine(server.Password);
					writer.WriteLine(server.Integrated_security);
                    writer.WriteLine(server.DatabaseName);
                }
				return CreateDatabase();
			}
			catch(Exception ex)
			{
				return ex.Message;
			}
		}
    }
}
