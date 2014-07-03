using System;
using System.Collections.Generic;

class E16SubsetWithSumS
{
    static void Main ()
    {
        // We are given an array of integers and a number S. Write a program to find if there exists 
        // a subset of the elements of the array that has a sum S.
        int[] array = new int[20] ;
        Random randomInt = new Random ();
        Console.Write ("Array : ");
        for (int index = 0; index < array.Length; index++)
        {
            if (index > 9)
            {
                Console.Write (" ");
            }
            array[index] = randomInt.Next (1, 10);
            Console.Write ("{0} |", array[index]);
            
        }
        Console.WriteLine ();
        
        Console.Write ("index : ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write ("{0} |", index);
        }
        Console.WriteLine ();

        int S = number ("number S");

        int sum;
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
            if (sum == S)
            {
                numberOfSubset.Add (subset);
            }
            else
            {
                subset.Clear ();
            }
        }

        foreach (var sequence in numberOfSubset)
        {
            foreach (var value in sequence)
            {
                Console.Write ("{0} ", value);
            }
            Console.WriteLine ("- Indexes of elements from a subset having a sum S.");
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
