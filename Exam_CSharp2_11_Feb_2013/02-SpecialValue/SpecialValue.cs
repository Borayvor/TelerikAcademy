namespace _02_SpecialValue
{
    using System;

    public class SpecialValue
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[][] dataRow = new int[N][];
            bool[][] isVisitedCell = new bool[N][];

            for (int indexRow = 0; indexRow < N; indexRow++)
            {
                string dataCol = Console.ReadLine();
                string[] rowDataString = dataCol.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                dataRow[indexRow] = new int[rowDataString.Length];
                isVisitedCell[indexRow] = new bool[rowDataString.Length];

                for (int indexCol = 0; indexCol < rowDataString.Length; indexCol++)
                {
                    dataRow[indexRow][indexCol] = int.Parse(rowDataString[indexCol]);
                }
            }

            int specialValue = 0;

            int row;
            int column;
            int pathLength;
            int tempSpecialValue;
            int value;

            for (int indexStart = 0; indexStart < dataRow[0].Length; indexStart++)
            {
                row = 0;
                column = indexStart;
                pathLength = 0;
                tempSpecialValue = 0;
                value = 0;

                do
                {
                    value = dataRow[row][column];

                    pathLength++;

                    tempSpecialValue = pathLength + Math.Abs(value);

                    isVisitedCell[row][column] = true;

                    row++;

                    if (row >= N)
                    {
                        row = 0;
                    }

                    column = value;
                }
                while (value >= 0 && isVisitedCell[row][column] == false);

                for (int indexRow = 0; indexRow < N; indexRow++)
                {
                    for (int indexCol = 0; indexCol < isVisitedCell[indexRow].Length; indexCol++)
                    {
                        isVisitedCell[indexRow][indexCol] = false;
                    }
                }

                if (specialValue < tempSpecialValue)
                {
                    specialValue = tempSpecialValue;
                }
            }

            Console.WriteLine(specialValue);
        }
    }
}
