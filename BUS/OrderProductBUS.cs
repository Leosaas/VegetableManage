using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class OrderProductBUS
    {
		public static int GetLastID()
        {
            return OrderProductDAO.GetLastID();
        }

		public static string MakeBill(OrderBillDTO bill)
        {
            return OrderProductDAO.MakeBill(bill);
        }
		public static List<OrderBillDTO> GetAllBill()
        {
            return OrderProductDAO.GetAllBill();
        }
		public static DataTable GetBillDetailsById(int id)
        {
            return OrderProductDAO.GetBillDetailsById(id);
        }

	}
}
