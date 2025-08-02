namespace Homework15
{
    public class RealEstateListings
    {
        public RealEstateListings()
        {
            List<Property> properties = new List<Property>
            {
                new Property { Address = "123 Main St", Price = 120000, Area = 80, NumberOfRooms = 3 },
                new Property { Address = "45 Oak Ave", Price = 200000, Area = 100, NumberOfRooms = 4 },
                new Property { Address = "78 River Rd", Price = 95000, Area = 50, NumberOfRooms = 2 },
            };

            properties.Sort();

            int minRooms = 3;

            foreach (Property property in properties)
            {
                if (property.NumberOfRooms >= minRooms)
                {
                    Console.WriteLine(property.NumberOfRooms);
                }
            }
        }
    }
}
/*
7. RealEstateListings
------------------------------------------------
Topic: IComparable<Property>
Model a `Property` class:
- string Address
- decimal Price
- double Area (square meters)
- int NumberOfRooms
Tasks:
- Sort properties by Price per square meter (Price / Area).
- Bonus: Filter by minimum number of rooms.
*/