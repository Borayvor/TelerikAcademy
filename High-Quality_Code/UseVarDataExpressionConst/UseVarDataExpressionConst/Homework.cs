using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseVarDataExpressionConst
{
    public class Homework
    {
        public static void Main (string[] args)
        {
        }

        public static Size GetRotatedSize (Size rotatedSize, double angle)
        {
            double newWidth = Math.Abs (Math.Cos (angle)) * rotatedSize.Width +
                Math.Abs (Math.Sin (angle)) * rotatedSize.Height;

            double newHeight = Math.Abs (Math.Sin (angle)) * rotatedSize.Width +
                Math.Abs (Math.Cos (angle)) * rotatedSize.Height;

            return new Size (newWidth, newHeight);
        }


        public void PrintStatistics (double[] array)
        {
            Console.WriteLine ("The max value is: {0}", GetMaxValue (array));

            Console.WriteLine ("The average value is: {0}", GetAverageValue (array));

            Console.WriteLine ("The min value is: {0}", GetMinValue (array));           
        }

        private double GetMaxValue (double[] array)
        {
            double maxValue = double.MinValue;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > maxValue)
                {
                    maxValue = array[index];
                }
            }

            return maxValue;
        }

        private double GetMinValue (double[] array)
        {
            double minValue = double.MaxValue;

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < minValue)
                {
                    minValue = array[index];
                }
            }

            return minValue;
        }

        private double GetAverageValue (double[] array)
        {
            double averageValue = 0;
            double sum = 0;

            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }

            averageValue = sum / array.Length;

            return averageValue;
        }
    }
}

public class Size
{
    private double width;
    private double height;

    public Size (double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }


    public double Width
    {
        get
        {
            return this.width;
        }

        set
        {
            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }

        set
        {
            this.height = value;
        }
    }
}
