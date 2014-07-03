﻿namespace E01Homework
{
    using System;


    class Test_Shape
    {
        static void Main ()
        {
            // Define abstract class Shape with only one abstract method CalculateSurface() and fields width and 
            // height. Define two new classes Triangle and Rectangle that implement the virtual method and return 
            // the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define class 
            // Circle and suitable constructor so that at initialization height must be kept equal to width and 
            // implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() 
            // method for different shapes (Circle, Rectangle, Triangle) stored in an array.

            Shape[] shapesList =
            {
                new Triangle(4, 5),
                new Triangle(4, 4.386),
                new Rectangle(10.743, 20),
                new Rectangle(4, 5),
                new Circle(7.567),
                new Circle(5),
            };

            foreach (var shape in shapesList)
            {
                Console.WriteLine ("{0} surface : {1}", shape.GetType().Name, shape.CalculateSurface());
                Console.WriteLine ();
            }


        }
    }
}
