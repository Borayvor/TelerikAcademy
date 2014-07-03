using System;
using System.Collections.Generic;

class E6KElementsWithMaxSum
{
    static void Main ()
    {
        // Write a program that reads two integer numbers N and K and an array of N elements from the console.
        // Find in the array those K elements that have maximal sum.
        int N = 0;
        int K = 0;
        do
        {
            N = (int) number ("N");
            K = (int) number ("K");
        } while (N < 3 || K < 2);
        
        double[] array = new double[N];
        Console.WriteLine ();

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = number ("array[" + index + "]");
        }        

        Array.Sort (array); // сортира масива

        List<double> sequence = new List<double> ();

        for (int index = array.Length - 1; index >= array.Length - K; index--)
        {// запаметява последните К елемента на сортираният масив
            sequence.Add (array[index]);
        }
        Console.WriteLine ();

        for (int index = sequence.Count - 1; index >= 0; index--)
        {
            Console.Write ("{0} | ", sequence[index]);
        }
        Console.WriteLine ("- are those elements that have maximal sum.");
        Console.WriteLine ();
    }


    static double number (string name) // проверява дали стойността е число и дали е в обхвата на "double"
    {                                     // ако това е изпълнено връща стойността на числото  
        double number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = double.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
