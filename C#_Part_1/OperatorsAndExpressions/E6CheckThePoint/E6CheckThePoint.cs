using System;

class E6CheckThePoint
{
    static void Main ()
    {
        Console.Write ("Enter coordinate \"x\": ");
        double x = double.Parse (Console.ReadLine ());

        Console.Write ("Enter coordinate \"y\": ");
        double y = double.Parse (Console.ReadLine ());

        if (((x * x) + (y * y)) <= 25)
        {
            Console.WriteLine ("The point is within the circle K(0, 5).");
        }
        else
        {
            Console.WriteLine("The point is out of the circle K(0, 5).");
        }
    }
}
