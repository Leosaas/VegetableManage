using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class OrderProductDAO : BaseDAO
    {
        public static int GetLastID()
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "select top 1 idpurchasebill from PURCHASE_BILL order by idpurchasebill desc";
                    var cmd = new SqlCommand(query, connection);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = int.Parse(reader["idpurchasebill"].ToString());
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
        public static string MakeBill (OrderBillDTO bill)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "INSERT INTO PURCHASE_BILL VALUES(@Date,@Total,@Username)";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = bill.Date;
                    cmd.Parameters.Add("@Total", SqlDbType.Float).Value = bill.Total;
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar,50).Value = bill.Username;
                    cmd.ExecuteNonQuery();
                    bill.Id = GetLastID();
                    foreach (BillDetailDTO detail in bill.Detail)
                    {
                        cmd.Parameters.Clear();
                        query = "INSERT INTO PURCHASE_BILL_DETAIL VALUES(@IdBill,@IdProduct,@Quantity,@Price)";
                        cmd.CommandText = query;
                        cmd.Parameters.Add("@IdBill", SqlDbType.Int).Value = bill.Id;
                        cmd.Parameters.Add("@IdProduct", SqlDbType.VarChar,15).Value = detail.IdProduct;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = detail.Quantity;
                        cmd.Parameters.Add("@Price", SqlDbType.Float).Value = detail.Price;
                        cmd.ExecuteNonQuery();


                        
                        string message = StorageDAO.IncreaseQuantity(detail.IdProduct,detail.Quantity);
                        if(message != null)
                        {
                            return message;
                        }

                        ProductPriceDTO price = new ProductPriceDTO(detail.IdProduct, (float)detail.Price,DateTime.Now,true,false);
                        ProductPriceDAO.AddProductBuyPrice(price);
                        
                    }
                    return null;
                }
                catch(Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể lập hoá đơn do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL !";
        }
        public static List<OrderBillDTO> GetAllBill()
        {
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = "select * from PURCHASE_BILL";
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);
                    List<OrderBillDTO> lst = new List<OrderBillDTO>();
                    foreach(DataRow dr in dt.Rows)
                    {
                        OrderBillDTO order = new OrderBillDTO();
                        order.Id = int.Parse(dr["idpurchasebill"].ToString());
                        order.Username = dr["username"].ToString();
                        order.Date = DateTime.Parse(dr["date"].ToString());
                        order.Total = float.Parse(dr["total"].ToString());
                        lst.Add(order);
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
					string query = string.Format("select p.product_name,u.unit_name,b.price,b.quantity from PURCHASE_BILL_DETAIL b,PRODUCT p, UNIT u where idpurchasebill = {0} and b.idproduct = p.idproduct and p.idunit = u.idunit",id);
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
