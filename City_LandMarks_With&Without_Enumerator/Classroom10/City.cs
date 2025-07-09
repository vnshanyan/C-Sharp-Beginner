using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom10
{
    internal class City
    {
        private Guid CityId { get; set; } = new();
        public string CityName { get; set; }
        private List<Landmark> Landmarks { get; } = new List<Landmark>();

        public City(string cityName)
        {
            CityId = Guid.NewGuid();
            CityName = cityName;
        }

        public void AddLandMark(Landmark landmark)
        {
            Landmarks.Add(landmark);
        }

        public void PrintInfo()
        {
            foreach (Landmark landmark in Landmarks)
            {
                Console.WriteLine(landmark.LandmarkName);
                Console.WriteLine(landmark.Description);
            }
        }
    }
}
