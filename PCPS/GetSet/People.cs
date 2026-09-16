using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.GetSet
{
    public class People
    {
        private int age; // Private field
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }
    }

    
}
