using System;
using System.Text.RegularExpressions;

class E14Dictionary
{
    static void Main ()
    {
        // A dictionary is stored as a sequence of text lines containing words and their explanations. 
        // Write a program that enters a word and translates it by using the dictionary. 

        string[] dictionary = {
                                ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes"
                               };
        string word = "CLR";

        foreach (string member in dictionary)
        {
            var explanation = Regex.Match (member, "(.*?) - (.*)").Groups;

            if (explanation[1].Value == word)
            {
                Console.WriteLine ("{0} - {1}", word, explanation[2]);
                return;
            }
        }
    }
}
