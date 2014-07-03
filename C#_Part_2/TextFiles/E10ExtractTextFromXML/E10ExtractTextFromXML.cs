using System;
using System.IO;
using System.Text;
using System.Xml;

class E10ExtractTextFromXML
{
    static void Main ()
    {
        // Write a program that extracts from given XML file all the text without the tags.

        using (StreamReader streamReader = new StreamReader ("TestXML.xml"))
        {
            for (int index; (index = streamReader.Read ()) != -1; )
            {
                if (index == '>')
                {
                    StringBuilder text = new StringBuilder ();

                    while (((index = streamReader.Read ()) != '<') && index != -1)
                    {
                        text.Append ((char) index);
                    }

                    if (!String.IsNullOrWhiteSpace (Convert.ToString (text)))
                    {
                        Console.WriteLine (Convert.ToString (text).Trim ());
                    }
                }
            }
        }
        Console.WriteLine ();

        XmlDocument doc = new XmlDocument ();
        doc.Load ("TestXML.xml");

        Console.WriteLine (doc.InnerText);
        Console.WriteLine ();
    }
}
