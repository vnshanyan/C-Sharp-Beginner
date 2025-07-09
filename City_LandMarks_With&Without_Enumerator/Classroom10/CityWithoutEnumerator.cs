using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom10
{
    internal class CityWithoutEnumerator
    {
        private Guid CityId { get; set; } = new();
        public string CityName { get; set; }
        private List<Landmark> Landmarks { get; } = new List<Landmark>();

        public CityWithoutEnumerator(string cityName)
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

        public GuideWithoutEnumerator GetEnumerator()
        {
            return new GuideWithoutEnumerator(Landmarks);
        }

    }
}
