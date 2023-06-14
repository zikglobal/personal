using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data
{
    public class User
    {
        public object Name;

        public string Id { get; set; }
        public string Fullname { get; set; }
      
        public string Email { get; set; }
        public string Password { get; set; }

        public User( string id, string fullname, string email, string password) 
        {
            Id = id;
            Fullname= fullname;
            Email = email;
            Password = password;
            
        }
    }
}
