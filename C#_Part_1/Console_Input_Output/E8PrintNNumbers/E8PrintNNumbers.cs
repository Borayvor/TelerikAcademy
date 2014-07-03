using System;

class E8PrintNNumbers
{
    static void Main ()
    {
        int n = 0;

        do
        {
            Console.Write ("Please, enter an integer number : n = ");
            n = enterNum (Console.ReadLine ());
        } while (n == 0);

        Console.WriteLine ("Prints all the numbers in the interval [1..n] :");
        for (int index = 1; index <= n; ++index)
        {
            Console.WriteLine (index);
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
            return 0; //Ако не е число връща 0
        }
    }
}
