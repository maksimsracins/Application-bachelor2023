using app_banking.Models;
using app_banking.Models.Interfaces;
using app_banking.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app_banking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository userRepository;
        private readonly IAccountRepository accountRepository;

        public HomeController(IUserRepository userRepository, IAccountRepository accountRepository)
        {
            this.userRepository = userRepository;
            this.accountRepository = accountRepository;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentUser = "Maksims Racins";
            UserAccountsViewModel model = new UserAccountsViewModel(userRepository.GetAllUsers, accountRepository.GetAllAccounts);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}