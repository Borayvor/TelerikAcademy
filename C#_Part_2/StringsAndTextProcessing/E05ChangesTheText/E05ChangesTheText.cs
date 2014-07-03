using System;
using System.Text.RegularExpressions;

class E05ChangesTheText
{
    static void Main ()
    {
        // You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> 
        // and </upcase> to uppercase. The tags cannot be nested. 

        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine (text);
        Console.WriteLine ();

        string regText = @"<upcase>(.*?)</upcase>";
        
        string newText = Regex.Replace (text, regText, m => m.Groups[1].Value.ToUpper());

        Console.WriteLine (newText);

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //int oddNumbers = numbers.Count (n => n % 2 == 1);
    }
}
