﻿
/* 
 * Author: Amanda Blakley
 * Date: 9/19/2019
 * Description: This C# console application code demonstrates the use of an
 * array, which are manually populated.
*/

using System;

namespace Deliverable3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Let's manually populate an array with integers");
                Console.WriteLine();
                Console.WriteLine("Then, let's iterate through the elements in the array");
                Console.WriteLine("_________________________________________");

                // Declare and initialize the array 
                int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25 };

                // Iterate through the array with a foreach loop
                foreach (int i in numbers)
                {
                    Console.WriteLine("The element value is: " + i);
                }
                Console.WriteLine("_________________________________________");
                // Display a message after the element values have been displayed 
                Console.WriteLine();
                Console.WriteLine("Excellent Job! ");

                // Display a message prompting the user to exit the program
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the program...");

                // Pause the program and wait for the user to press a key to end the program
                Console.ReadKey(true);
            }
            catch
            {
                // Pause the program and wait for the user to press a key to end the program
                Console.ReadKey(true);
            }
        }
    }
}
