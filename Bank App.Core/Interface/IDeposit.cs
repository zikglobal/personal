using BankApp.Data;

namespace Bank_App.Core.Interface
{
    public interface IDeposit
    {
        void DepositMoney(User UserLoggedIn);
    }
}