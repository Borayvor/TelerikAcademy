using System;


class E06SumOfValuesFromString
{
    static void Main ()
    {
        // You are given a sequence of positive integer values written into a string, separated by spaces. 
        // Write a function that reads these values from given string and calculates their sum.
        Console.Write ("Please, enter a sequence of positive integer values, separated by spaces : ");
        string readNumbers = Console.ReadLine ();

        Console.WriteLine ("The sum of these values is : {0}", SumOfValues (readNumbers));
    }


    static int SumOfValues (string readNumbers)
    {
        char[] charSeparators = new char[] { ' ' };
        string[] numbers = readNumbers.Split (charSeparators, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        foreach (string stringNumber in numbers)
        {
            int intNumber = 0;

            if ((int.TryParse (stringNumber, out intNumber)) && intNumber >= 0)
            {
                sum += intNumber;
            }
        }

        return sum;
    }
}
