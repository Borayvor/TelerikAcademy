using System;

class E8User_sChoice
{
    static void Main ()
    {
        Console.WriteLine ("Write a program that, depending on the user's choice inputs int, " + 
                            "double or string variable. If the variable is integer or double, increases " + 
                            "it with 1. If the variable is string, appends \" * \" at its end. The program must " + 
                            "show the value of that variable as a console output. Use switch statement.");
        Console.WriteLine ();

        int varInt;
        double varDouble;
        string varString;
        bool isInt = false;
        bool isDouble = false;
        byte choice = 0;

        Console.Write ("Please, enter varible : ");
        varString = Console.ReadLine ();
        isInt = int.TryParse (varString, out varInt);
        isDouble = double.TryParse (varString, out varDouble);

        if (isInt)
        {
            choice = 1;
        }
        else if (isDouble)
        {
            choice = 2;
        }


        switch (choice)
        {
            case 1:
                Console.WriteLine ("int + 1 : {0}", (varInt + 1));
                break;
            case 2:
                Console.WriteLine ("double + 1 : {0}", (varDouble + 1));
                break;
            default:
                Console.WriteLine ("string + * : {0}", (varString + "*"));
                break;
        }
    }
}
