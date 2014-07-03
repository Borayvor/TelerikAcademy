using System;
using System.Collections.Generic;
using System.Text;


namespace Defining_Classes_Part_II
{
    public class Path
    {
        private readonly List<Point3D> pathOfPoints;
                

        public Path ()
        {
            pathOfPoints = new List<Point3D> ();
        }

        public void AddPoint ()
        {
            this.pathOfPoints.Add (Point3D.ZeroCoordinate);
        }
                
        public void AddPoint (Point3D point)
        {
            this.pathOfPoints.Add (point);
        }

        public void AddPoint (int x, int y, int z)
        {
            this.pathOfPoints.Add (new Point3D (x, y, z));
        }

        public void Clear ()
        {
            this.pathOfPoints.Clear ();
        }

        public override string ToString ()
        {
            StringBuilder sb = new StringBuilder ();

            int pathIndex = 0;

            foreach (Point3D point in this.pathOfPoints)
            {
                sb.AppendFormat ("Point {0} : {1}\r\n", pathIndex, point.ToString ());
               
                pathIndex++;
            }
            return sb.ToString ();
        }

    }
}
