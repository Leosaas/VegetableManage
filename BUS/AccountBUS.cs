using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class AccountBUS
    {
		public static string UpdateAccount(AccountDTO account)
        {
            return AccountDAO.UpdateAccount(account);
        }
		public static DataTable GetAllAccount()
        {
            return AccountDAO.GetAllAccount();
        }

		public static AccountDTO VerifyAccount(string username, string password)
        {
            return AccountDAO.VerifyAccount(username, password);
        }
    }
}
