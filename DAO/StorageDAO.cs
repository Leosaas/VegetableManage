using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class StorageDAO : BaseDAO
    {
        public static DataTable GetStorageInfo()
        {
            if (IsConnectDB())
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "select p.idproduct, p.product_name, p.storage_quantity, u.unit_name from PRODUCT p, UNIT u where p.idunit = u.idunit";
					SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
					adapter.Fill(dt);

					return dt;
				
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return null;
        }
        public static int GetQuantityOfProduct(string id)
        {
			if (IsConnectDB())
			{
				try
				{
                    int value = -1;
					string query = "select storage_quantity from PRODUCT where idproduct = @Id";
					var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar, 15).Value = id;
					var reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        value = int.Parse(reader[0].ToString());
                        reader.Close();
                        return value;
                    }
					reader.Close();
					return -1;
				}
				catch (Exception e)
				{
					//MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
					return -1;
				}
			}
			return -1;
		}
		public static string IncreaseQuantity(string idproduct, int value)
        {
            if (IsConnectDB())
            {
				int currentQuantity = StorageDAO.GetQuantityOfProduct(idproduct);
				if (currentQuantity != -1)
				{
                    StorageDTO storage = new StorageDTO();
                    storage.IdProduct = idproduct;
                    storage.Quantity = currentQuantity + value ;
					StorageDAO.UpdateQuantity(storage);
                    return null;
				}
				else
				{
					return "Không thể lấy thông tin kho hàng tồn";
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static string DecreaseQuantity(string idproduct, int value)
		{
			if (IsConnectDB())
			{
				int currentQuantity = StorageDAO.GetQuantityOfProduct(idproduct);
				if (currentQuantity != -1)
				{
					StorageDTO storage = new StorageDTO();
					storage.IdProduct = idproduct;
					storage.Quantity = currentQuantity - value;
                    if(storage.Quantity < 0)
                        return ProductDAO.GetProductByID(storage.IdProduct).Name + " không có đủ trong kho (Hiện có: "+currentQuantity+")"; 
					StorageDAO.UpdateQuantity(storage);
					return null;
				}
				else
				{
					return "Không thể lấy thông tin kho hàng tồn";
				}
			}
			return "Không thể kết nối tới CSDL !";
		}
		public static string UpdateQuantity (StorageDTO detail)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Update PRODUCT set storage_quantity = @Quantity where idproduct = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = detail.Quantity;
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar,15).Value = detail.IdProduct;
                    cmd.ExecuteNonQuery();
             
                    return null;
                }
                catch(Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể cập nhật do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL !";
        }
      
     
    }
}
