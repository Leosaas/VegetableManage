using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class SellBillBUS
	{
		public static DataTable GetSellBillByMonthAndYear(int month, int year)
        {
            return SellBillDAO.GetSellBillByMonthAndYear(month, year);
        }
		public static DataTable GetSellBillFromDateToDate(DateTime dateFrom, DateTime dateTo)
        {
            return SellBillDAO.GetSellBillFromDateToDate(dateFrom, dateTo);
        }
		public static DataTable GetSellBillByMonthAndYearFromDateToDate(DateTime dateFrom, DateTime dateTo)
        {
            return SellBillDAO.GetSellBillByMonthAndYearFromDateToDate(dateFrom, dateTo);
        }
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
		public static SellBillDTO GetSellBillById(int id)
        {
            return SellBillDAO.GetSellBillById(id);
        }
	}
}
