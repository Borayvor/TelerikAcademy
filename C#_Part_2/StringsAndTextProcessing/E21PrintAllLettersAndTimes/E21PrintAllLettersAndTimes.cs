﻿using System;

class E21PrintAllLettersAndTimes
{
    static void Main ()
    {
        // Write a program that reads a string from the console and prints all different letters in the string along 
        // with information how many times each letter is found. 

        string text = "Write a program that reads a string from the console and prints all different letters in the " + 
                        "string along with information how many times each letter is found.";

        int[] values = new int['z' - 'a' + 1];

        foreach (char c in text.ToLower ())
        {
            if ('a' <= c && c <= 'z')
            {
                values[c - 'a']++;
            }
        }

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] != 0)
            {
                Console.WriteLine ("{0}: {1}", (char) (i + 'a'), values[i]);
            }
        }
    }
}
