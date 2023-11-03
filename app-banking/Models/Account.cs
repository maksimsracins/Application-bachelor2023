namespace app_banking.Models
{
    public class Account
    {
        public int Id { get; set; }
        public AccountType AccountType { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountCurrency { get; set; } = string.Empty;
        public User User { get; set; } = default!;

        public DateTime DateCreated { get; set; }
    }
}
