namespace ConsoleApp1
{
    public class Attraction
    {
        public Attraction(int uniqueIdentity, string name, string description, string category, int latitude, int longtitude)
        {
            UniqueIdentity = uniqueIdentity;
            Name = name;
            Description = description;
            Category = category;
            Latitude = latitude;
            Longtitude = longtitude;
            Latitude = latitude;
        }

        public int UniqueIdentity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Latitude { get; set; }
        public int Longtitude { get; set; }
    }
}
