using System;
using System.IO;
using System.Text.RegularExpressions;

class E08ReplaceOnlyWholeWords
{
    static void Main ()
    {
        // Modify the solution of the previous problem to replace only whole words (not substrings).

        using (StreamReader streamReader = new StreamReader ("Text.txt"))
        {
            using (StreamWriter streamWriter = new StreamWriter ("Result.txt"))
            {
                string line = streamReader.ReadLine ();

                while (line != null)
                {
                    streamWriter.WriteLine (Regex.Replace (line, @"\bstart\b", "finish"));
                    line = streamReader.ReadLine ();
                }
            }
        }
    }
}
