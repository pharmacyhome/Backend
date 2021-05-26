using System;


namespace PharmacyHome
{
    public class Medicine
    {
        public int Id { get; }
        public string ExpirationDate { get; }
        public string Title { get; }

        public Medicine(int id, string title, string expirationDate)
        {
            Id = id;            
            Title = title;
            ExpirationDate = expirationDate;
        }
        internal static bool IsExpirationDate(string s)
        {
            return false;
        }

    }
}
