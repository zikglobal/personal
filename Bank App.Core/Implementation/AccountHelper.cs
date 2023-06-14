using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Core.Implementation
{
    public class AccountHelper
    {
        public void PromptToViewAccount(User UserLoggedIn)
        {
            string choice;
            bool isValid;
            do
            {
                Console.WriteLine("\n>>To view all your accounts press Y \n>>To go back to your Menu Press N");
                choice = Console.ReadLine()!;
                if (choice == "Y" || choice == "y")
                {
                    isValid = true;
                    ShowAllAccount(UserLoggedIn);
                }
                else if (choice == "N" || choice == "n")
                {
                    isValid = true;
                    Console.Clear();
                    Console.WriteLine("You have been redirected to your Dashboard.\n");
                    // _dash.MyDashBoard(UserLoggedIn);

                }
                else
                {
                    isValid = false;
                    Console.WriteLine(" Invalid input! ");
                    Console.WriteLine("Please choose either 'Y' or 'N' when prompted again ?");
                }
            } while (isValid);

        }

        public static List<Account> ReadAccountsFromFile(string filePath)
        {
            List<Account> accounts = new List<Account>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] fields = line.Split('|');

                        if (fields.Length >= 5)
                        {
                            string id = fields[1].Trim();
                            string name = fields[2].Trim();
                            string accNo = fields[3].Trim();
                            string accType = fields[4].Trim();
                            decimal Bal = decimal.Parse(fields[5].Trim());

                            Account account = new Account (id, name, accNo, accType, Bal);
                            accounts.Add(account);
                        }
                    }
                }
            }

            return accounts;
        }

        public void ShowAllAccount(User UserLoggedIn)
        {
            List<Account> accounts = ReadAccountsFromFile("Accounts.txt");

            List<Account> UserLoggedInAccounts = accounts.Where(account => account.Id == UserLoggedIn.Id).ToList();

            string allprints = "";
            foreach (Account acc in accounts)
            {
                allprints += $"|   {acc.Id,-14}  |   {acc.Name,-14}  |   {acc.AccountNumber,-15}  |  {acc.AccountType,-15}  |  {acc.AccountBalance,-16}  |\n";
            }
            Console.WriteLine("|-------------------|-------------------|--------------------|-------------------|--------------------|");
            Console.WriteLine("|     CUSTOMER_ID   |    FULLNAME       |     ACCOUNT_NO     |   ACCOUNT_TYPE    |   ACCOUNT BALANCE  |");
            Console.WriteLine("|-------------------|-------------------|--------------------|-------------------|--------------------|");
            Console.WriteLine(allprints);
            Console.WriteLine("|-----------------------------------------------------------------------------------------------------|");
        }

    }
}

