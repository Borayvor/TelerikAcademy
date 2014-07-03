namespace E02ExtendIEnumerableT
{
    using System;
    using System.Collections.Generic;


    class ExtendIEnumerableTDemo
    {
        static void Main ()
        {
            // Implement a set of extension methods for IEnumerable<T> that implement the following group 
            // functions: sum, product, min, max, average.

            List<int> enumerable1 = new List<int>() { -1, -5, 32 };
            Console.WriteLine("Sum<int> : {0}", enumerable1.Sum());
            Console.WriteLine();

            List<double> enumerable2 = new List<double>() { -1, -5.54, 32.67 };
            Console.WriteLine("Sum<double> : {0}", enumerable2.Sum());
            Console.WriteLine();

            List<sbyte> enumerable3 = new List<sbyte>() { -1, -5, 32 };
            Console.WriteLine("Sum<sbyte> : {0}", enumerable3.Sum());
            Console.WriteLine();

            List<sbyte> enumerable4 = new List<sbyte>() { -1, 15, 22 };
            Console.WriteLine("Product<sbyte> : {0}", enumerable4.Product());
            Console.WriteLine();

            List<double> enumerable5 = new List<double>() { -1, -5.54, 32.67 };
            Console.WriteLine("Product<double> : {0}", enumerable5.Product());
            Console.WriteLine();

            List<int> enumerable6 = new List<int>() { -1, -15, 39 };
            Console.WriteLine("Average<int> : {0}", enumerable6.Average());
            Console.WriteLine();

            List<int> enumerable7 = new List<int>() { -1, -15, 39 };
            Console.WriteLine("Min<int> : {0}", enumerable7.Min());
            Console.WriteLine();

            List<int> enumerable8 = new List<int>() { -1, -15, 39 };
            Console.WriteLine("Max<int> : {0}", enumerable8.Max());
            Console.WriteLine();

            List<int> enumerable9 = new List<int>();
            Console.WriteLine("Min<int> : {0}", enumerable9.Min());
            Console.WriteLine();
        }
    }
}
