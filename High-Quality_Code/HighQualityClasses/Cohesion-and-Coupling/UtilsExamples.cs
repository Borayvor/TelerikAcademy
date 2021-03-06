﻿namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(UtilsFile.GetFileExtension("example"));
            Console.WriteLine(UtilsFile.GetFileExtension("example.pdf"));
            Console.WriteLine(UtilsFile.GetFileExtension("example.new.pdf"));

            Console.WriteLine(UtilsFile.GetFileNameWithoutExtension("example"));
            Console.WriteLine(UtilsFile.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(UtilsFile.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Utils2D.CalculateDistance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Utils3D.CalculateDistance(5, 2, -1, 3, -6, 4));
                                   
            double width = 3;
            double height = 4;
            double depth = 5;

            Console.WriteLine("Volume = {0:f2}", Utils3D.CalculateVolume(width, height, depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils3D.CalculateDiagonal(width, height, depth));

            Console.WriteLine("Diagonal XY = {0:f2}", Utils2D.CalculateDiagonal(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils2D.CalculateDiagonal(height, depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils2D.CalculateDiagonal(width, depth));

            Console.WriteLine(Utils3D.CalculateVolume(403005430.43246622, 205001130.865776, 4001760.12988456));
        }
    }
}
