using System;

class E9CheckSubset
{
    static void Main ()
    {
        Console.WriteLine ("We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0");
        Console.WriteLine ();

        int[] array = new int[5];

        for (byte index = 0; index < array.Length; index++)
        {
            array[index] = number (index);
        }

        byte firstInt = 0;
        byte lastInt = 0;

        for (byte index = 0; index < array.Length - 1; index++)
        {
            int subsetSum = 0;
            byte br = 0;

            for (byte subsetindex = index; subsetindex < array.Length; subsetindex++)
            {
                subsetSum += array[subsetindex];
                br++;

                if ((subsetSum == 0) && (br > 1))
                {
                    firstInt = index;
                    lastInt = subsetindex;

                    break;
                }
            }
        }

        Console.Write ("The sum of : ");

        for (byte index = firstInt; index < lastInt + 1; index++)
        {
            Console.Write (array[index] + " ");
        }
        Console.WriteLine (" is 0.");
    }


    static int number (byte variableName) // проверява дали стойността е число и дали е в обхвата на "int"
    {                                     // ако това е изпълнено връща стойността на числото  
        int number;
        bool isNumber = false;

        do
        {
            Console.Write ("Please, enter array[{0}] : ", variableName);
            isNumber = int.TryParse (Console.ReadLine (), out number);
        } while (isNumber == false);

        return number;
    }
}
