
namespace Classroom10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_________________With Enumerator_______________________

            Console.WriteLine("WITH ENUMERATOR");
            List<CityWithEnumerator> cities = new List<CityWithEnumerator>()
            {
                new CityWithEnumerator("Yerevan"),
                new CityWithEnumerator("Vanadzor"),
                new CityWithEnumerator("Sevan"),
                new CityWithEnumerator("Masis"),
            };

            foreach (CityWithEnumerator city in cities)
            {
                Landmark landmark1 = new Landmark(Guid.NewGuid(), "Landmark1", "Description1");
                Landmark landmark2 = new Landmark(Guid.NewGuid(), "Landmark2", "Description2");
                Landmark landmark3 = new Landmark(Guid.NewGuid(), "Landmark3", "Description3");
                Landmark landmark4 = new Landmark(Guid.NewGuid(), "Landmark4", "Description4");
                city.AddLandMark(landmark1);
                city.AddLandMark(landmark2);
                city.AddLandMark(landmark3);
                city.AddLandMark(landmark4);
            }

            foreach (CityWithEnumerator city in cities)
            {
                Console.WriteLine($"City: {city.CityName}");
                Console.WriteLine("Landmarks:");
                city.PrintInfo();
                Console.WriteLine("_____________________________");
            }


            //_________________Without Enumerator_______________________

            Console.WriteLine("WITHOUT ENUMERATOR");
            List<CityWithoutEnumerator> cities1 = new List<CityWithoutEnumerator>()
            {
                new CityWithoutEnumerator("Yerevan"),
                new CityWithoutEnumerator("Vanadzor"),
                new CityWithoutEnumerator("Sevan"),
                new CityWithoutEnumerator("Masis"),
            };

            foreach (CityWithoutEnumerator city in cities1)
            {
                Landmark landmark1 = new Landmark(Guid.NewGuid(), "Landmark1", "Description1");
                Landmark landmark2 = new Landmark(Guid.NewGuid(), "Landmark2", "Description2");
                Landmark landmark3 = new Landmark(Guid.NewGuid(), "Landmark3", "Description3");
                Landmark landmark4 = new Landmark(Guid.NewGuid(), "Landmark4", "Description4");
                city.AddLandMark(landmark1);
                city.AddLandMark(landmark2);
                city.AddLandMark(landmark3);
                city.AddLandMark(landmark4);
            }


            foreach (CityWithoutEnumerator city in cities1)
            {
                Console.WriteLine($"City: {city.CityName}");
                Console.WriteLine("Landmarks:");
                city.PrintInfo();
                Console.WriteLine("_____________________________");
            }
        }
    }
}