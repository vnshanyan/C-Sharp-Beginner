using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1:
            Console.WriteLine("Write 8-letter secret word:");
            string secret = Console.ReadLine();
            char char1 = secret[0];
            char char2 = secret[1];
            char char3 = secret[2];
            char char4 = secret[3];
            char char5 = secret[4];
            char char6 = secret[5];
            char char7 = secret[6];
            char char8 = secret[secret.Length - 1];
            string reversed = "" + char8 + char7 + char6 + char5 + char4 + char3 + char2 + char1;
            Console.WriteLine(reversed);

            //2:
            Console.WriteLine("Write any word: ");
            string word = Console.ReadLine();
            int first = (int)word[0];
            int last = (int)word[word.Length - 1];
            string winner = $"Between '{word[0]}' and '{word[word.Length - 1]}', '{(first > last ? word[word.Length - 1] : word[0])}' wins!";
            Console.WriteLine(winner);

            //3:
            Console.WriteLine("Write your favorite color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Write your favorite animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine($"Your funny name is: {color.ToUpper()} {animal.ToLower()}!");

            //4:
            Console.WriteLine("Write 6-letter word:");
            string word6 = Console.ReadLine();
            string second = word6.Substring(1, 1);
            string fourth = word6.Substring(3, 1);
            string sixth = word6.Substring(5, 1);
            Console.WriteLine($"Output: {second + fourth + sixth}");

            //5:
            Console.WriteLine("Give first letter:");
            int firstLetter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Give second letter:");
            int secondLetter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{Math.Abs(firstLetter - secondLetter)}");

            //6:
            Console.WriteLine("Write a word:");
            string resp = Console.ReadLine();
            Console.WriteLine($"{resp.ToUpper() + resp.ToLower()}");

            //7:
            Console.WriteLine("Write an even length word:");
            string evenResp = Console.ReadLine();
            string resp_first = evenResp.Substring(0, evenResp.Length / 2);
            string resp_second = evenResp.Substring(evenResp.Length / 2, evenResp.Length / 2);
            Console.WriteLine(resp_first);
            Console.WriteLine(resp_second);

            //8:
            Console.WriteLine("Write a 4-letter word:");
            string word4 = Console.ReadLine();
            Console.WriteLine(word4.Last() + word4.Substring(1, word4.Length-2) + word4.First());

            //9:
            Console.WriteLine("Give first letter:");
            string letter1 = Console.ReadLine();
            int letter1Int = Convert.ToChar(letter1);
            Console.WriteLine("Give second letter:");
            string letter2 = Console.ReadLine();
            int letter2Int = Convert.ToChar(letter2);
            Console.WriteLine($"Output: {letter1}: {letter1Int}, {letter2}: {letter2Int}, Difference: {Math.Abs(letter1Int - letter2Int)}");

            //Bonus Tiny Challenges:
            // - Input your name, display it backwards.
            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();
            string backwards = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                backwards += name[i];
            }
            Console.WriteLine(backwards);

            // - Enter a fruit name, show its middle letter.
            string fruit_name = "code";
            if (fruit_name.Length % 2 == 0)
            {
                Console.WriteLine(fruit_name[fruit_name.Length / 2 - 1]);
            }
            else
            {
                Console.WriteLine(fruit_name[fruit_name.Length / 2]);
            }

            // -Input a 5 - letter word, sum all character codes.
            Console.WriteLine("Write a 5-letter word:");
            string word5Str = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < word5Str.Length; i++)
            {
                sum += Convert.ToChar(word5Str[i]);
            }
            Console.WriteLine(sum);

            //-Enter two short words, concatenate with '-' between.
            string firstStr1 = "First";
            string secondStr2 = "Second";
            string result = string.Concat(firstStr1, "-", secondStr2);
            Console.WriteLine(result);

            // - Enter your birth month and day, swap and display them.
            Console.WriteLine("Enter your birth month and day (month/day):");
            string birthMonth = Console.ReadLine();
            string[] birthSplitted = birthMonth.Split('/');
            Console.WriteLine(birthSplitted[1] + '/' + birthSplitted[0]);
        }
    }
}