using System;

class E13HowManyTrailingZeros
{
    static void Main ()
    {
        // * Write a program that calculates for given N how many trailing zeros present at the end of the number N!.
        // Try N = 25.
        int N = 0;        
        do
        {
            N = number ("value of N");            
        } while (N < 1);

        decimal factN = factorial (N);
        decimal valueFactN = factN;
        byte index = 0;

        do
        {
            if (valueFactN % 10 == 0)
            {
                valueFactN /= 10;
                index++;
            }
        } while (valueFactN % 10 == 0);

        Console.WriteLine ("The number of trailing zeros present at the end of the " + 
                            "number {0} are : {1}", factN, index);
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

    static decimal factorial (int number) // изчислява стойността на факториела от даденото число
    {
        decimal factorial = 1;
        for (int index = number; index > 1; index--)
        {
            factorial *= (decimal) index;
            // Console.WriteLine (factorial + " " + index);
        }
        return factorial;
    }
}
