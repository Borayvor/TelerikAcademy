using System;

class E3ComparesTwoCharArrays
{
    static void Main ()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).

        Console.Write ("Please enter sequence of character for arrayOne: ");
        string arrayOne = Console.ReadLine ();

        Console.WriteLine ();

        Console.Write ("Please enter sequence of character for arrayTwo: ");
        string arrayTwo = Console.ReadLine ();

        Console.WriteLine ();

        for (int index = 0; index < (Math.Min (arrayOne.Length, arrayTwo.Length)); index++)
        {
            int rezult = (arrayOne[index].CompareTo (arrayTwo[index]));

            if (rezult > 0)
            {
                Console.WriteLine (arrayOne[index] + " is before " + arrayTwo[index]);
            }
            else if (rezult < 0)
            {
                Console.WriteLine (arrayOne[index] + " is after " + arrayTwo[index]);
            }
            else
            {
                Console.WriteLine (arrayOne[index] + " equal " + arrayTwo[index]);
            }
        }
    }
}
