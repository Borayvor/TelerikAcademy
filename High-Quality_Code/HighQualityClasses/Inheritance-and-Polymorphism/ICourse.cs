namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public interface ICourse
    {
        string CourseName { get; set; }

        string TeacherName { get; set; }

        IList<string> Students { get; }
    }
}
