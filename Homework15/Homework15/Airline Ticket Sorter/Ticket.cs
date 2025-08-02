namespace Homework15
{
    public class Ticket: IComparable<Ticket>
    {
        public string? PassengerName { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Ticket? other)
        {
            return DepartureTime.CompareTo(other.DepartureTime);
        }
    }
}