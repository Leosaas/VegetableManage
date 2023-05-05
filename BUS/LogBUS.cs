using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class LogBUS
	{
		public static string ClearLog()
		{
			return LogDAO.ClearLog();
		}
		public static string WriteLog(LogDTO log)
		{
			return LogDAO.WriteLog(log);
		}
		public static DataTable GetLog()
		{
			return LogDAO.GetLog();
		}
		public static string WriteLog(string username, string action)
		{
			return LogDAO.WriteLog(username, action);
		}
	}
}
