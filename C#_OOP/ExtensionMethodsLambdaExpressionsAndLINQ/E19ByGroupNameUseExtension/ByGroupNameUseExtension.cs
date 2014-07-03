using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E19ByGroupNameUseExtension
{
    class ByGroupNameUseExtension
    {
        static void Main (string[] args)
        {

            var students = new[] 
            {
                            new {Name = "Zornitca", GroupName = "Mathematics"},
                            new {Name = "Albena", GroupName = "Physics"},
                            new {Name = "Gogo", GroupName = "Bilogy"},
                            new {Name = "Unufri", GroupName = "Physics"},
                            new {Name = "Gancho", GroupName = "Bilogy"},
                            new {Name = "Ivan", GroupName = "Mathematics"},
            };

            Console.WriteLine ("Extension methods: ");
            Console.WriteLine ();
            var selectStudentsExtension = students.OrderBy (st => st.GroupName);

            foreach (var student in selectStudentsExtension)
            {
                Console.WriteLine (string.Join (" - ", student.Name, student.GroupName));
            }
            Console.WriteLine ();
        }
    }
}
