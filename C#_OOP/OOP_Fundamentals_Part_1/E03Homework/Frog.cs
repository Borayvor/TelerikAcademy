namespace E03Homework
{
    using System;


    public class Frog : Animal, ISound
    {
        public Frog (double age, string name, char sex)
            : base (age, name, sex)
        {
        }
        

        public string Sound ()
        {
            return "ribbit, ribbit !";
        }

        public override string ToString ()
        {
            return string.Format ("I am a Frog {0}, sex {1} at age {2} years and say {3}", Name, Sex, Age, Sound ());
        }
    }
}
