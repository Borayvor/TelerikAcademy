using System;
using System.Collections.Generic;

class E19AllPermutationsOfTheNumbers
{
    static int[] array;

    static void Main ()
    {
        // Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
        int N, fact = 1;
		
		do
		{            
            N = number ("array length");
		}
		while (N < 1);
		
		for (int element = 1; element <= N; element++)
		{
			fact = fact * element;
		}
				
		array = new int[N];
		
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;			
		}
		Console.WriteLine ();
		
		Permute (array, 0, array.Length - 1);
        Console.WriteLine ();

		Console.WriteLine (fact + " permutations.");
    }


    static void Swap (int first, int second)
    {
        int temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }


    static void Permute (int[] array, int current, int length)
	{
		if (current == length)
		{
			for (int i = 0; i <= length; i++)
			{
                Console.Write (array[i] + " ");
			}
			Console.WriteLine ();
		}
		else
		{
			for (int i = current; i <= length; i++)
			{
				Swap (i, current);
				Permute (array, current + 1, length);
				Swap (i, current);
			}
		}
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
