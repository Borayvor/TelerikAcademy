namespace E01Homework
{
    using System;


    public abstract class Human : Info, ICommentable
    {      
        public Human (string name)
           : base (name)
        {            
        }

    }
}
