using System;

class E11BitOfNumber
{
    static void Main ()
    {
        Console.Write ("Enter an integer: ");
        int i = int.Parse (Console.ReadLine ());

        Console.Write ("Enter position of the bit: ");
        int b = int.Parse (Console.ReadLine ());

        int mask = 1 << b;
        int iAndMask = i & mask;
        int bit = iAndMask >> b;

        Console.WriteLine ("On position {0} of number {1} value of bit  is {2}.", b, i, bit);
    }
}
