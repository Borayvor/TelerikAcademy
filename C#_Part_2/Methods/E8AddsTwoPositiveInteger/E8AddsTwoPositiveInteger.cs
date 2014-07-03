using System;
using System.Collections.Generic;
using System.Numerics;

class E8AddsTwoPositiveInteger
{
    static void Main ()
    {
        // Write a method that adds two positive integer numbers represented as arrays of digits (each array 
        // element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will 
        // be added could have up to 10 000 digits.
        BigInteger firstNumber = Number ("first number");
        BigInteger secondNumber = Number ("second number");

        List<byte> result = AddNumber (firstNumber, secondNumber);

        Console.Write ("Result = ");
        for (int index = result.Count - 1; index >= 0; index--)
        {
            Console.Write (result[index]);
        }
        Console.WriteLine ();
    }


    static List<byte> AddNumber (BigInteger numberOne, BigInteger numberTwo)
    {
        List<byte> arrayOne = Digits (numberOne);
        List<byte> arrayTwo = Digits (numberTwo);
        List<byte> arrayResult = new List<byte> (Math.Max(arrayOne.Count, arrayTwo.Count));
        
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
            arrayResult.Add ((byte)1);
        }

        return arrayResult;
    }


    static List<byte> Digits (BigInteger number)
    {
        List<byte> result = new List<byte> ();

        while (number != 0)
        {
            result.Add ((byte) (number % 10));

            number /= 10;
        }

        return result;
    }


    static BigInteger Number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        BigInteger number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = BigInteger.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
