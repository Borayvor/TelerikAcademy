namespace MatrixProgram
{
    using System;

    public static class Matrix
    {
        private const int DIRECTION_MAX = 8;

        public static void FillMatrix()
        {
            //  int n = EnterNumber("Please, enter a positive number");

            int n = 6;
            int[,] matrix = new int[n, n];
            //int step = n;
            int cellValue = 1;
            int row = 0;
            int col = 0;
            int dirRow = 1;
            int dirCol = 1;

            while(true)
            {
                matrix[row, col] = cellValue;

                if(cellValue == 30)
                {
                    Console.WriteLine();
                }

                if(!CheckForValidDirection(matrix, row, col))
                {
                    break;
                }

                while(IsTheCorrectCell(matrix, row, dirRow, col, dirCol, n))
                {
                    ChangeDirection(ref dirRow, ref dirCol);
                }

                row += dirRow;
                col += dirCol;
                cellValue++;


            }

            //FindEmptyCell(matrix, out row, out col);

            for(int p = 0; p < n; p++)
            {
                for(int q = 0; q < n; q++)
                {
                    Console.Write("{0,4}", matrix[p, q]);
                }

                Console.WriteLine();
            }
        }

        private static void ChangeDirection(ref int dirRow, ref int dirCol)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int direction = 0;



            for(int dirCount = 0; dirCount < DIRECTION_MAX; dirCount++)
            {
                if(directionRow[dirCount] == dirRow && directionCol[dirCount] == dirCol)
                {
                    direction = dirCount;

                    break;
                }
            }

            if(direction == DIRECTION_MAX - 1)
            {
                dirRow = directionRow[0];
                dirCol = directionCol[0];

                return;
            }

            dirRow = directionRow[direction + 1];
            dirCol = directionCol[direction + 1];

        }

        private static bool CheckForValidDirection(int[,] array, int row, int col)
        {
            int[] directionRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for(int dirCount = 0; dirCount < DIRECTION_MAX; dirCount++)
            {
                if(row + directionRow[dirCount] >= array.GetLength(0) || row + directionRow[dirCount] < 0)
                {
                    directionRow[dirCount] = 0;
                }

                if(col + directionCol[dirCount] >= array.GetLength(0) || col + directionCol[dirCount] < 0)
                {
                    directionCol[dirCount] = 0;
                }
            }

            for(int dirCount = 0; dirCount < DIRECTION_MAX; dirCount++)
            {
                if(array[row + directionRow[dirCount], col + directionCol[dirCount]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindEmptyCell(int[,] array, out int row, out int col)
        {
            row = -1;
            col = -1;

            for(int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
            {
                for(int colIndex = 0; colIndex < array.GetLength(0); colIndex++)
                {
                    if(array[rowIndex, colIndex] == 0)
                    {
                        row = rowIndex;
                        col = colIndex;

                        return;
                    }
                }
            }

        }

        private static int EnterNumber(string stringForVariable)
        {
            int number;
            bool isNumber = false;

            do
            {
                Console.Write("{0}: ", stringForVariable);
                isNumber = int.TryParse(Console.ReadLine(), out number);
            } while(isNumber == false || number < 0 || number > 100);

            return number;
        }

        private static bool IsTheCorrectCell(int[,] matrix, int row, int dirRow, int col, int dirCol, int n)
        {
            bool isCorrect = false;

            if(row + dirRow >= n || row + dirRow < 0 || col + dirCol >= n || col + dirCol < 0 || matrix[row + dirRow, col + dirCol] != 0)
            {
                isCorrect = true;
            }

            return isCorrect;
        }
    }
}
