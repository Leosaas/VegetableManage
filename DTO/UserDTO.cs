using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
	{
        int rank;
        private string customerName;
        private string address;
        private string phoneNumber;

		public CustomerDTO()
		{
		}

		public CustomerDTO(string phoneNumber, string customerName, string address, int rank)
		{
			this.Rank = rank;
			this.CustomerName = customerName;
			this.Address = address;
			this.PhoneNumber = phoneNumber;
		}

		public int Rank { get => rank; set => rank = value; }
		public string CustomerName { get => customerName; set => customerName = value; }
		public string Address { get => address; set => address = value; }
		public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
	}
}
