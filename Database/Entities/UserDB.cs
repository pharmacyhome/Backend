using PharmacyHome.Types;

namespace PharmacyHome.Database
{
    public class UserDB : IEntity
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
