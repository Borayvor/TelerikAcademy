using System;

class E8TheGreatestCommonDivisor
{
    static void Main ()
    {
        // Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm.

        int firstNumber = number ("first number");
        int secondNumber = number ("second number");

        Console.WriteLine ("The greatest common divisor (GCD) of {0} and {1} is {2}",
                            firstNumber, secondNumber, gcd (firstNumber, secondNumber));
    }


    static int number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
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


    static int gcd (int firstNumber, int secondNumber) // Взимайки двете дадени на входа на алгоритъма числа a и b, 
    {                                                 // провери дали b е равно на 0    
        if (secondNumber == 0)
        {   // Ако да, числото a е търсеният най-голям общ делител
            return firstNumber; 
        }
        else
        {   // Ако не, повтори процеса, като използваш за входни данни b и остатъка, получен при деленето a на b
            return gcd (secondNumber, firstNumber % secondNumber);
        }
    }
}
