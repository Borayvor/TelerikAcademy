using System;

class E7GreatestOfGivenFive
{
    static void Main ()
    {
        Console.WriteLine ("Write a program that finds the greatest of given 5 variables.");
        Console.WriteLine ();

        double firstVariable = number ("First variable");
        double secondVariable = number ("Second variable");
        double thirdVariable = number ("Third variable");
        double fourthVariable = number ("Fourth variable");
        double fifthVariable = number ("Fifth variable");

        double greatest = 0;
        greatest = isgreatest (greatest, firstVariable);
        greatest = isgreatest (greatest, secondVariable);
        greatest = isgreatest (greatest, thirdVariable);
        greatest = isgreatest (greatest, fourthVariable);
        greatest = isgreatest (greatest, fifthVariable);

        Console.WriteLine ("The greatest of given 5 variables is : {0}", greatest);
    }



    static double isgreatest (double first, double second) // намира по-голямото от две числа
    {
        double greatest = 0;

        if (first > second)
        {
            greatest = first;
        }
        else
        {
            greatest = second;
        }
        return greatest;
    }


    static double number (string variableName) // проверява дали стойността е число и дали е в обхвата на "double"
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
