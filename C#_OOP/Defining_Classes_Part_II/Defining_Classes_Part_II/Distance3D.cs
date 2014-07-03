using System;


namespace Defining_Classes_Part_II
{
    public static class Distance3D
    {
        public static double Calculate (Point3D firstPoint, Point3D secontPoint)
        {            
            double deltaX = secontPoint.X - firstPoint.X;
            double deltaY = secontPoint.Y - firstPoint.Y;
            double deltaZ = secontPoint.Z - firstPoint.Z;

            double distance = (double) Math.Sqrt (deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            return distance;
        }
    }
}
