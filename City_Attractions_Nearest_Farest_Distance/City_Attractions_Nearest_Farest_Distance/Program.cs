using ConsoleApp1;

namespace City_Attractions_Nearest_Farest_Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userWantsToSeeAllAttractions = 10;
            Console.WriteLine("Welcome to the City Guide!");

            // Get user's current coordinates
            int userLongitude = GetUserCoordinate("longitude");
            int userLatitude = GetUserCoordinate("latitude");

            // Display all attractions
            Attraction[] attractionsAlreadyBeen = new Attraction[userWantsToSeeAllAttractions];
            //CityGuide.CheckDistances(userLongitude, userLatitude);

            Console.WriteLine("Get Nearest Attractions: ");
            for (int i = 0; i < userWantsToSeeAllAttractions; i++)
            {
                Attraction? attraction = CityGuide.GetNearestAttractionExceptAlreadyBeen(userLongitude, userLatitude, attractionsAlreadyBeen);
                if (attraction == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("No more attractions to show.");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine($"go to attraction : {attraction.Name}");
                userLatitude = attraction.Latitude;
                userLongitude = attraction.Longtitude;
                attractionsAlreadyBeen[i] = attraction;
            }

            Console.WriteLine("Get Farest Attractions: ");
            for (int i = 0; i < userWantsToSeeAllAttractions; i++)
            {
                Attraction? attraction = CityGuide.GetFarestAttractionExceptAlreadyBeen(userLongitude, userLatitude, attractionsAlreadyBeen);
                if (attraction == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("No more attractions to show.");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine($"go to attraction : {attraction.Name}");
                userLatitude = attraction.Latitude;
                userLongitude = attraction.Longtitude;
                attractionsAlreadyBeen[i] = attraction;
            }
        }

        static int GetUserCoordinate(string coordinateType)
        {
            Console.Write($"Enter your {coordinateType}: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
