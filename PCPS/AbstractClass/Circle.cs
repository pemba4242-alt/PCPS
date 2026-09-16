using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.AbstractClass
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        // MUST override the abstract method from the base class
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }


    }
}
