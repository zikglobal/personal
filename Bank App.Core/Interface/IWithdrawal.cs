using BankApp.Data;

namespace Bank_App.Core.Interface
{
    public interface IWithdrawal
    {
        void WithdrawMoney(User UserLoggedIn);
    }
}