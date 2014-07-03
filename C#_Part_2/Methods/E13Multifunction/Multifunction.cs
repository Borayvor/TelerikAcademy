using System;

class Multifunction
{
    static void Main ()
    {
        // Write a program that can solve these tasks:
        // Reverses the digits of a number
        // Calculates the average of a sequence of integers
        // Solves a linear equation a * x + b = 0
		// Create appropriate methods.
		// Provide a simple text-based menu for the user to choose which task to solve.
		// Validate the input data:
        // The decimal number should be non-negative
        // The sequence should not be empty a should not be equal to 0.

        Menu ();
    }


    static void Menu ()
    {
        Console.WriteLine ("Please select the task you want to solve !");
        Console.WriteLine (" 1 : Reverses the digits of a number.");
        Console.WriteLine (" 2 : Calculates the average of a sequence of integers.");
        Console.WriteLine (" 3 : Solves a linear equation \"a * x + b = 0\".");
        Console.WriteLine (" 4 : Exit.");
        Console.WriteLine ();

        int choice = -1;
        do
        {
            choice = Number ("your choice");
        } while (choice < 1 || choice > 4);

        switch (choice)
        {
            case (1):
                Reverse ();
                break;
            case (2):
                Average ();
                break;
            case (3):
                Equation ();
                break;
            default:
               
                break;
        }
        Console.WriteLine ();

        Console.WriteLine ("Thank you for using our application!");
    }


    static void Reverse ()
    {
        int n = Number ("a number");

        if (n >= 0)
        {
            Console.WriteLine ("The reversed number is: " + ReverseNumber (n));
        }
        else
        {
            Console.WriteLine ("Number should be non-negative.");
        }
    }


    static void Average ()
    {    
        int[] array = new int[Number ("array size")];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Number ("a number");
        }

        Console.Write ("{ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write ("{0} ", array[i]);
        }
        Console.WriteLine ("}");

        if (array.Length > 0)
        {
            Console.WriteLine ("The average of the sequence of integers is : {0}", AverageNumber (array));
        }
        else
        {
            Console.WriteLine ("Array should have elements.");
        }
    }


    static void Equation ()
    {
        Console.WriteLine ("Please, enter \"a\" and \"b\" to solve the linear equation \"a * x + b = 0\".");

        int a = Number ("\"a\"");
        int b = Number ("\"b\"");

        if (a != 0)
        {
            Console.WriteLine ("The result is : x = {0}", EquationResult (a, b));
        }
        else
        {
            Console.WriteLine ("Coefficient \"a\" should not be zero.");
        }
    }


    static double EquationResult (int a, int b)
    {
        return ((double) -b / (double) a);
    }


    static double AverageNumber (int[] array)
    {
        double sum = 0;

        for (int index = 0; index < array.Length; index++)
        {
            sum += array[index];
        }

        return (sum / array.Length);
    }


    static long ReverseNumber (int number)
    {
        long result = 0;

        while (number != 0)
        {
            result = result * 10 + (long) number % 10; // измества получената цифра в ляво и прибавя следващата

            number /= 10;
        }

        return result;
    }


    static int Number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        int number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = int.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
