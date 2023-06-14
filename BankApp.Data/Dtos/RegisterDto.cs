using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data.Dtos
{
    public class RegisterDto
    {
       [Required] public string FirstName { get; set; }
        [Required] public string LastName { get;set; }
        [EmailAddress][Required]public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
