using System;

class E5NameOfDigit
{
    static void Main ()
    {
        Console.WriteLine ("Write program that asks for a digit and depending on the " + 
                            "input shows the name of that digit (in English) using a switch statement.");

        byte variable;
        Console.Write ("Please enter a digit in the diapason of 0-9 : ");
        bool isNumber = byte.TryParse (Console.ReadLine (), out variable);
        String nameVariable = "";

        if (isNumber) // проверява дали стойността е число и дали е в обхвата на "byte"
        {
            switch (variable)
            {
                case 0:
                    nameVariable = "Zero";
                    break;
                case 1:
                    nameVariable = "One";
                    break;
                case 2:
                    nameVariable = "Two";
                    break;
                case 3:
                    nameVariable = "Three";
                    break;
                case 4:
                    nameVariable = "Four";
                    break;
                case 5:
                    nameVariable = "Five";
                    break;
                case 6:
                    nameVariable = "Six";
                    break;
                case 7:
                    nameVariable = "Seven";
                    break;
                case 8:
                    nameVariable = "Eight";
                    break;
                case 9:
                    nameVariable = "Nine";
                    break;
                default:
                    nameVariable = "out of range";                    
                    break;
            }
            Console.WriteLine ("The digit you have entered is {0} ({1})", nameVariable, variable);
        }
        else
        {
            Console.WriteLine("Not a number, or not in range.");
        }
    }
}
