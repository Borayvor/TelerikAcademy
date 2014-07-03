namespace E01Homework
{

    public class Circle : Shape
    {
        public Circle (double diameter)
            : base (diameter, diameter)
        {
        }

        public override double CalculateSurface ()
        {
            return (this.Height / 2) * (this.Width / 2) * System.Math.PI;
        }
    }
}
