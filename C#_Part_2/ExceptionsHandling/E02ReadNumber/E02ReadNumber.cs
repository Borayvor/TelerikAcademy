using System;

class E02ReadNumber
{
    static void Main ()
    {
        // Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
        // If an invalid number or non-number text is entered, the method should throw an exception. Using this
        // method write a program that enters 10 numbers:
		//	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

        int start = -10;
        int end = 20;

        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.Write ("Enter a Integer : ");
                int newNumber = ReadNumber (start, end);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine (aoore.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine (fe.Message);
            }
        }
    }


    static int ReadNumber (int start, int end)
    {
        if (start > end) return ReadNumber (end, start);

        int number;
        try
        {
            number = int.Parse (Console.ReadLine ());
        }
        catch (FormatException fe)
        {
            throw new FormatException ("Not a Integer !", fe);
        }

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException ();
        }

        return number;
    }
}
