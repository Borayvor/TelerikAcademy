namespace E02Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;



    class HomeworkTest
    {
        static void Main ()
        {
            // Define abstract class Human with first name and last name. Define new class Student which is derived 
            // from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary
            // and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define 
            // the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them 
            // by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and 
            // sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.


            List<Student> students = new List<Student> ()
            {
              new Student( "Pesho","Peshev", 9 ),
              new Student( "Gogo","Gogov", 7 ),
              new Student( "Ianko","Iankov", 3 ),
              new Student( "Ivan","Ivanov", 4 ),
              new Student( "Mitko","Dimitrov", 5 ),
              new Student( "Asen","Asenov", 8 ),
              new Student( "Elena","Elenova", 2 ),
              new Student( "Iva","Ivailova", 1 ),
              new Student( "Zornica","Zogravska", 10 ),
              new Student( "Maria","Angelova", 6 )
            };

            


            Console.WriteLine ("Workers :");
            List<Worker> workers = new List<Worker> ()
            {
              new Worker( "Iva","Zogravska", 250, 8 ),
              new Worker( "Ivan","Dimitrov", 350, 8 ),
              new Worker( "Maria","Ivailova", 50, 4 ),
              new Worker( "Elena","Angelova", 1500, 4 ),
              new Worker( "Zornica","Elenova", 800, 8 ),
              new Worker( "Asen","Ivanov", 210, 8 ),
              new Worker( "Ianko","Peshev", 30, 8 ),
              new Worker( "Pesho","Gogov", 145, 6 ),
              new Worker( "Gogo","Iankov", 731, 6 ),
              new Worker( "Ianko","Asenov", 235, 4 )
            };


            Console.WriteLine ("Menu :");
            Console.WriteLine ("1. Students.");
            Console.WriteLine ("2. Workers.");
            Console.WriteLine ("3. Merged.");
            
            int choice = 0;
            choice = int.Parse (Console.ReadLine ());

            switch (choice)
            {
                case 1 :
                    {
                        Console.WriteLine ("======= Unsorted Students list :");
                        foreach (var student in students)
                        {
                            Console.WriteLine (student.Print ());
                        }
                        Console.WriteLine ();

                        students = students.OrderBy (student => student.Grade).ToList ();

                        Console.WriteLine ("======= Sorted Students list :");
                        foreach (var student in students)
                        {
                            Console.WriteLine (student.Print ());
                        }
                        Console.WriteLine ();
                    }
                    break;

                case 2 :
                    {
                        Console.WriteLine ("======= Unsorted Workers list :");
                        foreach (var worker in workers)
                        {
                            Console.WriteLine (worker.Print ());
                        }
                        Console.WriteLine ();

                        workers = workers.OrderByDescending (worker => worker.MoneyPerHour ()).ToList ();

                        Console.WriteLine ("======= Sorted Workers list :");
                        foreach (var worker in workers)
                        {
                            Console.WriteLine (worker.Print ());
                        }
                        Console.WriteLine ();
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine ("======= Merged and sorted by name :");

                        var mergedList = workers.Concat<Human> (students).ToList ();

                        mergedList = mergedList.OrderBy (ml => ml.FirstName).ThenBy (ml => ml.LastName).ToList ();

                        foreach (var human in mergedList)
                        {
                            Console.WriteLine (human.Print ());
                        }
                        Console.WriteLine ();
                    }
                    break;
            }

        }
    }
}
