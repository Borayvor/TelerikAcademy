
namespace E03FindStudents
{
    using System;
    using System.Collections.Generic;


    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + Age;
        }
    }
        
}
