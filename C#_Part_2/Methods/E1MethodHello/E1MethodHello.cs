using System;

class E1MethodHello
{
    static void Main ()
    {
        // Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
        // Write a program to test this method.
        Hello ();
    }


    static void Hello ()
    {
        Console.WriteLine ("Hello, what's your name ?");

        string name = Console.ReadLine ();

        Console.WriteLine ("Hello, {0} !", name);
    }
}
