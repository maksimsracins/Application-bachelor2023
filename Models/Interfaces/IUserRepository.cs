namespace app_banking.Models.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers { get; }
        User? GetUserById(int id);
    }
}
