namespace E03Homework
{
    using System;



    public class InvalidRangeException<T> : ApplicationException 
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException (string msg, T start, T end)
            : base (msg)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException (string msg, T start, T end, Exception innerEx)
            : base (msg, innerEx)
        { 
        }


        public T Start
        {
            get
            {
                return this.start;
            }

            private set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }

            private set
            {
                this.end = value;
            }
        }        

    }
}
