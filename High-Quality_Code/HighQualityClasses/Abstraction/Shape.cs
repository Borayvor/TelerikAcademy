namespace Abstraction
{
    using System;

    public abstract class Shape : IShape
    {
        private double width;
        private double height;       
        private double radius;        
                
        protected Shape(double initialRadius)
        {
            this.Radius = initialRadius;
        }

        protected Shape(double initialWidth, double initialHeight)
        {
            this.Width = initialWidth;
            this.Height = initialHeight;            
        }

        public double Width
        {            
            get
            {
                return this.width;
            }

            private set
            {
                CheckValueForException(value, "Width");

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                CheckValueForException(value, "Height");

                this.height = value;
            }
        }
               
        public double Radius
        {
            get
            {
                return this.radius;
            }

            private set
            {
                CheckValueForException(value, "Radius");

                this.radius = value;
            }
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();

        private void CheckValueForException(double value, string valueName)
        {
            if(value < 0 || value == 0)
            {
                throw new ArgumentOutOfRangeException(" " + valueName + " cannot be zero, or negative !");
            }
        }
    }
}
