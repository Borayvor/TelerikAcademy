﻿using System;
using System.IO;
using System.Text;

class E02ConcatenateTwoTextFiles
{
    static void Main()
    {
        // Write a program that concatenates two text files into another text file.

        using (var output = File.Create("Result.txt"))
        {
            foreach (var file in new[] { "TextFileOne.txt", "TextFileTwo.txt" })
            {
                using (var input = File.OpenRead(file))
                {
                    input.CopyTo(output);
                }
            }
        }

        StreamReader reader = new StreamReader("Result.txt", Encoding.GetEncoding("windows-1251"));

        using (reader)
        {
            int lineNumber = 0;

            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;

                Console.WriteLine(line);

                line = reader.ReadLine();
            }
        }
    }
}
