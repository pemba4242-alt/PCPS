using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.PassByReference
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class ReferenceTypeRefExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Reference Type: Pass By Reference (using ref) ---");
            Person person = new Person { Name = "Alice" };
            Console.WriteLine($"Before method call: {person.Name}");

            ModifyPerson(ref person);

            Console.WriteLine($"After method call: {person.Name} (Original object variable was completely reassigned!)");
            Console.WriteLine();
        }

        private static void ModifyPerson(ref Person p)
        {
            p.Name = "Bob"; // Changes internal state

            // Reassigning p to a new object completely replaces the original reference!
            p = new Person { Name = "Charlie" };
            Console.WriteLine($"Inside method (after reassignment): {p.Name}");
        }
    }
}
