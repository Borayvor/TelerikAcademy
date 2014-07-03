using System;

class E02ReverseString
{
    static void Main ()
    {
        // Write a program that reads a string, reverses it and prints the result at the console.
        Console.WriteLine ("Enter a string :");
        string inputString = Console.ReadLine ();

        char[] outputString = inputString.ToCharArray ();

        for (int index = outputString.Length - 1; index >= 0; index--)
        {
            Console.Write (outputString[index]);
        }
        Console.WriteLine ();
    }
}
