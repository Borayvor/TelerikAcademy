using System;

class E6CheckElementVerTwo
{
    static void Main ()
    {
        // Write a method that returns the index of the first element in array that is bigger than its neighbors,
        // or -1, if there’s no such element.
        // Use the method from the previous exercise.
        int[] array = FillArray ();
        Console.WriteLine ();

        Console.WriteLine ("Check for element in the array, bigger than its neighbors.");
        Console.WriteLine ();
        Console.WriteLine ("Position {0}", CheckElement (array));
        Console.WriteLine ();

        PrintArray (array);
        Console.WriteLine ();
    }


    static int CheckElement (int[] array) // проверява елементите от масива
    {
        for (int index = 1; index < array.Length - 1; index++)
        {
            int neighborLeft = array[index - 1];
            int neighborRight = array[index + 1];
            int element = array[index];

            if (element > neighborLeft && element > neighborRight)
            {
                Console.WriteLine ("The first element bigger than its two neighbors :");
                Console.WriteLine ("{0} < {1} > {2}", neighborLeft, element, neighborRight);
                return index;
            }            
        }

        Console.WriteLine ("There’s no such element.");
        return -1;
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
