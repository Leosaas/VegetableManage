using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderBillDTO
    {
        int id;
        DateTime date;
        float total;
        string username;
        List<BillDetailDTO> detail;

        public OrderBillDTO()
        {
        }

        public OrderBillDTO(DateTime date, float total, string username, List<BillDetailDTO> detail)
        {
            Date = date;
            Total = total;
            Username = username;
            Detail = detail;
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
    }
}
