namespace Problem04DancingBits
{
    using System;

    public class DancingBits
    {
        public static void Main(string[] args)
        {
            string sequenceOfBits = null;
            int countEqualBits = 0;            

            int K = int.Parse(Console.ReadLine());

            int N = int.Parse(Console.ReadLine());

            for(int indexSeq = 0; indexSeq < N; indexSeq++)
            {
                //// convert to binary number, then convert to string, and then add to 'sequenceOfBits'
                sequenceOfBits += Convert.ToString((int.Parse(Console.ReadLine())), 2);
            }
                        
            for(int index = 0; index < sequenceOfBits.Length; index++ )
            {
                int countDancingBits = 0;

                for(int indexDancingBits = index; indexDancingBits < sequenceOfBits.Length; indexDancingBits++)
                {         
                    if(sequenceOfBits[index] != sequenceOfBits[indexDancingBits])
                    {
                        index = indexDancingBits - 1;
                        break;
                    }

                    countDancingBits++;

                    if(indexDancingBits == sequenceOfBits.Length - 1)
                    {
                        index = indexDancingBits;
                        break;
                    }
                }

                if(countDancingBits == K)
                {
                    countEqualBits++;
                }
            } 

            Console.WriteLine(countEqualBits);
        }
    }
}
