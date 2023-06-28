using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
