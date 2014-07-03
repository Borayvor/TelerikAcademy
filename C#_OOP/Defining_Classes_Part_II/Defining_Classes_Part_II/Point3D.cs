using System;


namespace Defining_Classes_Part_II
{
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;

        public Point3D (int x, int y, int z)
            : this ()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
       
        private static readonly Point3D zeroCoordinate = new Point3D (0, 0, 0);

        public int X 
        { 
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
       
        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point3D ZeroCoordinate
        {
            get
            {
                return zeroCoordinate;
            }
        }

        public override string ToString ()
        {
            return string.Format("X = {0} , Y = {1} , Z = {2}", X, Y, Z);
        }
    }
}
