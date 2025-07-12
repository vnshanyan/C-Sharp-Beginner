using Guide_City_Landmarks;

namespace City_Landmarks_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City? yerevan = new City();
            yerevan.AddLandmark("Landmark1");
            yerevan.AddLandmark("Landmark2");
            yerevan.AddLandmark("Landmark3");
            yerevan.AddLandmark("Landmark4");
            yerevan.AddLandmark("Landmark5");

            foreach (Landmark landmark in yerevan)
            {
                Console.WriteLine(landmark.LandmarkName);
            }
        }
    }
}
