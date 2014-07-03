namespace Abstraction
{
    using System;

    public class Rectangle : Shape, IShape
    {
        ////public Rectangle()
        ////    : base(0, 0)
        ////{
        ////}

        ////public Rectangle(double width, double height)
        ////    : base(width, height)
        ////{
        ////}

        ////public override double Radius
        ////{
        ////    get
        ////    {
        ////        throw new NotImplementedException("Rectangle does not have Radius");
        ////    }
        ////    set
        ////    {
        ////        throw new NotImplementedException("Rectangle does not have Radius");
        ////    }
        ////}
                
        public Rectangle(double initialWidth, double initialHeight)
            : base(initialWidth, initialHeight)
        {
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
