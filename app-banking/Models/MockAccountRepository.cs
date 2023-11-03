using app_banking.Models.Interfaces;

namespace app_banking.Models
{
    public class MockAccountRepository : IAccountRepository
    {
        private readonly IUserRepository _userRepository = new MockUserRepository();

        public IEnumerable<Account> GetAllAccounts =>
            new List<Account>
            {
                new Account { Id = 1, AccountNumber="ABC", AccountType = "Saving", AccountCurrency = "EUR"},
                new Account { Id = 2, AccountNumber="ABCD", AccountType = "Investment", AccountCurrency = "USD"},
                new Account { Id = 3, AccountNumber="ABCDE", AccountType = "Pension", AccountCurrency = "NOK"},
                new Account { Id = 4, AccountNumber="ABCDEF", AccountType = "Saving", AccountCurrency = "EUR"},
            };

        public Account? AddAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Account DeleteAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public Account? GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public Account UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
