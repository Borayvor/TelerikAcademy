using System;

class E4NumbersExist
{
    static void Main ()
    {
        Console.WriteLine ("Initialization of interval of numbers.");

        int startPoint = 0;
        int endPoint = 0;
        int count = 0;

        do
        {
            Console.Write ("Please, enter start point : ");
            startPoint = enterNum (Console.ReadLine ());

            Console.Write ("Please, enter end point : ");
            endPoint = enterNum (Console.ReadLine ());
        } while (startPoint < 0 || endPoint < 0 || startPoint >= endPoint);

        for (int index = startPoint; index <= endPoint; index++)
        {
            if (index % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine ();

        Console.WriteLine ("In interval between {0} and {1} exist {2} numbers" +
                            " whos remainder of the division by 5 is 0.", startPoint, endPoint, count);
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
            return -1; //Ако не е число връща -1
        }
    }
}
