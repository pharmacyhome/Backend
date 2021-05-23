using System.Linq;

namespace PharmacyHome.Memory
{
    public class MedicineRepository : IMedicineRepository

    {
        private readonly Medicine[] medicines = new[]
        {
            new Medicine(1, "Омепразол"),
            new Medicine(2, "Парацетамол"),
            new Medicine(3, "Корвалол")
        };
        public Medicine[] GetAllByTitle(string titlePart)
        {
            return medicines.Where(m => m.Title.Contains(titlePart))
                             .ToArray();
        }
    }
}
