namespace E01Homework
{
    using System.Collections.Generic;


    public class SchoolClass : Info, ICommentable
    {
        private List<Teacher> teachersList;
        private List<Student> studentsList;

        public SchoolClass (string identifier, List<Student> studentsList, List<Teacher> teachersList)
            : base (identifier)
        {
            this.studentsList = studentsList;

            this.teachersList = teachersList;
        }
                       

        public List<Teacher> TeachersList
        {
            get
            {
                return this.teachersList;
            }                        
        }

        public List<Student> StudentsList
        {
            get
            {
                return this.studentsList;
            }
        }

        
    }
}
