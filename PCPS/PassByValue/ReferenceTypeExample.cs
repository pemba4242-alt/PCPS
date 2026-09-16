using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.PassByValue
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class ReferenceTypeExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Reference Type: Pass By Value ---");
            Person person = new Person { Name = "Alice" };
            Console.WriteLine($"Before method call: {person.Name}");

            ModifyPerson(person);

            Console.WriteLine($"After method call: {person.Name} (Internal state changed, but it's still the same object)");
            Console.WriteLine();
        }

        private static void ModifyPerson(Person p)
        {
            p.Name = "Bob"; // Changes the data inside the shared object

            // Reassigning p to a new object won't affect the original object outside
            p = new Person { Name = "Charlie" };
            Console.WriteLine($"Inside method (after reassignment attempt): {p.Name}");
        }
    }
}
