
namespace E14Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;


    class E14Homework
    {
        static void Main ()
        {
            // Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.

            Console.WriteLine ("Homework 14:");
            Console.WriteLine ();
            var students_Exactly_2Marks_2 =
                from student in StudentsList.list
                where student.Marks.Count (x => x.Equals ('2')) == 2
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = student.Marks
                };

            foreach (var student in students_Exactly_2Marks_2)
            {
                Console.WriteLine (student.FullName + " --> marks: " + student.Marks);
            }
        }
    }
}
