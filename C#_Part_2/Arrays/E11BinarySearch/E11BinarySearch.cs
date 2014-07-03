using System;

class E11BinarySearch
{
    static void Main ()
    {
        // Write a program that finds the index of given element in a sorted array of integers
        // by using the binary search algorithm.
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        int element = number ();
        Console.WriteLine ();
        int position = binarySearch (array, element, 0, array.Length - 1);

        if (position == -1)
		{
		    Console.WriteLine ("Searched value is absent.");
		}
		else
		{
            Console.WriteLine ("Searched value is on position: " + position);
		}
        Console.WriteLine ();
    }


    static int number () // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        int number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, select a number in the range (1 - 15): ");
            isNumber = int.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }


    private static int binarySearch (int[] array, int value, int left, int right)
    {

        if (left > right) // Когато са обходени елементите на масива по описания по горе алгоритъм и 
        {                 // търсения елемент не е намерен. В този случай може да заключим, че търсеният елемент го няма в масива.
            return -1;
        }

        int middle = (left + right) / 2;

        if (array[middle] == value) // Взима средния елемент на масива.
        {                            // Ако средният елемент е търсената стойност, алгоритъма завършва.
            return middle;
        }
        else if (array[middle] > value) // Търсената стойност е по-малка от средният елемент. 
        {                               // В този случай стъпка 1 се повтаря с частта от масива преди средният елемент.
            return binarySearch (array, value, left, middle - 1);
        }
        else // Търсената стойност е по-голяма от средният елемент. 
        {    // В този случай стъпка 1 се повтаря с частта от масива след средният елемент.
            return binarySearch (array, value, middle + 1, right);
        }
    }
}
