namespace Problem04DancingBits
{
    using System;

    public class DancingBits
    {
        public static void Main(string[] args)
        {
            string sequenceOfBits = null;
            int count = 0;            

            int K = int.Parse(Console.ReadLine());

            int N = int.Parse(Console.ReadLine());

            for(int indexSeq = 0; indexSeq < N; indexSeq++)
            {
                sequenceOfBits += Convert.ToString((int.Parse(Console.ReadLine())), 2);
            }
                        
            for(int index = 0; index < sequenceOfBits.Length; index++ )
            {
                int localCount = 0;

                for(int indexNext = index; indexNext < sequenceOfBits.Length; indexNext++)
                {         
                    if(sequenceOfBits[index] != sequenceOfBits[indexNext])
                    {
                        index = indexNext - 1;
                        break;
                    }

                    localCount++;

                    if(indexNext == sequenceOfBits.Length - 1)
                    {
                        index = indexNext;
                        break;
                    }
                }

                if(localCount == K)
                {
                    count++;
                }
            } 

            Console.WriteLine(count);
        }
    }
}
