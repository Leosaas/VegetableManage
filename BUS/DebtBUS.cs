using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class DebtBUS
	{
		public static DataTable GetAllCustomerWithDebt()
		{
			return DebtDAO.GetAllCustomerWithDebt();
		}
		public static float GetTotalDebtOfCustomer(string customerPhone)
		{
			return DebtDAO.GetTotalDebtOfCustomer(customerPhone);
		}
		public static float GetTotalPayOfCustomer(string customerPhone)
		{
			return DebtDAO.GetTotalPayOfCustomer(customerPhone);
		}
		public static DataTable GetDebtPayDetailOfCustomer(string customerPhone)
		{
			return DebtDAO.GetDebtPayDetailOfCustomer(customerPhone);
		}
		public static string PayDebitByAmount(DebtDTO debt)
		{
			return DebtDAO.PayDebitByAmount(debt);
		}
		public static DataTable GetDetailDebtOfCustomer(string customerPhone)
		{
			return DebtDAO.GetDetailDebtOfCustomer(customerPhone);
		}
		public static string RemoveAllDebtOfCustomer(DebtDTO debit)
		{
			return DebtDAO.RemoveAllDebtOfCustomer(debit);
		}
		public static string RemoveDebtOneBill(DebtDTO debt)
		{
			return DebtDAO.RemoveDebtOneBill(debt);
		}
		public static DataTable GetAllCustomerHaveDebtWithDebtValue()
		{
			return DebtDAO.GetAllCustomerHaveDebtWithDebtValue();
		}

	}
}
