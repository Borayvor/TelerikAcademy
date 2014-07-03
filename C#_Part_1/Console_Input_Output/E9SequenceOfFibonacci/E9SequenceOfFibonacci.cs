using System;

class E9SequenceOfFibonacci
{
    static void Main ()
    {
        Console.WriteLine ("Sequence of Fibonacci :");

        for (int index = 0; index < 100; index++)
        {
            Console.WriteLine (fib (index));
        }
    }


    public static ulong fib (int n)
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
