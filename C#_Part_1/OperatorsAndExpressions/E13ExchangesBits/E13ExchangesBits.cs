using System;

class E13ExchangesBits
{
    static void Main ()
    {
        // алгоритъмът е копиран от: https://github.com/CuST0M1z3/OperatorsExpressionsAndStatements/blob/master/13.%20ExchangeBits/ExchangeBits.cs
        Console.Write ("Enter an integer: ");
        int number = int.Parse (Console.ReadLine ());

        Console.WriteLine (GetIntBinaryString (number) + " = " + number);

        int position1 = 3;
        int position2 = 24;

        int mask1 = 7 << position1;
        int mask2 = 7 << position2;

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
