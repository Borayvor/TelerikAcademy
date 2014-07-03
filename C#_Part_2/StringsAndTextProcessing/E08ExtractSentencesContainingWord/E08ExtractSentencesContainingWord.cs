using System;
using System.Text.RegularExpressions;

class E08ExtractSentencesContainingWord
{
    static void Main ()
    {
        // Write a program that extracts from a given text all sentences containing given word.
        // Consider that the sentences are separated by "." and the words – by non-letter symbols.

        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very " +
                        "tight. So we are drinking all the day. In the black sea.We will move out of it in 5 days.";

        string word = @"(?i)(\bin\b)";
        string regText = @"\s*([^\.]*" + word + @".*?\.)";

        MatchCollection matches = Regex.Matches (text, regText);

        foreach (Match match in matches)
        {
            Console.WriteLine (match.Groups[1]);
        }
    }
}
