using System;
using System.Collections.Generic;

class E18BiggestIncrementSequence
{
    static void Main ()
    {
        // Write a program that reads an array of integers and removes from it a minimal number of elements 
        // in such way that the remaining array is sorted in increasing order. Print the remaining sorted array.        
        int size = number ("the length of your array");
        int[] numbers = new int[size];
        for (int index = 0; index < size; index++)
        {
            numbers[index] = number ("array[" + index + "]");
        }

        int[] result = FindBiggestIncrementSequence (numbers);
        
        if (result.Length > 1)
        {
            PrintResult (result);
        }
        else
        {
            Console.WriteLine ("There were no increasing sequences found in the given array.");
        }
    }


    static bool AllElementsAreEqual (int[] numbers)
    {
        bool areEqual = true;
        for (int index = 0, length = numbers.Length; index < length; index++)
        {
            if (numbers[0] != numbers[index])
            {
                areEqual = false;
                break;
            }
        }
        return areEqual;
    }

    static int[] FindBiggestIncrementSequence (int[] numbers)
    {
        List<int> lengths = new List<int> ();

        for (int i = 0; i < numbers.Length; i++)
        {
            lengths.Add (0);
        }

        int[] indexs = new int[numbers.Length];
        int[] result;
        lengths.Insert (0, 1);
        indexs[0] = -1;

        if (AllElementsAreEqual (numbers))
        {
            return new int[1];
        }

        for (int numberIndex = 1, length = numbers.Length; numberIndex < length; numberIndex++)
        {
            for (int parentIndex = numberIndex - 1; parentIndex >= 0; parentIndex--)
            {
                if (numbers[numberIndex] >= numbers[parentIndex])
                {
                    if (lengths[numberIndex] <= lengths[parentIndex])
                    {
                        lengths.Insert (numberIndex, lengths[parentIndex] + 1);
                        indexs[numberIndex] = parentIndex;
                    }
                }
                else
                {
                    if (lengths[numberIndex] == 0)
                    {
                        lengths.Insert (numberIndex, 1);
                        indexs[numberIndex] = -1;
                    }
                }
            }
        }

        do
        {
            if (lengths.Count == 1)
            {
                return new int[1];
            }
            int resultLength = 0;
            int maxLengthIndex = 0;

            for (int index = 0; index < lengths.Count; index++)
            {
                if (lengths[index] > resultLength)
                {
                    resultLength = lengths[index];
                    maxLengthIndex = index;
                }
            }
            int currentIndex = maxLengthIndex;
            result = new int[resultLength];
            for (int count = 0; currentIndex != -1; count++)
            {
                result[count] = numbers[currentIndex];
                currentIndex = indexs[currentIndex];
            }
            if (result[0] == result[resultLength - 1])
            {
                lengths.Remove (maxLengthIndex);
                continue;
            }
            break;
        }
        while (true);

        return result;
    }


    static void PrintResult (int[] result)
    {
        Console.Write ("{");
        for (int i = result.Length - 1; i > 0; i--)
        {
            Console.Write (result[i] + ", ");
        }
        Console.WriteLine (result[0] + "}");
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
