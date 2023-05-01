using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class BillDetailDTO
	{
		int id, idBill, quantity;
		string idProduct;
		double price;
		public BillDetailDTO()
		{
		}

		public BillDetailDTO(string idProduct, int quantity,  double price)
		{
			this.quantity = quantity;
			this.idProduct = idProduct;
			this.price = price;
		}

		public int Id { get => id; set => id = value; }
		public int IdBill { get => idBill; set => idBill = value; }
		public int Quantity { get => quantity; set => quantity = value; }
		public string IdProduct { get => idProduct; set => idProduct = value; }
		public double Price { get => price; set => price = value; }
	}
}
