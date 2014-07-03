namespace E05Homework
{
    using System;
    using System.Collections.Generic;


    class TestBitArray64
    {
        static void Main ()
        {
            // Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> 
            // and Equals(…), GetHashCode(), [], == and !=.

            ulong firstLong = 9223372035854775807;
            BitArray64 bitsFirst = new BitArray64 (firstLong);

            foreach (var bit in bitsFirst.Bits)
            {
                Console.Write (bit);
            }
            Console.WriteLine ();

            ulong secondLong = 9223372035854775808;
            BitArray64 bitsSecond = new BitArray64 (secondLong);

            foreach (var bit in bitsSecond.Bits)
            {
                Console.Write (bit);
            }
            Console.WriteLine ();
            Console.WriteLine ();

            Console.WriteLine ("bitsFirst -> bit {0}, bit {1}", (10), (9));
            Console.WriteLine (bitsFirst[63 - 10] + " " + bitsFirst[63 - 9]);
            Console.WriteLine ();

            Console.WriteLine ("!= {0}", bitsFirst != bitsSecond);
            Console.WriteLine ("== {0}", bitsFirst == bitsSecond);
            Console.WriteLine();

            Console.WriteLine ("GetHashCode {0}", bitsFirst.GetHashCode ());
        }
    }
}
