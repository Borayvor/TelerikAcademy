
namespace E12Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;


    class E12Homework
    {
        static void Main ()
        {
            // Extract all students with phones in Sofia. Use LINQ.

            Console.WriteLine ("Homework 12:");
            Console.WriteLine ();
            var studentsSofiaPhoneNumbers =
                from student in StudentsList.list
                where student.Tel.StartsWith ("02")
                select student;

            StudentsList.PrintList (studentsSofiaPhoneNumbers);
        }
    }
}
