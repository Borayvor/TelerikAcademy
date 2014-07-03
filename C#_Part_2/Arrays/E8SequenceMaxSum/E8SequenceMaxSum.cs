using System;
using System.Collections.Generic;

class E8SequenceMaxSum
{
    static void Main ()
    {
        // Write a program that finds the sequence of maximal sum in given array. 
        // Can you do it with only one loop (with single scan through the elements of the array)?
        double[] array = new double[10];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = number ("array[" + index + "]");
        }
        Console.WriteLine ();

        int position = 0;
        int positionStart = 0;
        int positionEnd = 0;
        double sum = 0;
        double tempSum = 0;

        for (int index = 0; index < array.Length; index++)
        {
            tempSum += array[index];

            if (tempSum < 0) 
            {
                tempSum = 0;
                position = index + 1;
            }

            if (sum < tempSum)
            {
                sum = tempSum;
                positionStart = position;
                positionEnd = index;
            }
        }

        Console.Write ("The sequence is :");
        for (int index = positionStart; index <= positionEnd; index++)
        {
            Console.Write ("{0} ", array[index]);
        }
        Console.WriteLine ();
        Console.WriteLine ("Sum of elements is : {0}", sum);
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
