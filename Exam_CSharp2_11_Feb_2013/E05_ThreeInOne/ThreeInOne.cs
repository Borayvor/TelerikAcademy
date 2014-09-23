namespace E05_ThreeInOne
{
    using System;
    using System.Linq;

    public class ThreeInOne
    {
        public static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
        }

        private static int[] GetInputAsInt()
        {
            string[] stringInput = (Console.ReadLine()).Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            int[] inputAsInt = stringInput.Select(x => int.Parse(x)).ToArray();

            return inputAsInt;
        }

        private static void FirstTask()
        {
            const int BLACKJACK_MAX_POINTS = 21;
            const int NO_WINNER = -1;

            int[] points = GetInputAsInt();

            int indexOfWinner = -1;
            int winnerCount = 0;
            int maxPoints = 0;

            for (int index = 0; index < points.Length; index++)
            {
                if (points[index] >= maxPoints && points[index] <= BLACKJACK_MAX_POINTS)
                {
                    if (points[index] > maxPoints)
                    {
                        winnerCount = 0;
                    }

                    winnerCount++;

                    indexOfWinner = index;

                    maxPoints = points[index];
                }
            }

            if (winnerCount == 1)
            {
                Console.WriteLine(indexOfWinner);
            }
            else
            {
                Console.WriteLine(NO_WINNER);
            }
        }

        private static void SecondTask()
        {
            const int ME = 1;

            int[] cakes = GetInputAsInt();

            int gluttons = int.Parse(Console.ReadLine()) + ME;

            Array.Sort(cakes, new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    ));

            int myBites = cakes[0];
            int nextCakeIndex = gluttons;

            for (int index = 1; index < cakes.Length; index++)
            {
                if (index == nextCakeIndex)
                {
                    myBites += cakes[index];
                    nextCakeIndex += gluttons;
                }
            }

            Console.WriteLine(myBites);
        }

        private static void ThirdTask()
        {
            const int NO_ENOUGH_MONEY = -1;
            ////const int BIGGER_COIN = 1;
            const int SMALL_FOR_BIGGER = 9;
            const int BIGGER_FOR_SMALL = 11;

            int[] coinsInput = GetInputAsInt();

            int myCoinsValuePositionsLength = coinsInput.Length / 2;

            int operationsCount = 0;
            int absTempResult = 0;
            bool haveMoneyForEachGSB = true;

            for (int i = 0; i < myCoinsValuePositionsLength; i++)
            {
                if (coinsInput[i] < coinsInput[i + myCoinsValuePositionsLength])
                {
                    haveMoneyForEachGSB = false;
                }
            }
            
            for (int index = 0; index < myCoinsValuePositionsLength - 1; index++)
            {
                int tempResult = coinsInput[index + myCoinsValuePositionsLength] - coinsInput[index];

                if (tempResult < 0 && haveMoneyForEachGSB == false)
                {
                    coinsInput[index] += tempResult;

                    absTempResult = tempResult * (-1);

                    coinsInput[index + 1] += SMALL_FOR_BIGGER * absTempResult;

                    operationsCount += absTempResult;
                }
                else if (tempResult > 0 && haveMoneyForEachGSB == false)
                {
                    coinsInput[index] += tempResult;

                    absTempResult = tempResult;

                    coinsInput[index + 1] -= BIGGER_FOR_SMALL * absTempResult;

                    operationsCount += absTempResult;
                }                
            }
            
            if (coinsInput[myCoinsValuePositionsLength - 1] >= coinsInput[coinsInput.Length - 1])
            {
                Console.WriteLine(operationsCount);
            }
            else
            {
                Console.WriteLine(NO_ENOUGH_MONEY);
            }
        }
    }
}

////  1000000 1000000 1000000 1000000 1000000 1000000
////  0 0 0 0 0 0
////  1000000 1000000 1000000 0 0 0
////  0 0 0 1000000 1000000 1000000