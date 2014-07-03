using System;

class E2BooleanExpression
{
    static void Main ()
    {
        Console.Write("Please enter integer: ");

        int var = int.Parse(Console.ReadLine());

        bool checkVar = (var % 35 == 0);

        Console.WriteLine ("The statement that the integer can be divided by 5 and 7 is {0}", checkVar);
    }
}
