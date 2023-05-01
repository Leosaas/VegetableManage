using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        private string id;
        private string name;
        private string type;
        private string unit;
        public ProductDTO()
        {
        }

        public ProductDTO(string id, string name, string type, string unit)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.Unit = unit;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}
