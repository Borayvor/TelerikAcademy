
namespace E05FindStudentsOrder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E03FindStudents;


    class FindStudentsOrder
    {
        public static void DescendingSort (List<Student> students)
        {
            var newSudentsList =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (Student student in newSudentsList)
            {
                Console.WriteLine (student);
            }
        }



        static void Main ()
        {
            // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
            // first name and last name in descending order. Rewrite the same with LINQ.

            var students = new List<Student>
            {
                new Student 
                {                     
                    FirstName = "Zornitca",
                    LastName = "Elenova",
                    Age = 17,
                },
                new Student
                {                    
                    FirstName = "Albena",
                    LastName = "Zlateva",
                    Age = 20,
                },
                new Student
                {                    
                    FirstName = "Pesho",
                    LastName = "Dimitrov",  
                    Age = 27,
                },
                new Student
                {
                    FirstName = "Boris",
                    LastName = "Alonov",
                    Age = 24,
                },
                new Student
                {
                    FirstName = "Unufri",
                    LastName = "Unufriev",
                    Age = 18,
                },
                    
                new Student
                {
                    FirstName = "Boris",
                    LastName = "Sabov",
                    Age = 37,
                },
            };


            Console.WriteLine ("LINQ: DescendingSort");
            DescendingSort (students);
            Console.WriteLine ();
            Console.WriteLine ("Lambda expression: DescendingSort");
            var lambdaExpression = students.OrderByDescending (x => x.FirstName).ThenByDescending (x => x.LastName);
            foreach (var item in lambdaExpression)
            {
                Console.WriteLine (item);
            }
        }
    }
}
