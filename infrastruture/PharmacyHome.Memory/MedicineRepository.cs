using System.Linq;
using System;

namespace PharmacyHome.Memory
{
    public class MedicineRepository : IMedicineRepository

    {
        private readonly Medicine[] medicines = new[]
        {
            new Medicine(1, "Омепразол", "Омез", "03.2022"),
            new Medicine(2, "Парацетамол", "Терафлю", "05.2022"),
            new Medicine(3, "Цинк", "Зиннерит", "01.2023")
        };

        public Medicine[] GetAllByExpirationDate(string expirationDate)
        {
            throw new NotImplementedException();
        }

        public Medicine[] GetAllByTitle(string titlePart)
        {
            return medicines.Where(m => m.Title.Contains(titlePart))
                             .ToArray();
        }
    }
}
