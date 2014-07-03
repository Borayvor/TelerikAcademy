using System;

class E1OddOrEven
{
    static void Main ()
    {
        int number;

        Console.Write ("Enter number: ");

        number = Int32.Parse (Console.ReadLine ());

        if (number == 0)
        {
            Console.WriteLine ("The number {0} is neither even nor odd.", number);
        }
        else if (number % 2 == 0)
        {
            Console.WriteLine ("The number {0} is even.", number);
        }
        else
        {
            Console.WriteLine ("The number {0} is odd.", number);
        }
    }
}
