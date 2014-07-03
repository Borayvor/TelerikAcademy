using System;
using System.Text.RegularExpressions;

class E04HowManyTimes
{
    static void Main ()
    {
        // Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. " +
                       "So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(text);
        Console.WriteLine();

        string regText = @"we";
        MatchCollection match = Regex.Matches (text, regText, RegexOptions.IgnoreCase);

        Console.WriteLine ("\"{0}\" is contained {1}", regText, match.Count);
    }
}
