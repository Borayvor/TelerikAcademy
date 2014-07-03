using System;
using System.Collections.Generic;

class E4SequenceOfEqualElements
{
    static void Main ()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.
        double[] array = new double[10];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = number ("array[" + index + "]");
        }

        List<double> sequence = new List<double> ();
        int count = 0;

        for (int value = 0; value < array.Length - 1; value++)
        {
            int size = 0;

            for (int index = value; index < array.Length; index++)
            {
                if (array[value].Equals (array[index]))
                {
                    size++;
                }
                else
                {
                    break;
                }
            }

            if ( (count < size) && (array[value].Equals (array[value + 1])) )
            {
                count = size;
                sequence.Clear ();

                for (int index = value; index < value + count; index++)
                {
                    sequence.Add (array[index]);
                }
            }
            else if (count == size)
            {
                for (int index = value; index < value + count; index++)
                {
                    sequence.Add (array[index]);
                }
            }
        }

        Console.WriteLine ();

        for (int index = 0; index < sequence.Count; index++)
        {
            Console.Write ("{0} | ", sequence[index]);
            if ((index + 1) % count == 0)
            {
                Console.WriteLine (" - the maximal sequence of equal elements in the array.");
            }
        }
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
