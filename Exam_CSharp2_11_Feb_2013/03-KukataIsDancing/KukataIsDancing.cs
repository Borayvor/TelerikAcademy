namespace _03_KukataIsDancing
{
    using System;

    public class KukataIsDancing
    {

        public static void Main(string[] args)
        {                  
            int numberPerformedDances = int.Parse(Console.ReadLine());

            string[] dances = new string[numberPerformedDances];

            for (int danceNumber = 0; danceNumber < dances.Length; danceNumber++)
            {
                dances[danceNumber] = Console.ReadLine();
            }

            string[,] cube = new string[,]
                {
                    {"RED", "BLUE", "RED"},
                    {"BLUE", "GREEN", "BLUE"},
                    {"RED", "BLUE", "RED"}
                };

            int[] directionX = new int[] { 0, 1, 0, -1 };
            int[] directionY = new int[] { 1, 0, -1, 0 };

            int positionX = 1;
            int positionY = 1;

            int currentDirection = 0;
            int currentMove = 0;

            for (int danceNumber = 0; danceNumber < dances.Length; danceNumber++)
            {
                for (int step = 0; step < dances[danceNumber].Length; step++)
                {
                    currentMove = GetMove((dances[danceNumber][step]));

                    if (currentMove != 0)
                    {
                        currentDirection += currentMove;

                        currentDirection = CheckPosition(currentDirection, false);
                    }

                    if (currentMove == 0)
                    {
                        positionX += directionX[currentDirection];
                        positionY += directionY[currentDirection];

                        positionX = CheckPosition(positionX, true);
                        positionY = CheckPosition(positionY, true);
                    }
                }

                Console.WriteLine(cube[positionY, positionX]);

                positionX = 1;
                positionY = 1;
                currentDirection = 0;
            }
        }

        private static int CheckPosition(int position, bool isPosition)
        {
            int limit = (isPosition == true) ? 2 : 3;

            if (position > limit)
            {
                position = 0;
            }

            if (position < 0)
            {
                position = limit;
            }

            return position;
        }

        private static int GetMove(char move)
        {
            switch (move)
            {
                case 'L':
                    {
                        return -1;
                    }
                case 'R':
                    {
                        return 1;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}