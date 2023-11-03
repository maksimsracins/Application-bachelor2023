using Microsoft.AspNetCore.Mvc;

namespace app_banking.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
