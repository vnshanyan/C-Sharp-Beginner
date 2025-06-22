using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Student Struct
            //---------------- -
            //Method: PrintInfo()
            //Task: Display student name and grade.

            Student student1 = new Student("Anun1", Grade.A);
            student1.PrintInfo();

            //2.Circle Struct
            //----------------
            //Field: Radius
            //Method: GetArea(), GetCircumference()

            Circle circle1 = new Circle(12);
            Console.WriteLine(circle1.GetArea());
            Console.WriteLine(circle1.GetCircumference());

            //3.Currency Converter
            //---------------------
            //Fields: Amount, Currency
            //Method: ConvertTo(string targetCurrency)
            //Task: Return converted amount(use mock conversion rates).

            Console.OutputEncoding = Encoding.UTF8;
            var c1 = new CurrencyConverter(100, "USD");
            c1.PrintConversion("AMD");

            var c2 = new CurrencyConverter(150000, "AMD");
            c2.PrintConversion("USD");

            //4.Email Validator
            //------------------
            //Field: Email
            //Method: IsValidEmail()(use Contains('@') && Contains('.'))

            EmailValidator email1 = new EmailValidator("vardouhy.nshanyan@gmail.com");
            Console.WriteLine(email1.IsValidEmail());

            //5.Discount Calculator
            //----------------------
            //Fields: Price, DiscountPercentage
            //Method: GetFinalPrice()

            DiscountCalculator discount1 = new DiscountCalculator(5000, 20);
            Console.WriteLine(discount1.GetFinalPrice());

            //6.Time Interval
            //----------------
            //Fields: StartTime, EndTime
            //Method: GetDuration()(returns TimeSpan)
            DateTime start = new DateTime(2025, 6, 16, 14, 30, 0);
            DateTime end = new DateTime(2025, 6, 16, 17, 45, 0);
            TimeInterval interval = new TimeInterval(start, end);
            Console.WriteLine(interval.GetDuration());

            //7.Rectangle Comparison
            //------------------------
            //Method: IsSquare(), IsLargerThan(Rectangle other)

            RectangleComparison r1 = new RectangleComparison(10, 10);
            RectangleComparison r2 = new RectangleComparison(8, 12);
            Console.WriteLine(r1.IsSquare());
            Console.WriteLine(r1.IsLargerThan(r2));

            //8.Temperature Conversion
            //-------------------------
            //Fields: Celsius
            //Methods: ToFahrenheit(), ToKelvin()

            TemperatureConversion temp1 = new TemperatureConversion(25);
            Console.WriteLine(temp1.ToFahrenheit());

            TemperatureConversion temp2 = new TemperatureConversion(-10);
            Console.WriteLine(temp2.ToKelvin());

            //9.Voting Eligibility
            //---------------------
            //Field: Age
            //Method: CanVote() → returns true if age ≥ 18
            VotingEligibility vote1 = new VotingEligibility(4);
            Console.WriteLine(vote1.CanVote());

            //10.Invoice Total
            //-----------------
            //Fields: UnitPrice, Quantity
            //Method: GetTotal() → returns UnitPrice *Quantity

            InvoiceTotal invoiceTotal1 = new InvoiceTotal(2000, 10);
            Console.WriteLine(invoiceTotal1.GetTotal());

        }
    }

    public struct InvoiceTotal
    {
        public double UnitPrice;
        public int Quantity;
        public InvoiceTotal(double unitPrice, int quantity)
        {
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public double GetTotal()
        {
            return UnitPrice * Quantity;
        }
    }
    public struct VotingEligibility
    {
        public int Age;

        public VotingEligibility(int age)
        {
            Age = age;
        }

        public bool CanVote()
        {
            return Age >= 18;
        }
    }
    public struct TemperatureConversion
    {
        public double Celsius;

        public TemperatureConversion(double celsius)
        {
            Celsius = celsius;
        }

        public double ToFahrenheit()
        {
            return (Celsius * 9 / 5) + 32;
        }
        public double ToKelvin()
        {
            return Celsius + 273.15;
        }
    }
    public struct RectangleComparison
    {
        public double Height;
        private double Width;

        public RectangleComparison(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public bool IsSquare()
        {
            return Height == Width;
        }

        public bool IsLargerThan(RectangleComparison other)
        {
            return (Height * Width) > (other.Height * other.Width);
        }
    }
    public struct TimeInterval
    {
        public DateTime StartTime;
        public DateTime EndTime;

        public TimeInterval(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }
    }
    public struct DiscountCalculator
    {
        public double Price;
        public double DiscountPercentage;

        public DiscountCalculator(double price, double discountPercentage)
        {
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double GetFinalPrice()
        {
            return Price * (1 - DiscountPercentage/100);
        }
    }
    public struct EmailValidator
    {
        public string Email;

        public EmailValidator(string email)
        {
            Email = email;
        }

        public bool IsValidEmail()
        {
            return Email.Contains('@') && Email.Contains('.');
        }
    }
    public struct Student
    {
        public string Name { get; set; }
        public Grade Grade { get; set; }

        public Student(string name, Grade grade)
        {
            Name = name;
            Grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }
    public struct Circle
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
    public struct CurrencyConverter
    {
        private decimal Amount;
        private string Currency;
        public CurrencyConverter(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal ConvertTo(string targetCurrency)
        {
            targetCurrency = targetCurrency.ToUpper();
            decimal sourceRate = GetRate(Currency);
            decimal targetRate = GetRate(targetCurrency);

            if (sourceRate == 0 || targetRate == 0)
            {
                Console.WriteLine("It's unsupported currency.");
                return 0;
            }
            decimal amountInAMD = Amount / sourceRate;
            decimal convertedAmount = amountInAMD * targetRate;
            return convertedAmount;
        }

        public decimal GetRate(string currency)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return 1.0m;
                case "AMD":
                    return 390;
                case "EUR":
                    return 0.92m;
                default:
                    return 0;
            }
        }

        public CultureInfo GetCulture(string currency)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return new CultureInfo("en-US");
                case "AMD":
                    return new CultureInfo("hy-AM");
                case "EUR":
                    return new CultureInfo("fr-FR");
                default:
                    return CultureInfo.InvariantCulture;
            }
        }

        public void PrintConversion(string targetCurrency)
        {
            decimal converted = ConvertTo(targetCurrency);
            if (converted == 0) return;

            CultureInfo sourceCulture = GetCulture(Currency);
            CultureInfo targetCulture = GetCulture(targetCurrency);
            string formattedSource = string.Format(sourceCulture, "{0:C}", Amount);
            string formattedTarget = string.Format(targetCulture, "{0:C}", converted);

            Console.WriteLine($"{formattedSource} ({Currency}) = {formattedTarget} ({targetCurrency})");
        }
    }
    
    public enum Grade { A, B, C, D, F }
}
