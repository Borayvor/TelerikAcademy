namespace E01Homework
{
   
    public class Discipline : Info
    {
        public Discipline (string name, int numOfLectures, int numOfExercises)
            : base (name)
        {
            this.NumOfLectures = numOfLectures;

            this.NumOfExercises = numOfExercises;
        }

        public int NumOfLectures { get; private set; }

        public int NumOfExercises { get; private set; }
    }
}
