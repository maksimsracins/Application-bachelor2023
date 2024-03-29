using app_banking.Models;
using Microsoft.EntityFrameworkCore;
using static Config;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }
    public DbSet<Account> Account { get; set; }
    public DbSet<User> User { get; set; }
}