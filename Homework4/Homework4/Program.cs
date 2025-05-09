using System.ComponentModel.Design;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // # Nested if tasks #
            //1: Airline Baggage Fee Calculator
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Give the weight of the baggage:");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give airplane class:");
                string airplaneClass = Console.ReadLine();

                int economyFreeLimit = 20;
                int economyCostPerKg = 10;

                int businessFreeLimit = 30;
                int businessCostPerKg = 8;

                int firstFreeLimit = 40;
                int firstCostPerKg = 5;

                if (airplaneClass == "Economy")
                {
                    if (weight <= economyFreeLimit)
                    {
                        Console.WriteLine("It is free");
                    }
                    else
                    {
                        Console.WriteLine($"Cost: {weight * economyCostPerKg}");
                    }
                }
                else if (airplaneClass == "Business")
                {
                    if (weight <= businessFreeLimit)
                    {
                        Console.WriteLine("It is free");
                    }
                    else
                    {
                        Console.WriteLine($"Cost: {weight * businessCostPerKg}");
                    }
                }
                else if (airplaneClass == "First")
                {
                    if (weight <= firstFreeLimit)
                    {
                        Console.WriteLine("It is free");
                    }
                    else
                    {
                        Console.WriteLine($"Cost: {weight * firstCostPerKg}");
                    }
                }
            }
            
            //2: Student Scholarship Eligibility Checker
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("GPA:");
                double gpa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Attendence:");
                int attendance = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Community service hours:");
                int communityServiceHours = Convert.ToInt32(Console.ReadLine());

                double minGPA = 3.5;
                int minAttendance = 90;
                if (gpa >= minGPA)
                {
                    if (attendance >= minAttendance)
                    {
                        if (communityServiceHours >= 20)
                        {
                            Console.WriteLine("Full Scholarship");
                        }
                        else if (communityServiceHours >= 10)
                        {
                            Console.WriteLine("Half Scholarship");
                        }
                        else
                        {
                            Console.WriteLine("Academic Scholarship Only");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not Eligible");
                    }
                }
                else
                {
                    Console.WriteLine("Not Eligible");
                }
            }

            //3: Progressive Tax Calculator
            for(int i = 0; i< 6; i++)
            {
                Console.WriteLine("Give annual income:");
                int annualIncome = Convert.ToInt32(Console.ReadLine());
                double totalTax = 0;
                if (annualIncome > 100000)
                {
                    totalTax += 50000 * 0.1;
                    totalTax += 50000 * 0.2;
                    totalTax += (annualIncome - 100000) * 0.3;
                }
                else if (annualIncome > 50000)
                {
                    totalTax += 50000 * 0.1;
                    totalTax += (annualIncome - 50000) * 0.2;
                }
                else
                {
                    totalTax += annualIncome * 0.1;
                }

                Console.WriteLine(totalTax);
            }

            //4: Job Applicant Filter
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Years of experience:");
                int yearsOfExperience = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Education level:");
                string educationLevel = Console.ReadLine();
                Console.WriteLine("Skill test score:");
                int score = Convert.ToInt32(Console.ReadLine());

                if (yearsOfExperience >= 5)
                {
                    if (educationLevel != "High School")
                    {
                        if (score >= 80)
                        {
                            Console.WriteLine("Highly Eligible");
                        }
                        else if (score >= 60)
                        {
                            Console.WriteLine("Eligible");
                        }
                        else
                        {
                            Console.WriteLine("Needs Improvement");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Education Not Sufficient");
                    }
                }
                else
                {
                    Console.WriteLine("Not enough experience!");
                }
            }

            //5: Theme Park Ticket Pricing
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ticket type:");
                string ticketType = Console.ReadLine();
                int whichCase = 0;

                if (age > 64)
                {
                    whichCase = 1;
                }
                else
                {
                    if (age > 13)
                    {
                        whichCase = 2;
                    }
                    else
                    {
                        if (age < 5)
                        {
                            whichCase = 3;
                        }
                        else
                        {
                            whichCase = 4;
                        }
                    }
                }

                switch (ticketType)
                {
                    case "Standard":
                        switch (whichCase)
                        {
                            case 1:
                                Console.WriteLine("$12");
                                break;
                            case 2:
                                Console.WriteLine("$20");
                                break;
                            case 3:
                                Console.WriteLine("It's free!");
                                break;
                            case 4:
                                Console.WriteLine("$10");
                                break;
                        }
                        break;
                    case "Fast Pass":
                        switch (whichCase)
                        {
                            case 1:
                                Console.WriteLine("$18");
                                break;
                            case 2:
                                Console.WriteLine("$30");
                                break;
                            case 3:
                                Console.WriteLine("It's free!");
                                break;
                            case 4:
                                Console.WriteLine("$15");
                                break;
                        }
                        break;
                }
            }

            //6: Bulk Discount Engine
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Item price:");
                int itemPrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Item quantity:");
                int itemQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Customer type:");
                string customerType = Console.ReadLine();
                int whichCase = 0;
                int _discount = 0;

                if (itemQuantity > 100)
                {
                    whichCase = 1;
                }
                else if (itemQuantity > 50)
                {
                    whichCase = 2;
                }
                else
                {
                    whichCase = 3;
                }

                switch (customerType)
                {
                    case "VIP":
                        switch (whichCase)
                        {
                            case 1:
                                _discount = 20;
                                break;
                            case 2:
                                _discount = 15;
                                break;
                            default:
                                _discount = 10;
                                break;
                        }
                        break;
                    case "Regular":
                        switch (whichCase)
                        {
                            case 1:
                                _discount = 10;
                                break;
                            case 2:
                                _discount = 5;
                                break;
                        }
                        break;
                }
                itemPrice = itemQuantity * (itemPrice - itemPrice * _discount / 100);
                Console.WriteLine(itemPrice);
            }
            
            //7: Restaurant Order Surcharge
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Meal type:");
                string mealType = Console.ReadLine();
                Console.WriteLine("Delivery or dine-in:");
                string isDelivery = Console.ReadLine();
                Console.WriteLine("Time:");
                string time = Console.ReadLine();
                int surcharge = 0;

                switch (isDelivery)
                {
                    case "delivery":
                        switch (mealType)
                        {
                            case "Dinner":
                                if (time == "After 8PM")
                                {
                                    surcharge = 5;
                                }
                                break;
                            case "Lunch":
                                surcharge = 3;
                                break;
                        }

                        break;
                    case "dine-in":
                        if (mealType == "Breakfast")
                        {
                            if (time == "Before 8AM")
                            {
                                surcharge = 2;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("No surcharge.");
                        break;
                }
                Console.WriteLine("$" + surcharge);
            }

            //8: Rent Estimator
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("City:");
                string city = Console.ReadLine();
                Console.WriteLine("Apartment type:");
                string apartmentType = Console.ReadLine();
                Console.WriteLine("Amenities:");
                string amenities = Console.ReadLine();
                int rent = 0;

                switch (apartmentType)
                {
                    case "1BHK":
                        if (city == "Tier 1")
                        {
                            rent = 800;
                        }
                        else if (city == "Tier 2")
                        {
                            rent = 600;
                        }
                        break;
                    case "2BHK":
                        if (city == "Tier 1")
                        {
                            rent = 1200;
                        }
                        else if (city == "Tier 2")
                        {
                            rent = 900;
                        }
                        break;
                    case "3BHK":
                        if (city == "Tier 1")
                        {
                            rent = 1600;
                        }
                        else if (city == "Tier 2")
                        {
                            rent = 1200;
                        }
                        break;
                }
                if (amenities == "yes")
                {
                    rent += 100;
                }
                Console.WriteLine("$" + rent);
            }

            //9: Credit Card Approval System
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Income:");
                int income = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Credit score:");
                int creditScore = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Age:");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 21)
                {
                    if (income >= 30000)
                    {
                        if (creditScore >= 700)
                        {
                            Console.WriteLine("Approved");
                        }
                        else if (creditScore >= 600)
                        {
                            Console.WriteLine("Approved with Low Limit");
                        }
                        else
                        {
                            Console.WriteLine("Denied");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Low Income - Denied");
                    }
                }
                else
                {
                    Console.WriteLine("Too Young - Denied");
                }
            }

            //10: IQ Level Categorizer
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Age group:");
                string ageGroup = Console.ReadLine();
                Console.WriteLine("IQ score:");
                int scoreIQ = Convert.ToInt32(Console.ReadLine());
                string level = "";

                switch(ageGroup)
                {
                    case "Child":
                        if(scoreIQ > 110)
                        {
                            level = "Gifted";
                        }
                        else if(scoreIQ < 80)
                        {
                            level = "Needs Support";
                        }
                        else
                        {
                            level = "Average";
                        }
                        break;
                    case "Teen":
                        if(scoreIQ > 120)
                        {
                            level = "Advanced";
                        }
                        else if(scoreIQ < 90)
                        {
                            level = "Below Average";
                        }
                        else
                        {
                            level = "Average";
                        }
                        break;
                    case "Adult":
                        if (scoreIQ > 130)
                        {
                            level = "High IQ";
                        }
                        else if (scoreIQ < 100)
                        {
                            level = "Below Normal";
                        }
                        else
                        {
                            level = "Normal";
                        }
                        break;
                }
                Console.WriteLine(level);
            }
            
            // # Loop decision tasks #
            //1: Shopping Cart Price Calculator
            string item = "";
            int price = 0;
            while(item != "Done")
            {
                Console.WriteLine("Choose item:");
                item = Console.ReadLine();
                switch (item)
                {
                    case "Apple":
                        price += 2;
                        break;
                    case "Bread":
                        price += 3;
                        break;
                    case "Cheese":
                        price += 5;
                        break;
                }
            }
            Console.WriteLine("$" + price);

            //2: Number Categorizer
            bool isExit = false;
            while(!isExit)
            {
                Console.WriteLine("Give a number:");
                string res = Console.ReadLine();
                if (res != "exit")
                {
                    int _number = Convert.ToInt32(res);
                    if (_number < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else if (_number == 0)
                    {
                        Console.WriteLine("Zero");
                    }
                    else
                    {
                        Console.WriteLine("Positive");
                    }
                }
                else
                {
                    isExit = true;
                }
            }

            //3: Guess the Secret Code
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            int number = 0;
            do
            {
                Console.WriteLine("Give a 4-digit code:");
                number = Convert.ToInt32(Console.ReadLine());
                if(randomNumber < number)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("Too Low");
                }
            }
            while (randomNumber != number);
            Console.WriteLine("Correct");

            //4: Simple Slot Machine
            Random _random = new Random();
            bool winner = false;
            bool exit = false;
            while (!exit)
            {
                int _count = 0;
                int lemon = _random.Next(1,4);
                int cherry = _random.Next(1,4);
                int bell = _random.Next(1,4);

                if(lemon == cherry)
                {
                    if(lemon == bell)
                    {
                        _count = 3;
                    }
                    else
                    {
                        _count = 2;
                    }
                } 
                else if(lemon == bell)
                {
                    _count = 2;
                }
                else if(bell == cherry)
                {
                    _count = 2;
                }

                switch(_count)
                {
                    case 2:
                        Console.WriteLine("Small Win");
                        winner = true;
                        break;
                    case 3:
                        Console.WriteLine("Big Win");
                        winner = true;
                        break;
                    default:
                        Console.WriteLine("Try Again!");
                        break;
                }
                Console.WriteLine("Exit loop?");
                exit = Convert.ToBoolean(Console.ReadLine());
            }

            //5: Login Attempt System
            string login = "Login";
            string password = "login123";
            bool isCorrect = false;
            int count = 0;
            do
            {
                Console.WriteLine("Login:");
                string userLogin = Console.ReadLine();
                Console.WriteLine("Password:");
                string userPassword = Console.ReadLine();
                if(userLogin == login)
                {
                    if(userPassword == password)
                    {
                        isCorrect = true;
                        Console.WriteLine("Login Successfull");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect login or password");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect login or password");
                }
                count++;
            }
            while (count < 3);
            if(!isCorrect)
            {
                Console.WriteLine("Account Locked!");
            }

            //6: ATM Menu System
            int getValue = 0;
            int balance = 20000;
            while (getValue != 4)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                getValue = Convert.ToInt32(Console.ReadLine());
                switch (getValue)
                {
                    case 1:
                        Console.WriteLine(balance);
                        break;
                    case 2:
                        balance += 30000;
                        Console.WriteLine(balance);
                        break;
                    case 3:
                        balance -= 10000;
                        Console.WriteLine(balance);
                        break;
                    case 4:
                        break;
                }
            }

            //7: Student Grade Analyzer
            bool stopLoop = false;
            while(!stopLoop)
            {
                Console.WriteLine("Write score:");
                int score = Convert.ToInt32(Console.ReadLine());
                if(score >= 60)
                {
                    Console.WriteLine("A");
                }
                else if(score >= 50)
                {
                    Console.WriteLine("B");
                }
                else if(score >= 40)
                {
                    Console.WriteLine("C");
                }
                else if(score >= 33)
                {
                    Console.WriteLine("D");
                }
                else if(score > 0)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    stopLoop = true;
                }
            }

            //8: Parking Fee Calculator
            bool anotherCustomer = false;
            while(!anotherCustomer)
            {
                Console.WriteLine("Enter number of hours parked:");
                int hours = Convert.ToInt32(Console.ReadLine());
                if(hours >= 5)
                {
                    Console.WriteLine("$15");
                }
                else if(hours >= 3)
                {
                    Console.WriteLine("$10");
                }
                else if(hours >= 1)
                {
                    Console.WriteLine("$5");
                }
                Console.WriteLine("Process another customer?");
                anotherCustomer = Convert.ToBoolean(Console.ReadLine());
            }

            //9: Discount Calculator
            double discount = 0;
            while (true)
            {
                Console.WriteLine("Enter item price:");
                int _price = Convert.ToInt32(Console.ReadLine());
                int changedPrice = 0;
                if(_price == 0)
                {
                    break;
                }
                if(_price > 100)
                {
                    discount = 0.1;
                }
                Console.WriteLine($"Price before: {_price}, Price after: {_price - discount* _price}");
            }

            //10: Game Menu System
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Load Game");
                Console.WriteLine("3. Quit");
                int entered = Convert.ToInt32(Console.ReadLine());
                switch(entered)
                {
                    case 1:
                        Console.WriteLine("New game");
                        break;
                    case 2:
                        Console.WriteLine("Load game");
                        break;
                    case 3:
                        return;
                }
            }
            while (true);
        }
    }
}
