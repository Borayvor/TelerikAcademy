using System;
using System.Collections.Generic;

class E10SequenceOfGivenSum
{
    static void Main ()
    {
        // Write a program that finds in given array of integers a sequence of given sum S (if present).
        int[] array = new int[20];
        Random randomInt = new Random ();
        Console.Write ("Array : ");
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = randomInt.Next (0, 21);
            Console.Write ("{0} ", array[index]);
        }
        Console.WriteLine ();

        int givenSum = number ("sum S ");
        Console.WriteLine ();

        int sum;
        List<List<int>> numberOfSeq = new List<List<int>> ();        

        for (int indexOne = 0; indexOne < array.Length - 1; indexOne++)
        {
            sum = array[indexOne];
            List<int> sequence = new List<int> ();

            for (int indexTwo = indexOne + 1; indexTwo < array.Length; indexTwo++)
            {
                sum += array[indexTwo];

                if (sum == givenSum)
                {
                    for (int index = indexOne; index <= indexTwo; index++)
                    {
                        sequence.Add (array[index]);
                    }
                    break;
                }
            }
            if (sum == givenSum)
            {
                numberOfSeq.Add (sequence);   
            }
        }

        foreach (var sequence in numberOfSeq)
        {
            foreach (var value in sequence)
            {
                Console.Write ("{0} ", value);                
            }
            Console.WriteLine ("- are sequence of given sum S.");
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
