using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numberArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numberArray[i] = i + 1;
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var number in numberArray)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                } else
                {
                    oddNumbers.Add(number);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Even numbers in the array");
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("Odd numbers in the array");
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
