using app_banking.Models.Interfaces;

namespace app_banking.Models.Repository;

public class UserRepository : IUserRepository
{
    private protected ApplicationContext _applicationContext;

    public UserRepository(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }
    
    public IEnumerable<User> GetAllUsers
    {
        get
        {
            return _applicationContext.Users.ToList();
        }
    }

    public User? GetUserById(int id)
    {
        throw new NotImplementedException();
    }
}