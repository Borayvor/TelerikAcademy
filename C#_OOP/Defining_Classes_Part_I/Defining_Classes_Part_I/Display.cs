using System;

namespace Defining_Classes_Part_I
{
    public class Display
    {
        private double? size;
        private string numberOfColors;

        public Display ()
            : this (null)
        {
        }

        public Display (double? size)
            : this (size, null)
        {
        }

        public Display (double? size, string numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }


        public double? Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException ("The size should be a positive number.");
                }
                else
                {
                    this.size = value;
                }
            }
        }


        public string NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                string[] tempValue = value.Split ();

                if (value != string.Empty && value.Length >= 2 && tempValue[0] != "-")
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException ("The colors should be a positive number.");
                }
            }
        }


        public override string ToString ()
        {
            return string.Format ("\r\n\tSize: {0}\r\n\tNumber of colors: {1}", this.size, this.numberOfColors);
        }
    }
}
