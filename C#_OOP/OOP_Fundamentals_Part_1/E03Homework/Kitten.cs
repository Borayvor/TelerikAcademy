namespace E03Homework
{
    using System;


    public class Kitten : Cat, ISound
    {
        public Kitten (double age, string name)
            : base (age, name, 'F')
        {
        }

        public override string ToString ()
        {
            return string.Format ("I am a Kitten {0} at age {2} years and say {2}", Name, Age, Sound ());
        }
    }
}
