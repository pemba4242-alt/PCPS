using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.Protected
{
    public class Student : Human
    {
        public void ChangeAndDisplayProtectedNumber()
        {
            this.protectedNumber = 10; //only accessible within the class and derived classes
            Console.WriteLine("Protected Number of student is " + this.protectedNumber);
        }
    }
}
