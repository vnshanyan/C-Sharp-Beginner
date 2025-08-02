namespace Homework15
{
    public class PriceComparer : IComparer<Ticket>
    {
        public int Compare(Ticket? x, Ticket? y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
}