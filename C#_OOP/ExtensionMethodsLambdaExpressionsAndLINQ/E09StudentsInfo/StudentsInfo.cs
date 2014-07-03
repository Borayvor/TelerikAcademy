namespace E09StudentsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class StudentsInfo
    {
        static void Main ()
        {

            // Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), 
            // GroupNumber. Create a List<Student> with sample students. Select only the students that are from 
            // group number 2. Use LINQ query. Order the students by FirstName.

            Console.WriteLine ("Homework 09:");
            Console.WriteLine ();
            var groupNumberTwo =
                          from student in StudentsList.list
                          where student.GroupNumber == 2
                          orderby student.FirstName
                          select student;


            StudentsList.PrintList (groupNumberTwo);            
        }

    }
}


