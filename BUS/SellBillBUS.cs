using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class SellBillBUS
	{
		public static int GetLastID()
        {
            return SellBillDAO.GetLastID(); 
        }

		public static string MakeBill(SellBillDTO bill)
        {
            return SellBillDAO.MakeBill(bill);
        }
		public static List<SellBillDTO> GetAllBill()
        {
            return SellBillDAO.GetAllBill();
        }
		public static DataTable GetBillDetailsById(int id)
        {
            return SellBillDAO.GetBillDetailsById(id);
        }

	}
}
