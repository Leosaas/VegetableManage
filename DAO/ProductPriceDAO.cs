
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ProductPriceDAO : BaseDAO
    {
		private static bool UpdateBuyPriceStatus(string productId)
		{
			if (IsConnectDB())
			{
				try
				{
					string query = "Update PRODUCT_PRICE set status = 0 where status = 1 and type = 0 and idproduct = @Id";
					var cmd = new SqlCommand(query, connection);
					cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = productId;
					cmd.ExecuteNonQuery();
					return true;
				}
				catch (Exception e)
				{
					//    MessageBoxForm.Show("Không thể sửa rau củ do lỗi: " + e.Message, "Lỗi");
					return false;
				}
			}
			return false;
		}
		public static string AddProductBuyPrice(ProductPriceDTO productPrice)
		{

			if (IsConnectDB())
			{
				try
				{
					if (UpdateBuyPriceStatus(productPrice.Idproduct))
					{
						string query = "INSERT INTO PRODUCT_PRICE(idproduct,price,date,status,type) VALUES(@Id,@Price,@Date,1,0)";
						var cmd = new SqlCommand(query, connection);
						cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = productPrice.Idproduct;
						cmd.Parameters.Add("@Price", SqlDbType.Float).Value = productPrice.Price;
						cmd.Parameters.Add("@Date", SqlDbType.SmallDateTime).Value = productPrice.Date;
						cmd.ExecuteNonQuery();
						return null;
					}
					return "Không thể cập nhật giá bán";
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm sản phẩm do lỗi: " + e.Message, "Lỗi");
					return "Không thể cập nhật giá bán do lỗi:" + e.Message;
				}
			}
			return "Không thể kết nối tới CSDL";
		}
		private static bool UpdateSellPriceStatus(string productId)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Update PRODUCT_PRICE set status = 0 where status = 1 and type = 1 and idproduct = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = productId;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    //    MessageBoxForm.Show("Không thể sửa rau củ do lỗi: " + e.Message, "Lỗi");
                    return false;
                }
            }
            return false;
        }
        public static string AddProductSellPrice(ProductPriceDTO productPrice)
        {

            if (IsConnectDB())
            {
                try
                {
                    if(UpdateSellPriceStatus(productPrice.Idproduct))
                    {
                        string query = "INSERT INTO PRODUCT_PRICE(idproduct,price,date,status,type) VALUES(@Id,@Price,@Date,1,1)";
                        var cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = productPrice.Idproduct;
                        cmd.Parameters.Add("@Price", SqlDbType.Float).Value = productPrice.Price;
                        cmd.Parameters.Add("@Date", SqlDbType.SmallDateTime).Value = productPrice.Date;
                        cmd.ExecuteNonQuery();
                        return null;
                    }
                    return "Không thể cập nhật giá bán";
                }
                catch (Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm sản phẩm do lỗi: " + e.Message, "Lỗi");
                    return "Không thể cập nhật giá bán do lỗi:" + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
        public static DataTable GetProductSellPriceByDate(string productId,DateTime dateFrom,DateTime dateTo)
        {
            DataTable dt = new DataTable();
            if (IsConnectDB())
            {
                try
                {
                    string query = string.Format("select * from PRODUCT_PRICE p where p.idproduct = N'{0}' and p.type = 1 and p.date between '{1}' and '{2}'",productId,dateFrom.ToString("yyyy/MM/dd"),dateTo.ToString("yyyy/MM/dd"));
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception e)
                {
                    // MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
                    return null;
                }
            }
            return null;
        }
		public static DataTable GetProductBuyPriceByDate(string productId, DateTime dateFrom, DateTime dateTo)
		{
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = string.Format("select * from PRODUCT_PRICE p where p.idproduct = N'{0}' and p.type = 0 and p.date between '{1}' and '{2}'", productId, dateFrom.ToString("yyyy/MM/dd"), dateTo.ToString("yyyy/MM/dd"));
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);
					return dt;
				}
				catch (Exception e)
				{
					// MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
					return null;
				}
			}
			return null;
		}
		public static DataTable GetAllProductSellPrice()
        {
            //SEll type = 1

            if (IsConnectDB())
            {
                try
                {
                    DataTable dt = new DataTable();
                    string query = "select * from PRODUCT_PRICE p where p.type = 1";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);
                  
                    return dt;

                }
                catch (Exception e)
                {
                    // MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
                    return null;
                }
            }
            return null;
        }
        public static DataTable GetSellPriceOfProduct(string id)
        {
            //SEll type = 1
            DataTable dt = new DataTable();
            if (IsConnectDB())
            {
                try
                {
                    string query = "select price,date,status from PRODUCT_PRICE p where p.type = 1 and idproduct = '"+id+"'";
                 
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);
                   
                    return dt;
                }
                catch (Exception e)
                {
                    // MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
                    return null;
                }
            }
            return null;
        }
		public static DataTable GetBuyPriceOfProduct(string id)
		{
			//SEll type = 1
			DataTable dt = new DataTable();
			if (IsConnectDB())
			{
				try
				{
					string query = "select price,date,status from PRODUCT_PRICE p where p.type = 0 and idproduct = '" + id + "'";

					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);

					return dt;
				}
				catch (Exception e)
				{
					// MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
					return null;
				}
			}
			return null;
		}
	}
}
