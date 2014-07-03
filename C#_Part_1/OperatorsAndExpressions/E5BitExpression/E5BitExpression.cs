using System;

class E5BitExpression
{
    static void Main ()
    {
        Console.WriteLine ("Please enter a integer to check if the bit 3 " + 
            "(counting from 0) is 1 or 0 : ");
        int number = Int32.Parse (Console.ReadLine ());

        int mask = 1 << 3;

        int numberAndMask = number & mask;

        int bit = numberAndMask >> 3;

        Console.WriteLine ("Third bit is " + bit);
    }
}
