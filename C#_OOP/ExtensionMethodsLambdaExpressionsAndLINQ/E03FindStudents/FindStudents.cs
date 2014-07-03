
namespace E03FindStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    

    class FindStudents
    {

        public static void FirstNameBeforeLastName(List<Student> students)
        {
            var newSudentsList =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (Student student in newSudentsList)
            {
                Console.WriteLine(student);
            }
        }
                



        static void Main()
        {
            // Write a method that from a given array of students finds all students whose first name 
            // is before its last name alphabetically. Use LINQ query operators.

            
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

            Console.WriteLine("FirstNameBeforeLastName");
            FirstNameBeforeLastName(students);
            Console.WriteLine();            
            
        }
    }



}
