namespace Homework15
{
    public class Vehicle: IComparable<Vehicle>
    {
        public string Model { get; set; }
        public double FuelConsumption { get; set; }
        public int TopSpeed { get; set; }

        public int CompareTo(Vehicle? other)
        {
            return FuelConsumption.CompareTo(other.FuelConsumption);
        }
    }
}