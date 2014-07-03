using System;

class E3Rectangle_sArea
{
    static void Main ()
    {
        Console.WriteLine ("Calculation of rectangle’s area by given width and height.");

        Console.Write ("Please enter a width: ");
        double width = double.Parse (Console.ReadLine ());

        Console.Write ("Please enter a height: ");
        double height = double.Parse (Console.ReadLine ());

        Console.WriteLine ("Rectangle area is: {0}", (width * height));        
    }
}
