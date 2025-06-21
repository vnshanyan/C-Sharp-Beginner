using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Security.Principal;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Globalization;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Data;
using System.Diagnostics.Metrics;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Day Schedule System
            //-----------------------
            //Enum: DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
            //Struct: Schedule { DayOfWeek Day; string Task; }
            //Task: Create 3 schedules and print their contents.

            Schedule schedule1 = new Schedule(DayOfWeek.Monday, "Go to Swimming pool");
            Schedule schedule2 = new Schedule(DayOfWeek.Tuesday, "Go to C# trainings");
            Schedule schedule3 = new Schedule(DayOfWeek.Wednesday, "Go to business school");

            //2. Traffic Light Simulation
            //----------------------------
            //Enum: TrafficLight { Red, Yellow, Green }
            //Struct: Intersection { string Name; TrafficLight CurrentLight; }
            //Task: Create a light cycle method to simulate light changes.
            Intersection intersection = new Intersection("Street name", TrafficLight.Red);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(intersection.CurrentLight);
                intersection.SimulateLightChanges();
                Thread.Sleep(1000);
            }

            //3.Student Grade Levels
            //------------------------
            //Enum: GradeLevel { Freshman, Sophomore, Junior, Senior }
            //Struct: Student { string Name; int Age; GradeLevel Grade; }
            //Task: Create and display two students with different grade levels.

            Student student1 = new Student("Anun1", 10, GradeLevel.Junior);
            Console.WriteLine($"Student: {student1.Name}, Grade: {student1.Grade}");
            Student student2 = new Student("Anun2", 18, GradeLevel.Freshman);
            Console.WriteLine($"Student: {student2.Name}, Grade: {student2.Grade}");

            //4.Weather Reporting
            //---------------------
            //Enum: WeatherType { Sunny, Rainy, Cloudy, Stormy, Snowy }
            //Struct: WeatherReport { string City; WeatherType Weather; int Temperature; }
            //Task: Create and print weather reports for 3 cities.

            WeatherReport weatherReport1 = new WeatherReport("Yerevan", WeatherType.Rainy, 19);
            WeatherReport weatherReport2 = new WeatherReport("Areni", WeatherType.Sunny, 28);
            WeatherReport weatherReport3 = new WeatherReport("Artashat", WeatherType.Snowy, 0);
            Console.WriteLine($"City: {weatherReport1.City}, Type: {weatherReport1.Weather}, Temperature: {weatherReport1.Temperature}");
            Console.WriteLine($"City: {weatherReport2.City}, Type: {weatherReport2.Weather}, Temperature: {weatherReport2.Temperature}");
            Console.WriteLine($"City: {weatherReport3.City}, Type: {weatherReport3.Weather}, Temperature: {weatherReport3.Temperature}");

            //5.Light Bulb State Tracker
            //----------------------------
            //Enum: BulbState { On, Off, Broken }
            //Struct: LightBulb { string Room; BulbState State; int Wattage; }
            //Task: Create a light bulb inventory for a house.

            LightBulb bulb1 = new LightBulb("Living Room", BulbState.On, 60);
            LightBulb bulb2 = new LightBulb("Kitchen", BulbState.Off, 40);
            LightBulb bulb3 = new LightBulb("Bathroom", BulbState.Broken, 75);

            //6.Vehicle Registration
            //------------------------
            //Enum: FuelType { Petrol, Diesel, Electric, Hybrid }
            //Struct: Vehicle { string License; FuelType Fuel; int Year; }
            //Task: Create 5 vehicle entries and sort them by year.

            Vehicle[] vehicles = new Vehicle[5];
            vehicles[0] = new Vehicle("ABC123", FuelType.Petrol, 2015);
            vehicles[1] = new Vehicle("DEF456", FuelType.Electric, 2020);
            vehicles[2] = new Vehicle("GHI789", FuelType.Diesel, 2010);
            vehicles[3] = new Vehicle("JKL012", FuelType.Hybrid, 2018);
            vehicles[4] = new Vehicle("MNO345", FuelType.Petrol, 2012);

            for (int i = 0; i < vehicles.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicles.Length; j++)
                {
                    if (vehicles[i].Year > vehicles[j].Year)
                    {
                        Vehicle temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                }
            }

            for(int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine($"License: {vehicles[i].License}, Fuel: {vehicles[i].Fuel}, Year: {vehicles[i].Year}");
            }

            //7.Bank Account Types
            //----------------------
            //Enum: AccountType { Checking, Savings, Business }
            //Struct: Account { string Holder; AccountType Type; decimal Balance; }
            //Task: Create 3 accounts and calculate total balance.

            Account account1 = new Account("Anun1", AccountType.Savings, 20000);
            Account account2 = new Account("Anun2", AccountType.Business, 3420000);
            Account account3 = new Account("Anun3", AccountType.Checking, 87920000);
            decimal totalBalance = account1.Balance + account2.Balance + account3.Balance;
            Console.WriteLine(totalBalance);

            //8.Product Inventory System
            //----------------------------
            //Enum: ProductCategory { Electronics, Clothing, Food, Tools }
            //Struct: Product { string Name; ProductCategory Category; int Quantity; }
            //Task: Count how many items exist in each category.
            Product[] products = new Product[4];
            products[0] = new Product("Bread", ProductCategory.Food, 30);
            products[1] = new Product("Monitor", ProductCategory.Electronics, 100);
            products[2] = new Product("Mice", ProductCategory.Electronics, 40);
            products[3] = new Product("Keyboard", ProductCategory.Electronics, 10);

            int foodsQuantity = 0;
            int electronicsQuantity = 0;
            int toolsQuantity = 0;
            int clothingQuantity = 0;

            for(int i = 0; i < products.Length; i++)
            {
                switch(products[i].Category)
                {
                    case ProductCategory.Food:
                        foodsQuantity += products[i].Quantity;
                        break;
                    case ProductCategory.Electronics:
                        electronicsQuantity += products[i].Quantity;
                        break;
                    case ProductCategory.Tools:
                        toolsQuantity += products[i].Quantity;
                        break;
                    case ProductCategory.Clothing:
                        clothingQuantity += products[i].Quantity;
                        break;
                }
            }

            Console.WriteLine($"Foods: {foodsQuantity}, Electronics: {electronicsQuantity}, Tools: {toolsQuantity}, Clothing: {clothingQuantity}");

            //9.Patient Blood Type Registry
            //-------------------------------
            //Enum: BloodType { A, B, AB, O }
            //Struct: Patient { string Name; BloodType Type; bool RhPositive; }
            //Task: Group patients by blood type and Rh factor.

            Patient[] patients = new Patient[3];
            patients[0] = new Patient("Anun1", BloodType.A, true);
            patients[1] = new Patient("Anun2", BloodType.B, false);
            patients[2] = new Patient("Anun3", BloodType.B, true);

            int aPositive = 0;
            int aNegative = 0;
            int bPositive = 0;
            int bNegative = 0;
            int abPositive = 0;
            int abNegative = 0;
            int oPositive = 0;
            int oNegative = 0;

            for(int i = 0; i < patients.Length; i++)
            {
                switch(patients[i].Type)
                {
                    case BloodType.A:
                        if (patients[i].RhPositive)
                            aPositive++;
                        else
                            aNegative++;
                        break;
                    case BloodType.B:
                        if (patients[i].RhPositive)
                            bPositive++;
                        else
                            bNegative++;
                        break;
                    case BloodType.AB:
                        if (patients[i].RhPositive)
                            abPositive++;
                        else
                            abNegative++;
                        break;
                    case BloodType.O:
                        if (patients[i].RhPositive)
                            oPositive++;
                        else
                            oNegative++;
                        break;
                }
            }

            Console.WriteLine($"A - Positive: {aPositive}, Negative: {aNegative}");
            Console.WriteLine($"B - Positive: {bPositive}, Negative: {bNegative}");
            Console.WriteLine($"AB - Positive: {abPositive}, Negative: {abNegative}");
            Console.WriteLine($"O - Positive: {oPositive}, Negative: {oNegative}");

            //10.Movie Library
            //------------------
            //Enum: Genre { Action, Drama, Comedy, Horror, SciFi }
            //Struct: Movie { string Title; Genre Genre; double Rating; }
            //Task: Filter movies with rating above 7.5 and group by genre.

            Movie[] movies = new Movie[6];
            movies[0] = new Movie("A", Genre.Action, 8);
            movies[1] = new Movie("B", Genre.Drama, 10);
            movies[2] = new Movie("C", Genre.SciFi, 6);
            movies[3] = new Movie("D", Genre.Horror, 2);
            movies[4] = new Movie("E", Genre.Action, 10);
            movies[5] = new Movie("F", Genre.SciFi, 9);

            int actionsQuantity = 0;
            int dramasQuantity = 0;
            int comediesQuantity = 0;
            int horrorsQuantity = 0;
            int scifiesQuantity = 0;

            for(int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > 7.5)
                {
                    switch(movies[i].Genre)
                    {
                        case Genre.Action:
                            actionsQuantity++;
                            break;
                        case Genre.Drama:
                            dramasQuantity++;
                            break;
                        case Genre.Comedy:
                            comediesQuantity++;
                            break;
                        case Genre.Horror:
                            horrorsQuantity++;
                            break;
                        case Genre.SciFi:
                            scifiesQuantity++;
                            break;
                    }
                }
            }
            Console.WriteLine($"Action: {actionsQuantity}");
            Console.WriteLine($"Drama: {dramasQuantity}");
            Console.WriteLine($"Comedy: {comediesQuantity}");
            Console.WriteLine($"Horror: {horrorsQuantity}");
            Console.WriteLine($"SciFi: {scifiesQuantity}");

            //11.Order Processing System
            //----------------------------
            //Enum: OrderStatus { Pending, Processing, Shipped, Delivered, Cancelled }
            //Struct: Order { int Id; string Product; OrderStatus Status; }
            //Task: Create a list of orders and show how many are pending.

            int pendingProductsCount = 0;

            List<Order> orders = new List<Order>
            {
                new Order(0, "Product1", OrderStatus.Processing),
                new Order(1, "Product2", OrderStatus.Pending),
                new Order(2, "Product3", OrderStatus.Shipped),
                new Order(3, "Product4", OrderStatus.Pending),
                new Order(4, "Product5", OrderStatus.Cancelled),
            };

            for(int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Status == OrderStatus.Pending)
                {
                    pendingProductsCount++;
                }
            }
            Console.WriteLine(pendingProductsCount);


            //12.Parking Lot Tracker
            //------------------------
            //Enum: SpotSize { Small, Medium, Large }
            //Struct: ParkingSpot { int Number; SpotSize Size; bool Occupied; }
            //Task: Count how many spots are available by size.

            int largeAvailable = 0;
            int mediumAvailable = 0;
            int smallAvailable = 0;

            List<ParkingSpot> parkings = new List<ParkingSpot>()
            {
                new ParkingSpot(0, SpotSize.Large, true),
                new ParkingSpot(1, SpotSize.Medium, false),
                new ParkingSpot(2, SpotSize.Small, true),
                new ParkingSpot(3, SpotSize.Medium, false),
            };

            for(int i = 0; i < parkings.Count; i++)
            {
                if(!parkings[i].Occupied)
                {
                    switch (parkings[i].Size)
                    {
                        case SpotSize.Large:
                            largeAvailable++;
                            break;
                        case SpotSize.Medium:
                            mediumAvailable++;
                            break;
                        case SpotSize.Small:
                            smallAvailable++;
                            break;
                    }
                }
            }

            Console.WriteLine($"Small: {smallAvailable}");
            Console.WriteLine($"Medium: {mediumAvailable}");
            Console.WriteLine($"Large: {largeAvailable}");

            //13.Library Book Lending System
            //--------------------------------
            //Enum: BookStatus { Available, CheckedOut, Reserved }
            //Struct: Book { string Title; string Author; BookStatus Status; }
            //Task: Simulate lending a book and update its status.
            string author = "Author1";
            string title = "Title1";

            List<Book> books = new List<Book>()
            {
                new Book("Title1", "Author1", BookStatus.Available),
                new Book("Title2", "Author2", BookStatus.Reserved),
                new Book("Title3", "Author3", BookStatus.CheckedOut),
                new Book("Title4", "Author4", BookStatus.Available),
                new Book("Title5", "Author5", BookStatus.Reserved),
            };

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title && books[i].Author == author && BookStatus.Available == books[i].Status)
                {
                    Console.WriteLine("The book is available!");
                    break;
                }
                else if(i == books.Count - 1)
                {
                    Console.WriteLine("Reserved or checked out.");
                }
            }

            //14.Hotel Room Booking
            //-----------------------
            //Enum: RoomType { Single, Double, Suite }
            //Struct: Room { int Number; RoomType Type; bool IsBooked; }
            //Task: List all unbooked rooms sorted by type.
            int suiteCount = 0;
            int singleCount = 0;
            int doubleCount = 0;
            List<Room> rooms = new List<Room>
            {
                new Room(1, RoomType.Suite, true),
                new Room(2, RoomType.Single, false),
                new Room(3, RoomType.Double, false),
                new Room(4, RoomType.Double, false),
            };

            for(int i = 0; i < rooms.Count; i++)
            {
                if (!rooms[i].IsBooked)
                {
                    switch(rooms[i].Type)
                    {
                        case RoomType.Suite:
                            suiteCount++;
                            break;
                        case RoomType.Single:
                            singleCount++;
                            break;
                        case RoomType.Double:
                            doubleCount++;
                            break;
                    }
                }
            }
            Console.WriteLine($"Suite: {suiteCount}");
            Console.WriteLine($"Double: {doubleCount}");
            Console.WriteLine($"Single: {singleCount}");

            //15.Car Manufacturing Tracker
            //------------------------------
            //Enum: CarModel { Sedan, SUV, Truck, Coupe }
            //Enum: FuelType { Petrol, Diesel, Electric, Hybrid }
            //Struct: Car { string VIN; CarModel Model; FuelType Fuel; DateTime ManufactureDate; }
            //Task: Generate 5 cars and group by model.

            List<Car> cars = new List<Car>() 
            {
                new Car("VIN1", CarModel.SUV, FuelType.Electric, DateTime.Now),
                new Car("VIN2", CarModel.Sedan, FuelType.Diesel, DateTime.Now),
                new Car("VIN3", CarModel.Truck, FuelType.Hybrid, DateTime.Now),
                new Car("VIN4", CarModel.Coupe, FuelType.Petrol, DateTime.Now),
                new Car("VIN5", CarModel.SUV, FuelType.Diesel, DateTime.Now),
            };

            Dictionary<CarModel, List<Car>> grouped = new Dictionary<CarModel, List<Car>>();
            for(int i = 0; i < cars.Count; i++)
            {
                if (!grouped.ContainsKey(cars[i].Model))
                {
                    grouped[cars[i].Model] = new List<Car>();
                }
                grouped[cars[i].Model].Add(cars[i]);
            }

            foreach (var kvp in grouped)
            {
                Console.WriteLine($"Model: {kvp.Key}");
                foreach (Car car in kvp.Value)
                {
                    Console.WriteLine(car.VIN);
                    Console.WriteLine(car.Fuel);
                }
                Console.WriteLine();
            }

            //16.Stock Movement Logging
            //---------------------------
            //Enum: MovementType { Inbound, Outbound, Transfer }
            //Struct: StockMovement { string SKU; MovementType Type; DateTime Date; int Quantity; }
            //Task: Calculate total inbound and outbound quantity for a product.

            List<StockMovement> stockMovements = new List<StockMovement>()
            {
                new StockMovement("SKU1", MovementType.Inbound, DateTime.Now, 20),
                new StockMovement("SKU2", MovementType.Outbound, DateTime.Now, 300),
                new StockMovement("SKU1", MovementType.Inbound, DateTime.Now, 30),
                new StockMovement("SKU1", MovementType.Inbound, DateTime.Now, 1000),
                new StockMovement("SKU2", MovementType.Outbound, DateTime.Now, 10),
            };

            string sku = "SKU1";
            int inboundTotal = 0;
            int outboundTotal = 0;

            for(int i = 0; i < stockMovements.Count; i++)
            {
                if (stockMovements[i].SKU == sku)
                {
                    switch(stockMovements[i].Type)
                    {
                        case MovementType.Inbound:
                            inboundTotal += stockMovements[i].Quantity;
                            break;
                        case MovementType.Outbound:
                            outboundTotal += stockMovements[i].Quantity;
                            break;
                    }
                }
            }
            Console.WriteLine($"Total Inbound: {inboundTotal}");
            Console.WriteLine($"Total Outbound: {outboundTotal}");

            //17.Airline Seat Allocation
            //----------------------------
            //Enum: SeatClass { Economy, Business, First }
            //Struct: FlightSeat { int SeatNumber; SeatClass Class; bool IsBooked; }
            //Task: Allocate and count remaining available seats by class.

            int economyQuantity = 0;
            int businessQuantity = 0;
            int firstQuantity = 0;

            List<FlightSeat> flightSeats = new List<FlightSeat>()
            {
                new FlightSeat(1, SeatClass.Economy, true),
                new FlightSeat(2, SeatClass.Business, true),
                new FlightSeat(3, SeatClass.First, true),
                new FlightSeat(4, SeatClass.Economy, true),
                new FlightSeat(5, SeatClass.Business, false),
                new FlightSeat(6, SeatClass.First, false),
            };

            for(int i = 0; i < flightSeats.Count; i++)
            {
                if (!flightSeats[i].IsBooked)
                {
                    switch (flightSeats[i].Class)
                    {
                        case SeatClass.First:
                            firstQuantity++;
                            break;
                        case SeatClass.Business:
                            businessQuantity++;
                            break;
                        case SeatClass.Economy:
                            economyQuantity++;
                            break;
                    }
                }
            }
            Console.WriteLine($"Economy: {economyQuantity}");
            Console.WriteLine($"Business: {businessQuantity}");
            Console.WriteLine($"First: {firstQuantity}");

            //18.Employee Shift Scheduler
            //-----------------------------
            //Enum: ShiftType { Morning, Evening, Night }
            //Struct: Shift { string Employee; ShiftType Shift; DateTime Date; }
            //Task: Group employees by shift and count them.

            List<Shift> shifts = new List<Shift>()
            {
                new Shift("Anun1", ShiftType.Night, DateTime.Now),
                new Shift("Anun2", ShiftType.Evening, DateTime.Now),
                new Shift("Anun3", ShiftType.Morning, DateTime.Now),
                new Shift("Anun4", ShiftType.Evening, DateTime.Now),
                new Shift("Anun5", ShiftType.Night, DateTime.Now),
            };

            Dictionary<ShiftType, List<Shift>> groupedShifts = new Dictionary<ShiftType, List<Shift>>();
            for (int i = 0; i < shifts.Count; i++)
            {
                if (!groupedShifts.ContainsKey(shifts[i].Shift_))
                {
                    groupedShifts[shifts[i].Shift_] = new List<Shift>();
                }
                groupedShifts[shifts[i].Shift_].Add(shifts[i]);
            }

            foreach (var kvp in groupedShifts)
            {
                Console.WriteLine($"Shift Type: {kvp.Key}");
                foreach (Shift shift in kvp.Value)
                {
                    Console.WriteLine(shift.Employee);
                }
                Console.WriteLine();
            }

            //19.City Transport Routes
            //--------------------------
            //Enum: TransportType { Bus, Tram, Metro, Ferry }
            //Struct: Route { int RouteId; TransportType Type; int Stops; }
            //Task: Calculate average number of stops by transport type.

            List<Route> routes = new List<Route>()
            {
                new Route(1, TransportType.Ferry, 4),
                new Route(2, TransportType.Bus, 7),
                new Route(3, TransportType.Tram, 10),
                new Route(4, TransportType.Metro, 4),
                new Route(5, TransportType.Ferry, 14),
                new Route(6, TransportType.Bus, 9),
            };

            int sumFerry = 0;
            int sumBus = 0;
            int sumTram = 0;
            int sumMetro = 0;

            int quantityFerry = 0;
            int quantityBus = 0;
            int quantityTram = 0;
            int quantityMetro = 0;

            for (int i = 0; i < routes.Count; i++)
            {
                switch (routes[i].Type)
                {
                    case TransportType.Ferry:
                        sumFerry += routes[i].Stops;
                        quantityFerry++;
                        break;
                    case TransportType.Bus:
                        sumBus += routes[i].Stops;
                        quantityBus++;
                    break;
                    case TransportType.Metro:
                        sumMetro += routes[i].Stops;
                        quantityMetro++;
                    break;
                    case TransportType.Tram:
                        sumTram += routes[i].Stops;
                        quantityTram++;
                    break;
                }
            }
            Console.WriteLine($"Ferry: {sumFerry/quantityFerry}");
            Console.WriteLine($"Bus: {sumBus / quantityBus}");
            Console.WriteLine($"Metro: {sumMetro / quantityMetro}");
            Console.WriteLine($"Tram: {sumTram / quantityTram}");

            //20.Smart Home Device Monitor
            //------------------------------
            //Enum: DeviceType { Light, Thermostat, DoorLock }
            //Enum: DeviceState { On, Off, Standby, Malfunctioning }
            //Struct: SmartDevice { string Name; DeviceType Type; DeviceState State; }
            //Task: Change device states based on conditions and count offline devices.

            List<SmartDevice> smartDevices = new List<SmartDevice>()
            {
                new SmartDevice("Device1", DeviceType.Thermostat, DeviceState.On),
                new SmartDevice("Device2", DeviceType.Light, DeviceState.Off),
                new SmartDevice("Device3", DeviceType.DoorLock, DeviceState.Malfunctioning),
                new SmartDevice("Device4", DeviceType.Light, DeviceState.Standby),
                new SmartDevice("Device5", DeviceType.Thermostat, DeviceState.Off),
            };

            for (int i = 0; i < smartDevices.Count; i++)
            {
                if (smartDevices[i].State == DeviceState.Standby)
                {
                    SmartDevice updated = smartDevices[i];
                    updated.State = DeviceState.On;
                    smartDevices[i] = updated;
                }
            }

            int offlineCount = 0;
            for (int i = 0; i < smartDevices.Count; i++)
            {
                if (smartDevices[i].State == DeviceState.Off || smartDevices[i].State == DeviceState.Malfunctioning)
                {
                    offlineCount++;
                }
            }

            Console.WriteLine(offlineCount);
        }
    }

    public enum DeviceState { On, Off, Standby, Malfunctioning }
    public enum DeviceType { Light, Thermostat, DoorLock }
    public enum TransportType { Bus, Tram, Metro, Ferry }
    public enum ShiftType { Morning, Evening, Night }
    public enum SeatClass { Economy, Business, First }
    public enum MovementType { Inbound, Outbound, Transfer }
    public enum FuelType { Petrol, Diesel, Electric, Hybrid }
    public enum CarModel { Sedan, SUV, Truck, Coupe }
    public enum RoomType { Single, Double, Suite }
    public enum BookStatus { Available, CheckedOut, Reserved }
    public enum SpotSize { Small, Medium, Large, }
    public enum OrderStatus { Pending, Processing, Shipped, Delivered, Cancelled, }
    public enum Genre { Action, Drama, Comedy, Horror, SciFi, }
    public enum BloodType { A, B, AB, O, }
    public enum ProductCategory { Electronics, Clothing, Food, Tools, }
    public enum AccountType { Checking, Savings, Business, }
    public enum BulbState { On, Off, Broken, }
    public enum WeatherType { Sunny, Rainy, Cloudy, Stormy, Snowy, }
    public enum GradeLevel { Freshman, Sophomore, Junior, Senior, }
    public enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, }
    public enum TrafficLight { Red, Yellow, Green, }

    public struct Schedule
    {
        public DayOfWeek Day { get; set; }
        public string Task { get; set; }

        public Schedule(DayOfWeek day, string task)
        {
            Day = day;
            Task = task;
        }
    }

    public struct Intersection
    {
        string Name { get; set; }
        public TrafficLight CurrentLight { get; set; }

        public Intersection(string name, TrafficLight currentLight)
        {
            Name = name;
            CurrentLight = currentLight;
        }

        public void SimulateLightChanges()
        {
            switch(CurrentLight)
            {
                case TrafficLight.Red:
                    CurrentLight = TrafficLight.Green;
                    break;
                case TrafficLight.Yellow:
                    CurrentLight = TrafficLight.Red;
                    break;
                case TrafficLight.Green:
                    CurrentLight = TrafficLight.Yellow;
                    break;
            }
        }
    }
    public struct Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public GradeLevel Grade { get; set; }

        public Student(string name, int age, GradeLevel grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }

    public struct WeatherReport
    {
        public string City { get; set; }
        public WeatherType Weather { get; set; }
        public int Temperature { get; set; }

        public WeatherReport(string city, WeatherType weather, int temperature)
        {
            City = city;
            Weather = weather;
            Temperature = temperature;
        }
    }

    public struct LightBulb {
        public string Room { get; set; }
        public BulbState State { get; set; }
        public int Wattage { get; set; }

        public LightBulb(string room, BulbState state, int wattage)
        {
            Room = room;
            State = state;
            Wattage = wattage;
        }
    }

    public struct Vehicle
    {
        public string License { get; set; }
        public FuelType Fuel { get; set; }
        public int Year { get; set; }

        public Vehicle(string license, FuelType fuel, int year)
        {
            License = license;
            Fuel = fuel;
            Year = year;
        }
    }

    public struct Account
    {
        public string Holder { get; set; }
        public AccountType Type { get; set; }
        public decimal Balance { get; set; }

        public Account(string holder, AccountType type, decimal balance)
        {
            Holder = holder;
            Type = type;
            Balance = balance;
        }
    }

    public struct Product 
    { 
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public int Quantity { get; set; }

        public Product(string name, ProductCategory category, int quantity)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
        }
    }

    public struct Patient 
    { 
        public string Name { get; set; }
        public BloodType Type { get; set; }
        public bool RhPositive { get; set; }

        public Patient(string name, BloodType type, bool rhPositive)
        {
            Name = name;
            Type = type;
            RhPositive = rhPositive;
        }
    }

    public struct Movie 
    { 
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }

        public Movie(string title, Genre genre, double rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }
    }

    public struct Order 
    { 
        public int Id { get; set; }
        public string Product { get; set; }
        public OrderStatus Status { get; set; }
        public Order(int id, string product, OrderStatus status)
        {
            Id = id;
            Product = product;
            Status = status;
        }
    }

    public struct ParkingSpot 
    {
        public int Number { get; set; }
        public SpotSize Size { get; set; }
        public bool Occupied { get; set; }
        public ParkingSpot(int number, SpotSize size, bool occupied)
        {
            Number = number;
            Size = size;
            Occupied = occupied;
        }
    }

    public struct Book 
    { 
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }

        public Book(string title, string author, BookStatus status)
        {
            Title = title;
            Author = author;
            Status = status;
        }
    }

    public struct Room 
    { 
        public int Number { get; set; }
        public RoomType Type { get; set; }
        public bool IsBooked { get; set; }

        public Room(int number, RoomType type, bool isBooked)
        {
            Number = number;
            Type = type;
            IsBooked = isBooked;
        }
    }

    public struct Car 
    { 
        public string VIN { get; set; }
        public CarModel Model { get; set; }
        public FuelType Fuel { get; set; }
        public DateTime ManufactureDate { get; set; }
        public Car(string vin, CarModel model, FuelType fuel, DateTime manufactureDate)
        {
            VIN = vin;
            Model = model;
            Fuel = fuel;
            ManufactureDate = manufactureDate;
        }
    }

    public struct StockMovement 
    { 
        public string SKU { get; set; }
        public MovementType Type { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public StockMovement(string sku, MovementType type, DateTime date, int quantity)
        {
            SKU = sku;
            Type = type;
            Date = date;
            Quantity = quantity;
        }
    }

    public struct FlightSeat 
    { 
        public int SeatNumber { get; set; }
        public SeatClass Class { get; set; }
        public bool IsBooked { get; set; }

        public FlightSeat(int seatNumber, SeatClass seatClass, bool isBooked)
        {
            SeatNumber = seatNumber;
            Class = seatClass;
            IsBooked = isBooked;
        }
    }

    public struct Shift 
    { 
        public string Employee { get; set; }
        public ShiftType Shift_ { get; set; }
        public DateTime Date { get; set; }
        public Shift(string employee, ShiftType shift, DateTime date)
        {
            Employee = employee;
            Shift_ = shift;
            Date = date;
        }
    }

    public struct Route 
    { 
        public int RouteId { get; set; }
        public TransportType Type { get; set; }
        public int Stops { get; set; }
        public Route(int routeId, TransportType type, int stops)
        {
            RouteId = routeId;
            Type = type;
            Stops = stops;
        }
    }

    public struct SmartDevice 
    { 
        public string Name { get; set; }
        public DeviceType Type { get; set; }
        public DeviceState State { get; set; }

        public SmartDevice(string name, DeviceType type, DeviceState state)
        {
            Name = name;
            Type = type;
            State = state;
        }
    }
}
