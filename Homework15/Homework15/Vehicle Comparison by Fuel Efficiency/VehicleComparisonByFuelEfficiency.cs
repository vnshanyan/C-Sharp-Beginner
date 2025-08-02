namespace Homework15
{
    public class VehicleComparisonByFuelEfficiency
    {
        public VehicleComparisonByFuelEfficiency()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Vehicle { Model = "EcoCar X", FuelConsumption = 3.8, TopSpeed = 180 },
                new Vehicle { Model = "Speedster Z", FuelConsumption = 8.5, TopSpeed = 250 },
                new Vehicle { Model = "FamilyVan V", FuelConsumption = 6.2, TopSpeed = 160 }
            };

            // Sort by fuel efficiency (lower consumption is better)
            vehicles.Sort();
            Console.WriteLine("Sorted by Fuel Consumption:");
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.FuelConsumption);
            }

            // Bonus: Sort by TopSpeed (descending)
            vehicles.Sort(new TopSpeedComparer());
            Console.WriteLine("\nSorted by Top Speed (Descending):");
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v.TopSpeed);
            }
        }
    }
}
/*
9. VehicleComparisonByFuelEfficiency
------------------------------------------------
Topic: IComparable<Vehicle>
Model a `Vehicle` class:
- string Model
- double FuelConsumption (liters per 100km)
- int TopSpeed
Tasks:
- Sort vehicles by FuelConsumption (lower is better).
- Allow custom sorting by TopSpeed (descending).
*/