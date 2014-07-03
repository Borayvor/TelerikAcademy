using System;

class E1FillsAndPrintsMatrix
{
    static int N;

    static void Main ()
    {
        // Write a program that fills and prints a matrix of size (N, N).
        do
		{			
			N = number ("array length N");			
		}
		while (N < 3);
		
		vertikalSort (N);
		
		vertikalZigZagSort (N);
		
		diagonalSort (N);
		
		spiralSort (N);
    }


    static void vertikalSort (int size)
	{
		Console.WriteLine ("A:");
		
		int[,] matrix = new int [size, size];
		
		int index;
		
		for (int vertikal = 0; vertikal < size; vertikal++)
		{
			index = vertikal + 1;
			
			for (int horizontal = 0; horizontal < size; horizontal++)
			{
				matrix[vertikal, horizontal] = index; 
				
				index += size;	
			}
		}
        print (matrix);

        Console.WriteLine ();
	}


    static void vertikalZigZagSort (int size)
	{
		Console.WriteLine ("B:");
		
		int[,] matrix = new int [size, size];
		
		int index = 0; 
		
		int horizontal = 0;
		
		while (horizontal < size)
		{
			if ((horizontal % 2) == 0)
            {
	            for (int vertikal = 0; vertikal < size; vertikal++)
	            {
		            index++;
		            
		            matrix[vertikal, horizontal] = index;
	            }
            }
			else
			{
				for (int vertikal = size - 1; vertikal >= 0; vertikal--)
				{
					index++;
					
					matrix[vertikal, horizontal] = index;
				}
			}
			horizontal++;
		}

        print (matrix);

        Console.WriteLine ();
	}


    static void diagonalSort (int size)
	{
		Console.WriteLine ("C:");
		
		int[,] matrix = new int[size, size];
		
		int index = 1;
		
		for (int vertikal = 0; vertikal <= size - 1; vertikal++)
		{
			for (int horizontal = 0; horizontal <= vertikal; horizontal++)
			{
				matrix[size - vertikal + horizontal - 1, horizontal] = index++;
			}
		}
		
		for (int vertikal = size - 2; vertikal >= 0; vertikal--)
		{
			for (int horizontal = vertikal; horizontal >= 0; horizontal--)
			{
				matrix[vertikal - horizontal, size - horizontal - 1] = index++;
			}
		}
        
        print (matrix);
        
        Console.WriteLine ();
	}



    static void spiralSort (int size)
	{
		Console.WriteLine ("D:");
		
		int[,] matrix = new int [size, size];
		
		int index = 0; 
		
		int start = 0, end = size;
		
		int vertikal = 0, horizontal = 0;
		
		while ((end - start ) > 0)
		{
			
            for (vertikal = start; vertikal < end; vertikal++)
            {
	            index++;
	            
	            matrix[vertikal, horizontal] = index;
            }
            
            vertikal--;
           
            for (horizontal = start + 1; horizontal < end; horizontal++)
            {
	            index++;
	            
	            matrix[vertikal, horizontal] = index;
            }
            
            horizontal--;
            
			for (vertikal = end - 2; vertikal >= start; vertikal--)
			{
				index++;
				
				matrix[vertikal, horizontal] = index;
			}
			
			vertikal++;
			
			for (horizontal = end - 2; horizontal >= start + 1; horizontal--)
            {
	            index++;
	            
	            matrix[vertikal, horizontal] = index;
            }
			
			horizontal++;
			
			start++;
			
			end--;
		}
                
        print (matrix);

        Console.WriteLine ();
	}


    static void print (int[,] array) // Отпечатва матрицата
    {
        string line = new string ('-', (array.GetLength (0) * 6));

        for (int column = 0; column < array.GetLength(0); column++)
        {
            
            Console.WriteLine (line + "-");
            Console.Write ("|");
            for (int row = 0; row < array.GetLength(1); row++)
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
