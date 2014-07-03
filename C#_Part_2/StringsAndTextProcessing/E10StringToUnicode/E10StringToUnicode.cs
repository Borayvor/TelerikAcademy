using System;
using System.Text;
using System.Text.RegularExpressions;

class E10StringToUnicode
{
    static void Main ()
    {
        // Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 

        string text = "Hi!";

        foreach (var ch in text)
        {
            Console.Write ("\\u{0:X4} ", (int) ch);
        }        
    }
}
