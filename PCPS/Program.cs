using PCPS.AbstractClass;
using PCPS.Constructor;
using PCPS.GetSet;
using PCPS.PassByReference;
using PCPS.PassByValue;
using PCPS.Protected;
using PCPS.VariableTypes;

namespace PCPS
{
    class Program
    {
        static void Main(string[] args) // This is the entry point of this application
        {
            // Uncomment the lines to run each section. Go through each section in ascending order

            // 1. Pass By Value Examples
            //ValueTypeExample.Run();
            //ReferenceTypeExample.Run();

            // 2. Pass By Reference Examples
            //ValueTypeRefExample.Run();
            //ReferenceTypeRefExample.Run();

            // 3. VariableTypes Example
            //VariableTypesExample();

            // 4. Get Set Example
            //GetSetExample();

            // 5. Constructor Example
            //ConstructorExample();

            // 6. Protected Example 
            //Human human = new Human();
            //human.publicNumber = 16;
            //human.DisplayPublicNumber();
            //human.protectedAge = 20; // only accessible within the class and derived classes


            //Student student = new Student();
            //student.ChangeAndDisplayProtectedNumber();

            // 7. Abstract Class Example
            //AbstractClassExample();
            //Shape shape = new Shape(); // cannot create instance of abstract class
        }

        public static void AbstractClassExample()
        {
            Circle myCircle = new Circle(5.0);
            myCircle.Color = "Red";

            Rectangle myRectangle = new Rectangle(4.0, 6.0);
            myRectangle.Color = "Blue";

            Console.WriteLine("--- Displaying Circle Details ---");
            myCircle.DisplayColor();
            double circleArea = myCircle.CalculateArea();
            Console.WriteLine("Circle Area " + circleArea);
            Console.WriteLine("\n");

            Console.WriteLine("--- Displaying Rectangle Details ---");
            myRectangle.DisplayColor();
            double rectangleArea = myRectangle.CalculateArea();
            Console.WriteLine("Rectangle Area " + rectangleArea);
            Console.WriteLine("\n");
        }

        public static void ConstructorExample()
        {
            // Default Constructor
            Animal animal1 = new Animal();
            animal1.Display();
            Console.WriteLine();

            // Constructor with one parameter
            Animal animal2 = new Animal(101);
            animal2.Display();
            Console.WriteLine();

            // Constructor with two parameters
            Animal animal3 = new Animal(102, "John");
            animal3.Display();
        }

        public static void GetSetExample()
        {
            People people = new People();
            people.Age = 20;
            Console.WriteLine("Age: " + people.Age);

            people.Age = -5;
            Console.WriteLine("Age: " + people.Age);
        }

        public static void VariableTypesExample()
        {
            CollegeStudent s1 = new CollegeStudent("John");
            CollegeStudent s2 = new CollegeStudent("Alice");

            s1.DisplayDetails(20);
            s2.DisplayDetails(22);
        }

    }
}
