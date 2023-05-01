using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class UserBUS
    {
		public static string DeleteUser(UserDTO user)
        {
            return UserDAO.DeleteUser(user);
        }
		public static string UpdateUser(UserDTO user)
        {
            return UserDAO.UpdateUser(user);
        }
		public static UserDTO GetUserFromUsername(string username)
        {
            return UserDAO.GetUserFromUsername(username);   
        }
		public static DataTable GetAllUser()
        {
            return UserDAO.GetAllUser();
        }
		public static string AddNewUser(UserDTO user)
        {
            if(GetUserFromUsername(user.Username) != null)
            {
                return "Tên ngưởi dùng đã tồn tại";
            }
            return UserDAO.AddNewUser(user);
		}

		public static UserDTO GetUserFromAccount(AccountDTO account)
        {
            return UserDAO.GetUserFromAccount(account);
        }

    }
}
