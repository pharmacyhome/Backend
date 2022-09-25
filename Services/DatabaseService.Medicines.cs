using PharmacyHome.Types;

namespace PharmacyHome.Services
{
    public partial class DatabaseService
    {
        public Medicine GetMedicineById(Guid id)
        {
            return new Medicine();
        }
        public Medicine GetMedicineByName(string name)
        {
            return new Medicine();
        }

        public ICollection<Medicine> GetAllMedicines()
        {
            return new List<Medicine>();
        }
        public ICollection<Medicine> GetMedicinesByExpireData(DateTime dateTime)
        {
            return new List<Medicine>();
        }
    }
}
