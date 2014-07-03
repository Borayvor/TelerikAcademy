using System;
using System.Collections.Generic;

class E17KElementsWithSumS
{
    static void Main ()
    {
        // Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
        // Find in the array a subset of K elements that have sum S or indicate about its absence.
        int N = 0;
        do
        {
            N = number ("the size of the array N");
        } while (N < 3);
        int K = number ("number of elements K");
        int S = number ("sum S");
        Console.WriteLine ();

        int[] array = new int[N];
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = number ("array[" + index + "]");
        }
        Console.WriteLine ();

        Console.Write ("Array : ");
        for (int index = 0; index < array.Length; index++)
        {
            if (index > 9)
            {
                Console.Write (" ");
            }
            Console.Write ("{0} |", array[index]);

        }
        Console.WriteLine ();

        Console.Write ("index : ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write ("{0} |", index);
        }
        Console.WriteLine ();
        Console.WriteLine ();

        int sum;
        bool absence = true;
        List<List<int>> numberOfSubset = new List<List<int>> ();

        for (int indexOne = 0; indexOne < array.Length - 1; indexOne++)
        {
            sum = array[indexOne];
            List<int> subset = new List<int> ();
            subset.Add (indexOne);
            int x = 0;

            if (sum >= S)
            {
                continue;
            }

            for (int indexTwo = indexOne + 1; indexTwo < array.Length; indexTwo++)
            {
                if (array[indexTwo] >= array[subset[x]])
                {
                    sum += array[indexTwo];
                }

                if (sum > S)
                {
                    sum -= array[indexTwo];
                    continue;
                }

                if (array[indexTwo] >= array[subset[x]])
                {
                    subset.Add (indexTwo);
                    x++;                    
                }

                if (sum == S)
                {
                    break;
                }
            }
            if ((sum == S) && (x + 1 == K))
            {
                numberOfSubset.Add (subset);
                absence = false;
            }
            else
            {
                subset.Clear ();
            }
        }

        if (absence)
        {
            Console.WriteLine ("No such subset.");
        }
        else
        {
            foreach (var sequence in numberOfSubset)
            {
                foreach (var value in sequence)
                {
                    Console.Write ("{0} ", value);
                }
                Console.WriteLine ("- Indexes of elements from a subset having a sum S.");
            }
        }
        Console.WriteLine ();
    }


    static int number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        int number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = int.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
