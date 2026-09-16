using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.Protected
{
    public class Human
    {
        protected int protectedNumber {  get; set; }
        public int publicNumber {  get; set; }
        public void DisplayProtectedNumber()
        {
            Console.WriteLine("Protected Number of human is " + protectedNumber); //only accessible within the class and derived classes
        }

        public void DisplayPublicNumber()
        {
            Console.WriteLine("Public Number of human is " + publicNumber);
        }
    }
}
