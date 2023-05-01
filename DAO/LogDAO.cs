using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class LogDAO : BaseDAO
    {
        public static string WriteLog(LogDTO log)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "exec WriteLog @Username = @username,@Time = @time,@Action = @action";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("username", log.Username);
					cmd.Parameters.AddWithValue("time", log.Date);
					cmd.Parameters.AddWithValue("action", log.Action);
					cmd.ExecuteNonQuery();
                    return "";
                }
                catch(Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể ghi lịch sử do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL !";
        }
		public static string WriteLog(string username, string action)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec WriteLog @Username = @username,@Time = @time,@Action = @action";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("username", username);
					cmd.Parameters.AddWithValue("time", DateTime.Now);
					cmd.Parameters.AddWithValue("action", action);
					cmd.ExecuteNonQuery();
					return "";
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể ghi lịch sử do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static DataTable GetLog()
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = "exec GetLog";
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);
					
					return dt;
				}
				catch (Exception e)
				{
					//     MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
					return null;
				}
			}
			return null;
		}


	}
}
