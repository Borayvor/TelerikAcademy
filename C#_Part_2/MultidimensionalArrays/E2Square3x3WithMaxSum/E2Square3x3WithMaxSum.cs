using System;

class E2Square3x3WithMaxSum
{
    static int[,] subArray = new int[3, 3];

    static int value = 0;


    static void Main ()
    {
        // Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
        // that has maximal sum of its elements.
        int N = 0;
        do
        {
            N = number ("vertical array length N");
        }
        while (N < 3);

        int M = 0;
        do
        {
            M = number ("horizontal array length M");
        }
        while (M < 3);
        Console.WriteLine ();

        int [,] array = new int[N, M];

        Console.WriteLine ("Enter numbers in the cells: ");
		
		for (int vertikal = 0; vertikal < N; vertikal++)
		{
			for(int horizontal = 0; horizontal < M; horizontal++)
			{
                array[vertikal, horizontal] = number ("array[" + vertikal + ", " + horizontal + "]");
			}
		}
        Console.WriteLine ();

        Console.WriteLine ("Matrix {0} x {1}", N, M);
        print (array);
        Console.WriteLine ();
		
		for (int vertikal = 0; vertikal < N - 2; vertikal++)
        {
	        for (int horizontal = 0; horizontal < M - 2; horizontal++)
            {
	        	subMatrixSum (array, vertikal, horizontal);
            }
        }

        Console.WriteLine ("The square 3 x 3 that has maximal sum of its elements:");
		print (subArray);        
		Console.WriteLine ();
		
		Console.WriteLine ("Sum of elements: {0}", value);
    }


    private static void subMatrixSum (int[,] array, int row, int column)
    {
        int sum = 0;

        for (int i = 0; i < 9; i++)
        {
            sum += array[row + (i % 3), column + (i / 3)];
        }
        if (sum >= value)
        {
            for (int i = 0; i < 9; i++)
            {
                subArray[i % 3, i / 3] = array[row + (i % 3), column + (i / 3)];
            }
            value = sum;
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
