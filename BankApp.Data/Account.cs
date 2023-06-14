using System.Xml.Linq;

namespace BankApp.Data
{
    public class Account
    //{
    //    public string AccountNumber { get; set; }
    //    public decimal AccountBalance { get; set; }
    //    public AccountType AccountType { get; set; }
    //    public string FullName { get; set; }
    //    public string Id { get; set; }

    { 
    public string Name { get; set; }
    public string Id { get; set; }
    public string AccountNumber { get; set; }
    public decimal AccountBalance { get; set; }
    public string AccountType { get; set; }

    public Account(string id, string fullName, string accountNumber, string accountType, decimal accountbalance)
    {
        Name = fullName;
        Id = id;
        AccountNumber = accountNumber;
        AccountType = accountType;
        AccountBalance = accountbalance;
    }

}
  
}