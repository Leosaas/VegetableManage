using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CustomerDAO : BaseDAO
    {
		public static string DeleteCustomer(CustomerDTO customer)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec DeleteCustomer @PhoneNumber = @phonenumber";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@phonenumber", customer.PhoneNumber);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể xoá khách hàng do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static string UpdateCustomer(CustomerDTO customer)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec UpdateCustomer @PhoneNumber = @phonenumber,@CustomerName = @name,@Address = @address,@Rank = @rank";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@phonenumber", customer.PhoneNumber);
					cmd.Parameters.AddWithValue("@name", customer.CustomerName);
					cmd.Parameters.AddWithValue("@address", customer.Address);
					cmd.Parameters.AddWithValue("@rank", customer.Rank);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể cập nhật khách hàng do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static CustomerDTO GetCustomerByPhoneNumber(string phoneNumber)
		{
			CustomerDTO customer = null;
			if (IsConnectDB())
			{
				string query = "exec GetCustomerByPhoneNumber @PhoneNumber = @phoneNumber";

				var cmd = new SqlCommand(query, connection);
				cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 11).Value = phoneNumber;
				var reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					string name = reader["customer_name"].ToString();
					string address = reader["address"].ToString();
					int rank = int.Parse(reader["rank"].ToString());
					customer = new CustomerDTO(phoneNumber, name, address, rank);

				}
				reader.Close();
				Close();

			}
			return customer;
		}
		public static DataTable GetAllCustomer()
		{

			if (IsConnectDB())
			{
				DataTable dt = new DataTable();
				try
				{
					string query = "exec GetAllCustomer";
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
		public static string AddNewCustomer(CustomerDTO customer)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec AddCustomer @PhoneNumber = @phonenumber,@CustomerName = @name,@Address = @address,@Rank = @rank";
					var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@rank", customer.Rank);
					cmd.Parameters.AddWithValue("@name", customer.CustomerName);
					cmd.Parameters.AddWithValue("@address", customer.Address);
					cmd.Parameters.AddWithValue("@phonenumber", customer.PhoneNumber);
					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể thêm khách hàng do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		
       
    }
}
