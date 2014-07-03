using System;

class E5OperationsWithFactorials
{
    static void Main ()
    {
        // Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
        Console.WriteLine ("Please enter (1 < N < K):");
        int N = 0;
        int K = 0;
        do
        {
            N = number ("N");
            K = number ("K");
        } while ((K < N) || (N < 1));

        Console.WriteLine ("Result of operation " +
                "(N!*K! / (K-N)!) is : {0}", (((double) factorial (N) * factorial (K)) / factorial (K - N)));
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
