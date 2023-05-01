using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class UnitBUS
    {
		public static UnitDTO GetUnitById(string id)
        {
            return UnitDAO.GetUnitById(id);
        }

		public static DataTable GetAllUnit()
        {
            return UnitDAO.GetAllUnit();
        }
        public static string InsertUnit(UnitDTO unit)
        {
            if (string.IsNullOrEmpty(unit.Id))
            {
              //  MessageBoxForm.Show("Mã loại không được để trống", "Thông báo");
                return "Mã đơn vị không được để trống !";
            }
            if (string.IsNullOrEmpty(unit.Name))
            {
             //   MessageBoxForm.Show("Tên không được để trống", "Thông báo");
                return "Tên không được để trống !";
            }
            if (UnitDAO.GetUnitById(unit.Id) != null)
            {
            //    MessageBoxForm.Show("Mã loại rau củ đã có", "Thông báo");
                return "Mã đơn vị rau củ đã có !";
            }
            return UnitDAO.InsertUnit(unit);
        }
        public static string UpdateUnit(UnitDTO unit)
        {
            if (string.IsNullOrEmpty(unit.Name))
            {
              //  MessageBoxForm.Show("Tên không được để trống", "Thông báo");
                return "Tên không được để trống !";
            }
            return UnitDAO.UpdateUnit(unit);
        }
        public static string DeleteUnit(UnitDTO unit)
        { 
            return UnitDAO.DeleteUnit(unit);
        }

    }
}
