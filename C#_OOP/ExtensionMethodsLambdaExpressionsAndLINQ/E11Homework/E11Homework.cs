
namespace E11Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;


    class E11Homework
    {
        static void Main ()
        {
            // Extract all students that have email in abv.bg. Use string methods and LINQ.

            Console.WriteLine ("Homework 11:");
            Console.WriteLine ();
            var studentEmailAbv =
                from student in StudentsList.list
                where student.Email.EndsWith ("@abv.bg")
                select student;

            StudentsList.PrintList (studentEmailAbv); 
        }
    }
}
