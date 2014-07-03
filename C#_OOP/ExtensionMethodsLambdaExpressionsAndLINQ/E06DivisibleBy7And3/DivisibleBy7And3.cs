
namespace E06DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main ()
        {
            // Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
            // Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


            int[] array = new int[] { 10, 22, 21, 42, 3, 5, 1, 20, 12, 72, 31, 51 };

            // Lambda expression:
            int[] lambdaResult = array.Where (x => x % 21 == 0).ToArray ();
            Console.WriteLine ("Lambda expression:");
            foreach (int item in lambdaResult)
            {
                Console.WriteLine (item);
            }
            Console.WriteLine ();

            // LINQ: 
            Console.WriteLine ("LINQ:");
            int[] linqResult = (
                from number in array 
                where number % 21 == 0 
                select number).ToArray ();

            foreach (int item in linqResult)
            {
                Console.WriteLine (item);
            }
            Console.WriteLine ();
        }
    }
}
