using System;
using System.Collections.Generic;
using System.Numerics;

class E10Factorial
{
    static void Main ()
    {
        // Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method 
        // that multiplies a number represented as array of digits by given integer number.

        int range = 100;


        for (int index = 1; index <= range; index++)// първи метод
        {
            Console.WriteLine ("    {0}! = {1}\n", index, FactorialOne (index));
        }



        for (int index = 1; index <= range; index++)// втори метод
        {
            List<byte> n = new List<byte> ();
            n = FactorialTwo (index);

            Console.Write ("    {0}! = ", index);

            for (int i = 0; i < n.Count; i++)
            {
                Console.Write (n[i]);
            }
            Console.WriteLine ();
        }
        Console.WriteLine ();

    }




    static BigInteger FactorialOne (int number) // изчислява стойността на факториела от даденото число
    {
        BigInteger factorial = 1;
        for (int index = number; index > 1; index--)
        {
            factorial *= index;
        }
        return factorial;
    }




    static List<byte> FactorialTwo (int num)
    {
        List<byte> number = Digits (num);
        List<byte> tempResult = new List<byte> ();
        List<byte> result = new List<byte> ();

        if (num > 1)
        {
            tempResult = Multiply (number, num - 1);

            for (int index = tempResult.Count - 1; index >= 0; index--)
            {
                result.Add (tempResult[index]);
            }

        }
        else
        {
            result.Add (1);
        }

        return result;
    }


    static List<byte> Multiply (List<byte> x, int y)
    {
        List<byte> result = new List<byte> ();

        for (int i = 0; i < y; i++)
        {
            result = AddNumber (result, x);
        }

        if (y > 1)
        {
            result = Multiply (result, y - 1);
        }

        return result;
    }


    static List<byte> AddNumber (List<byte> arrayOne, List<byte> arrayTwo)
    {
        List<byte> arrayResult = new List<byte> (Math.Max (arrayOne.Count, arrayTwo.Count));

        byte tempDigit = 0;

        for (int index = 0; index < arrayResult.Capacity; index++)
        {
            byte sum = (byte) ((index < arrayOne.Count ? arrayOne[index] : 0) +
                                    (index < arrayTwo.Count ? arrayTwo[index] : 0) + tempDigit);

            tempDigit = (byte) (sum / 10);

            arrayResult.Add ((byte) (sum % 10));
        }

        if (tempDigit == 1)
        {
            arrayResult.Add ((byte) 1);
        }

        return arrayResult;
    }


    static List<byte> Digits (int number)
    {
        List<byte> result = new List<byte> ();

        while (number != 0)
        {
            result.Add ((byte) (number % 10));

            number /= 10;
        }

        return result;
    }


}
