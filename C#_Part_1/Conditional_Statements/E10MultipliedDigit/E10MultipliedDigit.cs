using System;

class E10MultipliedDigit
{
    static void Main ()
    {
        Console.WriteLine ("    Write a program that applies bonus scores to given scores in the range [1..9]." + 
            " The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies " + 
            "it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it" + 
            " by 1000. If it is zero or if the value is not a digit, the program must report an error.\n" + 
		    "   Use a switch statement and at the end print the calculated new value in the console");
        Console.WriteLine ();

        Console.Write ("Please, enter number between 1 and 9 : ");
        byte digit = byte.Parse (Console.ReadLine ());
        ushort result = 0;
        
        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                {
                    result = (ushort)(digit * 10);
                    Console.WriteLine ("The value is : {0}", result);
                    break;
                }
            case 4:
            case 5:
            case 6:
                {
                    result = (ushort)(digit * 100);
                    Console.WriteLine ("The value is : {0}", result);
                    break;
                }
            case 7:
            case 8:
            case 9:
                {
                    result = (ushort) (digit * 1000);
                    Console.WriteLine ("The value is : {0}", result);
                    break;
                }
            default:
                {
                    Console.WriteLine ("The value is out of range.");
                    break;
                }
        }        
    }
}
