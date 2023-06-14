using Bank_App.Core.Interface;
using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Core.Implementation
{
    public class Menu : IMenu
    {
        private readonly IDeposit _deposit;
        private readonly IWithdrawal _withdrawal;
        private readonly ITransfer _transfer;
        private readonly ICreateAccountService _createAccountService;
        public Menu(IDeposit deposit, IWithdrawal withdrawal, ITransfer transfer, ICreateAccountService createAccountService)
        {
            _deposit = deposit;
            _withdrawal = withdrawal;
            _transfer = transfer;
            _createAccountService = createAccountService;
        }
        public void MainMenu(User UserLoggedIn)
        {
            Console.WriteLine($"---{UserLoggedIn.Name}'s--DASHBOARD------\n");
            Console.WriteLine($"Welcome, dear {UserLoggedIn.Name} .\nWhat would you like to do today ?\n");
            Console.WriteLine(">Press 1 Create Account");
            Console.WriteLine(">Press 2 to Deposit");
            Console.WriteLine(">Press 3 to Withdraw");
            Console.WriteLine(">Press 4 Transfer");
            Console.WriteLine("Press 5 to get balance");
            Console.WriteLine("Press 6 to get your Statement");
            Console.WriteLine("Press 7 to Logout\n\n");
            Console.Write("Select an option: ");

            //Console.WriteLine("************ Welcome to Zik_Global Bank **********\n");

            //Console.WriteLine("\nplease select an option:\n");


            //Console.WriteLine("1. Create Account\n2 Check Balance\n3. Deposit\n4. Withdraw\n5. Transfer \n6. DisplayAllTables  \n7 Logout\n");
            //Console.WriteLine("");

            string mychoice;
            bool isValidChoice = false;

            do
            {
                mychoice = Console.ReadLine()!;

                if (mychoice == "1")
                {
                    _createAccountService.CreateNewAccount(UserLoggedIn);
                    MainMenu(UserLoggedIn);
                    isValidChoice = true;
                }
                else if (mychoice == "2")
                {
                    _deposit.DepositMoney(UserLoggedIn);
                    MainMenu(UserLoggedIn);
                    isValidChoice = true;
                }
                else if (mychoice == "3")
                {
                    _withdrawal.WithdrawMoney(UserLoggedIn);
                    MainMenu(UserLoggedIn);
                    isValidChoice = true;
                }
                else if (mychoice == "4")
                {
                    _transfer.TransferMoney(UserLoggedIn);
                    MainMenu(UserLoggedIn);
                    isValidChoice = true;
                }
                else if (mychoice == "5")
                {
                    //_myAccService.CheckAccountBalance();

                    isValidChoice = true;
                }
                else if (mychoice == "6")
                {
                    //_myAccService.PrintAccountStatement();

                    isValidChoice = true;
                }

                else if (mychoice == "7")
                {
                    //_userService.LogMeOut();
                    isValidChoice = true;
                }

            } while (isValidChoice);

            //string option = Console.ReadLine();
            //if (option == "1")
            //{
            //    _createAccountService.CreateAccount();
            //    MainMenu(User);

            //}

            //else if (option == "2")
            //{
            //    _accountService.CheckBalance();
            //    MainMenu();
            //    //  CheckBalance();
            //    //  string AcctNumber = Console.ReadLine();
            //    //  Console.WriteLine($"Your account balance is: ");

            //}
            //else if (option == "3")
            //{
            //    _accountService.Deposit();
            //    MainMenu();
            //    //  Deposit();

            //    //Console.WriteLine("Enter the amount to deposit");

            //}
            //else if (option == "4")
            //{
            //    _accountService.Withdraw();
            //    MainMenu();
            //    //  Withdraw();
            //    //Console.WriteLine("To make a withdrawal, enter the amonut");


            //}
            //else if (option == "5")
            //{
            //    _accountService.Transfer();
            //    MainMenu();
            //    //  DisplayTable.DisplayAllTables();

            //}
            ///* else if (option == "6")
            // {
            //     _accountService.DisplayAllTables();
            //     MainMenu();

            //     //   WelcomePage();
            //     //  Console.WriteLine("Below is your account details");
            // }*/
            //else if (option == "7")
            //{
            //    Console.WriteLine("Thank you for Banking with us");
            //    // Transfer();

            //}
            //else
            //{
            //    MainMenu();
            //}


        }

      
    }
}
