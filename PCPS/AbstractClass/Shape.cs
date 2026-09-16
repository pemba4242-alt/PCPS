using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.AbstractClass
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public abstract double CalculateArea();

        public void DisplayColor()
        {
            Console.WriteLine($"Shape Color: {Color}");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual Method");
        }
    }
}
