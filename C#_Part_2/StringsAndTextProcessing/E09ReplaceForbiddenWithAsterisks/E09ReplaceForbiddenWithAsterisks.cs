using System;
using System.Text.RegularExpressions;

class E09ReplaceForbiddenWithAsterisks
{
    static void Main ()
    {
        // We are given a string containing a list of forbidden words and a text containing some of these words. 
        // Write a program that replaces the forbidden words with asterisks.

        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 " + 
                        "and is implemented as a dynamic language in CLR.";

        string words = "PHP, CLR, Microsoft";
        
        string newText = Regex.Replace (text, words.Replace (", ", "|"), m => new string ('*', m.Length));
        
        Console.WriteLine (newText);
    }
}
