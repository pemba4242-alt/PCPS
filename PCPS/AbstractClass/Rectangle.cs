using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.AbstractClass
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // MUST override the abstract method from the base class
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
