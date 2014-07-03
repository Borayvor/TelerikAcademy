using System;
using System.Collections.Generic;


namespace E01Homework
{
    class HomeworkTest
    {
        static void Main ()
        {
            // We are given a school. In the school there are classes of students. Each class has a set of teachers. 
            // Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have 
            // unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of 
            // exercises. Both teachers and students are people. Students, classes, teachers and disciplines could 
            // have optional comments (free text block).
	        // Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate 
            // their fields, define the class hierarchy and create a class diagram with Visual Studio.


            Student gogo = new Student ("Gogo", 23);
            Student vania = new Student ("Vania", 24);
            Discipline math = new Discipline ("Mathematic", 4, 10);
            Discipline phys = new Discipline ("Physics", 5, 8);
            Discipline med = new Discipline ("Medicine", 2, 18);
            List<Discipline> LDkiro = new List<Discipline> () { math, phys };
            List<Discipline> LDpesho = new List<Discipline> () { math, phys, med };
            
            Teacher techerPesho = new Teacher ("Pesho", LDpesho);
            Teacher techerKiro = new Teacher ("Kiro", LDkiro);
                        
            techerPesho.Comment = "brrrrr";
            gogo.Comment = "Imalo edno wreme.";

            Console.WriteLine ("Teacher Pesho coment : {0}", techerPesho.Comment);
            Console.WriteLine ();
            Console.WriteLine ("Gogo class number : {0}", gogo.ClassNumber);
            Console.WriteLine ();
            Console.WriteLine ("Teacher Pesho disciplines:");
            foreach (var discipline in techerPesho.DisciplinesList)
            {
                Console.WriteLine (discipline.Identifier);
            }
            Console.WriteLine ();

            List<Student> sudentsListA1 = new List<Student> ();
            sudentsListA1.Add (gogo);
            sudentsListA1.Add (vania);

            List<Teacher> TeachersListA1 = new List<Teacher> ();
            TeachersListA1.Add (techerPesho);

            SchoolClass A1 = new SchoolClass ("A1", sudentsListA1, TeachersListA1);

            List<SchoolClass> listOfClasses = new List<SchoolClass> ();
            listOfClasses.Add (A1);

            School profIvanov = new School (listOfClasses);
        }
    }
}
