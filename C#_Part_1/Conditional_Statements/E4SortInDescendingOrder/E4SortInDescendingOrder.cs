using System;

class E4SortInDescendingOrder
{
    static void Main ()
    {
        Console.WriteLine ("Sort 3 real values in descending order using nested if statements.");
        double firstVariable, secondVariable, thirdVariable;

        Console.Write ("Please, enter First variable : ");
        bool isNumber = double.TryParse (Console.ReadLine (), out firstVariable);

        Console.Write ("Please, enter Second variable : ");
        isNumber = double.TryParse (Console.ReadLine (), out secondVariable);

        Console.Write ("Please, enter Thrid variable : ");
        isNumber = double.TryParse (Console.ReadLine (), out thirdVariable);

        if (isNumber)
        {
            if (firstVariable < secondVariable)
            {
                double variable = firstVariable;
                firstVariable = secondVariable;
                secondVariable = variable;

                if (secondVariable < thirdVariable)
                {
                    variable = secondVariable;
                    secondVariable = thirdVariable;
                    thirdVariable = variable;

                    if (firstVariable < secondVariable)
                    {
                        variable = firstVariable;
                        firstVariable = secondVariable;
                        secondVariable = variable;
                    }
                }
            }
            else
            {
                if (secondVariable < thirdVariable)
                {
                    double variable = secondVariable;
                    secondVariable = thirdVariable;
                    thirdVariable = variable;

                    if (firstVariable < secondVariable)
                    {
                        variable = firstVariable;
                        firstVariable = secondVariable;
                        secondVariable = variable;
                    }
                }
            }
            Console.WriteLine ("First variable : {0}", firstVariable);
            Console.WriteLine ("Second variable : {0}", secondVariable);
            Console.WriteLine ("Thrid variable : {0}", thirdVariable);
        }
        else
        {
            Console.WriteLine ("No one of these variables is not a number.");
        }
    }
}
