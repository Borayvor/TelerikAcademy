namespace E01ExtendStringBuilder
{
    using System;
    using System.Text;
    

    class ExtendSBTest
    {
        static void Main ()
        {
            // Implement an extension method Substring(int index, int length) for the class StringBuilder that 
            // returns new StringBuilder and has the same functionality as Substring in the class String.

            StringBuilder sbTest = new StringBuilder ();

            sbTest.Append ("Implement an extension method Substring(int index, int length)");

            StringBuilder newSbTest = sbTest.Substring (10, 12);

            Console.WriteLine ("Original : {0}", sbTest.ToString());
            Console.WriteLine ();
            Console.WriteLine ("Substring : {0}", newSbTest.ToString ());
            Console.WriteLine ();
        }
    }
}
