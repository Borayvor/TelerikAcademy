using System;
using System.Collections.Generic;

class E3SequenceOfEqualStrings
{    
    static List<string> sequence = new List<string> ();


    static void Main ()
    {
        // We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
        // neighbor elements located on the same line, column or diagonal. Write a program that finds the longest 
        // sequence of equal strings in the matrix.
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

        string[,] array = new string[N, M];

        Console.WriteLine ("Enter strings in the cells: ");

        for (int vertikal = 0; vertikal < N; vertikal++)
        {
            for (int horizontal = 0; horizontal < M; horizontal++)
            {
                Console.Write ("array[" + vertikal + ", " + horizontal + "] = ");
                array[vertikal, horizontal] = Console.ReadLine ();
            }
        }
        Console.WriteLine ();

        Console.WriteLine ("Matrix {0} x {1}", N, M);
        print (array);
        Console.WriteLine ();

        horizontalSequence (array);
        vertikalSequence (array);
        diagonalUpLRDownSequence (array);
        diagonalDownLRUpSequence (array);


        Console.WriteLine ("The longest sequence of equal strings in the matrix has {0} elements.", sequence.Count);
        Console.Write ("|");
        for (int index = 0; index < sequence.Count; index++)
        {
            Console.Write (" {0} |", (sequence[index]));            
        }
        Console.WriteLine ();
    }


    static void horizontalSequence (string[,] array)
    {
        for (int vertikal = 0; vertikal < array.GetLength (0); vertikal++)
        {
            for (int horizontal = 0; horizontal < array.GetLength (1); horizontal++)
            {
                int index = 0;

                for (int horiz = horizontal; horiz < array.GetLength (1); horiz++)
                {
                    if (array[vertikal, horizontal].Equals (array[vertikal, horiz]))
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                if ((sequence.Count < index) && (index > 1))
                {
                    sequence.Clear ();

                    for (int horiz = horizontal; horiz < horizontal + index; horiz++)
                    {
                        sequence.Add (array[vertikal, horiz]);
                    }
                }
            }
        }        
    }



    static void vertikalSequence (string[,] array)
    {
        int horizontal = 0;

        while (horizontal < array.GetLength (1))
        {
            int vertikal = 0;

            for (vertikal = 0; vertikal < array.GetLength (0); vertikal++)
            {
                int index = 0;

                for (int vert = vertikal; vert < array.GetLength (0); vert++)
                {
                    if (array[vertikal, horizontal].Equals (array[vert, horizontal]))
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                if ((sequence.Count < index) && (index > 1))
                {
                    sequence.Clear ();

                    for (int vert = vertikal; vert < vertikal + index; vert++)
                    {
                        sequence.Add (array[vert, horizontal]);
                    }
                }
            }
            horizontal++;
        }        
    }


    static void diagonalUpLRDownSequence (String[,] array)
    {
        for (int vertikal = 0; vertikal < array.GetLength (0); vertikal++)
        {
            for (int horizontal = 0; horizontal < array.GetLength (1); horizontal++)
            {
                int index = 0;

                int vert = vertikal;

                int horiz = horizontal;

                while ((vert < array.GetLength (0)) && (horiz < array.GetLength (1)))
                {
                    if ((array[vertikal, horizontal].Equals (array[vert, horiz])))
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }

                    vert++;
                    horiz++;
                }

                if ((sequence.Count < index) && (index > 1))
                {
                    sequence.Clear ();
                    vert = vertikal;
                    horiz = horizontal;

                    while (sequence.Count < index)
                    {
                        sequence.Add (array[vert, horiz]);

                        vert++;
                        horiz++;
                    }
                }
            }
        }       
    }



    static void diagonalDownLRUpSequence (String[,] array)
    {
        for (int vertikal = array.GetLength (0) - 1; vertikal >= 0; vertikal--)
        {
            for (int horizontal = 0; horizontal < array.GetLength (1); horizontal++)
            {
                int index = 0;

                int vert = vertikal;

                int horiz = horizontal;


                while ((vert >= 0) && (horiz < array.GetLength (1)))
                {
                    if ((array[vertikal, horizontal].Equals (array[vert, horiz])))
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }

                    vert--;
                    horiz++;
                }

                if ((sequence.Count < index) && (index > 1))
                {
                    sequence.Clear ();
                    vert = vertikal;
                    horiz = horizontal;

                    while (sequence.Count < index)
                    {
                        sequence.Add (array[vert, horiz]);

                        vert--;
                        horiz++;
                    }
                }
            }
        }        
    }


    static void print (string[,] array) // Отпечатва матрицата
    {
        string line = new string ('-', (array.GetLength (1) * 6));

        for (int column = 0; column < array.GetLength (0); column++)
        {

            Console.WriteLine (line + "-");
            Console.Write ("|");
            for (int row = 0; row < array.GetLength (1); row++)
            {
                if ((array[column, row].Length) < 1)
                {
                    Console.Write ("   ");
                }
                else if ((array[column, row].Length) < 2)
                {
                    Console.Write ("  ");
                }
                else if ((array[column, row].Length) < 3)
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
