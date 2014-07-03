using System;
using System.Text.RegularExpressions;

class E18ExtractAllEmailAddresses
{
    static void Main ()
    {
        // Write a program for extracting all email addresses from given text. All substrings that match the 
        // format <identifier>@<host>…<domain> should be recognized as emails.

        string str = "Static void Main() nakov@telerik.com. using System,nakov@gmail.com return";

        foreach (var item in Regex.Matches (str, @"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}\b"))
        {
            Console.WriteLine (item);
        }
    }
}
