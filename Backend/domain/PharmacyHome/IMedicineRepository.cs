using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHome
{
    public interface IMedicineRepository
    {
        Medicine[] GetAllByExpirationDate(string expirationDate);
        Medicine[] GetAllByTitle(string titlePart);   
    }
}
