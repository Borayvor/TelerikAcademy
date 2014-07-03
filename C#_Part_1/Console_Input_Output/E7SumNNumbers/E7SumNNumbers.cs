using System;

class E7SumNNumbers
{
    static void Main ()
    {
        double n = -5E+307;

        do
        {
            Console.Write ("Please, enter number of digits : n = ");
            n = enterNum (Console.ReadLine ());
        } while (n == -5E+307);

        double sum = 0;

        for (int index = 0; index < n; index++)
        {
            double number = -5E+307;

            do
            {
                Console.Write ("Please, enter a number : ");
                number = enterNum (Console.ReadLine ());
            } while (number == -5E+307);

            sum += number;
        }

        Console.WriteLine ("The sum of the given numbers is : {0}", sum);
    }


    private static double enterNum (string value) // проверява дали е въведено число
    {
        double number = 0;
        bool result = double.TryParse (value, out number);

        if (result)
        {
            return number; // Ако е число го  връща като стойност
        }
        else
        {
            return -5E+307; //Ако не е число връща -5E+307
        }
    }
}
