using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System.Security.Cryptography;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.Find the Maximum Number:
            //-Create an int[] array of 10 numbers.
            //- Use a loop to find and display the maximum number.

            int[] intArray = [2,5,8,23,1,34,67,44,88,3];
            int maxNumber = int.MinValue;

            for(int i = 0; i < intArray.Length; i++)
            {
                if(maxNumber < intArray[i])
                {
                    maxNumber = intArray[i];
                }
            }
            Console.WriteLine(maxNumber);

            //2.Reverse an Array:
            //-Take a string array(e.g., names of 5 students).
            //-Print the array in reverse order.
            string[] stringArray = ["John", "Michael", "Bob", "Tom", "Anna"];
            for(int i = stringArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(stringArray[i]);
            }

           // 3.Calculate the Average:
           //-Store exam scores in a double[].
           //-Calculate and print the average score.

            double[] examScores = [7.5, 6.4, 9.5, 0.25];
            double sum = 0;
            for(int i = 0; i < examScores.Length; i++)
            {
                sum += examScores[i];
            }
            double average = sum / examScores.Length;
            Console.WriteLine(average);

            //4.Count Even and Odd Numbers:
            //-Create an int[] with 10 numbers.
            //- Count how many are even and how many are odd.

            int[] intRandArray = [2, 5, 8, 23, 1, 34, 67, 44, 88, 3];
            int evensQuantity = 0;
            int oddsQuantity = 0;

            for(int i = 0; i < intRandArray.Length; i++)
            {
                if (intRandArray[i] % 2 == 0)
                    evensQuantity++;
                else
                    oddsQuantity++;
            }

            // 5.Search for an Element:
            //-Create a string[] of fruits.
            //- Ask the user to enter a fruit name and search the array.
            //- Print whether it was found or not.

            string[] fruitsList = ["mango", "apple", "banana", "pear", "qiwi"];
            string? userInput = Console.ReadLine();
            if(userInput is not null && Array.IndexOf(fruitsList, userInput.ToLower()) > -1)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not found");

            //6.Sort an Array(Manually):
            // -Write a simple sorting algorithm(e.g., Bubble Sort) to sort an int[] in ascending order.
            
            int[] intArray = [2, 5, 8, 23, 1, 34, 67, 44, 88, 3];
            int arrLength = intArray.Length;

            for (int i = 0; i < arrLength - 1; i++)
            {
                for(int j = 0; j < arrLength - 1 - i; j++)
                {
                    if (intArray[j] > intArray[j+1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            }

            //7.Sum of Array Elements:
            //-Create an int[] with predefined values.
            //-Use a loop to calculate the total sum.

            int[] numbers = { 10, 20, 5, 15, 30 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);

            //8.Copy Elements to Another Array:
            //-Create an array of 5 integers.
            //- Copy its contents into another array using a loop.

            int[] intArray = [2, 5, 8, 23, 1];
            int[] intArrayCopy = new int[intArray.Length];
            for(int i = 0; i < intArray.Length; i++)
            {
                intArrayCopy[i] = intArray[i];
            }

            //9.Concatenate Two String Arrays:
            //-Have two string[] arrays(e.g., first names and last names).
            //-Combine each pair into full names and print the result.

            string[] firstNames = ["Anna", "Julieta", "Ruzanna", "Mariam", "Eva"];
            string[] lastNames = ["Hovhannisyan", "Karagyozyan", "Poghosyan", "Petrosyan", "Harutyunyan"];
            string[] fullNames = new string[firstNames.Length];

            for(int i = 0; i < lastNames.Length; i++)
            {
                fullNames[i] = lastNames[i] + " " + firstNames[i];
            }

            //10.Frequency Count:
            //-Create an array with repeated integers(e.g., { 1, 2, 2, 3, 3, 3}).
            //-Count and print how many times each number appears.

            int[] arr = { 1, 2, 2, 3, 3, 3 };

            for(int i = 0; i < arr.Length; i++)
            {
                int currentValue = arr[i];
                int count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (currentValue == arr[j])
                        count++;
                    if(j == arr.Length - 1)
                    {
                        Console.WriteLine($"Number: {currentValue}");
                        Console.WriteLine($"Qunatity: {count}");
                    }
                }
            }
            */

        }
    }
}
