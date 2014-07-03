using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {

        static void Main ()
        {
            const int MAX_POINTS = 35;

            string command = string.Empty;
            char[,] playingField = CreatePlayingField ();
            char[,] bombs = PutBombs ();
            int counter = 0;
            int row = 0;
            int column = 0;
            bool explosion = false;
            bool isEndOfGame = true;            
            bool isMaxResult = false;

            List<MinesweeperPoints> champions = new List<MinesweeperPoints> (6);

            do
            {
                if (isEndOfGame)
                {
                    Console.WriteLine ("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");

                    DrawBoard (playingField);
                    isEndOfGame = false;
                }

                Console.Write ("Daj red i kolona : ");
                command = Console.ReadLine ().Trim ();

                if (command.Length >= 3)
                {
                    if (int.TryParse (command[0].ToString (), out row) &&
                    int.TryParse (command[2].ToString (), out column) &&
                        row <= playingField.GetLength (0) && column <= playingField.GetLength (1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        {
                            Ranking (champions);
                            break;
                        }
                    case "restart":
                        {
                            playingField = CreatePlayingField ();
                            bombs = PutBombs ();
                            DrawBoard (playingField);
                            explosion = false;
                            isEndOfGame = false;
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine ("4a0, 4a0, 4a0!");
                            break;
                        }
                    case "turn":
                        {
                            if (bombs[row, column] != '*')
                            {
                                if (bombs[row, column] == '-')
                                {
                                    PlayerMove (playingField, bombs, row, column);
                                    counter++;
                                }
                                if (MAX_POINTS == counter)
                                {
                                    isMaxResult = true;
                                }
                                else
                                {
                                    DrawBoard (playingField);
                                }
                            }
                            else
                            {
                                explosion = true;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine ("\nGreshka! nevalidna Komanda\n");
                            break;
                        }
                }

                if (explosion)
                {
                    DrawBoard (bombs);

                    Console.Write ("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);

                    string username = Console.ReadLine ();

                    MinesweeperPoints userPoints = new MinesweeperPoints (username, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add (userPoints);
                    }
                    else
                    {
                        for (int index = 0; index < champions.Count; index++)
                        {
                            if (champions[index].Points < userPoints.Points)
                            {
                                champions.Insert (index, userPoints);
                                champions.RemoveAt (champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort ((MinesweeperPoints r1, MinesweeperPoints r2) => r2.Name.CompareTo (r1.Name));
                    champions.Sort ((MinesweeperPoints r1, MinesweeperPoints r2) => r2.Points.CompareTo (r1.Points));

                    Ranking (champions);

                    playingField = CreatePlayingField ();
                    bombs = PutBombs ();

                    counter = 0;
                    explosion = false;
                    isEndOfGame = true;
                }

                if (isMaxResult)
                {
                    Console.WriteLine ("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");

                    DrawBoard (bombs);

                    Console.WriteLine ("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine ();

                    MinesweeperPoints to4kii = new MinesweeperPoints (imeee, counter);
                    champions.Add (to4kii);

                    Ranking (champions);

                    playingField = CreatePlayingField ();
                    bombs = PutBombs ();

                    counter = 0;
                    isMaxResult = false;
                    isEndOfGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine ("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine ("AREEEEEEeeeeeee.");
            Console.Read ();
        }

        private static void Ranking (List<MinesweeperPoints> points)
        {
            Console.WriteLine ("\nTo4KI:");

            if (points.Count > 0)
            {
                for (int index = 0; index < points.Count; index++)
                {
                    Console.WriteLine ("{0}. {1} --> {2} kutii",
                        index + 1, points[index].Name, points[index].Points);
                }
                Console.WriteLine ();
            }
            else
            {
                Console.WriteLine ("prazna klasaciq!\n");
            }
        }

        private static void PlayerMove (char[,] FIELD,
            char[,] BOMBS, int ROW, int COLUMN)
        {
            char numberOfBombs = Result (BOMBS, ROW, COLUMN);

            BOMBS[ROW, COLUMN] = numberOfBombs;
            FIELD[ROW, COLUMN] = numberOfBombs;
        }

        private static void DrawBoard (char[,] board)
        {
            int boardRows = board.GetLength (0);
            int boardColumns = board.GetLength (1);

            Console.WriteLine ("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine ("   ---------------------");

            for (int indexRow = 0; indexRow < boardRows; indexRow++)
            {
                Console.Write ("{0} | ", indexRow);

                for (int indexColumn = 0; indexColumn < boardColumns; indexColumn++)
                {
                    Console.Write (string.Format ("{0} ", board[indexRow, indexColumn]));
                }

                Console.Write ("|");
                Console.WriteLine ();
            }
            Console.WriteLine ("   ---------------------\n");
        }

        private static char[,] CreatePlayingField ()
        {
            int boardRows = 5;
            int boardColumns = 10;

            char[,] board = new char[boardRows, boardColumns];

            for (int indexRow = 0; indexRow < boardRows; indexRow++)
            {
                for (int indexColumn = 0; indexColumn < boardColumns; indexColumn++)
                {
                    board[indexRow, indexColumn] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs ()
        {
            int boardRows = 5;
            int boardColumns = 10;

            char[,] board = new char[boardRows, boardColumns];

            for (int indexRow = 0; indexRow < boardRows; indexRow++)
            {
                for (int indexColumn = 0; indexColumn < boardColumns; indexColumn++)
                {
                    board[indexRow, indexColumn] = '-';
                }
            }

            List<int> bombsList = new List<int> ();

            while (bombsList.Count < 15)
            {
                Random random = new Random ();

                int bombCell = random.Next (50);

                if (!bombsList.Contains (bombCell))
                {
                    bombsList.Add (bombCell);
                }
            }

            foreach (int cell in bombsList)
            {
                int col = (cell / boardColumns);
                int row = (cell % boardColumns);

                if (row == 0 && cell != 0)
                {
                    col--;
                    row = boardColumns;
                }
                else
                {
                    row++;
                }
                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void CalculateBombs (char[,] bombs)
        {
            int bombsRows = bombs.GetLength (0);
            int bombsColumns = bombs.GetLength (1);

            for (int indexRow = 0; indexRow < bombsRows; indexRow++)
            {
                for (int indexColumn = 0; indexColumn < bombsColumns; indexColumn++)
                {
                    if (bombs[indexRow, indexColumn] != '*')
                    {
                        char numberOfBombs = Result (bombs, indexRow, indexColumn);
                        bombs[indexRow, indexColumn] = numberOfBombs;
                    }
                }
            }
        }

        private static char Result (char[,] bombs, int row, int col)
        {
            int result = 0;
            int bombsRows = bombs.GetLength (0);
            int bombsColumns = bombs.GetLength (1);

            if (row - 1 >= 0)
            {
                if (bombs[row - 1, col] == '*')
                {
                    result++;
                }
            }

            if (row + 1 < bombsRows)
            {
                if (bombs[row + 1, col] == '*')
                {
                    result++;
                }
            }

            if (col - 1 >= 0)
            {
                if (bombs[row, col - 1] == '*')
                {
                    result++;
                }
            }

            if (col + 1 < bombsColumns)
            {
                if (bombs[row, col + 1] == '*')
                {
                    result++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (bombs[row - 1, col - 1] == '*')
                {
                    result++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < bombsColumns))
            {
                if (bombs[row - 1, col + 1] == '*')
                {
                    result++;
                }
            }

            if ((row + 1 < bombsRows) && (col - 1 >= 0))
            {
                if (bombs[row + 1, col - 1] == '*')
                {
                    result++;
                }
            }

            if ((row + 1 < bombsRows) && (col + 1 < bombsColumns))
            {
                if (bombs[row + 1, col + 1] == '*')
                {
                    result++;
                }
            }
            return char.Parse (result.ToString ());
        }
    }
}
