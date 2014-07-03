using System;
using System.Collections.Generic;
using System.Text;

class E02BinaryToDecimal
{
    static void Main ()
    {
        // Write a program to convert binary numbers to their decimal representation.
        
        string decimalNumber = BinaryToDecimal (GetBinaryNumber ());

        Console.WriteLine ("Convert binary numbers to their decimal representation : {0}", decimalNumber);
    }


    static string GetBinaryNumber ()
    {
        StringBuilder binaryNumber = new StringBuilder ();
        bool isBinary;

        do
        {
            isBinary = true;
            Console.Write ("Please, enter a binary number : ");
            string decimalNumber = Console.ReadLine ();

            for (int index = 0; index < decimalNumber.Length; index++)
            {

                if (decimalNumber[index] < '0' || decimalNumber[index] > '1')
                {
                    isBinary = false;
                    break;
                }
            }

            if (decimalNumber.Length % 4 != 0)
            {
                string fill = new string ('0', (1 * (4 - (decimalNumber.Length % 4))));
                binaryNumber.Append (fill);
            }
            binaryNumber.Append (decimalNumber);

        } while (!isBinary);

        return Convert.ToString (binaryNumber);
    }


    static string BinaryToDecimal (string binaryNumber)
    {
        string decimalNumber = null;
        int tempNumber = 0;

        for (int index = binaryNumber.Length - 1; index >= 0; index--)
        {
            tempNumber += ((binaryNumber[index] - '0') * ((int) Math.Pow (2, (binaryNumber.Length - 1 )- index)) );
        }

        decimalNumber = Convert.ToString (tempNumber);

        return decimalNumber;
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
