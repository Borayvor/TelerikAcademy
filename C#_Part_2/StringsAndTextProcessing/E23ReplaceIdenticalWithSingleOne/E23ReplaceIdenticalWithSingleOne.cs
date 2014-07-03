using System;
using System.Text.RegularExpressions;

class E23ReplaceIdenticalWithSingleOne
{
    static void Main ()
    {
        // Write a program that reads a string from the console and replaces all series of consecutive identical 
        // letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

        string str = "aaaaabbbbbcdddeeeedssaafffffffffrrrrrrrtyewwwwwwww";

        Console.WriteLine (Regex.Replace (str, @"(\w)\1+", "$1"));
    }
}
