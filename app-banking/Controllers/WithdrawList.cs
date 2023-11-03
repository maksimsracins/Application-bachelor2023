using Microsoft.AspNetCore.Mvc;

namespace app_banking.Controllers
{
    public class WithdrawList : Controller
    {
        public IActionResult ShowWithdrawList()
        {
            return View();
        }
    }
}
