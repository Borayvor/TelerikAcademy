using System;

class E6CalculatesTheSum
{
    static void Main ()
    {
        // Write a program that, for a given two integer numbers N and X, 
        // calculates the sumS = 1 + 1!/X + 2!/X_2 + … + N!/X_N
        int N = 0;
        int X = number ("X");

        do
        {
            N = number ("N");            
        } while (N < 1);

        double sum = 1;

        for (int index = 1; index < N + 1; index++)
        {
            sum += ( factorial (index) / Math.Pow (X, index) );
        }

        Console.WriteLine ("Result of operation is: \nsum = {0}", sum);
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

    static int factorial (int number) // изчислява стойността на факториела от даденото число
    {
        int factorial = 1;
        for (int index = number; index > 1; index--)
        {
            factorial *= index;
        }
        return factorial;
    }
}
