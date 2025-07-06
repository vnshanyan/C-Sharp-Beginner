namespace Homework14
{
    public class Product 
    {
        public string Id { get; set; }              // e.g., "burger-001"
        public string Name { get; set; }            // e.g., "Burger"
        public decimal Price { get; set; }          // e.g., 5.99
        public bool IsAvailable { get; set; }       // Whether the item is currently available
        public override string ToString() => $"{Id}: {Name} - {Price:C}";
    }
}
