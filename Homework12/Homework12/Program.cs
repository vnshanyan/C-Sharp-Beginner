using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Book Struct
            //--------------
            //Struct: Book { string Title; string Author; int Year; }
            //Task: Create a constructor to initialize all properties.
            Book book1 = new Book("Title1", "Author1", 2025);

            //2.Rectangle Area Calculator
            //----------------------------
            //Struct: Rectangle { int Width; int Height; }
            //Task: Create a constructor to initialize width/ height and a method to return area.

            Rectangle rectangle1 = new Rectangle(10, 20);
            //Console.WriteLine(rectangle1.GetArea());

            //3.Point in 2D Space
            //--------------------
            //Struct: Point2D { double X; double Y; }
            //Task: Use a constructor for coordinates and print them.

            Point2D point2D = new Point2D(10,20);
            //point2D.PrintInfo();

            //4.Employee Info
            //----------------
            //Struct: Employee { string Name; int Id; decimal Salary; }
            //Task: Use a constructor to initialize name, ID, and salary.
            Employee employee = new Employee("Name1", 2, 20000000);

            //5.Temperature Record
            //---------------------
            //Struct: Temperature { string City; double Celsius; DateTime Date; }
            //Task: Constructor takes all three values.
            Temperature temperature = new Temperature("Yerevan", 23.4, new DateTime(2020,5,12));
            //Console.WriteLine(temperature.Date);

            //6.Gadget Stock Entry
            //---------------------
            //Struct: Gadget { string Name; string Brand; decimal Price; int Quantity; }
            //Task: Create a constructor to quickly add gadgets to stock.
            Gadget gadget1 = new Gadget("GadgetName", "Brand", 2000, 20);

            //7.Bank Transaction
            //-------------------
            //Struct: Transaction { int Id; decimal Amount; DateTime Timestamp; }
            //Task: Constructor auto-sets current DateTime for timestamp.
            Transaction t1 = new Transaction(1, 250.75m);

            //8.Course Enrollment
            //--------------------
            //Struct: Course { string Code; string Title; int Credit; }
            //Task: Use constructor to create multiple course objects.
            Course course1 = new Course("A767", "Programming", 3);

            //9.GeoLocation
            //--------------
            //Struct: Location { double Latitude; double Longitude; }
            //Task: Constructor must validate that lat / lon are in valid range.
            Location loc1 = new Location(40.18, 44.51);

            //10.User Profile
            //----------------
            //Struct: User { string Username; string Email; DateTime CreatedAt; }
            //Task: CreatedAt is set automatically in constructor to DateTime.Now.
            User user1 = new User("varduhi", "varduhi@gmail.com");
        }
        public struct User
        {
            public string Username; 
            public string Email; 
            public DateTime CreatedAt;
            public User(string username, string email)
            {
                Username = username;
                Email = email;
                CreatedAt = DateTime.Now;
            }
        }
        public struct Location
        {
            public double Latitude;
            public double Longitude;
            public Location(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }
            public bool IsValid()
            {
                return Latitude >= -90 && Latitude <= 90 && Longitude >= -180 && Longitude <= 180;
            }
        }
        public struct Course
        {
            public string Code;
            public string Title;
            public int Credit;
            public Course(string code, string title, int credit)
            {
                Code = code;
                Title = title;
                Credit = credit;
            }
        }
        public struct Transaction
        {
            int Id;
            decimal Amount;
            DateTime Timestamp;
            public Transaction(int id, decimal amount)
            {
                Id = id;
                Amount = amount;
                Timestamp = DateTime.Now;
            }
        }
        public struct Gadget
        {
            public string Name;
            public string Brand;
            public decimal Price;
            public int Quantity;
            public Gadget(string name, string brand, decimal price, int quantity)
            {
                Name = name;
                Brand = brand;
                Price = price;
                Quantity = quantity;
            }
        }
        public struct Temperature
        {
            public string City;
            public double Celsius;
            public DateTime Date;
            public Temperature(string city, double celsius, DateTime date)
            {
                City = city;
                Celsius = celsius;
                Date = date;
            }
        }
        public struct Employee 
        { 
            public string Name; 
            public int Id; 
            public decimal Salary; 
            public Employee(string name, int id, decimal salary)
            {
                Name = name;
                Id = id;
                Salary = salary;
            }
        }
        public struct Point2D 
        { 
            public double X; 
            public double Y;

            public Point2D(double x, double y)
            {
                X = x;
                Y = y;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"X: {X}, Y: {Y}");
            }
        }
        public struct Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

            public Book(string title, string author, int year)
            {
                Title = title;
                Author = author;
                Year = year;
            }
        }

        public struct Rectangle 
        { 
            public int Width; 
            public int Height;

            public Rectangle(int height, int width)
            {
                Width = width;
                Height = height;
            }

            public int GetArea()
            {
                return Height * Width;
            }
        }
    }
}