using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class E24PrintInAlphabeticalOrder
{
    static void Main ()
    {
        // Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

        string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";

        var words = new List<string> ();

        foreach (Match word in Regex.Matches (text, @"\w+"))
        {
            words.Add (word.Value);
        }

        words.Sort ();

        foreach (string word in words)
        {
            Console.WriteLine (word);
        }
    }
}
