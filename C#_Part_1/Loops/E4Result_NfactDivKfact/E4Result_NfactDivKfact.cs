using System;

class E4Result_NfactDivKfact
{
    static void Main ()
    {
        // Write a program that calculates N!/K! for given N and K (1<K<N).
        Console.WriteLine ("Please enter (1 < K < N):");
        int N = 0;
        int K = 0;
        do
        {
            N = number ("N");
            K = number ("K");
        } while ((N < K) || (K < 1));
                
        Console.WriteLine ("Result of operation (N! / K!) is : {0}", ((double) factorial (N) / factorial (K)));
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
