using System;
using System.Collections.Generic;

class E12SubtractionMultiplicationPolynom
{
    static void Main ()
    {
        // Extend the program 11 to support also subtraction and multiplication of polynomials.
        List<int> firstPolynom = Digits ("3x^2 + x^1 + 8");
        Console.Write ("First polynom : ");
        Print (firstPolynom);

        List<int> secondPolynom = Digits ("- 2x^4 - 3x^3 + 4x^2 - x + 3");
        Console.Write ("Second polynom : ");
        Print (secondPolynom);

        List<int> resultSubtract = SubtractNumbers (firstPolynom, secondPolynom);
        Console.Write ("Result subtract : ");
        Print (resultSubtract);

        List<int> resultMultiplication = Multiplication (firstPolynom, secondPolynom);
        Console.Write ("Result multiplication : ");
        Print (resultMultiplication);
    }


    static void Print (List<int> array)
    {
        for (int i = array.Count - 1; i >= 0; i--)
        {
            Console.Write ("{0} ", array[i]);
        }
        Console.WriteLine ();
    }


    static List<int> SubtractNumbers (List<int> arrayOne, List<int> arrayTwo)
    {
        List<int> arrayResult = new List<int> (Math.Max (arrayOne.Count, arrayTwo.Count));

        for (int index = 0; index < arrayResult.Capacity; index++)
        {
            int sum = ((index < arrayOne.Count ? arrayOne[index] : 0) -
                                    (index < arrayTwo.Count ? arrayTwo[index] : 0));

            arrayResult.Add (sum);
        }

        return arrayResult;
    }


    static List<int> Multiplication (List<int> arrayOne, List<int> arrayTwo)
    {
        List<int> arrayResult = new List<int> (arrayOne.Count + arrayTwo.Count - 1);
        for (int i = 0; i < arrayResult.Capacity; i++)
        {
            arrayResult.Add (0);
        }

        for (int i = 0; i < arrayOne.Count; i++)
        {
            for (int j = 0; j < arrayTwo.Count; j++)
            {
                int position = i + j;
                arrayResult[position] += (arrayOne[i] * arrayTwo[j]) ;
            }
        }

        return arrayResult;
    }


    static List<int> Digits (string polynom)
    {
        List<int> result = new List<int> ();              
        
        string[] member = polynom.Split (' ');

        string[] numbers;

        for (int index = member.Length - 1; index >= 0; index--)
        {
            int sign = 1;
            if ((index - 1) >= 0)
            {
                if (member[index - 1] == "-")
                {
                    sign = -1;
                }
            }

            if (member[index] != "+" && member[index] != "-" && member[index] != "")
            {
                numbers = member[index].Split ('x', '^');

                if (numbers.Length == 1)
                {
                    
                        result.Add (int.Parse (numbers[0]) * sign);
                   
                }
                else if (numbers.Length > 1)
                {
                    if ((numbers.Length == 2) || (int.Parse (numbers[2]) == 1))
                    {
                        if (numbers[0] == "")
                        {
                            result.Add (1 * sign);
                        }
                        else
                        {
                            result.Add (int.Parse (numbers[0]) * sign);
                        }

                        continue;
                    }
                    else
                    {
                        for (int i = result.Count - 1; i < (int.Parse (numbers[2]) - 1); i++)
                        {                            
                            result.Add (0);
                        }
                    }

                    result.Add (int.Parse (numbers[0]) * sign);
                }
            }

        }

        return result;
    }
}
