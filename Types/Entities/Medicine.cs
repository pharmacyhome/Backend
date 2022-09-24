namespace PharmacyHome.Types.Entities
{
    public class Medicine : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Price { get; set; }
    }
}
