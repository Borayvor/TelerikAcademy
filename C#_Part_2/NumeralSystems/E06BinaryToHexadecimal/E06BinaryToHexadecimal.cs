using System;
using System.Collections.Generic;
using System.Text;

class E06BinaryToHexadecimal
{
    static void Main ()
    {
        // Write a program to convert binary numbers to hexadecimal numbers (directly).
        string hexadecimalNumber = BinaryToHexadecimal (GetBinaryNumber ());

        Console.WriteLine ("Convert binary numbers to hexadecimal numbers (directly) : {0}", hexadecimalNumber);
    }


    static string BinaryToHexadecimal (string binaryNumber)
    {
        string hexadecimalNumber = "";

        for (int index = 0; index < binaryNumber.Length; index += 4)
        {
            switch (binaryNumber.Substring (index, 4))
            {
                case "0000":
                    hexadecimalNumber += "0";
                    break;
                case "0001":
                    hexadecimalNumber += "1";
                    break;
                case "0010":
                    hexadecimalNumber += "2";
                    break;
                case "0011":
                    hexadecimalNumber += "3";
                    break;
                case "0100":
                    hexadecimalNumber += "4";
                    break;
                case "0101":
                    hexadecimalNumber += "5";
                    break;
                case "0110":
                    hexadecimalNumber += "6";
                    break;
                case "0111":
                    hexadecimalNumber += "7";
                    break;
                case "1000":
                    hexadecimalNumber += "8";
                    break;
                case "1001":
                    hexadecimalNumber += "9";
                    break;
                case "1010":
                    hexadecimalNumber += "A";
                    break;
                case "1011":
                    hexadecimalNumber += "B";
                    break;
                case "1100":
                    hexadecimalNumber += "C";
                    break;
                case "1101":
                    hexadecimalNumber += "D";
                    break;
                case "1110":
                    hexadecimalNumber += "E";
                    break;
                case "1111":
                    hexadecimalNumber += "F";
                    break;                
            }
        }
        return hexadecimalNumber;
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
