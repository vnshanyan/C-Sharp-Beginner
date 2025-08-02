namespace Homework15
{
    public class Product: IComparable<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }

        public int CompareTo(Product? other)
        {
            if (other is null) return 1;
            return Price.CompareTo(other.Price);
        }
    }
}