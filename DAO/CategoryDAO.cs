using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class CategoryDAO : BaseDAO
    {
        public static string InsertCategory(CategoryDTO category)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "INSERT INTO category(idcategory,category_name) VALUES(@Id,@Name)";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar,5).Value = category.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = category.Name;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch(Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể thêm thể loại do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL !";
        }
        public static string UpdateCategory(CategoryDTO category)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Update category set category_name = @Name where idcategory = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = category.Id;
                    cmd.Parameters.Add("@Name",SqlDbType.NVarChar, 50).Value = category.Name;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch (Exception e)
                {
                   // MessageBoxForm.Show("Không thể sửa thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể sửa thể loại do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
        public static string DeleteCategory(CategoryDTO category)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Delete from category where idcategory = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.VarChar, 5).Value = category.Id;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch (Exception e)
                {
                  //  MessageBoxForm.Show("Không thể xoá thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể xoá thể loại do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
        public static DataTable GetAllCategory()
        {
    
            if (IsConnectDB())
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "select * from category";
                    SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
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
        public static CategoryDTO GetCategoryByID(string id)
        {
            CategoryDTO category = null;
            if (IsConnectDB())
            {
                string query = "SELECT * FROM category WHERE idcategory = '" + id + "'";
                var cmd = new SqlCommand(query, connection);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    string name = reader["category_name"].ToString();
                    category = new CategoryDTO(id, name);
                }
                reader.Close();
            }
            return category;
        }
        
     
    }
}
