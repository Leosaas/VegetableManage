
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class AccountDAO : BaseDAO
    {
		public static string UpdateAccount(AccountDTO account)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec UpdateAccount @Username = @username,@Password = @password,@Type = @type";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@username", account.Username);
					cmd.Parameters.AddWithValue("@password", account.Password);
					cmd.Parameters.AddWithValue("@type", account.Type);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể cập nhật tài khoản do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		/* public User getUserByUsername(string userName)
		 {
			 User user = null;
			 if (IsConnectDB())
			 {
				 string query = "SELECT * FROM user WHERE username = '" + userName + "'";
				 var cmd = new MySqlCommand(query, connection);
				 var reader = cmd.ExecuteReader();
				 if (reader.Read())
				 {
					 int permissionCode = (int)reader["type"];
					 UserPermission permission = UserPermission.CLIENT;

					 switch (permissionCode)
					 {
						 case 0:
							 permission = UserPermission.CLIENT;
							 break;
						 case 1:
							 permission = UserPermission.ADMIN;
							 break;
						 case 2:
							 permission = UserPermission.SUPPLIER;
							 break;

					 }
					 string displayname = reader["displayname"].ToString();
					 string address = reader["diachi"].ToString();
					 string phoneNumber = reader["sodienthoai"].ToString();
					 string password = reader["password"].ToString();
					 user = new User(userName,password, permission, address, displayname, phoneNumber);

				 }
				 reader.Close();
				 Close();

			 }
			 return user;
		 }*/
		public static AccountDTO VerifyAccount(string username,string password)
        {
            AccountDTO account = null;
            if (IsConnectDB())
            {
                string query = "SELECT * FROM account WHERE username = @Username AND password = @Password";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 45).Value = username;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 45).Value = password;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int type = int.Parse(reader["type"].ToString());
                    reader.Close();
                    Close();
                    account = new AccountDTO(username, password, type);
                    return account;
                }
              //  MessageBoxForm.Show("Sai tên đăng nhập hoặc mật khẩu, vui lòng kiểm tra lại", "Lỗi");

                reader.Close();
                Close();
   
            }
            return account;
        }
		public static DataTable GetAllAccount()
		{

			if (IsConnectDB())
			{
				DataTable dt = new DataTable();
				try
				{
					string query = "exec GetAllAccount";
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

	}
}
