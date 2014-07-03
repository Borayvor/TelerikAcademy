namespace E03Homework
{
    using System;


    public class Cat : Animal, ISound
    {
        public Cat (double age, string name, char sex)
            : base (age, name, sex)
        {
        }


        public string Sound ()
        {
            return "meow, meow !";
        }

        public override string ToString ()
        {
            return string.Format ("I am a Cat {0}, sex {1} at age {2} years and say {3}", Name, Sex, Age, Sound ());
        }
    }
}
