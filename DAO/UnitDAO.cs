using System;
using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class UnitDAO : BaseDAO
    {
        public static string InsertUnit(UnitDTO unit)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "INSERT INTO unit VALUES(@Id,@Name)";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar,10).Value = unit.Id;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = unit.Name;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch(Exception e)
                {
                    //MessageBoxForm.Show("Không thể thêm thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể thêm đơn vị do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL !";
        }
        public static string UpdateUnit(UnitDTO unit)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Update unit set unit_name = @Name where idunit = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar, 10).Value = unit.Id;
                    cmd.Parameters.Add("@Name",SqlDbType.NVarChar, 50).Value = unit.Name;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch (Exception e)
                {
                   // MessageBoxForm.Show("Không thể sửa thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể sửa đơn vị do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
        public static string DeleteUnit(UnitDTO unit)
        {
            if (IsConnectDB())
            {
                try
                {
                    string query = "Delete from unit where idunit = @Id";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar, 10).Value = unit.Id;
                    cmd.ExecuteNonQuery();
                    return null;
                }
                catch (Exception e)
                {
                  //  MessageBoxForm.Show("Không thể xoá thể loại do lỗi: " + e.Message, "Lỗi");
                    return "Không thể xoá đơn vị do lỗi: " + e.Message;
                }
            }
            return "Không thể kết nối tới CSDL";
        }
        public static DataTable GetAllUnit()
        {
    
            if (IsConnectDB())
            {
                DataTable dt = new DataTable();
                try
                {
                    string query = "select * from unit";
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
        public static UnitDTO GetUnitById(string id)
        {
            UnitDTO unit = null;
            if (IsConnectDB())
            {
                string query = "SELECT * FROM unit WHERE idunit = '" + id + "'";
                var cmd = new SqlCommand(query, connection);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    string name = reader["unit_name"].ToString();
                    unit = new UnitDTO(id, name);
                }
                reader.Close();
            }
            return unit;
        }
        
     
    }
}
