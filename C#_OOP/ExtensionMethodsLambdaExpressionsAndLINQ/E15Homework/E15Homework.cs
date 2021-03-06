﻿
namespace E15Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;


    class E15Homework
    {
        static void Main ()
        {
            // Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 
            // as their 5-th and 6-th digit in the FN).

            Console.WriteLine ("Homework 14:");
            Console.WriteLine ();
            var studentsEnrolled_2006 =
                from student in StudentsList.list
                where student.FN.Substring (4, 2) == "06"
                select new 
                { 
                    FullName = student.FirstName + " " + student.LastName, 
                    FN = student.FN, Marks = student.Marks 
                };


            foreach (var student in studentsEnrolled_2006)
            {
                Console.WriteLine ("Full name: {0} --> FN: {1} --> marks: {2}", student.FullName, student.FN, student.Marks);
            }
        }
    }
}
