using app_banking.Models;

namespace app_banking.ViewModels
{
    public class UserAccountsViewModel
    {
        public IEnumerable<User> Users { get; }
        public IEnumerable<Account> Accounts { get; }

        public UserAccountsViewModel(IEnumerable<User> userRepository,
            IEnumerable<Account> accountRepository)
        {
            Users = userRepository;
            Accounts = accountRepository;
        }

    }
}
