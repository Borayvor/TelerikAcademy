using System;
using System.Collections.Generic;

class E15ImprovedOperationsWithArrays
{
    static void Main ()
    {
        // Modify your last program and try to make it work for any number type, not just integer 
        // (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

        var min = MinimumValue (6.1m, 3.11111m, 2.543m);
        var max = MaximumValue (6.1f, 3.1111f, 2.543f);
        var sum = Sum ((byte) 6.1, (byte) 3.1111, (byte) 2.543);
        var average = AverageValue (26.1, 32.11111, 22.543);
        var product = Product ((long) 26.1, (long) 32.11111, (long) 22.543);


        Console.WriteLine ("The minimum is : {0}", min);
        Console.WriteLine ("The maxmimum is : {0}", max);    
        Console.WriteLine ("The sum is : {0}", sum);
        Console.WriteLine ("The average number is : {0}", average);
        Console.WriteLine ("The product is : {0}", product);
    }



    static dynamic MinimumValue<T> (params T[] array)
    {
        Array.Sort (array);

        return (dynamic) array[0];
    }


    static dynamic MaximumValue<T> (params T[] array)
    {
        Array.Sort (array);

        return (dynamic) array[array.Length - 1];
    }


    static dynamic AverageValue<T> (params T[] array)
    {
        return (Sum (array) / (float) array.Length);
    }


    static dynamic Sum<T> (params T[] array)
    {
        dynamic sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }


    static dynamic Product<T> (params T[] array)
    {
        dynamic product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= (dynamic) array[i];
        }

        return product;
    }

}
