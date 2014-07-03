
namespace E17StringOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class StringOfStrings
    {
        static void Main ()
        {
            // Write a program to return the string with maximum length from an array of strings. Use LINQ.

            Console.WriteLine ("Homework 17:");
            Console.WriteLine ();
            string[] stringArray = GenerateRandomStrings ();

            Console.WriteLine ("Array of strings:");
            foreach (var item in stringArray)
            {
                Console.WriteLine (item);
            }
            Console.WriteLine ();

            string longest = (from text in stringArray orderby text.Length descending select text).ElementAt (0);
            Console.WriteLine ("The string with maximum length:");
            Console.WriteLine (longest);
        }


        private static string[] GenerateRandomStrings ()
        {
            Random rnd = new Random ();

            string[] array = new string[7];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new string ((char) rnd.Next (65, 94), rnd.Next (5, 50));
            }

            return array;
        }
    }    
}
