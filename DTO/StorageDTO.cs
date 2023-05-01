using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class StorageDTO
	{
		string idProduct;
		string productName;
		string unit;
		int quantity;
		public StorageDTO()
		{
		}

		public StorageDTO(string idProduct, string productName, string unit, int quantity)
		{
			this.idProduct = idProduct;
			this.productName = productName;
			this.unit = unit;
			this.quantity = quantity;
		}

		public string IdProduct { get => idProduct; set => idProduct = value; }
		public string ProductName { get => productName; set => productName = value; }
		public string Unit { get => unit; set => unit = value; }
		public int Quantity { get => quantity; set => quantity = value; }
	}
}
