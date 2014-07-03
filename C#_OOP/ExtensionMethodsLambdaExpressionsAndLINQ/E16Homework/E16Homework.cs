
namespace E16Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;


    class E16Homework
    {
        static void Main ()
        {
            // Create a class Group with properties GroupNumber and DepartmentName. Introduce a property
            // Group in the Student class. Extract all students from "Mathematics" department. Use the Join operator.

            Console.WriteLine ("Homework 16:");
            Console.WriteLine ();
            
            var GroupMathematics =
                from student in StudentsList.list
                join grp in StudentsList.groups on student.GroupNumber equals grp.GroupNumber
                where grp.DepartmentName == "Mathematics"
                select student;


            StudentsList.PrintList (GroupMathematics);
        }
    }
}
