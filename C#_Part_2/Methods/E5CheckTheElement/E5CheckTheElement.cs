using System;

class E5CheckTheElement
{
    static void Main ()
    {
        // Write a method that checks if the element at given position in given array of integers is bigger 
        // than its two neighbors (when such exist).
        int[] array = FillArray ();
        Console.WriteLine ();

        int position = -1;
        do
        {
            position = Number ("the position of the element (0 - " + (array.Length - 1) + ")");
        } while (position < 0 || position > (array.Length - 1));
        Console.WriteLine ();

        CheckElement (array, position);
        Console.WriteLine ();

        PrintArray (array);
        Console.WriteLine ();
    }


    static void CheckElement (int[] array, int position) // проверява желаният елемент от масива
    {
        if (position > 0 && position < (array.Length - 1))
        {
            int neighborLeft = array[position - 1];
            int neighborRight = array[position + 1];

            if (array[position] > neighborLeft && array[position] > neighborRight)
            {
                Console.WriteLine ("The element at position {0} is bigger than its two neighbors.", position);
                Console.WriteLine ("{0} < {1} > {2}", neighborLeft, array[position], neighborRight);
            }
            else if (array[position] < neighborLeft && array[position] > neighborRight)
            {
                Console.WriteLine ("The element at position {0} is smaler than one, or two of its neighbors.", position);
                Console.WriteLine ("{0} > {1} > {2}", neighborLeft, array[position], neighborRight);
            }
            else if (array[position] < neighborLeft && array[position] < neighborRight)
            {
                Console.WriteLine ("The element at position {0} is smaler than one, or two of its neighbors.", position);
                Console.WriteLine ("{0} > {1} < {2}", neighborLeft, array[position], neighborRight);
            }
            else
            {
                Console.WriteLine ("The element at position {0} is smaler than one, or two of its neighbors.", position);
                Console.WriteLine ("{0} > {1} < {2}", neighborLeft, array[position], neighborRight);
            }

        }
        else
        {
            Console.WriteLine ("One of neighbors does not exist !");
        }
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
