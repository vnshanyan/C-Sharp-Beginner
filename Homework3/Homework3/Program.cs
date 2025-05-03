namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1:
            Console.WriteLine("How many liters of fuel you want to pump?");
            int fuelLiter = Convert.ToInt32(Console.ReadLine());
            int pumpedLiters = 0;
            int costPerLiter = 5000;
            int sumOfCost = 0;

            while (fuelLiter != pumpedLiters)
            {
                pumpedLiters++;
                sumOfCost += costPerLiter;
                Console.WriteLine($"Pumped 1 liter. Total: {pumpedLiters}");
            }
            Console.WriteLine(sumOfCost);

            //2:
            string isWantToSnooze = "";
            do
            {
                Console.WriteLine("Do you want to snooze?");
                isWantToSnooze = Console.ReadLine();
                if (!isWantToSnooze.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Snoozing for 5 more minutes...");
                }
            } while (!isWantToSnooze.Equals("no", StringComparison.OrdinalIgnoreCase));

            //3:
            int correctPin = 1234;
            int maxAttempts = 3;
            int insertedPin = 0;
            do
            {
                Console.WriteLine("Write a 4-digit PIN:");
                insertedPin = Convert.ToInt32(Console.ReadLine());
                maxAttempts--;
                if (correctPin != insertedPin && maxAttempts == 0)
                {
                    Console.WriteLine("Card Blocked.");
                }
            } while (correctPin != insertedPin && maxAttempts != 0);

            //4:
            Random randomNumber = new Random();
            int count = 0;
            int dice = 0;
            while (dice != 6)
            {
                dice = randomNumber.Next(1, 7);
                Console.WriteLine(dice);
                count++;
            }
            Console.WriteLine(count);

            //5:
            Console.WriteLine("How many packages are left to deliver?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            while (quantity > 0)
            {
                quantity--;
                Console.WriteLine(quantity);
            }
            Console.WriteLine("All delivered!");

            //6:
            string answer;
            string fullOrder = "";
            do
            {
                int _quantity = 0;
                string order = "";
                Console.WriteLine("What do you want?");
                order += Console.ReadLine();
                Console.WriteLine("How many?");
                _quantity += Convert.ToInt32(Console.ReadLine());
                fullOrder += order + ": " + _quantity + "\n";
                Console.WriteLine("Do you want to add more?");
                answer = Console.ReadLine();
            } while (answer.Equals("yes", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(fullOrder);

            //7:
            int stockPrice = 100;
            Random _randomNumber = new Random();
            while (stockPrice != 120)
            {
                int number = _randomNumber.Next(1, 10);
                if (number <= 5)
                {
                    stockPrice -= 10;
                }
                else
                {
                    stockPrice += 10;
                }
                Console.WriteLine(stockPrice);
            }

            //8:
            Console.WriteLine("Give a number of asterisks: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i <= n)
            {
                string asterisks = new String('*', i);
                Console.WriteLine(asterisks);
                i++;
            }

            //9:
            Console.WriteLine("Give a number of asterisks: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            while (numb > 0)
            {
                string asterisks = new String('*', numb);
                Console.WriteLine(asterisks);
                numb--;
            }

            //10:
            int rowNumber = 0;
            char sharps = '#';
            int sharpsQuantity = 4;
            while (rowNumber < sharpsQuantity)
            {
                int colNumber = 0;
                while (colNumber < sharpsQuantity)
                {
                    Console.Write("#");
                    colNumber++;
                }
                Console.WriteLine();
                rowNumber++;
            }

            //11:
            int _rowNumber = 0;
            int _sharpsQuantity = 5;
            while (_rowNumber < _sharpsQuantity)
            {
                int colNumber = 0;
                while (colNumber < _sharpsQuantity)
                {
                    if (_rowNumber != 0 && _rowNumber != _sharpsQuantity - 1 && colNumber != 0 && colNumber != _sharpsQuantity - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    colNumber++;
                }
                Console.WriteLine();
                _rowNumber++;
            }

            //12:
            int rowCount = 0;
            int _n = 5;
            while (rowCount < _n)
            {
                int spacesNumber = _n - rowCount - 1;
                int asterisksNumber = 2 * rowCount + 1;
                int spacesI = 0;
                int asterisksI = 0;
                while (spacesI < spacesNumber)
                {
                    Console.Write(" ");
                    spacesI++;
                }
                while (asterisksI < asterisksNumber)
                {
                    Console.Write("*");
                    asterisksI++;
                }
                Console.WriteLine();
                rowCount++;
            }

            //13
            Console.WriteLine("Give a number of stairs: ");
            int __n = Convert.ToInt32(Console.ReadLine());
            int __i = 1;
            while (__i <= __n)
            {
                int spacesQuantity = __n - __i;
                spacesQuantity = spacesQuantity < 0 ? 0 : spacesQuantity;
                string asterisks = new string(' ', spacesQuantity) + new String('*', __i);
                Console.WriteLine(asterisks);
                __i++;
            }
        }
    }
}
