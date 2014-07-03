using System;

class E02TenRandomValues
{
    static void Main ()
    {
        // Write a program that generates and prints to the console 10 random values in the range [100, 200].
        Random randomValue = new Random ();

        for (int index = 1; index <= 10; index++)
        {
            Console.WriteLine ("{0} : {1}", index, randomValue.Next (100, 201));
        }
    }
}
