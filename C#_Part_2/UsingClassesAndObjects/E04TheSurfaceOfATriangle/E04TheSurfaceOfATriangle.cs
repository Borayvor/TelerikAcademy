using System;
using System.Threading;

class E04TheSurfaceOfATriangle
{
    static void Main ()
    {
        // Write methods that calculate the surface of a triangle by given:
        // - Side and an altitude to it; 
        // - Three sides; 
        // - Two sides and an angle between them. 
        // Use System.Math.

        CalculateSurfaceOfTriangle ();        
    }


    static void CalculateSurfaceOfTriangle ()
    {
        double sideA;
        double sideB;
        double sideC;
        double altitude;
        int angle;
        byte userChoise;
        double surface;

        Console.WriteLine ("Choose the method to calculate the surface of a triangle.");
        Console.WriteLine ();
        Console.WriteLine ("1. By side and altitude.");
        Console.WriteLine ("2. By tree sides.");
        Console.WriteLine ("3. Two sides and an angle between them. ");
        Console.WriteLine ("4. Exit.");
        Console.WriteLine ();
        
        do
        {
            userChoise = (byte) Number ("your choice");
        } while (userChoise < 1 || userChoise > 4);

        switch (userChoise)
        {
            case 1:
                Console.WriteLine ();
                sideA = Number ("side A");
                altitude = Number ("altitude");
                if (sideA > 0 && altitude > 0)
                {
                    surface = TriangleSurface (sideA, altitude);
                    Console.WriteLine ("The surface is : {0}", surface);
                }
                else
                {
                    Console.WriteLine ("The side or altitude of triangle is not correct.");
                    Thread.Sleep (2000);
                    Console.Clear ();
                    Main ();
                }
                break;
            case 2:
                Console.WriteLine ();
                sideA = Number ("side A");
                sideB = Number ("side B");
                sideC = Number ("side C");
                if (Math.Pow (sideC, 2) == Math.Pow (sideA, 2) + Math.Pow (sideB, 2))
                {
                    surface = TriangleSurface (sideA, sideB, sideC);
                    Console.WriteLine ("The surface of triangle is : {0}", surface);
                }
                else
                {
                    Console.WriteLine ("One of the sides is not correct.");
                    Thread.Sleep (2000);
                    Console.Clear ();
                    Main ();
                }
                break;
            case 3:
                Console.WriteLine ();
                sideA = Number ("side A");
                sideB = Number ("side B");
                angle = (int) Number ("an angle");
                if (angle > 0 && angle < 180 && sideA > 0 && sideB > 0)
                {
                    surface = TriangleSurface (sideA, sideB, angle);
                    Console.WriteLine ("The surface of triangle is : {0}", surface);
                }
                else
                {
                    Console.WriteLine ("The angle or side is not correct.");
                    Thread.Sleep (2000);
                    Console.Clear ();
                    Main ();
                }
                break;
            default :
                Console.OpenStandardOutput ();
                break;
        } 
    }


    static double TriangleSurface (double side, double altitude)
    {
        return ((side * altitude) / 2);
    }


    static double TriangleSurface (double sideA, double sideB, double sideC)
    {
        double semiperimeter = ((sideA + sideB + sideC) / 2);

        return Math.Sqrt (semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
    }


    static double TriangleSurface (double sideA, double sideB, int angle)
    {
        double pi = Math.PI;

        double sin = Math.Sin ((angle * pi) / 180);

        return ((sideA * sideB * sin) / 2);
    }


    static double Number (string name) // проверява дали стойността е число и дали е в обхвата на "double"
    {                                     // ако това е изпълнено връща стойността на числото  
        double number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = double.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false && number < 0);

        return number;
    }
}
