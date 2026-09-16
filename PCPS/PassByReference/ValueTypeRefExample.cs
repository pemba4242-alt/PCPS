using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.PassByReference
{
    public class ValueTypeRefExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Value Type: Pass By Reference (using ref) ---");
            int number = 10;
            Console.WriteLine($"Before method call: {number}");

            ModifyNumber(ref number);

            Console.WriteLine($"After method call: {number} (Original value is changed!)");
            Console.WriteLine();
        }

        private static void ModifyNumber(ref int num)
        {
            num = 99; // Modifies the original variable directly
            Console.WriteLine($"Inside method: {num}");
        }
    }
}
