using Bank_App.Core.Interface;
using Microsoft.Extensions.DependencyInjection;
using Bank_App.Core.Implementation;
namespace Bank_Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddSingleton<UserInterface>();
            services.AddScoped<IRegisterUser, RegisterUser>();
            services.AddScoped<ILogIn, LogIn>();
            services.AddScoped<IMenu, Menu>();
            services.AddScoped<ICreateAccountService, CreateAccountService>();
            services.AddScoped<IDeposit, Deposit>();
            services.AddScoped<IWithdrawal, Withdrawal>();
            services.AddScoped<ITransfer, Transfer>();


            

            var serviceProvider = services.BuildServiceProvider();
            var userInterface = serviceProvider.GetRequiredService<UserInterface>();

            userInterface.Run();


        }
    }
}