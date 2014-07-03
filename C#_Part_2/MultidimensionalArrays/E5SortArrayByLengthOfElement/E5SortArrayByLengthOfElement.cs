using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class E5SortArrayByLengthOfElement
{
    static void Main ()
    {
        // You are given an array of strings. Write a method that sorts the array by the length of 
        // its elements (the number of characters composing them).
        Console.WriteLine ("Please, enter an array of strings :");
        string strings = Console.ReadLine ();
        Console.WriteLine ();

        string[] words = strings.Split (' ');

        List<string> sortedWords = new List<string> ();
        
        foreach (string word in SortByLength (words))
        {
            sortedWords.Add (word);
        }        

        for (int index = 0; index < sortedWords.Count; index++)
        {
            Console.WriteLine ("position {0}: {1}", index, sortedWords[index]);
        }
        Console.WriteLine ();
    }


    static IEnumerable<string> SortByLength (IEnumerable<string> array)
    {
        // Use LINQ to sort the array received and return a copy.
        var sorted = from str in array
                     orderby str.Length ascending
                     select str;
        return sorted;
    }
}
