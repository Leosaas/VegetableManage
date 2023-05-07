using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace DAO
{
    public class ServerConfigDAO
    {
		
		public static string CreateDatabase()
		{
			ServerConfigDTO server = ReadConfigFile();
			string workingDirectory = Environment.CurrentDirectory;
			string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
			string path = Directory.GetParent(projectDirectory).Parent.FullName + @"\VegetableManage\Data\Database\";
			string filename = path + "\\VegetableData.mdf";
			string logname = path + "\\VegetableLog.ldf";
			string str;
			SqlConnection myConn = new SqlConnection("Server="+server.ServerName+";Integrated security=SSPI;database=master");

			str = string.Format(@"CREATE DATABASE {0} ON
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
    FILEGROWTH = 5 MB);", "Vegetable", "Vegetable_dat", filename, "Vegetable_log", logname);
			SqlCommand myCommand = new SqlCommand(str, myConn);


			try
			{
				myConn.Open();
				myCommand.ExecuteNonQuery();
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
