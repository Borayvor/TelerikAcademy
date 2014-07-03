using System;

class Matrix
{
    private int row, column;
    private int[,] matrix;

    public Matrix (int[,] matrix)
    {
        this.Value = (int[,]) matrix.Clone ();
    }

    public Matrix (int rows, int cols) : this (new int[rows, cols]) { }

    public int Row
    {
        get
        {
            return this.row;
        }
    }

    public int Column
    {
        get
        {
            return this.column;
        }
    }

    public int[,] Value
    {
        get
        {
            return this.matrix;
        }
        set
        {
            this.matrix = value;
            this.row = value.GetLength (0);
            this.column = value.GetLength (1);
        }
    }

    public int this[int i, int j]
    {
        get
        {
            return this.Value[i, j];
        }
        set
        {
            this.Value[i, j] = value;
        }
    }

    // Addition
    public static Matrix operator + (Matrix m1, Matrix m2)
    {
        Matrix mNull = new Matrix (1, 1);
        try
        {
            SizeEqual (m1, m2);
        }
        catch (FormatException fe)
        {
            Console.WriteLine (fe.Message);
            return mNull;
        }

        Matrix m = new Matrix (m1.Row, m1.Column);

        for (int i = 0; i < m.Row; i++)
        {
            for (int j = 0; j < m.Column; j++)
            {
                m[i, j] = m1[i, j] + m2[i, j];
            }
        }
        return m;
    }

    // Subtraction
    public static Matrix operator - (Matrix m1, Matrix m2)
    {
        Matrix mNull = new Matrix (1, 1);
        try
        {
            SizeEqual (m1, m2);
        }
        catch (FormatException fe)
        {
            Console.WriteLine (fe.Message);
            return mNull;
        }
        Matrix m = new Matrix (m1.Row, m1.Column);

        for (int i = 0; i < m.Row; i++)
        {
            for (int j = 0; j < m.Column; j++)
            {
                m[i, j] = m1[i, j] - m2[i, j];
            }
        }

        return m;
    }

    // Naive multiplication
    public static Matrix operator * (Matrix m1, Matrix m2)
    {
        Matrix mNull = new Matrix (1, 1);
        try
        {
            SizeEqual (m1, m2);
        }
        catch (FormatException fe)
        {
            Console.WriteLine (fe.Message);
            return mNull;
        }
        Matrix m = new Matrix (m1.Row, m1.Column);

        for (int i = 0; i < m.Row; i++)
        {
            for (int j = 0; j < m.Column; j++)
            {
                for (int k = 0; k < m1.column; k++)
                {
                    m[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }

        return m;
    }

    // Print
    public override string ToString ()
    {
        int max = (Convert.ToString (this.matrix[0, 0])).Length;
        foreach (var cell in this.matrix)
        {
            int cellLength = (Convert.ToString (cell)).Length;
            max = Math.Max (max, cellLength);
        }
        int cellSize = max + 3;

        string line = new string ('-', (((max + 3) * matrix.GetLength (1)) + (matrix.GetLength (1) - 1)));

        string s = String.Empty;

        Console.WriteLine (line + "-");

        for (int i = 0; i < this.row; i++)
        {
            for (int j = 0; j < this.column; j++)
            {
                s += (Convert.ToString ("| " + this.matrix[i, j]).PadRight (cellSize, ' ') +
                                        (j != this.column - 1 ? " " : ("|\n" + line + "-" + "\n")));
            }
        }
        return s;
    }

    private static void SizeEqual (Matrix m1, Matrix m2)
    {
        if ((m1.Row != m2.Row) || (m1.Column != m2.Column))
        {
            throw new FormatException ("Matrixes must have same dimensions!");
        }
    }
}


class E6MatrixClass
{
    static void Main ()
    {
        // Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and 
        // multiplying of matrices, indexer for accessing the matrix content and ToString().
        Matrix m1 = new Matrix (3, 3);
        Matrix m2 = new Matrix (4, 5);
        Matrix m3 = new Matrix (3, 3);

        Random randomGenerator = new Random ();
        m1 = fillMatrix (m1, randomGenerator);
        m2 = fillMatrix (m2, randomGenerator);
        m3 = fillMatrix (m3, randomGenerator);

        Console.WriteLine ("Matrix 1");
        Console.WriteLine (m1);

        Console.WriteLine ("Matrix 2");
        Console.WriteLine (m2);

        Console.WriteLine ("Matrix 3");
        Console.WriteLine (m3);


        Console.WriteLine ("Matrix 1 + Matrix 2");
        Console.WriteLine (m1 + m2);

        Console.WriteLine ("Matrix 1 - Matrix 3");
        Console.WriteLine (m1 - m3);

        Console.WriteLine ("Matrix 1 + Matrix 3");
        Console.WriteLine (m1 + m3);

        Console.WriteLine ("Matrix 1 * Matrix 3");
        Console.WriteLine (m1 * m3);

    }


    static Matrix fillMatrix (Matrix matrix, Random randomGenerator) // Fill with random numbers
    {
        for (int i = 0; i < matrix.Row; i++)
        {
            for (int j = 0; j < matrix.Column; j++)
            {
                matrix[i, j] = randomGenerator.Next (20);

            }
        }
        return matrix;
    }

}
