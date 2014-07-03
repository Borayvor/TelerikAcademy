
namespace E13Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;


    class E13Homework
    {
        static void Main ()
        {
            // Select all students that have at least one mark Excellent (6) into a new anonymous 
            // class that has properties – FullName and Marks. Use LINQ.

            Console.WriteLine ("Homework 13:");
            Console.WriteLine ();
            var studentsWithAtLeastOne_Six =
                        from student in StudentsList.list
                        where student.Marks.Contains("6")
                        select new
                        {
                            FullName = student.FirstName + " " + student.LastName,
                            Marks = student.Marks
                        };

            foreach (var student in studentsWithAtLeastOne_Six)
            {
                Console.WriteLine (student.FullName + " --> marks: " + student.Marks);
            }
        }
    }
}
