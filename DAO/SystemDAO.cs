
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;

namespace DAO
{
    public class SystemDAO : BaseDAO
    {
		public static string BackupDatabase(string path)
		{

			if (IsConnectDB())
			{
				try
				{
					string name = "\\backup(" + DateTime.Now.Day.ToString() + "_" +
												DateTime.Now.Month.ToString() + "_" +
												DateTime.Now.Year.ToString() + "_" +
												DateTime.Now.Hour.ToString() + "h_" +
												DateTime.Now.Minute.ToString() + "m_" +
												DateTime.Now.Second.ToString()+"s).bak";
					string query = "exec BackupDatabase @Path = @path";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("path", path + name);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể tạo file sao lưu do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static string RestoreDatabase(string path)
		{

			if (IsConnectDB())
			{
				try
				{
					
					string query = @"use master;
									Alter Database VegetableManager set offline with rollback immediate;
									exec RestoreDatabase @Path = @path
									alter database VegetableManager set online;";

					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("path", path);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể phục hồi do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}

	}
}
