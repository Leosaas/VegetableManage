using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private string username;
        private string name;
        private string address;
        private string phonenumber;
        public UserDTO()
        {
        }

        public UserDTO(string username, string name, string address, string phonenumber)
        {
            this.username = username;
            this.name = name;
            this.address = address;
            this.phonenumber = phonenumber;
        }

        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
    }
}
