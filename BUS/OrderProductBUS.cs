using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class OrderProductBUS
    {
		public static DataTable GetOrderBillByMonthAndYear(int month, int year)
        {
            return OrderProductDAO.GetOrderBillByMonthAndYear(month, year);
        }
		public static DataTable GetOrderBillByMonthAndYearFromDateToDate(DateTime dateFrom, DateTime dateTo)
        {
            return OrderProductDAO.GetOrderBillByMonthAndYearFromDateToDate(dateFrom, dateTo);
        }
		public static DataTable GetOrderBillFromDateToDate(DateTime dateFrom, DateTime dateTo)
        {
            return OrderProductDAO.GetOrderBillFromDateToDate(dateFrom, dateTo);
        }
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
