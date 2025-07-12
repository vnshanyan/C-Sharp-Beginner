using System.Collections;

namespace Guide_City_Landmarks
{
    public class City: IEnumerable<Landmark>
    {
        public Guid CityId { get; set; }
        public string? CityName { get; set; }
        public List<Landmark> landmarks = new List<Landmark>();

        public void AddLandmark(string landmarkName)
        {
            landmarks.Add(new Landmark { LandmarkName = landmarkName});
        }
    
        public IEnumerator<Landmark> GetEnumerator()
        {
            return new Enumerator(landmarks);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
