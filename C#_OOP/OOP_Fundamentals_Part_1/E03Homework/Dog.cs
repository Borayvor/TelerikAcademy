namespace E03Homework
{
    using System;


    public class Dog : Animal, ISound
    {
        public Dog (double age, string name, char sex)
            : base (age, name, sex)
        {
        }


        public string Sound ()
        {
            return "bark, bark !";
        }

        public override string ToString ()
        {
            return string.Format ("I am a Dog {0}, sex {1} at age {2} years and say {3}", Name, Sex,  Age, Sound ());
        }
    }
}
