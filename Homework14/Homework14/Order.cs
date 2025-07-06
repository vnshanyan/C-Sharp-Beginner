namespace Homework14
{
    public class Order
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public List<Product> Items { get; set; } = new();
        public decimal TotalPrice { get; set; }
        public StatusTypes Status { get; set; } = StatusTypes.Placed;

    }
}
