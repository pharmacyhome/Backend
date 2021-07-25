using System.Text.RegularExpressions;

namespace PharmacyHome
{
    public class Medicine
    {
        public int Id { get; }
        public string Name { get; }
        public string ExpirationDate { get; }
        public string Title { get; }
        public string Description { get; }
        public int Dosage { get; }
        public int Amount { get; }



        public Medicine(int id, string name, string title, string expirationDate, string description, int dosage, int amount)
        {
            Id = id;
            Name = name;
            Title = title;
            ExpirationDate = expirationDate;
            Description = description;
            Dosage = dosage;
            Amount = amount;
        }
        internal static bool IsExpirationDate(string s)
        {
            if (s == null)
                return false;

            s = s.Replace("/", ".")
                 .Replace(",", ".");

            return Regex.IsMatch(s, @"\d{1,2}.\d{2,4}");
        }

    }
}
