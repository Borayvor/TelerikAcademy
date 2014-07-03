using System;
using System.IO;
using System.Text;

class E09DeleteAllOddLines
{
    static void Main ()
    {
        // Write a program that deletes from given text file all odd lines. The result should be in the same file.

        string[] lines = File.ReadAllLines ("TextFile.txt", Encoding.GetEncoding ("windows-1251"));

        for (int index = 0; index < lines.Length; index++)
        {
            Console.WriteLine (lines[index]);
        }

        using (StreamWriter streamWriter = new StreamWriter ("TextFile.txt", false, Encoding.GetEncoding ("windows-1251")))
        {

            for (int index = 0; index < lines.Length; index++)
            {
                if (index % 2 == 0)
                {
                    streamWriter.WriteLine (lines[index]);
                }
            }
        }
    }
}
