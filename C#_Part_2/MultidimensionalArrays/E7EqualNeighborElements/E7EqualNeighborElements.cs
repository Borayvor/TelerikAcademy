using System;
using System.Collections.Generic;


class DepthFirstSearch
{
    //  този "клас" е копиран от интернет прибавил съм само LargestAreaEqNbEl ()
    private static Stack<int> _branchingCellCol;
    private static Stack<int> _branchingCellRow;
    private static int[,] _table;
    private static bool[,] _visitedCells;
    private static int[,] NeighborElements;
    private static int[,] tempNeighborElements;
    private static int _rows;
    private static int _cols;
    private static int _maxAreaSize;
    private static int _currentAreaSize;


    private static void Initialize (int[,] table, int cols, int rows)
    {
        _branchingCellCol = new Stack<int> ();
        _branchingCellRow = new Stack<int> ();
        InitializeVisitedCells (cols, rows);
        _table = table;
        _cols = cols;
        _rows = rows;
        _maxAreaSize = 0;
        _currentAreaSize = 0;
        NeighborElements = new int[rows, cols];
        tempNeighborElements = new int[rows, cols];
    }



    private static void InitializeVisitedCells (int cols, int rows)
    {
        _visitedCells = new bool[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                _visitedCells[row, col] = false;
            }
        }
    }



    private static bool IsBranching (int row, int col)
    {
        int currentValue = _table[row, col];
        if (col - 1 >= 0 && _table[row, col - 1] == currentValue &&
            IsVisited (row, col - 1) == false) //left
        {
            return true;
        }
        else if (col + 1 < _cols && _table[row, col + 1] == currentValue &&
            IsVisited (row, col + 1) == false)//right
        {
            return true;
        }
        else if (row - 1 >= 0 && _table[row - 1, col] == currentValue &&
            IsVisited (row - 1, col) == false)//up
        {
            return true;
        }
        else if (row + 1 < _rows && _table[row + 1, col] == currentValue &&
            IsVisited (row + 1, col) == false)//down
        {
            return true;
        }

        return false;
    }


    private static bool IsVisited (int row, int col)
    {
        return _visitedCells[row, col];
    }


    public static int[,] LargestAreaEqNbEl ()
    {
        return NeighborElements;
    }


    public static int CheckMatrix (int[,] table, int cols, int rows)
    {


        Initialize (table, cols, rows);

        for (int row = 0; row < _rows; row++)
        {
            for (int col = 0; col < _cols; col++)
            {
                if (_visitedCells[row, col] == false && IsBranching (row, col) == true)
                {
                    _branchingCellCol.Push (col);
                    _branchingCellRow.Push (row);
                    Explore (col, row);
                }
            }
        }

        return _maxAreaSize;
    }


    private static void Explore (int col, int row)
    {
        int currentValue = _table[row, col];
        //_currentAreaSize++;
        while (_branchingCellCol.Count > 0 && _branchingCellRow.Count > 0)
        {
            col = _branchingCellCol.Pop ();
            row = _branchingCellRow.Pop ();


            int colTemp = col;
            int rowTemp = row;
            while (colTemp - 1 >= 0 && _table[rowTemp, colTemp - 1] == currentValue &&
                IsVisited (rowTemp, colTemp - 1) == false) //left
            {
                colTemp = colTemp - 1;
                //rowTemp = rowTemp;
                _branchingCellCol.Push (colTemp);
                _branchingCellRow.Push (rowTemp);
                _visitedCells[rowTemp, colTemp] = true;
                _currentAreaSize++;
                tempNeighborElements[rowTemp, colTemp] = currentValue;
            }

            colTemp = col;
            rowTemp = row;
            while (colTemp + 1 < _cols && _table[rowTemp, colTemp + 1] == currentValue &&
                IsVisited (rowTemp, colTemp + 1) == false)//right
            {
                colTemp = colTemp + 1;
                //rowTemp = rowTemp;
                _branchingCellCol.Push (colTemp);
                _branchingCellRow.Push (rowTemp);
                _visitedCells[rowTemp, colTemp] = true;
                _currentAreaSize++;
                tempNeighborElements[rowTemp, colTemp] = currentValue;
            }

            colTemp = col;
            rowTemp = row;
            while (rowTemp - 1 >= 0 && _table[rowTemp - 1, colTemp] == currentValue &&
               IsVisited (rowTemp - 1, colTemp) == false)//up
            {
                //colTemp = colTemp;
                rowTemp = rowTemp - 1;
                _branchingCellCol.Push (colTemp);
                _branchingCellRow.Push (rowTemp);
                _visitedCells[rowTemp, colTemp] = true;
                _currentAreaSize++;
                tempNeighborElements[rowTemp, colTemp] = currentValue;
            }

            colTemp = col;
            rowTemp = row;
            while (rowTemp + 1 < _rows && _table[rowTemp + 1, colTemp] == currentValue &&
                IsVisited (rowTemp + 1, colTemp) == false)//down
            {
                //colTemp = colTemp;
                rowTemp = rowTemp + 1;
                _branchingCellCol.Push (colTemp);
                _branchingCellRow.Push (rowTemp);
                _visitedCells[rowTemp, colTemp] = true;
                _currentAreaSize++;
                tempNeighborElements[rowTemp, colTemp] = currentValue;
            }
        }

        if (_currentAreaSize > _maxAreaSize)
        {
            if (_currentAreaSize >= _maxAreaSize)
            {
                for (int i = 0; i < NeighborElements.GetLength (0); i++)
                {
                    for (int j = 0; j < NeighborElements.GetLength (1); j++)
                    {
                        if (_table[i, j] == currentValue && (IsVisited (i, j)))
                        {
                            NeighborElements[i, j] = tempNeighborElements[i, j];
                        }
                        else
                        {
                            NeighborElements[i, j] = 0;
                        }
                    }
                }
            }

            _maxAreaSize = _currentAreaSize;
        }

        for (int i = 0; i < tempNeighborElements.GetLength (0); i++)
        {
            for (int j = 0; j < tempNeighborElements.GetLength (1); j++)
            {
                tempNeighborElements[i, j] = 0;
            }
        }
        _currentAreaSize = 0;
    }

}




class E7EqualNeighborElements
{

    static void Main ()
    {
        // Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.        
        Random randomGenerator = new Random ();
        int[,] matrix = new int[10, 10];

        fillMatrix (matrix, randomGenerator);

        Console.WriteLine ("The matrix.");
        print (matrix);
        Console.WriteLine ();

        int maxAreaSize = DepthFirstSearch.CheckMatrix (matrix, matrix.GetLength (0), matrix.GetLength (1));

        Console.WriteLine ("The largest area of equal neighbor elements in a rectangular matrix");
        print (DepthFirstSearch.LargestAreaEqNbEl ());

        Console.WriteLine ("The size of equal neighbor elements is : {0}", maxAreaSize);
    }


    static int[,] fillMatrix (int[,] matrix, Random randomGenerator)
    {
        for (int i = 0; i < matrix.GetLength (0); i++)
        {
            for (int j = 0; j < matrix.GetLength (1); j++)
            {
                matrix[i, j] = (randomGenerator.Next (4) + 1);

            }
        }
        return matrix;
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