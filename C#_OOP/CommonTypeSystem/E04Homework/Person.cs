namespace E04Homework
{
    using System;


    public class Person
    {
        public Person (string name)
            : this (name, null)
        {
        }
        
        public Person (string name, byte? age)            
        {
            this.Name = name;
            this.Age = age;
        }

        private string name;
        private byte? age;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace (value) || value.Length < 2)
                {
                    throw new ArgumentException ("The Name cannot be null, empty, white-space, or at least two characters !");
                }
                this.name = value;
            }
        }

        public byte? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public override string ToString ()
        {
            if (this.Age == null)
            {
                return string.Format ("Name: {0}\r\nAge: The age is not specified !", this.Name);
            }
            return string.Format ("Name: {0}\r\nAge: {1}", this.Name, this.Age);
        }
    }
}
