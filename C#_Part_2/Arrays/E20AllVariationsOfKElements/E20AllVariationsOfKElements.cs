﻿using System;

class E20AllVariationsOfKElements
{
    static int N, K;

    static void Main ()
    {
        // Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
        do
		{			
            N = number ("array length");
        }
        while (N < 3);
        do
        {
            K = number ("number of elements");
		}
		while (K < 2);
		
		int[] varArray = new int[K];
		
		variation (varArray, 0);
    }


    static void variation (int[] array, int index)
    {
        if (index == array.Length)
        {
            print (array);
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                array[index] = i;

                variation (array, index + 1);
            }
        }
    }


    static void print (int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
            Console.Write (array[i] + " ");
		}
        Console.WriteLine();
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
