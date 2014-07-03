namespace E01Homework
{
    using System;

    public class Student : Human, ICommentable
    {        
        private int classNumber;

        public Student (string name, int classNumber)
            : base (name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber 
        {
            get
            {
                return classNumber;
            }

            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentException ("Students class number can not be less than 1 !");
                }

                this.classNumber = value;
            }
        }

        
    }
}
