using System;
using System.Collections.Generic;

class E9MostFrequentNumber
{
    static void Main ()
    {
        // Write a program that finds the most frequent number in an array.
        double[] array = new double[15];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = number ("array[" + index + "]");
        }
        Console.WriteLine ();

        int count = 0;
        List<double> mostFrequent = new List<double> ();

        for (int index = 0; index < array.Length - 1; index++)
        {
            int tempCount = 0;

            for (int position = index; position < array.Length; position++)
            {
                if (array[index] == array[position])
                {
                    tempCount++;
                }
            }

            if (count <= tempCount)
            {
                mostFrequent.Add (array[index]);
                count = tempCount;
            }
        }
        
        for (int index = 0; index < mostFrequent.Count; index++)
        {
            Console.WriteLine ("{0} - {1} times", mostFrequent[index], count);
        }
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
