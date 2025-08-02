namespace Homework15
{
    public class Property: IComparable<Property>
    {
        public string Address { get; set; }
        public decimal Price { get; set; }
        public double Area { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal PricePerSquareMeter
        {
            get
            {
                return Area > 0 ? Price / (decimal)Area : 0;
            }
        }

        public int CompareTo(Property? other)
        {
            return PricePerSquareMeter.CompareTo(other.PricePerSquareMeter);
        }
    }
}