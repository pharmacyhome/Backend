using PharmacyHome.Types;

namespace PharmacyHome.Services
{
    public partial class DatabaseService
    {
        public User GetUserById(Guid id)
        {
            return new User();   
        }

        public User GetUserByLogin(string login)
        {
            return new User();
        }

        public ICollection<User> GetAllUsers()
        {
            return new List<User>();
        }
    }
}
