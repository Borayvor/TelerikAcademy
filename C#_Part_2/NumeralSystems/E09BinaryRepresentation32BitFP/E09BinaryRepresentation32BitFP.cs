using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class E09BinaryRepresentation32BitFP
{
    static void Main ()
    {
        // Write a program that shows the internal binary representation of given 32-bit signed floating-point 
        // number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, 
        // mantissa = 10110100000000000000000.
        
        float floatNumber = Number ("a number");
        Console.WriteLine ();

        BinaryRepresentationOf32BitFloatingPointNumber (floatNumber);
        Console.WriteLine ();
    }


    static void BinaryRepresentationOf32BitFloatingPointNumber (float number)
    {
        Console.WriteLine ("The internal binary representation of {0} in IEEE 754 format : ", number);
        Console.Write ("{0} | {1} | {2}", GetSign (number), GetExponent (number), GetMantissa (number));
    }


    static string GetSign (float number)
    {
        if (number >= 0)
        {
            return "0";
        }
        else
        {
            return "1";
        }
    }


    static string DecimalToBinaryFraction (float number)
    {
        string fraction = String.Empty;

        float temp = number - (int) number;

        do            
        {
            temp *= 2;

            fraction += (int) temp;

            temp -= (int) temp;

        } while (temp != 0);

        return fraction;
    }


    static string GetMantissa (float number)
    {
        if (number < 0)
        {
            number *= -1;
        }

        string integer = DecimalToBinary ((int) number);

        string fraction = DecimalToBinaryFraction (number);

        string mantissa = String.Empty;
                
        if (integer.Length != 0)
        {
            mantissa = integer.Substring (1) + fraction; 
        }
        else
        {
            mantissa = fraction.Substring (fraction.IndexOf ('1') + 1); 
        }

        return mantissa.PadRight (23, '0'); 
    }


    static string GetExponent (float number)
    {
        string exponent = String.Empty;

        if (number < 0)
        {
            number *= -1;
        }

        int exp = (int) (Math.Floor (Math.Log (number, 2)));
        
        exponent = DecimalToBinary (exp + 127);

        return exponent;
    }


    static string DecimalToBinary (int decimalNumber)
    {
        List<byte> binaryNumber = new List<byte> ();

        while (decimalNumber != 0)
        {
            binaryNumber.Add ((byte) (decimalNumber % 2));

            decimalNumber /= 2;
        }

        binaryNumber.Reverse ();

        StringBuilder result = new StringBuilder ();

        for (int index = 0; index < binaryNumber.Count; index++)
        {
            result.Append (binaryNumber[index]);
        }

        return Convert.ToString (result);
    }


    static float Number (string name) // проверява дали стойността е число и дали е в обхвата на "float"
    {                                     // ако това е изпълнено връща стойността на числото  
        float number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = float.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
