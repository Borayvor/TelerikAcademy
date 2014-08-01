namespace Problem03SandGlass
{
    using System;    

    public class SandGlass
    {
        public static void Main(string[] args)
        {
            int N;
            int indexRow = 0;
            int sign = 1;
            
            N = int.Parse(Console.ReadLine());

            do
            {
                for(int indexCol = 0; indexCol < N; indexCol++)
                {
                    if(indexCol < indexRow || indexCol > (N - 1) - indexRow)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();

                if(indexRow == (N / 2))
                {
                    sign = -1;
                }
                
                indexRow += sign;

            } while(indexRow >= 0);
        }
    }
}
