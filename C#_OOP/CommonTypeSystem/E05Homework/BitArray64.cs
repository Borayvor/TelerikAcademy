namespace E05Homework
{
    using System;
    using System.Collections;
    using System.Collections.Generic;



    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64 ()
            : this (0)
        {            
        }

        public BitArray64 (ulong number)
        {
            this.number = number;
        }

        private readonly ulong number;


        IEnumerator IEnumerable.GetEnumerator ()
        {
            return this.GetEnumerator ();
        }

        public IEnumerator<int> GetEnumerator ()
        {
            int[] bits = this.ConvertToBits ();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        // convert ulong to bits
        private int[] ConvertToBits ()
        {            
            int[] bits = new int[64];
                       
            for (int i = 0; i < bits.Length; i++)
            {
                int bit = (int) ((this.number >> i) & 1);

                bits[63 - i] = bit; 
            }

            return bits;
        }

        // get number in bits
        public int[] Bits
        {
            get
            {
                return this.ConvertToBits ();
            }

        }

        // []
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException ();
                }

                int[] bits = this.ConvertToBits ();

                return bits[index];
            }

        }
        

        // Equals
        public override bool Equals (object obj)
        {
            BitArray64 tempObj = obj as BitArray64;

            if (tempObj == null)
            {
                return false;
            }

            if (!(Object.Equals (this.number, tempObj.number)))
            {
                return false;
            }
            return true;            
        }

        // == operator
        public static bool operator == (BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals (first, second);
        }

        // != operator
        public static bool operator != (BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals (first, second);
        }

        // HashCode
        public override int GetHashCode ()
        {
            return this.number.GetHashCode () ^ this.Bits.GetHashCode ();
        }
    }
}
