using System;

class E10CheckBit
{
    static void Main ()
    {
        Console.Write ("Enter an integer: ");
        int v = int.Parse (Console.ReadLine ());

        Console.Write ("Enter position of the bit: ");
        int p = int.Parse (Console.ReadLine ());

        int mask = 1 << p;
        int vAndMask = v & mask;
        int bit = vAndMask >> p;

        if (bit == 1)
        {
            Console.WriteLine (true);
        }
        else
        {
            Console.WriteLine (false);
        }
    }
}
