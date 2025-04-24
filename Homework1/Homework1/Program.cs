namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Homework - 24.04.2025
            // 1:
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello. {name}! Welcome to your first C# program.");
            // 2:
                Console.WriteLine("Enter the first number:");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                double add = firstNumber + secondNumber;
                double subtract = firstNumber - secondNumber;
                double multiply = firstNumber * secondNumber;
                double divide = firstNumber / secondNumber;
                Console.WriteLine($"Add: {add}");
                Console.WriteLine($"Subtract: {subtract}");
                Console.WriteLine($"Multiply: {multiply}");
                Console.WriteLine($"Divide: {divide}");
            // 3:
                Console.WriteLine("What's your favorite color?");
                string color = Console.ReadLine();
                Console.WriteLine("What's your favorite food?");
                string food = Console.ReadLine();
                Console.WriteLine("What's your favorite number?");
                string number = Console.ReadLine();
                Console.WriteLine($"You love {color}, {food}, and your lucky number is {number}!");
            // 4:
                Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Where do you live?");
                string country = Console.ReadLine();
                Console.WriteLine($"Your name is {firstName} {lastName}, you are {age} years old and you live in {country}.");
            // 5:
                Console.WriteLine("Give a number of hours: ");
                int minutes = Convert.ToInt32(Console.ReadLine()) * 60;
                Console.WriteLine($"That’s {minutes} minutes.");
        }
    }
}
