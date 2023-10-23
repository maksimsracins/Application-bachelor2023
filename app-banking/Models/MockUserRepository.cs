using app_banking.Models.Interfaces;

namespace app_banking.Models
{
    public class MockUserRepository : IUserRepository
    {
        public IEnumerable<User> GetAllUsers =>
            new List<User>()
            {
                new User() { Id = 1, Name = "Name1"},
                new User() { Id = 2, Name = "Name2"},
                new User() { Id = 3, Name = "Name3"},
                new User() { Id = 4, Name = "Name4"},
                new User() { Id = 5, Name = "Name5"},
            };

        public User? GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
