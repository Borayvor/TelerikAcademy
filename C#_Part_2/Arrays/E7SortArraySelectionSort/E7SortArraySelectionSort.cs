using System;

class E7SortArraySelectionSort
{
    static void Main ()
    {
        // Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        // Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the 
        // smallest from the rest, move it at the second position, etc
        double[] array = new double[10];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = number ("array[" + index + "]");
        }
        Console.WriteLine ();

        int min;

        for (int index = 0; index < array.Length - 1; index++)
        {
            min = index;

            for (int jdex = index + 1; jdex < array.Length; jdex++)
            {
                if (array[jdex] < array[min])
                {
                    min = jdex;
                }
            }

            if (min != index)
            {
                double temp = array[index];
                array[index] = array[min];
                array[min] = temp;
            }
        }

        for (int index = 0; index < array.Length; index++)
        {
            Console.Write (" {0}", array[index]);
        }
        Console.WriteLine ();
    }


    static double number (string name) // проверява дали стойността е число и дали е в обхвата на "double"
    {                                     // ако това е изпълнено връща стойността на числото  
        double number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter {0}: ", name);
            isNumber = double.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
