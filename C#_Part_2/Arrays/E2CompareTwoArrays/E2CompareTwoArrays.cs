using System;

class E2CompareTwoArrays
{
    static void Main ()
    {
        //Write a program that reads two arrays from the console and compares them element by element.
        int length = 5;
        string[] arrayOne = new string[length];
        string[] arrayTwo = new string[length];

        for (int index = 0; index < length; index++)
        {
            Console.Write ("Please enter value for arrayOne[{0}]: ", index);
            arrayOne[index] = Console.ReadLine ();
        }
        Console.WriteLine ();
        for (int index = 0; index < length; index++)
        {
            Console.Write ("Please enter value for arrayTwo[{0}]: ", index);
            arrayTwo[index] = Console.ReadLine ();
        }

        for (int index = 0; index < length; index++)
        {
            int rezult = (arrayOne[index].CompareTo (arrayTwo[index]));

            if (rezult > 0)
            {
                Console.WriteLine (arrayOne[index] + " > " + arrayTwo[index]);
            }
            else if (rezult < 0)
            {
                Console.WriteLine (arrayOne[index] + " < " + arrayTwo[index]);
            }
            else
            {
                Console.WriteLine (arrayOne[index] + " = " + arrayTwo[index]);
            }
        }
    }
}
