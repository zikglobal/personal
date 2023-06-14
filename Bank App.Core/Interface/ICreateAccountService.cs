using BankApp.Data;

namespace Bank_App.Core.Interface
{
    public interface ICreateAccountService
    {
        string AcNo { get; set; }
        string AcType { get; set; }
        decimal Bal { get; set; }

        void CreateNewAccount(User UserLoggedIn);
    }
}