using System;

class E3MinAndMaxOfNNumbers
{
    static void Main ()
    {
        // Write a program that reads from the console a sequence of N integer numbers and returns 
        // the minimal and maximal of them.

        int N = number ("size of the sequence N");
        
        int intNumber = number ("a number");
        int minNumber = intNumber;
        int maxNumber = intNumber;

        for (int index = 1; index < N; index++)
        {
            intNumber = number ("a number");

            if (minNumber > intNumber)
            {
                minNumber = intNumber;
            }

            if (maxNumber < intNumber)
            {
                maxNumber = intNumber;
            }
        }

        Console.WriteLine ("Minmal number is {0}", minNumber);
        Console.WriteLine ("Maximal number is {0}", maxNumber);
    }


    static int number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
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
