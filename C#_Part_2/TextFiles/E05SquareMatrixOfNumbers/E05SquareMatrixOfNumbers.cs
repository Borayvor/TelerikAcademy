using System;
using System.IO;

class E05SquareMatrixOfNumbers
{

    static int result = 0;
    static int[,] subMatrix = new int[2, 2];


    static void Main ()
    {
        // Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
        // an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains 
        // the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should 
        // be a single number in a separate text file.
        int[,] matrix;
        int length;
        
        using (StreamReader readerResult = new StreamReader ("SquareMatrixOfNumbers.txt"))
        {
            string line = readerResult.ReadLine ();

            length = int.Parse(line);

            matrix = new int[length, length];

            char[] characters = new [] { ' ' };

            for (int lineNumber = 0; lineNumber < length; lineNumber++)
            {
                line = readerResult.ReadLine ();

                string[] numbers = line.Split (characters, StringSplitOptions.RemoveEmptyEntries);

                for (int charNumber = 0; charNumber < length; charNumber++)
                {
                    matrix[lineNumber, charNumber] = int.Parse (numbers[charNumber]);                 
                }    
            }
        }

       
        for (int vertikal = 0; vertikal < length - 1; vertikal++)
        {
            for (int horizontal = 0; horizontal < length - 1; horizontal++)
            {
                subMatrixSum (matrix, vertikal, horizontal);
            }
        }

        print (matrix);
        print (subMatrix);

        using (StreamWriter writer = new StreamWriter ("result.txt"))
        {
            writer.Write (result);
        }
    }


    private static void subMatrixSum (int[,] array, int row, int column)
    {  
        int sum = 0;

        for (int i = 0; i < 4; i++)
        {
            sum += array[row + (i % 2), column + (i / 2)];
        }
        if (sum > result)
        {
            for (int i = 0; i < 4; i++)
            {
                subMatrix[i % 2, i / 2] = array[row + (i % 2), column + (i / 2)];
            }
            result = sum;
        }
    }


    static void print (int[,] array) // Отпечатва матрицата
    {
        string line = new string ('-', (array.GetLength (1) * 6));

        for (int column = 0; column < array.GetLength (0); column++)
        {

            Console.WriteLine (line + "-");
            Console.Write ("|");
            for (int row = 0; row < array.GetLength (1); row++)
            {
                if ((array[column, row]) < 10)
                {
                    Console.Write ("  ");
                }
                else if ((array[column, row]) < 100)
                {
                    Console.Write (" ");
                }
                Console.Write (" {0} |", (array[column, row]));
            }
            Console.WriteLine ();
        }
        Console.WriteLine (line + "-");
    }
}
