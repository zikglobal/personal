using Bank_App.Core.Interface;
using BankApp.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class UserInterface 
    {
        private readonly IRegisterUser _registerUser;
        private readonly ILogIn _logIn;

        public UserInterface(IRegisterUser registerUser, ILogIn logIn)
        {
            _registerUser = registerUser;
            _logIn = logIn;
        }

        public void Run ()
        {
            string input;
            do
            {
                Console.WriteLine("Welcome to your Bank Application\n");
                Console.WriteLine("Select from 1-3");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Logout");
                input = Console.ReadLine()!;

                if (input == "1")
                {
                    //Registeration
                    // var reg = new IRegCustomer();
                    _registerUser.RegUser();

                }
                else if (input == "2")
                {
                    _logIn.LoginUser();
                }
                if (input == "3")
                {
                    Console.WriteLine("Thank you for banking with us");
                    Environment.Exit(0);

                }
            }
            while (!int.TryParse(input, out _) || int.Parse(input) != 1 || int.Parse(input) != 2 || int.Parse(input) != 3);
            {

            }
            //Console.WriteLine("******* Welcome to Zik_Global Bank *******");


            //Console.WriteLine("Enter 1 to Register");
            //Console.WriteLine("Enter 2 to Login");
            //Console.WriteLine("Enter 3 to Logout");

            //var userInput = Console.ReadLine();
            //Console.Clear();
            //if (userInput == null)
            //{
            //    Console.WriteLine("Please enter a number");
            //}


            //if (userInput == "1")
            //{

            //    var reg = new RegisterDto();
            //    Console.WriteLine("Enter your First Name:");
            //    string firstname = Console.ReadLine();
            //    reg.FirstName = firstname;

            //    Console.WriteLine("Enter your Last Name:");
            //    string lastname = Console.ReadLine();
            //    reg.LastName = lastname;

            //    Console.WriteLine("Enter your Email Address:");
            //    string email = Console.ReadLine();
            //    reg.EmailAddress = email;


            //    Console.WriteLine("Enter Password:");
            //    string password = Console.ReadLine();
            //    reg.Password = password;
            //    _userService.Register(reg);
            //    Console.Clear();
            //    Console.WriteLine("Registration Successfull");
            //    Run();

            //}
            //else if (userInput == "2")
            //{
            //    Console.WriteLine("Please enter your email");
            //    var email = Console.ReadLine();

            //    Console.WriteLine("Please enter your password");
            //    var password = Console.ReadLine();
            //    _userService.LogIn(email, password);

            //}

            //else if(userInput == "3")
            //{
            //    _userService.LogOut();
            //}
            //else
            {
                Run();
            }
        }
        

        
        
    }
}
