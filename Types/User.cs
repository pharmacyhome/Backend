namespace PharmacyHome.Types
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
