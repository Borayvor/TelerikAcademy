using System;

class E1ExchangesValues
{
    static void Main ()
    {
        Console.WriteLine ("The program read two integer variables and exchanges their values " + 
                            "if the first one is greater than the second one.");

        int firstVariable = -2147483648;
        do
        {
            Console.Write ("Please, enter First variable : ");
            firstVariable = enterNum (Console.ReadLine ());
        } while (firstVariable == -2147483648);

        int secondVariable = -2147483648;
        do
        {
            Console.Write ("Please, enter Second variable : ");
            secondVariable = enterNum (Console.ReadLine ());
        } while (secondVariable == -2147483648);

        if (firstVariable > secondVariable)
        {
            int variable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = variable;

            Console.WriteLine ("First variable = {0}", firstVariable);
            Console.WriteLine ("Second variable = {0}", secondVariable);
        }
        else
        {
            Console.WriteLine ("First variable = {0}", firstVariable);
            Console.WriteLine ("Second variable = {0}", secondVariable);
        }
    }



    private static int enterNum (string value) // проверява дали е въведено число
    {
        int number = 0;
        bool result = int.TryParse (value, out number);

        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return -2147483648; //Ако не е число връща -2,147,483,648
        }
    }
}
