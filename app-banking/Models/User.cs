﻿namespace app_banking.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Account>? Accounts { get; set; }
    }
}