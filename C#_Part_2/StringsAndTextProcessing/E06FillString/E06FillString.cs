using System;
using System.Text;

class E06FillString
{
    static void Main ()
    {
        // Write a program that reads from the console a string of maximum 20 characters. If the length of the string 
        // is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
        Console.WriteLine ("Please, enter a string of maximum 20 characters :");
        string text = string.Empty;
        do
        {
            text = Console.ReadLine();
        } while (text.Length > 20 || text.Length == 0);

        StringBuilder newText = new StringBuilder ();
        newText.Append (text);

        for (int index = text.Length; index < 20; index++)
        {
            newText.Append("*");
        }

        Console.WriteLine (Convert.ToString (newText));
        Console.WriteLine ();

        string str = Console.ReadLine ();
        int maxLength = 20;

        if (str.Length <= maxLength)
            Console.WriteLine (str.PadRight (maxLength, '*'));
    }
}
