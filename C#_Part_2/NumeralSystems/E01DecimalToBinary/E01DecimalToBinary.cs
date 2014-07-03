using System;
using System.Collections.Generic;
using System.Text;

class E01DecimalToBinary
{
    static void Main ()
    {
        // Write a program to convert decimal numbers to their binary representation.
        int decimalNumber = Number ("a decimal number");
        Console.WriteLine ();

        Console.Write ("Convert decimal numbers to their binary representation : {0}", DecimalToBinary (decimalNumber));
        Console.WriteLine ();
    }


    static string DecimalToBinary (int decimalNumber)
    {
        List<byte> binaryNumber = new List<byte> ();

        if (decimalNumber >= 0)
        {
            while (decimalNumber != 0)
            {
                binaryNumber.Add ((byte) (decimalNumber % 2));

                decimalNumber /= 2;
            }
            while ((binaryNumber.Count % 16 != 0) || binaryNumber.Count == 0)
            {
                binaryNumber.Add ((byte) 0);
            }
        }
        else
        {
            while (decimalNumber != 0)
            {
                binaryNumber.Add ((byte) ((decimalNumber * -1) % 2));

                decimalNumber /= 2;
            }
            while (binaryNumber.Count % 16 != 0)
            {
                binaryNumber.Add ((byte) 1);
            }
        }

        binaryNumber.Reverse ();

        StringBuilder result = new StringBuilder ();

        for (int index = 0; index < binaryNumber.Count; index++)
        {
            result.Append (binaryNumber[index]);
        }

        return Convert.ToString (result);
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
