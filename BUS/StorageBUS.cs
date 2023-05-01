using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class StorageBUS
    {
		public static int GetQuantityOfProduct(string id)
		{
			return StorageDAO.GetQuantityOfProduct(id);
		}
		public static DataTable GetStorageInfo()
		{
			return StorageDAO.GetStorageInfo();
		}

		public static string UpdateQuantity(StorageDTO detail)
		{
			return StorageDAO.UpdateQuantity(detail);
		}
	}
}
