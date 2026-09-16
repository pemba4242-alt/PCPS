using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.Constructor
{
    public class Animal
    {
        public int Id;
        public string Name;
        // Default Constructor
        public Animal()  
        {
            Id = 0;
            Console.WriteLine("Default Constructor Called");
        }
        // Parameterized Constructor
        public Animal(int id)
        {
            Id = id;
            Console.WriteLine("Constructor with 1 Parameter Called");
        }

        // Overloaded Constructor
        public Animal(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine("Constructor with 2 Parameters Called");
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name {Name}");
        }
    }

}
