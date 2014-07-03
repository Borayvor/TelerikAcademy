using System;

class E4LargestNumberSmallerThanK
{
    static void Main ()
    {
        // Write a program, that reads from the console an array of N integers and an integer K, 
        // sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
        int N = 0;
        do
        {
            N = number ("size of array, N");
        }
        while (N < 3);

        int K = number ("an integer K");

        Console.WriteLine ();
        
        int[] array = new int[N];

        for (int index = 0; index < N; index++)
        {
            array[index] = number ("array[" + index + "]");
        }
        Console.WriteLine ();

        print (array);
        Console.WriteLine ();       

        Array.Sort (array);

        int result = Array.BinarySearch (array, K);

        Console.Write ("The largest number in the array which is <= {0} is: ", K);
        if (result < 0)
        {
            Console.WriteLine (array[(result + 2) * (-1)]);
        }
        else
        {
            Console.WriteLine (array[result]);
        }
        Console.WriteLine ();
    }


    static void print (int[] array) // Отпечатва масива
    {        
        Console.Write ("|");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write (" {0} |", (array[index]));
        }
        Console.WriteLine ();        
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
