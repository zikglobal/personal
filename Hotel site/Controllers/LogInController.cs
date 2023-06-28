using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
    }
}
