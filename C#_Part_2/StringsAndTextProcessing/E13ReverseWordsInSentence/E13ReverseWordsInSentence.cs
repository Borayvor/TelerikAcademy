using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class E13ReverseWordsInSentence
{
    static void Main ()
    {
        // Write a program that reverses the words in given sentence.
     
        string sentence = "C# is not C++ , not PHP and not Delphi ! Test     1  ,2,3";
        Console.WriteLine (sentence);
        Console.WriteLine ();

        string regex = @"\s+|\,\s*|\;\s*|\:\s*|\-\s*|\!\s*|\?\s*|\.\s*";

        Stack words = new Stack ();
        Queue separators = new Queue ();

        foreach (var word in Regex.Split (sentence, regex))
        {
            if (!String.IsNullOrEmpty (word))
            {
                words.Push (word);
            }
        }

        foreach (Match separator in Regex.Matches (sentence, regex))
        {
            separators.Enqueue (separator);
        }

        StringBuilder reversedSentence = new StringBuilder ();

        while (words.Count > 0 && separators.Count > 0)
        {
            reversedSentence.Append (words.Pop ());

            reversedSentence.Append (separators.Dequeue ());
        }

        Console.WriteLine (reversedSentence.ToString ());
        Console.WriteLine ();
    }
}
