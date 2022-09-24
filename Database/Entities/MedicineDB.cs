using PharmacyHome.Types;

namespace PharmacyHome.Database
{
    public class MedicineDB : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Price { get; set; }
    }
}
