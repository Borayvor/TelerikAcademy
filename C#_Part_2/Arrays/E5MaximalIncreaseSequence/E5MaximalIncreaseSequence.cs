using System;
using System.Collections.Generic;

class E5MaximalIncreaseSequence
{
    static void Main ()
    {
        // Write a program that finds the maximal increasing sequence in an array.
        double[] array = new double[12];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = number ("array[" + index + "]");
        }

        List<double?> sequence = new List<double?> ();
        sequence.Add (null);
        int count = 0;

        for (int value = 0; value < array.Length - 1; value++)
        {
            int size = 0;

            for (int index = value; index < array.Length; index++)
            {
                if (array[value] + size == (array[index]))
                {
                    size++;
                }
                else
                {
                    break;
                }
            }

            if ((count <= size) && (array[value + 1] - array[value] == 1) &&
                ((sequence[0] <= array[value]) || (sequence[0] == null)) )
            {
                count = size;
                sequence.Clear ();

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
        }
        Console.WriteLine ("- is the maximal increasing sequence in the array.");
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
