using Bank_App.Core.Interface;
using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_App.Core.Implementation
{
    public class LogIn : RegistrationHelper, ILogIn
    {
        private readonly IMenu _menu;
        public LogIn(IMenu menu)
        {
            _menu = menu;
        }
        public void LoginUser()
        {
            List<User> users = ReadCustomersFromFile("Customers.txt");
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string passwordPattern = @"^(?=.*[a-zA-Z0-9])(?=.*[@#$%^&+=])(?=.{6,})";
            string? myemail;
            string? mypassword;


            Console.WriteLine("------Welcome to your Login portal-------");
            do
            {
                Console.Write("Enter your email. (E.g., john@gmail.com):>>> ");
                myemail = Console.ReadLine();
            } while (!Regex.IsMatch(myemail, emailPattern));

            do
            {
                Console.WriteLine("password should not be less than 6 characters and should contain a special character E.G @ ,#,* ");
                Console.Write("Enter your password :>>> ");
                mypassword = Console.ReadLine();
            } while (!Regex.IsMatch(mypassword, passwordPattern));




            User? loggedInUser = users.FirstOrDefault(user => user.Email == myemail && user.Password == mypassword);

            if (loggedInUser != null)
            {
                Console.Clear();
                Console.WriteLine("Successfully Logged in!");
                _menu.MainMenu(loggedInUser);
            }
            else
            {
                Console.WriteLine("\n\nInvalid email or password.");
                Console.WriteLine("Please try again or register a new account.");
            }


        }
    }
}
