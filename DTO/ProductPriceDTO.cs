using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductPriceDTO
    {
        string idproduct;
        float price;
        DateTime date;
        bool status;
        bool type;

        public ProductPriceDTO()
        {
        }

        public ProductPriceDTO(string idproduct, float price, DateTime date, bool status, bool type)
        {
            this.idproduct = idproduct;
            this.price = price;
            this.date = date;
            this.status = status;
            this.type = type;
        }

        public string Idproduct { get => idproduct; set => idproduct = value; }
        public float Price { get => price; set => price = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool Status { get => status; set => status = value; }
        public bool Type { get => type; set => type = value; }
    }
}
