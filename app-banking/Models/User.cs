using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_banking.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(name:"user_name")]
        public string Name { get; set; } = string.Empty;
        [Column(name:"user_accountid")]
        public int AccountId { get; set; }
        [Column(name:"user_role")]
        public string Role { get; set; }
        [Column(name:"user_password")]
        public long Password { get; set; }
    }
}