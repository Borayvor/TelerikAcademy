using System;

class E04HexadecimalToDecimal
{
    static void Main ()
    {
        // Write a program to convert hexadecimal numbers to their decimal representation.
        
        int decimalNumber = Convert.ToInt32 (GetHexadecimalNumber (), 16);

        Console.WriteLine ("Convert hexadecimal numbers to their decimal representation : {0}", decimalNumber);
    }


    static string GetHexadecimalNumber ()
    {
        bool isHexadecimal;
        string hexadecimalNumber;

        do
        {
            isHexadecimal = true;
            Console.Write ("Please, enter a hexadecimal number : ");
            hexadecimalNumber = Console.ReadLine ();

            for (int index = 0; index < hexadecimalNumber.Length; index++)
            {                
                if ((hexadecimalNumber[index] < '0' || hexadecimalNumber[index] > '9') &&
                    (hexadecimalNumber[index] < 'A' || hexadecimalNumber[index] > 'F'))
                {
                    isHexadecimal = false;
                    break;
                }
            }
        } while (!isHexadecimal);

        return hexadecimalNumber;
    }
}
