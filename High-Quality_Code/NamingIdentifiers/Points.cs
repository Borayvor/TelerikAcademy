namespace Minesweeper
{
    public class MinesweeperPoints
    {
        string name;
        int points;

        public MinesweeperPoints ()
        {
        }

        public MinesweeperPoints (string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }
    }
}
