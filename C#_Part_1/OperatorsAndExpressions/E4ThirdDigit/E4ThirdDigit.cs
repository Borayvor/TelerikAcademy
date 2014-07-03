using System;

class E4ThirdDigit
{
    static void Main ()
    {
        Console.WriteLine ("Please enter a integer to check if its third digit (right-to-left) is 7 : ");
        int var = Int32.Parse (Console.ReadLine ());

        int number = var / 100;

        int result = number % 10;

        if (result == 7)
        {
            Console.WriteLine (true);
        }
        else
        {
            Console.WriteLine (false);
        }
    }
}
