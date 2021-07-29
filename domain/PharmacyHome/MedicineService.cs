using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHome
{
    public class MedicineService
    {
        private readonly IMedicineRepository medicineRepository;

        public MedicineService(IMedicineRepository medicineRepository)
        {
            this.medicineRepository = medicineRepository;
        }

        public Medicine[] GetAllByQuery(string query)
        {
            if (Medicine.IsExpirationDate(query))
                return medicineRepository.GetAllByExpirationDate(query);

            return medicineRepository.GetAllByTitle(query);
        }

    }
}
