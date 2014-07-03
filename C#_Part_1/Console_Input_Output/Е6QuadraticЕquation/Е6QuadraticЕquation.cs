using System;

class Е6QuadraticЕquation
{
    static void Main ()
    {
        double a = -5E+307;
        double b = -5E+307;
        double c = -5E+307;
        
        Console.WriteLine ("Please, enter the coefficients a, b and c of a quadratic equation \"a(x * x) + bx + c = 0\"");

        do
        {
            Console.Write ("Please, enter : a = ");
            a = enterNum (Console.ReadLine ());
        } while (a == -5E+307);

        do
        {
            Console.Write ("Please, enter : b = ");
            b = enterNum (Console.ReadLine ());
        } while (b == -5E+307);

        do
        {
            Console.Write ("Please, enter : c = ");
            c = enterNum (Console.ReadLine ());
        } while (c == -5E+307);

        double D = (b * b) - (4 * a * c);

        if (D >= 0)
        {
            double x1 = (-b + Math.Sqrt (D)) / (2 * a);

            double x2 = (-b - Math.Sqrt (D)) / (2 * a);

            Console.WriteLine ("The real roots are :");
            Console.WriteLine ("x1 = {0}", x1);
            Console.WriteLine ("x2 = {0}", x2);
        }
        else
        {
            Console.WriteLine ("There are  no real roots.");
        }
    }


    private static double enterNum (string value) // проверява дали е въведено число
    {
        double number = 0;
        bool result = double.TryParse (value, out number);

        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return -5E+307; //Ако не е число връща -5E+307
        }
    }
}
