using System;

class E9CheckThePointCAndR
{
    static void Main ()
    {
        Console.Write ("Enter coordinate \"x\": ");
        double x = double.Parse (Console.ReadLine ());

        Console.Write ("Enter coordinate \"y\": ");
        double y = double.Parse (Console.ReadLine ());

        Console.WriteLine (-2 - 1);

        if (((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 9) && ((x >= -1 && x <= 5) && (y >= -1 && y <= 1)))
        {
            Console.WriteLine ("The point is within the circle K((1,1),3) and in rectangle " +
            "R(top = 1, left = -1, width = 6, height = 2).");
        }
        else
        {
            Console.WriteLine ("The point is out of the circle K((1,1),3) or out of rectangle " + 
                "R(top = 1, left = -1, width  =6, height = 2).");
        }
    }
}
