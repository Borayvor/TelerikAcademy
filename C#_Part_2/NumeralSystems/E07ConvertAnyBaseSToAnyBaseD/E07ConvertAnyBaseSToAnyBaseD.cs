using System;

class E07ConvertAnyBaseSToAnyBaseD
{
    static void Main ()
    {
        // Write a program to convert from any numeral system of given base s to any other numeral system 
        // of base d (2 ≤ s, d ≤  16).

        int BaseX = Number ("the base of the input value");
        char inputBase = GetChar (BaseX);

        string number = null;
        do
        {
            Console.Write ("Eter the number : ");
            number = Console.ReadLine ();
        } while (!CheckNumberBase (number, inputBase));

        int BaseY = Number ("the base of the output value");
        
        string XNumber = Base10ToBaseX (BaseXToBase10 (number, BaseX), BaseY);

        Console.WriteLine ("Convert base {0} number to base {1} representation : {2}", BaseX, BaseY, XNumber);

    }


    static bool CheckNumberBase (string number, char x)
    {
        foreach (char digit in number)
        {
            if (digit >= x)
            {
                return false;
            }
        }
        return true;
    }


    static char GetChar (int digit)
    {
        if (digit >= 10)
        {
            return (char) ('A' + digit - 10);
        }
        else
        {
            return (char) ('0' + digit);
        }
    }


    static int GetDigit (string number, int index)
    {
        if (number[index] >= 'A')
        {
            return number[index] - 'A' + 10;
        }
        else
        {
            return number[index] - '0';
        }
    }


    static string Base10ToBaseX (int decimalNumber, int BaseX)
    {
        string XNumber = null;

        for (; decimalNumber != 0; decimalNumber /= BaseX)
        {
            XNumber = GetChar (decimalNumber % BaseX) + XNumber;
        }

        return XNumber;
    }


    static int BaseXToBase10 (string number, int BaseX)
    {
        int decimalNumber = 0;        

        for (int index = number.Length - 1; index >= 0; index--)
        {
            decimalNumber += ((GetDigit (number, index)) * ((int) Math.Pow (BaseX, (number.Length - 1) - index)));
        }

        return decimalNumber;
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
