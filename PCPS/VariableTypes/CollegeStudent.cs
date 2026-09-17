using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.VariableTypes
{
    class CollegeStudent
    {
        // Static Variable
        public static string CollegeName = "PCPS College";

        // Instance Variable
        public string Name;

        public CollegeStudent(string name)
        {
            Name = name;
        }

        public void DisplayDetails(int age)
        {
            // Local Variable
            string department = "Computer Science";

            Console.WriteLine("College Name: " + CollegeName);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Department: " + department);
            Console.WriteLine();
        }
    }
}
