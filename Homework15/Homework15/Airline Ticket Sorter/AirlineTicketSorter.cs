namespace Homework15
{
    public class AirlineTicketSorter
    {
        public AirlineTicketSorter()
        {
            List<Ticket> tickets = new List<Ticket>
            {
                new Ticket { PassengerName = "Alice", DepartureTime = new DateTime(2025, 7, 31, 9, 0, 0), Price = 200m },
                new Ticket { PassengerName = "Bob", DepartureTime = new DateTime(2025, 7, 31, 7, 30, 0), Price = 150m },
                new Ticket { PassengerName = "Charlie", DepartureTime = new DateTime(2025, 7, 31, 11, 15, 0), Price = 300m }
            };

            tickets.Sort();

            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket.DepartureTime);
                Console.WriteLine("_________________");
            }

            tickets.Sort(new PriceComparer());
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket.Price);
                Console.WriteLine("_________________");
            }
        }
    }
}
/*
6. AirlineTicketSorter
------------------------------------------------
Topic: IComparable<Ticket>
Create a `Ticket` class:
- string PassengerName
- DateTime DepartureTime
- decimal Price
Tasks:
- Sort tickets by DepartureTime (ascending).
- Bonus: Implement a custom comparer `PriceComparer` for sorting by Price.
*/