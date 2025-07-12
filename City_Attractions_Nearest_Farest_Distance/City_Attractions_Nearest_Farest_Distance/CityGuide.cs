namespace ConsoleApp1
{
    public class CityGuide
    {
        private static Attraction[] attractions =
        {
            new Attraction(0,"name0", "decs0", "category0", 0, 0),
            new Attraction(1,"Metropolitan Museum of Art", "World-class art collection", "Museum", 1, 0),
            new Attraction(2,"Times Square", "Iconic entertainment hub", "Landmark", 2, 0),
            new Attraction(3,"Statue of Liberty", "Symbol of freedom and democracy", "Landmark", 3, 0),
            new Attraction(4,"Empire State Building", "Iconic skyscraper with stunning views", "Landmark", 0, 1),
            new Attraction(5,"Brooklyn Bridge", "Historic suspension bridge", "Landmark", 0, 2),
            new Attraction(6,"Museum of Modern Art", "Contemporary art museum", "Museum", 0, 3),
            new Attraction(7,"High Line", "Elevated park on a historic freight rail line", "Park", 0, 4),
            new Attraction(8,"Broadway", "World-famous theater district", "Landmark", 0, 5)
        };

        public static void CheckDistances(double longtitude, double latitude)
        {
            foreach (Attraction attraction in attractions)
            {
                double distance = Math.Sqrt(Math.Pow((attraction.Latitude - latitude), 2) + Math.Pow((attraction.Longtitude - longtitude), 2));
                Console.WriteLine($"attraction: {attraction.Name}");
                Console.WriteLine($"distance: {distance}");
                Console.WriteLine("_________________");
            }
        }

        public static Attraction? GetNearestAttractionExceptAlreadyBeen(double longtitude, double latitude, Attraction[] alreadyVisitedAttractions) 
        {
            Attraction? nearestAttraction = null;
            double shortestDistance = double.MaxValue;

            foreach (var attraction in attractions)
            {
                if (!alreadyVisitedAttractions.Contains(attraction))
                {
                    double distance = Math.Sqrt(Math.Pow((attraction.Latitude - latitude), 2) + Math.Pow((attraction.Longtitude - longtitude), 2));

                    if (distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        nearestAttraction = attraction;
                    }
                }
            }

            return nearestAttraction;
        }

        public static Attraction? GetFarestAttractionExceptAlreadyBeen(double longtitude, double latitude, Attraction[] alreadyVisitedAttractions)
        {
            Attraction? farestAttraction = null;
            double farestDistance = double.MinValue;

            foreach (Attraction attraction in attractions)
            {
                if (!alreadyVisitedAttractions.Contains(attraction))
                {
                    double distance = Math.Sqrt(Math.Pow(attraction.Latitude - latitude, 2) + Math.Pow(attraction.Longtitude - longtitude, 2));

                    if (distance > farestDistance)
                    {
                        farestDistance = distance;
                        farestAttraction = attraction;
                    }
                }
            }

            return farestAttraction;
        }
    }

}
