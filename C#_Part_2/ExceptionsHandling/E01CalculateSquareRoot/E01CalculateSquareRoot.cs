using System;

class E01CalculateSquareRoot
{
    static void Main ()
    {
        // Write a program that reads an integer number and calculates and prints its square root. If the 
        // number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
        // Use try-catch-finally.

        try
        {
            int number = int.Parse (Console.ReadLine ());
            if (number < 0)
            {
                throw new ArgumentException ("Invalid number");
            }
            Console.WriteLine ("Sqrt({0}) = {1}", number, Math.Sqrt (number));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine (ae.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine ("Invalid number !");
        }
        finally
        {
            Console.WriteLine ("Good bye !");
        }
    }
}
