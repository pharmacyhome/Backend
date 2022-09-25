using PharmacyHome.Types;

namespace PharmacyHome.Services
{
    public interface IDatabase
    {
        // Users
        public User GetUserById(Guid id);
        public User GetUserByLogin(string login);
        public ICollection<User> GetAllUsers();

        // Medicines
        public Medicine GetMedicineById(Guid id);
        public Medicine GetMedicineByName(string name);
        public ICollection<Medicine> GetAllMedicines();
        public ICollection<Medicine> GetMedicinesByExpireData(DateTime dateTime);
        

    }
}
