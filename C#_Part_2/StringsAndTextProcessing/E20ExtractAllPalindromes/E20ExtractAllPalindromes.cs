using System;
using System.Text.RegularExpressions;

class E20ExtractAllPalindromes
{
    static void Main ()
    {
        // Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

        string text = "Static void Main() ABBA, using System lamal, exe.";

        foreach (Match item in Regex.Matches (text, @"\w+"))
        {
            if (IsPalindrome (item.Value)) Console.WriteLine (item);
        }

        foreach (Match item in Regex.Matches (text, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b"))
        {
            Console.WriteLine (item);
        }
    }


    static bool IsPalindrome (string text)
    {
        for (int index = 0; index < text.Length / 2; index++)
        {
            if (text[index] != text[text.Length - 1 - index])
            {
                return false;
            }
        }

        return true;
    }
}
