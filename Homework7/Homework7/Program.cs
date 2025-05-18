using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.Security.Principal;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;
using System.Net;
namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //🚗 **Task 1: Vehicle Registration System**
            //** Scenario**: You’re building a basic console app for a small vehicle registration office.
            //#### Requirements:
            //* Ask the user to enter vehicle details: Brand, Model, Year, Engine Capacity, Owner Name.
            //* Use appropriate data types for each property.
            //*Concatenate strings to display the formatted registration record.
            //* Validate:
            //  *Year should be >= 1980 and <= current year.
            //  * Engine Capacity should be > 0.
            //* If validation fails, display a meaningful message using `if-else` and `logical operators`.
            //*Use `StringBuilder` to build the display output.
            //* Bonus: Create 3 vehicle records using a `for` or `while` loop.
            int vehiclesCount = 3;
            while (vehiclesCount > 0)
            {
                Console.WriteLine("Enter vehicle brand:");
                string brand = Console.ReadLine();
                Console.WriteLine("Enter vehicle model:");
                string model = Console.ReadLine();
                Console.WriteLine("Enter vehicle year:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter engine capacity:");
                int engineCapacity = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter owner name:");
                string ownerName = Console.ReadLine();

                int currentYear = DateTime.Now.Year;
                bool isYearValid = (year >= 1980 && year <= currentYear) ? true : false;
                bool isCapacityValid = engineCapacity > 0 ? true : false;
                Console.Clear();

                if (!isYearValid)
                {
                    Console.WriteLine($"Year must be from 1980 to {currentYear}");
                }
                if (!isCapacityValid)
                {
                    Console.WriteLine("Capacity must be greater than 0");
                }

                if (isYearValid && isCapacityValid)
                {
                    StringBuilder allInforamtion = new StringBuilder();
                    allInforamtion.AppendLine("Vehicle all information:");
                    allInforamtion.AppendLine($"brand: {brand}");
                    allInforamtion.AppendLine($"model: {model}");
                    allInforamtion.AppendLine($"year: {year}");
                    allInforamtion.AppendLine($"engineCapacity: {engineCapacity}");
                    allInforamtion.AppendLine($"ownerName: {ownerName}");
                    Console.WriteLine(allInforamtion.ToString());
                    vehiclesCount--;
                }
            }

            //🏦 **Task 2: Simple ATM Simulation**
            //** Scenario**: You are simulating basic ATM operations via a console.
            //#### Requirements:
            //* Start with a fixed account balance (e.g., 10, 000).
            //*Show a menu:
            //  1.Check balance
            //  2.Deposit
            //  3.Withdraw
            //  4.Exit
            //* Use `switch-case` or `if-else` to handle user choices.
            //*Use arithmetic operators to update balance.
            //* Withdrawals must check for insufficient funds using `comparison and logical operators`.
            //*Use loops to keep the program running until the user chooses "Exit".
            //* Use string interpolation to display the balance and messages.

            decimal accountBalance = 10.000m;
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Balance: {accountBalance}");
                        break;
                    case 2:
                        Console.WriteLine("How much cash can you deposit?");
                        accountBalance += decimal.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("How much cash do you want to withdraw?");
                        decimal withdraw = decimal.Parse(Console.ReadLine());
                        if (accountBalance > 0 && accountBalance >= withdraw)
                        {
                            accountBalance -= withdraw;
                        }
                        else
                        {
                            Console.WriteLine("Account balance is not enough");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exit!");
                        break;
                }
            }

            //🛍️ **Task 3: Simple Shopping Cart**
            //** Scenario**: Simulate a shopping cart system for a small grocery store.
            //#### Requirements:
            //* Allow the user to enter product names and prices(up to 5 products).
            //* Use arrays or lists(if introduced) to store them, or use string variables for a fixed number.
            //* Calculate the total price using a loop.
            //*Apply a 10 % discount if the total exceeds \$100.
            //* Use string formatting to display the bill nicely.
            //* Show final amount after discount.
            //*Use `StringBuilder` to print the full invoice.

            int productsCount = 5;
            decimal totalPrice = 0;
            decimal discount = 0;
            StringBuilder productsInformation = new StringBuilder();
            while (productsCount > 0)
            {
                Console.WriteLine("Enter product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                int productPrice = int.Parse(Console.ReadLine());
                if (totalPrice > 100)
                {
                    discount = 10;
                }
                totalPrice += productPrice;
                productsInformation.AppendLine($"Product name: {productName}");
                productsInformation.AppendLine($"Product price: {productPrice}");
                productsCount--;
                Console.Clear();
            }

            totalPrice = totalPrice * (1 - discount / 100);
            productsInformation.AppendLine($"discount: {discount}%");
            productsInformation.AppendLine($"Total price: {totalPrice}");
            Console.WriteLine(productsInformation.ToString());

            //⏰ **Task 4: Work Shift Scheduler**
            //** Scenario**: A factory wants to create a weekly shift scheduler.
            //#### Requirements:
            //* Ask the user to input:
            //  *Employee name
            //  * Day of the week
            //  * Shift start and end times(use integers for 24hr format)
            //  *Use `if-else` or `switch` to determine:
            //  *If the shift is "Morning", "Afternoon", or "Night".
            //  * Warn if the shift is longer than 12 hours.
            //* Use `?:` (ternary operator) to determine whether the employee has a "Short" or "Long" shift.
            //* Display the summary using `StringBuilder`.

            Console.WriteLine("Write employee name:");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter the day of the week:");
            string day = Console.ReadLine();
            Console.WriteLine("Shift start (0–23):");
            int shiftStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Shift end (0–23):");
            int shiftEnd = int.Parse(Console.ReadLine());
            string shiftType = "";
            int duration = (shiftEnd >= shiftStart) ? (shiftEnd - shiftStart) : (24 - (shiftStart - shiftEnd));

            if(shiftStart >= 6 && shiftEnd <12)
            {
                shiftType = "Morning";
            }
            else if (shiftStart >= 12 && shiftEnd < 18)
            {
                shiftType = "Afternoon";
            }
            else
            {
                shiftType = "Night";
            }

            bool isTooLong = duration > 12;
            if (isTooLong) Console.WriteLine("Warning: Employee has a long shift.");

            StringBuilder summary = new StringBuilder();
            summary.AppendLine($"Employee name: {employeeName}");
            summary.AppendLine($"Day: {day}");
            summary.AppendLine($"Shift : {shiftStart} - {shiftEnd}");
            summary.AppendLine($"Duration: {duration}");
            summary.AppendLine($"Shift type: {shiftType}");
            Console.WriteLine(summary.ToString());

            //👨‍👩‍👧‍👦 **Task 5: Household Budget Tracker**
            //** Scenario**: Help a family manage their monthly budget.
            //#### Requirements:
            //* Ask for:
            //  *Monthly income
            //  * Expenses for: rent, groceries, transport, entertainment, other
            //* Calculate:
            //  *Total expenses
            //  * Remaining balance
            //* Use arithmetic and logical operators to warn if:
            //  *More than 80 % of income is spent
            //  * Balance is negative
            //* Use null - coalescing `??` operator to handle optional values like entertainment(e.g., empty input = 0).
            //*Use operator precedence correctly when calculating the remaining balance.

            Console.WriteLine("Enter monthly income:");
            decimal monthlyIncome = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Rent Expenses:");
            decimal rentExpenses = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Rent groceries:");
            decimal rentGroceries = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Rent transport:");
            decimal rentTransport = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Rent entertainment:");
            decimal rentEntertainment = decimal.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Other rents:");
            decimal otherRents = decimal.Parse(Console.ReadLine());

            decimal totalExpenses = rentExpenses + rentGroceries + rentTransport + rentEntertainment + otherRents;
            decimal remainingBalance = monthlyIncome - totalExpenses;

            bool isBalanceNegative = remainingBalance < 0;
            bool isTooMuch = totalExpenses > monthlyIncome * 0.8m;

            if(isBalanceNegative)
            {
                Console.WriteLine("Warning expenses are greater than balance.");
            }
            if (isTooMuch)
            {
                Console.WriteLine("You have spent more than 80% of your income!");
            }

            Console.WriteLine($"Income: {monthlyIncome}");
            Console.WriteLine($"Total Expenses: {totalExpenses}");
            Console.WriteLine($"Remaining Balance: {remainingBalance}");

            //💻 Bonus Task: Basic User Login System
            //**Scenario * *: Simulate a login system.
            //#### Requirements:
            //*Store a username and password in variables.
            //* Ask the user to input credentials.
            //* Compare inputs using equality operators.
            //*Allow up to 3 attempts using a loop.
            //*Use null - conditional(`?.`) and null - coalescing(`??`) if using optional middle names or additional data.

            string login = "Lucifer777";
            string password = "Pa$$w0rd";
            int attemptsQuantity = 3;
            bool isLogedIn = false;
            string middleName = null;

            while (attemptsQuantity > 0 && !isLogedIn)
            {
                Console.WriteLine("Login:");
                string inputLogin = Console.ReadLine();
                Console.WriteLine("Password:");
                string inputPassword = Console.ReadLine();
                Console.Clear();
                if (inputLogin == login && inputPassword == password)
                {
                    isLogedIn = true;
                    Console.WriteLine("Welcome");
                    int middleNameLength = middleName?.Length ?? 0;
                    Console.WriteLine($"Middle name length: {middleNameLength}");
                }
                else
                {
                    Console.WriteLine("Login or password is not correct");
                }
                attemptsQuantity--;
            }

            if (!isLogedIn)
            {
                Console.WriteLine("Blocked.");
            }
        }
    }
}