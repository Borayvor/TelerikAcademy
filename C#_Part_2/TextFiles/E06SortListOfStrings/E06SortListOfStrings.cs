using System;
using System.Collections.Generic;
using System.IO;

class E06SortListOfStrings
{

    static void Main ()
    {
        // Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
        SaveSortedList (GetList ());
    }



    static void SaveSortedList (List<String> listOfNames)
    {
        using (StreamWriter writer = new StreamWriter ("SortedText.txt"))
        {
            for (int index = 0; index < listOfNames.Count; index++)
            {
                writer.WriteLine (listOfNames[index]);
            }
        }
    }


    static List<String> GetList ()
    {
        using (StreamReader reader = new StreamReader ("OriginalText.txt"))
        {
            List<string> listOfNames = new List<string> ();
            int lineNumber = 0;

            string line = reader.ReadLine ();

            while (line != null)
            {
                lineNumber++;

                listOfNames.Add (line);

                line = reader.ReadLine ();
            }

            listOfNames.Sort ();

            return listOfNames;
        }
    }
}
