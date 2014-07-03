namespace E10Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E09StudentsInfo;



    class E10Homework
    {
        static void Main (string[] args)
        {
            // Implement the previous using the same query expressed with extension methods.


            Console.WriteLine ("Homework 10:");
            Console.WriteLine ();
            var studentsFromGroup2Lambda = StudentsList.list.Where (x => x.GroupNumber == 2).OrderBy (x => x.FirstName);

            StudentsList.PrintList (studentsFromGroup2Lambda);            
        }
    }
}
