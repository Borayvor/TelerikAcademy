using System;

class E9TheCatalanNumbers
{
    static void Main ()
    {
        // In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
        // Cn = ( (2 * n)! / ((n + 1)! * n!) )  for n >= 0.
        Console.WriteLine ("Calculating the number of Catalan:");
        int n = 0;
        do
        {
            n = number ("N");
        } while (n < 0);

        double Cn = ( (factorial(2 * n)) / (factorial(n + 1) * factorial(n)) );
        Console.WriteLine ("The result is : {0}", Cn);
    }


    static int number (string name) // проверява дали стойността е число и дали е в обхвата на "double"
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
