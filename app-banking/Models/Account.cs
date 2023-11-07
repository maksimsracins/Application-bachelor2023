using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_banking.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Column(name:"account_type")]
        public string AccountType { get; set; }
        [Column(name:"account_number")]
        public string AccountNumber { get; set; } = string.Empty;
        [Column(name:"account_currency")]
        public string AccountCurrency { get; set; } = string.Empty;
        [Column(name:"user_id")]
        public int User { get; set; } = default!;
        [Column(name:"datecreated")]
        public DateTime DateCreated { get; set; }
    }
}
