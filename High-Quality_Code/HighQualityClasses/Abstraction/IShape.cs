namespace Abstraction
{
    public interface IShape
    {
        double Width { get; }

        double Height { get; }
               
        double Radius { get; }

        double CalculatePerimeter();

        double CalculateSurface();
    }
}
