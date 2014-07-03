using System;

class E11IntFormatOutput
{
    static void Main ()
    {
        // Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage 
        // and in scientific notation. Format the output aligned right in 15 symbols.

        int number = int.Parse (Console.ReadLine ());

        Console.WriteLine ("Decimal : {0,15}", number); 

        Console.WriteLine ("Hexadecimal : {0,15:X}", number); 

        Console.WriteLine ("Percentage : {0,15:P}", number); 

        Console.WriteLine ("Scientific notation : {0,15:E}", number); 
    }
}

