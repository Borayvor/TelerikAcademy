using System;
using System.Collections.Generic;

class E03DecimalToHexadecimal
{
    static void Main ()
    {
        // Write a program to convert decimal numbers to their hexadecimal representation.
        int decimalNumber = Number ("a decimal number");

        Console.WriteLine ("Convert decimal numbers to their hexadecimal representation : {0}", decimalNumber.ToString ("X"));
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
