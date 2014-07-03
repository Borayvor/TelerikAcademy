namespace E01Homework
{
    using System;


    public abstract class Shape
    {
        private double width;
        private double height;

        
        protected Shape (double width, double height)
        {
            this.Width = width;

            this.Height = height;
        }

        protected double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException ("Width must be positive.");
                }
                this.width = value;
            }
        }

        protected double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException ("Height must be positive.");
                }
                this.height = value;
            }
        }


        public abstract double CalculateSurface ();        
    }
}
