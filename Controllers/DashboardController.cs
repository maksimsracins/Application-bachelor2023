using Microsoft.AspNetCore.Mvc;

namespace app_banking.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Statistics()
        {
            return View();
        }
    }
}
