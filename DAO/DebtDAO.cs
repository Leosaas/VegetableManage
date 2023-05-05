using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using DTO;
namespace DAO
{
	public class DebtDAO : BaseDAO
	{
		public static float GetTotalDebtOfCustomer(string customerPhone)
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = string.Format("exec GetTotalDebtOfCustomer @CustomerPhone = {0}", customerPhone);
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);
					if(dt.Rows.Count == 0)
						return 0;
					return float.Parse(dt.Rows[0]["total"].ToString());
				}
				catch (Exception e)
				{
					//     MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
					return -1;
				}
			}
			return -1;
		}
		public static float GetTotalPayOfCustomer(string customerPhone)
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = string.Format("exec GetTotalPayOfCustomer @CustomerPhone = {0}", customerPhone);
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);
					if (dt.Rows.Count == 0)
						return 0;
					return float.Parse(dt.Rows[0]["total"].ToString());
				}
				catch (Exception e)
				{
					//     MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
					return -1;
				}
			}
			return -1;
		} 
		public static DataTable GetDebtPayDetailOfCustomer(string customerPhone)
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = string.Format("exec GetDebtPayDetailOfCustomer @CustomerPhone = {0}", customerPhone);
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
		public static string PayDebitByAmount(DebtDTO debt)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "exec PayDebitByAmount @phone,@pay,@date,@infomation";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@phone", debt.CustomerPhone);
					cmd.Parameters.AddWithValue("@pay", debt.Pay);
					cmd.Parameters.AddWithValue("@date", DateTime.Now);
					cmd.Parameters.AddWithValue("@infomation", debt.Infomation);
					cmd.ExecuteNonQuery();
				
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể thêm trả nợ do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static DataTable GetDetailDebtOfCustomer(string customerPhone)
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = string.Format("exec GetDetailDebtOfCustomer @CustomerPhone = {0}",customerPhone);
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
		public static string RemoveAllDebtOfCustomer(DebtDTO debit)
		{
			if (IsConnectDB())
			{
				try
				{
					
					string message = PayDebitByAmount(debit);
					if (message != null)
						return message;
					float allDebit = GetTotalDebtOfCustomer(debit.CustomerPhone);	
					DebtDTO debt = new DebtDTO();
					debt.CustomerPhone = debit.CustomerPhone;
					debt.Pay = -allDebit;
					debt.Infomation = "Trả toàn bộ nợ (" + allDebit + " VND)";
					message = PayDebitByAmount(debt);
					if (message != null)
						return message;
					string query = "exec UpdateDebitStatus @phone";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@phone", debit.CustomerPhone);
					cmd.ExecuteNonQuery();
					query = "exec RemoveAllDebtOfCustomer @CustomerPhone = @phone";
					cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@phone", debit.CustomerPhone);

					cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể xoá ghi nợ do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static string RemoveDebtOneBill(DebtDTO debt)
		{
			if (IsConnectDB())
			{
				try
				{
					string message = PayDebitByAmount(debt);
					if (message != null)
						return message;

					string query = "exec RemoveDebtOneBill @IdBill = @idbill";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@idbill", debt.IdBill);

					cmd.ExecuteNonQuery();

					return null;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return "Không thể xoá ghi nợ do lỗi: " + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static DataTable GetAllCustomerHaveDebtWithDebtValue()
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = string.Format("exec GetAllCustomerHaveDebtWithDebtValue");
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
