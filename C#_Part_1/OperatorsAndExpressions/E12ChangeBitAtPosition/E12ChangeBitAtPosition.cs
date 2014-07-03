using System;

class E12ChangeBitAtPosition
{
    static void Main ()
    {
        Console.Write ("Enter an integer: ");
        int n = int.Parse (Console.ReadLine ());

        Console.Write ("Enter position of the bit: ");
        int p = int.Parse (Console.ReadLine ());

        int v = 0;
        do
        {
        Console.Write ("Enter value of the bit - 0 or 1: ");
        v = int.Parse (Console.ReadLine ());
        }while (v < 0 || v > 1);
       

        Console.WriteLine (GetIntBinaryString (n) + " = " + n);

        int mask;
        int nAndMask;

        if (v == 1)
        {
            mask = 1 << p;
            nAndMask = n | mask;
        }
        else
        {
            mask = 1 << p;
            nAndMask = n ^ mask;
        }

        Console.WriteLine (GetIntBinaryString (nAndMask) + " = " + nAndMask);
    }


    static string GetIntBinaryString (int number)
    {
        char[] bit = new char[32];
        int pos = 31;
        int index = 0;

        while (index < 32)
        {
            if ((number & (1 << index)) != 0)
            {
                bit[pos] = '1';
            }
            else
            {
                bit[pos] = '0';
            }
            pos--;
            index++;
        }
        return new string (bit);
    }
}
