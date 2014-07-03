using System;

class E6QuadraticEquation
{
    static void Main ()
    {
        Console.WriteLine ("Write a program that enters the coefficients a, b and c of a quadratic equation " +
                            "a*x2 + b*x + c = 0	and calculates and prints its real roots. Note that quadratic " +
                            "equations may have 0, 1 or 2 real roots.");
        Console.WriteLine ();
        
        double a = number ('a');
        double b = number ('b');
        double c = number ('c');

        Console.WriteLine ("\n{0}(x * x) + {1}x + {2} = 0\n", a, b, c);

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



    static double number (char variableName) // проверява дали стойността е число и дали е в обхвата на "double"
    {
        double number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0} = ", variableName);
            isNumber = double.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
