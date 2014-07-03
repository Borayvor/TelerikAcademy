using System;

class Е14ExchangesBitsInRange
{
    static void Main ()
    {
        Console.Write ("Enter an integer: ");
        int number = int.Parse (Console.ReadLine ());

        Console.Write ("Enter first position: ");
        int position1 = int.Parse (Console.ReadLine ());

        Console.Write ("Enter second position: ");
        int position2 = int.Parse (Console.ReadLine ());

        int range = 0;
        do
        {
        Console.Write ("Enter range of bits less or equal on {0}: ", (31 - position2));
        range = int.Parse (Console.ReadLine ());
        } while (range < 1 || range > (31 - position2));

        Console.WriteLine (GetIntBinaryString (number) + " = " + number);

        int rangeMask = 0;
        for (int i = 0; i < range; i++ )
        {
            int m = 1 << i;
            rangeMask = rangeMask | m;
        }

        int mask1 = rangeMask << position1;
        int mask2 = rangeMask << position2;

        int firstSeq = number & mask1;
        Console.WriteLine (GetIntBinaryString (firstSeq) + " - firstSeq");

        int seconSeq = number & mask2;
        Console.WriteLine (GetIntBinaryString (seconSeq) + " - seconSeq");

        int change = (number & ~mask1) & ~mask2;
        Console.WriteLine (GetIntBinaryString (change) + " - change");

        int mask3 = (firstSeq >> position1) << position2;
        Console.WriteLine (GetIntBinaryString (mask3) + " - mask3");

        int mask4 = (seconSeq >> position2) << position1;
        Console.WriteLine (GetIntBinaryString (mask4) + " - mask4");

        int result = (change | mask3) | mask4;
        Console.WriteLine (GetIntBinaryString (result) + " = " + result);
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
