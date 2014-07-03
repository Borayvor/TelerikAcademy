using System;

class E4CountNumberAppear
{
    static void Main ()
    {
        // Write a method that counts how many times given number appears in given array. Write a test 
        // program to check if the method is working correctly.
        int[] array = FillArray ();

        int selectedNumber = -1;
        do
        {
            selectedNumber = Number ("a number (0 - 9)");
        } while (selectedNumber < 0 || selectedNumber > 9);

        int count = CounterNumber (array, selectedNumber);

        Console.WriteLine ();
        Console.WriteLine ("The number {0} appears {1} times.", selectedNumber, count);

        Console.WriteLine ();
        PrintArray (array);
    }


    static int CounterNumber (int[] array, int number) // брои колко пъти се среща числото в масива
    {
        int count = 0;

        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] == number)
            {
                count++;
            }
        }

        return count;
    }


    static int[] FillArray () // запълва масива с произволни числа от 0 до 9
    {
        int length = Number ("the length of the array");

        int[] array = new int[length];

        Random randomGenerator = new Random ();

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = randomGenerator.Next (10);
        }

        return array;
    }


    static int Number (string name) // проверява дали стойността е число и дали е в обхвата на "int"
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
