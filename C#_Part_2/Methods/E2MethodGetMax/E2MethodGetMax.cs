using System;

class E2MethodGetMax
{
    static void Main ()
    {
        // Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program 
        // that reads 3 integers from the console and prints the biggest of them using the method GetMax().
        int first = Number ("first number");
        int second = Number ("second number");
        int third = Number ("third number");

        Console.WriteLine ("{0} is the biggest number.", GetMax (GetMax (first, second), third));
    }


    static int GetMax (int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else if (first < second)
        {
            return second;
        }
        else
        {
            return first;
        }
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
