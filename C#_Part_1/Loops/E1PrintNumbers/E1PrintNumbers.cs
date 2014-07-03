using System;

class E1PrintNumbers
{
    static void Main ()
    {
        // Write a program that prints all the numbers from 1 to N.        
        int N = number ();

        for (int index = 1; index < N + 1; index++)
        {
            Console.WriteLine (index);
        }
    }


    static int number () // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        int number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter a number : ");
            isNumber = int.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
