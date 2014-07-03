using System;

class E03CheckBrackets
{
    static void Main ()
    {
        // Write a program to check if in a given expression the brackets are put correctly.
        // Example of correct expression: ((a+b)/5-d).
        // Example of incorrect expression: (a+b))(.

        Console.WriteLine (CheckBrackets ("((a + b) / 5 - d)"));
        Console.WriteLine (CheckBrackets ("))(a+b)"));
        Console.WriteLine (CheckBrackets ("(a+b))("));
        Console.WriteLine (CheckBrackets ("(a+b)(("));

    }


    static bool CheckBrackets (string str)
    {
        int stack = 0;

        for (int i = 0; i < str.Length && stack >= 0; i++)
        {
            if (str[i] == '(') stack++;
            if (str[i] == ')') stack--; 
        }

        return stack == 0;
    }
}
