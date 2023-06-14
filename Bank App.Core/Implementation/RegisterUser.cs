using Bank_App.Core.Interface;
using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Core.Implementation
{
    public class RegisterUser : RegistrationHelper, IRegisterUser
    {
        public void RegUser()
        {
            var id = UserId();
            var fullname = UserName();
            var email = UserEmail();
            var pwd = UserPassword();

            //Creating a customer
            User user = new User(id, fullname, email, pwd);

            //Inserting customer details to file
            using (StreamWriter writer = new StreamWriter("Customers.txt", true))
            {
                writer.WriteLine($"|  {user.Id,-12}   |      {user.Fullname,-16}    | {user.Email,-18}   |  {user.Password,-18}  | \n\n");
            }
            Console.WriteLine($" Customer {fullname} has been added to File.");
        }
    }
}
