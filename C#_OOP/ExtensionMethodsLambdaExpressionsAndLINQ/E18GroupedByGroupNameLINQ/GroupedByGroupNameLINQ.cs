namespace E18GroupedByGroupNameLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;


    class GroupedByGroupNameLINQ
    {
        static void Main ()
        {
            // Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.

            Console.WriteLine ("Homework 18:");
            Console.WriteLine ();
            string[] departmentName = {
                                          "Mathematics",
                                          "Medicine",
                                          "Physics",
                                          "Chemistry",
                                          "Arts",
                                          "Biology",
                                      };


            foreach (var item in departmentName)
            {


                var studentsByGroupName =
                    from student in StudentsList.list
                    join grp in StudentsList.groups on student.GroupNumber equals grp.GroupNumber
                    where grp.DepartmentName == item
                    select student;

                Console.WriteLine ();
                Console.WriteLine ("{0} :", item);
                StudentsList.PrintList (studentsByGroupName);
            }
            Console.WriteLine ();
        }
    }
}
