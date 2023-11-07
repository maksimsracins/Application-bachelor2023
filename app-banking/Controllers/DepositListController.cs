using app_banking.Models.Interfaces;
using app_banking.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace app_banking.Controllers
{
    public class DepositListController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUserRepository _userRepository;

        public DepositListController(IAccountRepository accountRepository, IUserRepository userRepository)
        {
            _accountRepository = accountRepository;
            _userRepository = userRepository;
        }

        public IActionResult ShowDepositList()
        {
            UserAccountsViewModel model = new UserAccountsViewModel(_userRepository.GetAllUsers,
                _accountRepository.GetAllAccounts
            );
            return View(model);
        }
    }
}
