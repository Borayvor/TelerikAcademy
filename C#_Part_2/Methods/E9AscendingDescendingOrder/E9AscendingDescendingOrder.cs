using System;
using System.Collections.Generic;

class E9AscendingDescendingOrder
{
    static void Main ()
    {
        // Write a method that return the maximal element in a portion of array of integers starting at given 
        // index. Using it write another method that sorts an array in ascending / descending order.
        int[] array = FillArray ();
        PrintArray (array);
        Console.WriteLine ();

        int[] sortedArray = Sort (array, OrderChoice ());
        Console.WriteLine ();
        PrintArray (sortedArray);
    }


    static bool OrderChoice ()
    {
        int choice = -1;
        do
        {
            choice = Number ("make your choice :\n1. Ascending order.\n2. Descending order.\n");
        } while (choice < 1 || choice > 2);        

        if (choice == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    static void Swap (int[] array, int i, int j)
    {
        int tempNumber = array[i];
        array[i] = array[j];
        array[j] = tempNumber;
    }


    static int MaximalElement (int[] array, int start, bool ordering)
    {
        int maxElement = start;

        for (start++; start < array.Length; start++)
        {
            if (ordering ? array[start] < array[maxElement] : array[maxElement] < array[start])
            {
                maxElement = start;
            }
        }

        return maxElement;
    }


    static int[] Sort (int[] array, bool ordering)
    {
        for (int index = 0; index < array.Length; index++)
        {
            Swap (array, index, MaximalElement (array, index, ordering));
        }

        return array;
    }


    static int[] FillArray () // запълва масива с произволни числа от 0 до 99
    {
        int length = Number ("enter the length of the array");

        int[] array = new int[length];

        Random randomGenerator = new Random ();

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = randomGenerator.Next (100);
        }

        return array;
    }


    static int Number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        int number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, {0}:> ", name);
            isNumber = int.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }


    static void PrintArray (int[] array) // отпечатва масива
    {
        Console.Write ("{ ");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write ("{0}", array[index]);

            if (index < array.Length - 1)
            {
                Console.Write (", ");
            }
        }
        Console.WriteLine (" }");
    }
}
