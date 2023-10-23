namespace app_banking.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public string AccountCurrency { get; set; } = string.Empty;
        public User User { get; set; } = default!;
    }
}
