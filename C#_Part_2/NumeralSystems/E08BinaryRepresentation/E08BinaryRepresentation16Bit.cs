using System;
using System.Collections.Generic;
using System.Text;

class E08BinaryRepresentation16Bit
{
    static void Main ()
    {
        // Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

        short decimalNumber = Number ("a 16-bit signed integer number");
        Console.WriteLine ();
        Console.WriteLine ("The binary representation of that number is : {0}", DecimalToBinary (decimalNumber));
    }


    static string DecimalToBinary (short decimalNumber)
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


    static short Number (string name) // проверява дали стойността е число и дали е в обхвата на "short"
    {                                     // ако това е изпълнено връща стойността на числото  
        short number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = short.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
