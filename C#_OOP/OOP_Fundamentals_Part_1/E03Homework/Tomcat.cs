namespace E03Homework
{
    public class Tomcat : Cat, ISound
    {
        public Tomcat (double age, string name)
            : base (age, name, 'M')
        {
        }

        public override string ToString ()
        {
            return string.Format ("I am a Tomcat {0} at age {2} years and say {2}", Name, Age, Sound ());
        }
    }
}
