using System.ComponentModel.DataAnnotations;

public enum AccountType
{
    [Display(Name = "Накопительный счёт")]
    SavingAccount = 0,
    [Display(Name = "Инвестиционный счёт")]
    InvestmentAccount = 1,
    [Display(Name = "Дебетовый счёт")]
    CurrentAccount = 2
}