
namespace E04FindStudentsAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using E03FindStudents;

    class FindStudentsAge
    {
        public static void FormEighteenToTwenty_four (List<Student> students)
        {
            var newSudentsList =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (Student student in newSudentsList)
            {
                Console.WriteLine (student);
            }
        }



        static void Main (string[] args)
        {
            // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

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

            Console.WriteLine ("FormEighteenToTwenty_four");
            FormEighteenToTwenty_four (students);
            Console.WriteLine ();
        }
    }
}
