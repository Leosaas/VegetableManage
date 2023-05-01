
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ProductDAO : BaseDAO
    {
    
        public static string InsertProduct(ProductDTO product)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "INSERT INTO product VALUES(@Id,@Name,@Type,@Unit,0)";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar,5).Value = product.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 45).Value = product.Name;
                    cmd.Parameters.Add("@Type", SqlDbType.VarChar, 5).Value = product.Type;
                    cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 10).Value = product.Unit;
                    cmd.ExecuteNonQuery();

                    query = "INSERT INTO product_price(idproduct,price,date,status,type) VALUES(@Id,0,@Date,1,1)";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = product.Id;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Today;
                    cmd.ExecuteNonQuery();

					query = "INSERT INTO product_price(idproduct,price,date,status,type) VALUES(@Id,0,@Date,1,0)";
					cmd = new SqlCommand(query, connection);
					cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = product.Id;
					cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Today;
					cmd.ExecuteNonQuery();
					return null;
                }
                catch(Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm sản phẩm do lỗi: " + e.Message, "Lỗi");
                    return "Không thể thêm sản phẩm do lỗi:" + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
        public static string UpdateProduct(ProductDTO product)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Update product set product_name = @Name, idcategory = @Type, idunit = @Unit where idproduct = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar,5).Value = product.Id;
                    cmd.Parameters.Add("@Type", SqlDbType.VarChar, 5).Value = product.Type;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 45).Value = product.Name;
                    cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 10).Value = product.Unit;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch (Exception e)
                {
                //    MessageBoxForm.Show("Không thể sửa rau củ do lỗi: " + e.Message, "Lỗi");
                    return "Không thể sửa rau củ do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
        public static string DeleteProduct(ProductDTO product)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Delete from product where idproduct = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = product.Id;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch (Exception e)
                {
                 //   MessageBoxForm.Show("Không thể xoá rau củ do lỗi: " + e.Message, "Lỗi");
                    return "Không thể xoá rau củ do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
		public static DataTable GetAllProductsWithCategoryAndUnitAndSellPrice()
		{

			if (IsConnectDB())
			{
				try
				{
					DataTable dt = new DataTable();

					string query = "select p.*,c.category_name,u.unit_name,pr.price from PRODUCT p, CATEGORY c,UNIT u,PRODUCT_PRICE pr where c.idcategory = p.idcategory and u.idunit = p.idunit and pr.idproduct = p.idproduct and pr.type = 1 and pr.status = 1";
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
		public static DataTable GetAllProductsWithCategoryAndUnit()
        {

            if (IsConnectDB())
            {
                try
                {
                    DataTable dt = new DataTable();
                
                    string query = "select p.*,c.category_name,u.unit_name from PRODUCT p, CATEGORY c,UNIT u where c.idcategory = p.idcategory and u.idunit = p.idunit";
                    SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
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
        public static DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            if (IsConnectDB())
            {
                try
                {
                    string query = "select * from product";
                  //  dt.FillData(query);
                    return dt;
                }
                catch (Exception e)
                {
               //     MessageBoxForm.Show("Không thể tải lên danh sách sản phẩm do lỗi: " + e.Message, "Lỗi");
                    return null;
                }
            }
            return dt;
        }
        public static ProductDTO GetProductByID(string id)
        {
            ProductDTO product = null;
            if (IsConnectDB())
            {
                string query = "SELECT * FROM product WHERE idproduct = @Id";
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = id;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    string name = reader["product_name"].ToString();
                    string type = reader["idcategory"].ToString();
                    string unit = reader["idunit"].ToString();
                    product = new ProductDTO(id, name, type,unit);
                }
                reader.Close();
            }
            return product;
        }


    }
}
