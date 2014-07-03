using System;
using System.IO;

class E07ReplacesAllOccurrencesOf
{
    static void Main ()
    {
        // Write a program that replaces all occurrences of the substring "start" with the substring "finish" 
        // in a text file. Ensure it will work with large files (e.g. 100 MB).

        using (StreamReader streamReader = new StreamReader ("Text.txt"))
        {
            using (StreamWriter streamWriter = new StreamWriter ("Result.txt"))
            {
                string line = streamReader.ReadLine ();

                while (line != null)
                {
                    streamWriter.WriteLine (line.Replace ("start", "finish"));
                    line = streamReader.ReadLine ();
                }
            }
        }
    }
}
