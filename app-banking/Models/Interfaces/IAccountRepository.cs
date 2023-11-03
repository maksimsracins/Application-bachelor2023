namespace app_banking.Models.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts { get; }
        Account? AddAccount(Account account);
        Account UpdateAccount(Account account);
        Account DeleteAccount(Account account);
        Account? GetAccountById(int id);
    }
}
