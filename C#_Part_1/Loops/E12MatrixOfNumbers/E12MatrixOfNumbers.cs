using System;

class E12MatrixOfNumbers
{
    static void Main ()
    {
        // Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix
        int N = 0;
        do
        {
            N = number ("a positive integer number N (N < 20)");
        } while (N < 1 || N > 19);

        Console.WriteLine ();

        string line = new string ('-', (N * 5));

        for (int column = 0; column < N; column++)
        {
            Console.WriteLine (line + "-");
            Console.Write ("|");
            for (int row = 1; row < N + 1; row++)
            {
                if ((row + column) < 10)
                {
                    Console.Write (" ");
                }
                Console.Write (" {0} |", (row + column));                
            }
            Console.WriteLine ();
        }
        Console.WriteLine (line + "-");
    }


    static int number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
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
