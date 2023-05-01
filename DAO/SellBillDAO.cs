using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class SellBillDAO : BaseDAO
    {
        public static int GetLastID()
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "select top 1 idsellbill from SELL_BILL order by idsellbill desc";
                    var cmd = new SqlCommand(query, connection);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = int.Parse(reader["idsellbill"].ToString());
                        reader.Close();
                        return id;
                    }
                    reader.Close();
                    return 0;
                }
                catch (Exception e)
                {
                    return -1;
                }
            }
            return -1;
        }
        public static string MakeBill(SellBillDTO bill)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "exec MakeNewSellBill @Date = @date, @Total = @total,@CustomerPhone = @customerPhone,@Username = @username,@Discount = @discount";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = bill.Date;
                    cmd.Parameters.AddWithValue("@total", bill.Total);
                    if (bill.Customer == null)
                    {
                        cmd.Parameters.AddWithValue("@customerPhone", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@customerPhone", bill.Customer.PhoneNumber);
                    }

                    cmd.Parameters.AddWithValue("@username", bill.Username);
                    cmd.Parameters.AddWithValue("@discount", bill.Discount);
                    cmd.ExecuteNonQuery();
                    bill.Id = GetLastID();
                    foreach (BillDetailDTO detail in bill.Detail)
                    {

                        string message = StorageDAO.DecreaseQuantity(detail.IdProduct, detail.Quantity);
                        if (message != null)
                        {
                            DeleteBill(bill.Id);
                            return message;
                        }
                        cmd.Parameters.Clear();
                        query = "INSERT INTO SELL_BILL_DETAIL VALUES(@IdBill,@IdProduct,@Quantity,@Price)";
                        cmd.CommandText = query;
                        cmd.Parameters.Add("@IdBill", SqlDbType.Int).Value = bill.Id;
                        cmd.Parameters.Add("@IdProduct", SqlDbType.VarChar, 15).Value = detail.IdProduct;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = detail.Quantity;
                        cmd.Parameters.Add("@Price", SqlDbType.Float).Value = detail.Price;
                        cmd.ExecuteNonQuery();






                    }
                    return null;
                }
                catch (Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể lập hoá đơn do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL !";
        }
        public static string DeleteBill(int id)
        {
            try
            {
                string query = "delete from SELL_BILL where idsellbill = @Id";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
				cmd.ExecuteNonQuery();
			}
            catch (Exception e)
            {
                //MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
                return "Không thể lập hoá đơn do lỗi: " + e.Message;
            }
        
            return "Không thể kết nối tới CSDL !";
        }
        public static List<SellBillDTO> GetAllBill()
        {
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = "exec GetAllSellBill";
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);
                    List<SellBillDTO> lst = new List<SellBillDTO>();
                    foreach(DataRow dr in dt.Rows)
                    {
                        SellBillDTO bill = new SellBillDTO();
						bill.Id = int.Parse(dr["idsellbill"].ToString());
						bill.Username = dr["username"].ToString();
						bill.Date = DateTime.Parse(dr["date"].ToString());
						bill.Total = float.Parse(dr["total"].ToString());
                        bill.Discount = int.Parse(dr["discount"].ToString());
                        bill.Customer = CustomerDAO.GetCustomerByPhoneNumber(dr["customer"].ToString());
						lst.Add(bill);
                    }
					return lst;
				}
				catch (Exception e)
				{
					//     MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
					return null;
				}
			}
			return null;
		}
		public static DataTable GetBillDetailsById(int id)
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = string.Format("select p.product_name,u.unit_name,b.price,b.quantity from SELL_BILL_DETAIL b,PRODUCT p, UNIT u where idsellbill = {0} and b.idproduct = p.idproduct and p.idunit = u.idunit",id);
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
