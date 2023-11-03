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
        private readonly IAccountRepository _accountRepository;
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository, 
            IAccountRepository accountRepository)
        {
            _userRepository = userRepository;
            _accountRepository = accountRepository;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentUser = "Maksims Racins";
            UserAccountsViewModel model = new UserAccountsViewModel(_userRepository.GetAllUsers, 
                _accountRepository.GetAllAccounts);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}