using System;
using System.Numerics;

class E14OperationsWithArrays
{
    static void Main ()
    {
        // Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        // Use variable number of arguments.
        int[] array = FillArray ();

        PrintArray (array);
        Console.WriteLine ();

        Console.WriteLine ("The minimum is : {0}", MinimumValue (array));
        Console.WriteLine ("The maxmimum is : {0}", MaximumValue (array));
        Console.WriteLine ("The average number is : {0}", AverageValue (array));
        Console.WriteLine ("The sum is : {0}", Sum (array));
        Console.WriteLine ("The product is : {0}", Product (array));
    }


    static int[] FillArray () // запълва масива с произволни числа от 0 до 99
    {
        int length = Number ("the length of the array");

        int[] array = new int[length];

        Random randomGenerator = new Random ();

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = randomGenerator.Next (100);
        }

        return array;
    }


    static void PrintArray (int[] array) // отпечатва масива
    {
        Console.Write ("{ ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write ("{0}", array[index]);

            if (index < array.Length - 1)
            {
                Console.Write (", ");
            }
        }
        Console.WriteLine (" }");
    }


    static int MinimumValue (int[] array)
    {
        Array.Sort (array);
        
        return array[0];
    }


    static int MaximumValue (int[] array)
    {
        Array.Sort (array);

        return array[array.Length - 1];
    }


    static double AverageValue (int[] array)
    {
        double sum = 0;

        for (int index = 0; index < array.Length; index++)
        {
            sum += array[index];
        }

        return (sum / array.Length);
    }


    static long Sum (int[] array)
    {
        long sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }


    static BigInteger Product (int[] array)
    {
        BigInteger product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= (BigInteger) array[i];
        }

        return product;
    }


    static int Number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
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
