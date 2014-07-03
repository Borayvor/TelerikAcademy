using System;
using System.Text;

class E7ReverseTheDigits
{
    static void Main ()
    {
        // Write a method that reverses the digits of given decimal number. Example: 256  652
        int decimalNumber = Number ("a number");

        long reverseNumber = Reverse (decimalNumber);

        Console.WriteLine ("The reversed number is : {0}", reverseNumber);
    }


    static long Reverse (int number)
    {        
        long result = 0;

        while (number != 0)
        {
            result = result * 10 + (long) number % 10; // измества получената цифра в ляво и прибавя следващата

            number /= 10;
        }

        return result;
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
