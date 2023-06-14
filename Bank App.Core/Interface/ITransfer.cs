using BankApp.Data;

namespace Bank_App.Core.Interface
{
    public interface ITransfer
    {
        void TransferMoney(User UserLoggedIn);
    }
}