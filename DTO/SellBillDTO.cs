using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SellBillDTO
	{
        int id;
        DateTime date;
        float total;
        string username;
        CustomerDTO customer;
        bool isDebit;
        List<BillDetailDTO> detail;
        int discount;
        public SellBillDTO()
        {
        }

        public SellBillDTO(DateTime date, float total, string username,int discount,CustomerDTO customer,bool isDebit, List<BillDetailDTO> detail)
        {
            Date = date;
            Total = total;
            Username = username;
            Detail = detail;
            this.customer = customer;
            this.Discount = discount;
            this.IsDebit = isDebit; 
        }
        [DisplayName("Mã phiếu")]
        public int Id { get => id; set => id = value; }
		[DisplayName("Ngày lập")]
		public DateTime Date { get => date; set => date = value; }
		[DisplayName("Tổng tiền")]
		public float Total { get => total; set => total = value; }
		[DisplayName("Người lập")]
		public string Username { get => username; set => username = value; }
        [Browsable(false)]
        public List<BillDetailDTO> Detail { get => detail; set => detail = value; }
        [Browsable(false)]
		public CustomerDTO Customer { get => customer; set => customer = value; }
        [DisplayName("Tên khách hàng")]
		public string CustomerName
		{
			get
                {
                if (customer == null)
                    return "Khách vãng lai";
                return customer.CustomerName;
            } }
        [DisplayName("Giảm giá")]
		public int Discount { get => discount; set => discount = value; }
        [Browsable(false)]
		public bool IsDebit { get => isDebit; set => isDebit = value; }
	}
}
