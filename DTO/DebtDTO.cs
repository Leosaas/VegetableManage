using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class DebtDTO
	{
		string customerPhone;
		int idBill;
		string infomation;
		bool status;
		float pay;
		public DebtDTO()
		{
		}

		public DebtDTO(string customerPhone, int idBill, string infomation, bool status, float pay)
		{
			this.customerPhone = customerPhone;
			this.idBill = idBill;
			this.Infomation = infomation;
			this.Status = status;
			this.Pay = pay;
		}

		public string CustomerPhone { get => customerPhone; set => customerPhone = value; }
		public int IdBill { get => idBill; set => idBill = value; }
		public string Infomation { get => infomation; set => infomation = value; }
		public bool Status { get => status; set => status = value; }
		public float Pay { get => pay; set => pay = value; }
	}
}
