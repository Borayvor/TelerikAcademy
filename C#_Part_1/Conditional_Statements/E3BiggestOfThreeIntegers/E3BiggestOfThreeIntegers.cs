using System;

class E3BiggestOfThreeIntegers
{
    static void Main ()
    {
        Console.WriteLine ("Write a program that finds the biggest of three integers using nested if statements.");
        int firstVariable, secondVariable, thirdVariable;

        Console.Write ("Please, enter First variable : ");
        bool isNumber = int.TryParse (Console.ReadLine (), out firstVariable);

        Console.Write ("Please, enter Second variable : ");
        isNumber = int.TryParse (Console.ReadLine (), out secondVariable);

        Console.Write ("Please, enter Thrid variable : ");
        isNumber = int.TryParse (Console.ReadLine (), out thirdVariable);

        if (isNumber)
        {
            if ((firstVariable == secondVariable) && (secondVariable == thirdVariable))
            {
                Console.WriteLine ("All numbers are equal.");
            }
            else
            {
                int biggestNumber = 0;
                // променя positive само когато числото е по-малко от нула, като запазва последната промяна
                if ((firstVariable > secondVariable) && (firstVariable > thirdVariable))
                {
                    biggestNumber = firstVariable;
                }
                if ((secondVariable > firstVariable) && (secondVariable > thirdVariable))
                {
                    biggestNumber = secondVariable;
                }
                if ((thirdVariable > firstVariable) && (thirdVariable > secondVariable))
                {
                    biggestNumber = thirdVariable;
                }
                //ако positive = true показва positive, ако positive = false показва negative
                Console.WriteLine ("The biggest of these  three integers is : {0}", biggestNumber);
            }
        }
        else
        {
            Console.WriteLine ("No one of these variables is not a number.");
        }
    }
}
