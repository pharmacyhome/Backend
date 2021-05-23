
namespace PharmacyHome
{
    public class Medicine
    {
        public int Id { get; }
        public string Title { get; }

        public Medicine(int id, string title)
        {
            Id = id;
            Title = title;
        }

    }
}
