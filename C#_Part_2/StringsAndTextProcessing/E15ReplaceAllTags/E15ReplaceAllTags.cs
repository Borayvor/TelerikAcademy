using System;
using System.Text.RegularExpressions;

class E15ReplaceAllTags
{
    static void Main ()
    {
        // Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with 
        // corresponding tags [URL=…]…/URL].

        string htmlText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training " + 
                            "course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        string tags = "<a href=\"(.*?)\">(.*?)</a>"; 
        string newTags = "[URL=$1]$2[/URL]";

        string newText = Regex.Replace (htmlText, tags, newTags);

        Console.WriteLine (newText);
    }
}
