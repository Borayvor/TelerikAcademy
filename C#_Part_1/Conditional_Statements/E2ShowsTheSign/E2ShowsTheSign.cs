using System;


class E2ShowsTheSign
{
    static void Main ()
    {
        Console.WriteLine ("Write a program that shows the sign (+ or -) of the product of three " + 
                            "real numbers without calculating it. Use a sequence of if statements.");
        float firstVariable, secondVariable, thirdVariable;

        Console.Write ("Please, enter First variable : ");
        bool isNumber = float.TryParse (Console.ReadLine (), out firstVariable);

        Console.Write ("Please, enter Second variable : ");
        isNumber = float.TryParse (Console.ReadLine (), out secondVariable);

        Console.Write ("Please, enter Thrid variable : ");
        isNumber = float.TryParse (Console.ReadLine (), out thirdVariable);

        if (isNumber)
        {
            if (firstVariable == 0 || secondVariable == 0 || thirdVariable == 0)
            {
                Console.WriteLine ("The product is zero.");
            }
            else
            {
                bool positive = true;
                // променя positive само когато числото е по-малко от нула, като запазва последната промяна
                if (firstVariable < 0)
                {
                    positive = !positive;
                }
                if (secondVariable < 0)
                {
                    positive = !positive;
                }
                if (thirdVariable < 0)
                {
                    positive = !positive;
                }
                //ако positive = true показва positive, ако positive = false показва negative
                Console.WriteLine ("The product of the numbers is {0}!", positive ? "positive" : "negative");
            }
        }
        else
        {
            Console.WriteLine ("Not a number.");
        }
    }
}
