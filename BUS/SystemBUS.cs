using DAO;
using DTO;
using System.Data;

namespace BUS
{
	public class SystemBUS
	{
		public static string BackupDatabase()
		{
			return SystemDAO.BackupDatabase();
		}
		public static string RestoreDatabase(string path)
		{
			return SystemDAO.RestoreDatabase(path);
		}
	}
}
