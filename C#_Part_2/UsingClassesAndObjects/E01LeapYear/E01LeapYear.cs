using System;

class E01LeapYear
{
    static void Main ()
    {
        // Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

        CheckYear ();
    }


    static void CheckYear ()
    {
        int year = Number ("year you want to check whether it is a leap");

        bool isLeapYear = DateTime.IsLeapYear (year);

        if (isLeapYear)
        {
            Console.WriteLine ("{0} is leap-year.", year);
        }
        else
        {
            Console.WriteLine ("{0} is ordinary year.", year);
        }
    }


    static int Number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        int number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = int.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false && (number < 0 || number > 3000));

        return number;
    }
}
