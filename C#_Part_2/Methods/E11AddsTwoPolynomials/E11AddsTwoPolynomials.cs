using System;
using System.Collections.Generic;

class E11AddsTwoPolynomials
{
    static void Main ()
    {
        // Write a method that adds two polynomials. Represent them as arrays of their coefficients.
        List<int> firstPolinom = Digits (" 11x^2 + 20x^1 + 35 ");
        Console.Write ("First polinom : ");
        Print (firstPolinom);

        List<int> secondPolinom = Digits ("1x^3 + 24x + 5");
        Console.Write ("Second polinom : ");
        Print (secondPolinom);

        List<int> result = AddNumbers (firstPolinom, secondPolinom);
        Console.Write ("Result : ");
        Print (result);
    }


    static void Print (List<int> array)
    {
        for (int i = array.Count - 1; i >= 0; i--)
        {
            Console.Write ("{0} ", array[i]);
        }
        Console.WriteLine ();
    }


    static List<int> AddNumbers (List<int> arrayOne, List<int> arrayTwo)
    {
        List<int> arrayResult = new List<int> (Math.Max (arrayOne.Count, arrayTwo.Count));

        for (int index = 0; index < arrayResult.Capacity; index++)
        {
            int sum = ((index < arrayOne.Count ? arrayOne[index] : 0) +
                                    (index < arrayTwo.Count ? arrayTwo[index] : 0));

            arrayResult.Add (sum);
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
