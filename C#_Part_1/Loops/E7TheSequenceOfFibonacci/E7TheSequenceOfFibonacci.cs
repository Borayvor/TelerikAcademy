using System;

class E7TheSequenceOfFibonacci
{
    static void Main ()
    {
        // Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci
        int N = 0;
        do
        {
            N = number ("how many are members of the sequence of Fibonacci");
        } while (N < 1);
        Console.WriteLine ();

        Console.WriteLine ("Sequence of Fibonacci :");
        for (int index = 0; index < N; index++)
        {
            Console.WriteLine (fib (index));
        }
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


    public static ulong fib (int n) // изчислява стойността на всеки член на последователността на Фибоначи
    {
        ulong number1 = 0, number2 = 1;

        for (ulong index = 0; index < (ulong) n; index++)
        {
            ulong savePrev1 = number1;
            number1 = number2;
            number2 = savePrev1 + number2;
        }
        return number1;
    }
}
