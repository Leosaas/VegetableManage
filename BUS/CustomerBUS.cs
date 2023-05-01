using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class CustomerBUS
	{
		public static string DeleteCustomer(CustomerDTO customer)
		{
			return CustomerDAO.DeleteCustomer(customer);
		}
		public static string UpdateCustomer(CustomerDTO customer)
		{
			return CustomerDAO.UpdateCustomer(customer);
		}
		public static CustomerDTO GetCustomerByPhoneNumber(string phoneNumber)
		{
			return CustomerDAO.GetCustomerByPhoneNumber(phoneNumber);
		}
		public static DataTable GetAllCustomer()
		{
			return CustomerDAO.GetAllCustomer();
		}
		public static string AddNewCustomer(CustomerDTO customer)
		{
			return CustomerDAO.AddNewCustomer(customer);	
		}

	}
}
