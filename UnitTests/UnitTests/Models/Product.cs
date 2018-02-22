namespace UnitTests.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Product() { }
        public Product(long id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}