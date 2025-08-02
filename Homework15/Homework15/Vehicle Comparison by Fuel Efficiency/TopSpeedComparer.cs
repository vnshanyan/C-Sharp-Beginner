namespace Homework15
{
    public class TopSpeedComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle? x, Vehicle? y)
        {
            return y.TopSpeed.CompareTo(x.TopSpeed);
        }
    }
}