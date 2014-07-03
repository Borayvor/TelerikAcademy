using System;

class E14NNumbersArrangedAsASpiral
{
    static void Main ()
    {
        // * Write a program that reads a positive integer number N (N < 20) from console and outputs in the 
        // console the numbers 1 ... N numbers arranged as a spiral.
        int N = 0;
        do
        {
            N = number ("a positive integer number N (N < 20)");
        } while (N < 1 || N > 19);

        Console.WriteLine ();

        spiralSort (N);
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


    static void spiralSort (int N) // създава и запълва матрицата
    {
        int[,] matrix = new int[N, N];

        int index = 0;

        int start = 0, end = N;

        int vertikal = 0, horizontal = 0;

        while ((end - start) > 0)
        {
            for (horizontal = start; horizontal < end; horizontal++)
            {
                index++;

                matrix[vertikal, horizontal] = index;
            }

            horizontal--;

            for (vertikal = start + 1; vertikal < end; vertikal++)
            {
                index++;

                matrix[vertikal, horizontal] = index;
            }

            vertikal--;

            for (horizontal = end - 2; horizontal >= start; horizontal--)
            {
                index++;

                matrix[vertikal, horizontal] = index;
            }

            horizontal++;

            for (vertikal = end - 2; vertikal >= start + 1; vertikal--)
            {
                index++;

                matrix[vertikal, horizontal] = index;
            }

            vertikal++;

            

            start++;

            end--;
        }

        string line = new string ('-', (N * 6));

        for (int column = 0; column < matrix.GetLength (0); column++) // отпечатва матрицата
        {
            Console.WriteLine (line + "-");
            Console.Write ("|");
            for (int row = 0; row < matrix.GetLength (1); row++)
            {
                if (matrix[column, row] < 10)
                {
                    Console.Write ("  ");
                }
                else if (matrix[column, row] < 100)
                {
                    Console.Write (" ");
                }
                Console.Write (" {0} |", matrix[column, row]);
            }
            Console.WriteLine ();
        }
        Console.WriteLine (line + "-");
    }
}
