using System;

class E2NumbersNotDivBy3and7
{
    static void Main ()
    {
        // Write a program that prints all the numbers from 1 to N, that are not 
        // divisible by 3 and 7 at the same time.

        int N = number ();

        for (int index = 1; index < N + 1; index++)
        {
            if (index % 21 != 0)
            {
                Console.WriteLine (index);
            }
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
