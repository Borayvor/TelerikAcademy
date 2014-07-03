using System;

class E5BiggerNumber
{
    static void Main ()
    {
        decimal firstNumber = -9999999999999999999999999999m;
        decimal secondNumber = -9999999999999999999999999999m;

        do
        {
            Console.Write ("Please, enter first number : ");
            firstNumber = enterNum (Console.ReadLine ());
        } while (firstNumber == -9999999999999999999999999999m);

        do
        {
            Console.Write ("Please, enter second number : ");
            secondNumber = enterNum (Console.ReadLine ());
        } while (secondNumber == -9999999999999999999999999999m);

        Console.WriteLine ("The higher number is : {0}", Math.Max (firstNumber, secondNumber)); // Сравнява двете числа и
                                                                                                // показва по-голямото
    }


    private static decimal enterNum (string value) // проверява дали е въведено число
    {
        decimal number = 0;
        bool result = decimal.TryParse (value, out number);

        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return -9999999999999999999999999999m; //Ако не е число връща -9999999999999999999999999999m
        }
    }
}
