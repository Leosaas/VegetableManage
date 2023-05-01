using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class UserDAO : BaseDAO
    {
		public static string DeleteUser(UserDTO user)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec DeleteUserAndAccount @Username = @username";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@username", user.Username);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể xoá người dùng do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static string UpdateUser(UserDTO user)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec UpdateUser @Username = @username,@Name = @name,@Address = @address,@PhoneNumber = @phonenumber";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@username", user.Username);
					cmd.Parameters.AddWithValue("@name", user.Name);
					cmd.Parameters.AddWithValue("@address", user.Address);
					cmd.Parameters.AddWithValue("@phonenumber", user.Phonenumber);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể cập nhật người dùng do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static UserDTO GetUserFromUsername(string username)
		{
			UserDTO user = null;
			if (IsConnectDB())
			{
				string query = "exec GetUserByUsername @Username = @username";

				var cmd = new SqlCommand(query, connection);
				cmd.Parameters.Add("@username", SqlDbType.VarChar, 45).Value = username;
				var reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					string name = reader["name"].ToString();
					string address = reader["address"].ToString();
					string phoneNumber = reader["phonenumber"].ToString();
					user = new UserDTO(username, name, address, phoneNumber);

				}
				reader.Close();
				Close();

			}
			return user;
		}
		public static DataTable GetAllUser()
		{

			if (IsConnectDB())
			{
				DataTable dt = new DataTable();
				try
				{
					string query = "exec GetAllUser";
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);

					return dt;
				}
				catch (Exception e)
				{
					// MessageBoxForm.Show("Không thể tải lên danh sách loại sản phẩm do lỗi: " + e.Message, "Lỗi");
					return null;
				}
			}
			return null;
		}
		public static string AddNewUser(UserDTO user)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec AddUser @Username = @username,@Name = @name,@Address = @address,@PhoneNumber = @phonenumber";
					var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", user.Username);
					cmd.Parameters.AddWithValue("@name", user.Name);
					cmd.Parameters.AddWithValue("@address", user.Address);
					cmd.Parameters.AddWithValue("@phonenumber", user.Phonenumber);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể thêm người dùng do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static UserDTO GetUserFromAccount(AccountDTO account)
        {
            UserDTO user = null;
            if (IsConnectDB())
            {
                string query = "SELECT * FROM user_data WHERE username = @Username";

                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 45).Value = account.Username;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string address = reader["address"].ToString();
                    string phoneNumber = reader["phonenumber"].ToString();
                    user = new UserDTO(account.Username,name,address,phoneNumber);

                }
                reader.Close();
                Close();

            }
            return user;
        }
    }
}
