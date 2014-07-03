using System;
using System.Collections.Generic;


namespace Defining_Classes_Part_II
{
    class Defining_Classes_Part_II
    {
        static void Main ()
        {
            //test Point3D
            Console.WriteLine ("test Point3D");
            Point3D p1 = new Point3D ();
            p1.X = 3;
            p1.Y = 9;
            Console.WriteLine (p1.ToString ());
            
            Console.WriteLine (Point3D.ZeroCoordinate);
            Console.WriteLine ();

            //test Distance3D
            Console.WriteLine ("test Distance3D");
            Console.WriteLine ("p1 = {0}", p1);
            Console.WriteLine ("ZeroCoordinate = ", Point3D.ZeroCoordinate);
            Console.Write ("distance p1 -> ZeroCoordinate = ");
            Console.WriteLine (Distance3D.Calculate (p1, Point3D.ZeroCoordinate));
            Point3D p2 = new Point3D (4, 6, 2);
            Console.WriteLine ("p2 = {0}", p2);
            Console.Write ("distance p1 -> p2 = ");
            Console.WriteLine (Distance3D.Calculate (p1, p2));
            Console.WriteLine ();

            //test Path
            Console.WriteLine ("test Path");
            var pathArr = new Path[3];
            Random randomGenerator = new Random ();

            for (int index = 0; index < pathArr.Length; index++)
            {
                pathArr[index] = new Path ();

                for (int i = 0; i < 5; i++)
                {
                    Point3D point = new Point3D (randomGenerator.Next (100) + 1, randomGenerator.Next (100) + 1, 
                                                                                 randomGenerator.Next (100) + 1);
                    pathArr[index].AddPoint (point);                        
                }
            }
            Console.WriteLine ();

            //test PathStorage
            Console.WriteLine ("test PathStorage");
            PathStorage.Clear ();

            for (int index = 0; index < pathArr.Length; index++)
            {
                PathStorage.SavePathToFile (pathArr[index]);
            }

            var pathList = PathStorage.GetPathList ();

            foreach (var path in pathList)
            {
                Console.WriteLine ("New Path:");
                Console.WriteLine (path);
            }
            Console.WriteLine ();

            //test GenericList
            Console.WriteLine ("test GenericList");
            GenericList<int> list = new GenericList<int> (5);

            int length = list.Capacity; 
            for (int i = 0; i < length; i++)
            {
                list.Add (i);
            }

            Console.WriteLine ("list -> element at index 1 = {0}", list.GetElement (1));
            
            list.InsertElementAtIndex (3, 7);
            list.InsertElementAtIndex (3, 7);
            list.InsertElementAtIndex (3, 7);
            list.InsertElementAtIndex (3, 7);
            list.InsertElementAtIndex (3, 7);
            list.InsertElementAtIndex (3, 7);
            list.InsertElementAtIndex (3, 7);

            list.Add (7);

            list.RemoveElementAtIndex (3);
            list.RemoveElementAtIndex (3);
            list.RemoveElementAtIndex (3);
            list.RemoveElementAtIndex (3);
            list.RemoveElementAtIndex (3);
            list.RemoveElementAtIndex (3);
            list.RemoveElementAtIndex (3);

            Console.WriteLine ("find index of value 4 = {0}", list.FindByValue(4));
            Console.WriteLine ("list = {0}", list);

            Console.WriteLine ("list min-element = {0}", list.Min<int>());
            Console.WriteLine ("list max-element = {0}", list.Max<int>());

            list.Clear();
            Console.WriteLine ();

            //test Matrix
            Console.WriteLine ("test Matrix");
            Matrix<int> matrix = new Matrix<int>();
            Matrix<double> matrix1 = new Matrix<double> (4);
            Matrix<int> matrix2 = new Matrix<int> (3,3);
            int[,] tempMatrix = new int[3, 3];
            Matrix<int> matrix3 = new Matrix<int> (tempMatrix);
            Matrix<int> matrix4 = new Matrix<int> (new int[4, 4]);
            
            Matrix<DateTime> matrix5 = new Matrix<DateTime> (3, 3);

            //     Console.WriteLine (matrix5 + matrix5);

            double[,] matrixD = { { 0, 2, 3, 4.3 }, { 1, 2.5, 3, 4 }, { 1, 2, 3.2, 4 }, { 1.1, 2, 3, 4 } };
            Matrix<double> matrix6 = new Matrix<double> (matrixD);
            
            Console.WriteLine ();
            // matrix1
            for (int row = 0; row < matrix1.Rows; row++)
            {
                for (int col = 0; col < matrix1.Cols; col++)
                {
                    matrix1[row, col] = 2;
                }
            }
            matrix1[1, 1] = 0;

            Console.WriteLine ("m1 + m6 = ");
            Console.WriteLine (matrix1 + matrix6);
            Console.WriteLine ("m1 - m6 = ");
            Console.WriteLine (matrix1 - matrix6);
            Console.WriteLine ("m1 * m6 = ");
            Console.WriteLine (matrix1 * matrix6);

            Console.WriteLine ("matrix1 - true or false");
            if (matrix1)
            {
                Console.WriteLine (true);
            }
            else
            {
                Console.WriteLine (false);
            }
            Console.WriteLine ();
        }
    }
}
