using Bank_App.Core.Interface;
using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Core.Implementation
{
    public class Deposit : AccountHelper, IDeposit
    {
        private string? AccountToDepositTo { get; set; }
        private string? AmountToDeposit { get; set; }
        private decimal CleanAmountToDeposit { get; set; }




        public void DepositMoney(User UserLoggedIn)
        {
            Console.Clear();

            ShowAllAccount(UserLoggedIn);

            Console.Write("Type in the account number you want to send money to.>>");
            AccountToDepositTo = Console.ReadLine();

            Console.Write("Enter the amount you want to send>>>");
            AmountToDeposit = Console.ReadLine()!.Trim();
            CleanAmountToDeposit = decimal.Parse(AmountToDeposit);

            List<Account> accounts = ReadAccountsFromFile("Accounts.txt");

            List<Account> loggedInUserAccounts = accounts.Where(account => account.Id == UserLoggedIn.Id).ToList();

            Account? accountToUpdate = loggedInUserAccounts.FirstOrDefault(account => account.AccountNumber == AccountToDepositTo);

            if (accountToUpdate is null)
            {
                Console.Clear();
                Console.WriteLine("The account entered does not exist!\nPlease enter a valid account number>>");

            }

            else if (accountToUpdate != null)
            {
                accountToUpdate.AccountBalance += CleanAmountToDeposit;
                Console.WriteLine($"You have successfully deposited {CleanAmountToDeposit} into your account with account number {AccountToDepositTo}");

            }
            // Update the Account.txt file with the new balance
            using (StreamWriter writer = new StreamWriter("Accounts.txt"))
            {
                foreach (var account in accounts)
                {
                    writer.WriteLine($"| {account.Id,-12} | {account.Name,-12} | {account.AccountNumber,-12} | {account.AccountType,-8} | {account.AccountBalance} |");
                }
            }
        }
    }
}
