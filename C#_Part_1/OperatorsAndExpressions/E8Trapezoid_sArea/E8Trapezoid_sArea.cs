using System;

class E8Trapezoid_sArea
{
    static void Main ()
    {
        Console.WriteLine ("This expression calculates trapezoid's area by given sides a and b and height h.");

        Console.Write ("Please enter side \"a\": ");
        double a = double.Parse (Console.ReadLine ());

        Console.Write ("Please enter side \"b\": ");
        double b = double.Parse (Console.ReadLine ());

        Console.Write ("Please enter height \"h\": ");
        double h = double.Parse (Console.ReadLine ());

        Console.WriteLine ("The trapezoid's area is: {0}", ( ((a + b) * h) / 2) );
    }
}
