using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tasks No Collections:
            //1: Countdown Timer with Delays
            Console.WriteLine("Type a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number >= 0)
            {
                Console.WriteLine(number--);
                Thread.Sleep(1000);
            }

            //2: PIN Code Entry System
            int attemptsCount = 0;
            int maxAttemptsQuantity = 3;
            int pin = 1234;
            while(attemptsCount < maxAttemptsQuantity)
            {
                Console.WriteLine("Type a 4-digit PIN");
                int typedPin = Convert.ToInt32(Console.ReadLine());
                if(pin == typedPin)
                {
                    Console.WriteLine("Access Granted");
                    break;
                }
                else if (attemptsCount < maxAttemptsQuantity)
                {
                    Console.WriteLine("Try again");
                }
                attemptsCount++;
                if(attemptsCount == 3)
                {
                    Console.WriteLine("Account Locked");
                }
            }

            //3: Days in a Month Checker
            Console.WriteLine("Write month (1–12)");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write year:");
            int year = Convert.ToInt32(Console.ReadLine());
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine(31);
                    break;
                case 2:
                    if(DateTime.IsLeapYear(2012))
                    {
                        Console.WriteLine(29);
                    }
                    else
                    {
                        Console.WriteLine(28);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine(30);
                    break;
            }

            //4: Distance Tracker
            Console.WriteLine("Write speed(km/h):");
            string speed = Console.ReadLine();
            Console.WriteLine("Write time(hours):");
            string time = Console.ReadLine();
            float speedFloat = Convert.ToSingle(speed);
            float timeFloat = Convert.ToSingle(time);
            float timeFloor = (float)Math.Floor(timeFloat);
            float fullDistance = timeFloat * speedFloat;
            Console.WriteLine(timeFloor);

            float distance = 0;
            while (timeFloor > 0)
            {
                distance = timeFloor * speedFloat;
                Console.WriteLine(distance);
                timeFloor--;
            }
            Console.WriteLine($"Full Distance: {fullDistance}");

            //5: Simple Menu Loop
            var currentDate = DateTime.Today;
            int typedValue = 0;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print Hello");
                Console.WriteLine("2. Print Date");
                Console.WriteLine("3. Exit");
                typedValue = Convert.ToInt32(Console.ReadLine());
                switch(typedValue)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine(currentDate);
                        break;
                    case 3:
                        Console.WriteLine("Bye!");
                        break;
                }
            }
            while (typedValue != 3);

            //6:Division Table Generator
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Type a number");
            int typedNumber = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Number ÷ i = result: {(double)typedNumber / i}");
            }

            //7: Currency Converter
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            CultureInfo currencyCultureUS = CultureInfo.GetCultureInfo("en-US");
            Console.WriteLine("Give amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double usd = 390.50;
            double euro = 437;
            double gbp = 546;
            Console.WriteLine($"USD: {(amount * usd).ToString("C")}");
            Console.WriteLine($"EUR: {(amount * euro).ToString("C", new CultureInfo("fr-FR"))}");
            Console.WriteLine($"GBP: {(amount * gbp).ToString("C", new CultureInfo("en-GB"))}");

            //8: Age Group Classifier
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 65)
            {
                Console.WriteLine("Senior");
            }
            else if(age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else if(age >= 13)
            {
                Console.WriteLine("Teen");
            }
            else if(age > 0)
            {
                Console.WriteLine("Child");
            }

            //9: Digit Counter
            Console.WriteLine("Give a positive integer number");
            string number33 = Console.ReadLine();
            int numbersQuantity = 0;
            for(int i = 0; i < number33.Length; i++)
            {
                numbersQuantity++;
            }
            Console.WriteLine(numbersQuantity);

            //10: Ride Eligibility Checker
            Console.WriteLine("Give height in cm:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give age: ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            if(age1 >= 12 && height >= 140)
            {
                Console.WriteLine("Allowed");
            }
            else if(age1 >= 10 && height >= 130)
            {
                Console.WriteLine("With Parent");
            }
            else
            {
                Console.WriteLine("Not Allowed");
            }

            // Combined Tasks
            //1: Multi-Operation Calculator with History
            bool isExitTrue = false;
            while(!isExitTrue)
            {
                Console.WriteLine("Give first number:");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give second number:");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give operation:");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case "-":
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case "*":
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case "/":
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                }
                Console.WriteLine("Do you want to exit loop?");
                isExitTrue = Convert.ToBoolean(Console.ReadLine());
            }

            //2: Shipping Cost Estimator
            string continueLoop = "yes";
            while (continueLoop == "yes")
            {
                Console.WriteLine("Give weight:");
                float weight = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Give shipping speed:");
                string shippingSpeed = Console.ReadLine();
                float cost = 0;
                switch (shippingSpeed)
                {
                    case "Standard":
                        cost = 5 + 1 * weight;
                        break;
                    case "Express":
                        cost = 10 + 2 * weight;
                        break;
                }
                Console.WriteLine(cost);
                Console.WriteLine("Do you want to estimate another package?");
                continueLoop = Console.ReadLine();
            }

            //3: Number Conversion Tool
            string q = "";
            while (q != "q")
            {
                Console.WriteLine("Give a decimal number:");
                decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());
                string binary = Convert.ToString((int)decimalNumber, 2);
                string hex1 = Convert.ToString((int)decimalNumber, 16);
                Console.WriteLine(binary);
                Console.WriteLine(hex1);
                q = Console.ReadLine();
            }
            string str = "123.12";
            var dc = (int)decimal.Parse(str, System.Globalization.NumberStyles.Number, CultureInfo.InvariantCulture);
            var x = Convert.ToString(dc, 2);
            var hex2 = Convert.ToString(dc,16);
            Console.WriteLine(x);
            Console.WriteLine(hex2);

            //4: Discount Pricing System
            string isDone = "no";
            do
            {
                Console.WriteLine("Enter product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Give price:");
                string price2 = Console.ReadLine();
                Console.WriteLine("Give quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                double priceDouble = Convert.ToDouble(price2);

                if (quantity >= 10)
                {
                    priceDouble = priceDouble - priceDouble * 0.1;
                }
                Console.WriteLine(priceDouble);
                Console.WriteLine("Continue loop?");
                isDone = Console.ReadLine();
            }
            while (isDone != "done");

            //5: Student Marks Analyzer
            int subjectsQuantity = 5;
            int mark = 0;
            int total = 0;
            for (int i = 1; i <= subjectsQuantity; i++)
            {
                Console.WriteLine($"Enter marks for subject {i}:");
                mark = int.Parse(Console.ReadLine());
                total += mark;
            }
            Console.WriteLine($"total: {total}");
            int avg = total / subjectsQuantity;
            Console.WriteLine($"avg: {avg}");
            if(avg >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (avg < 75)
            {
                Console.WriteLine("Needs Improvement");
            }
            else
            {
                Console.WriteLine("Good");
            }

            //6: Employee Salary Breakdown
            string salary = "1000000";
            float basicSalary = float.Parse(salary);
            float hra = basicSalary * 0.2f;
            float da = basicSalary * 0.1f;
            float tax = basicSalary * 0.05f;
            float finalSalary = basicSalary + hra + da - tax;
            Console.WriteLine($"Basic Salary: {basicSalary}");
            Console.WriteLine($"HRA (20%): {hra}");
            Console.WriteLine($"DA (10%): {da}");
            Console.WriteLine($"Tax (5%): {tax}");
            Console.WriteLine($"Final Salary: {finalSalary}");

            //7: Receipt Generator (with type safety)
            int total1 = 0;
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter price:");
                int price1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter quantity:");
                int quantity = int.Parse(Console.ReadLine());
                total1 += price1 * quantity;
                Console.WriteLine($"Name: {name}, Price: {price1}, Quantity: {quantity}");
            }
            Console.WriteLine($"Total: {total1}");

            //8: FizzBuzz with Type Control
            string divisible = "";
            StringBuilder allInfo = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    divisible = "Fizaa";
                }
                else if (i % 5 == 0)
                {
                    divisible = "Buzz";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    divisible = "FizzBuzz";
                }
                if (divisible != "")
                {
                    allInfo.Append(divisible);
                    allInfo.Append("\n");
                }
            }
            Console.WriteLine(allInfo);

            //9: Sales Tax Calculator
            string price = "300";
            int productPrice = int.Parse(price);
            string category = "Essential";
            float productPriceFloat = float.Parse(price);
            float tax3 = 0;
            switch(category)
            {
                case "Essential":
                    tax3 = productPriceFloat * 0.05f;
                    break;
                case "Luxury":
                    tax3 = productPriceFloat * 0.15f;
                    break;
            }
            Console.WriteLine($"Amount: {productPrice + tax3}");

            //10: Interest Calculator
            Console.WriteLine("Enter principal amount:");
            double principal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter annual interest rate:");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of years:");
            int years = int.Parse(Console.ReadLine());
            for (int i = 1; i <= years; i++)
            {
                double growth = principal * Math.Pow((1 + rate / 100), i);
                Console.WriteLine($"Year: {i}, Growth: {growth}");
            }
        }

    }
}



