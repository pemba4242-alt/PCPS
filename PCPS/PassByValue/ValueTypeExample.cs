using System;
using System.Collections.Generic;
using System.Text;

namespace PCPS.PassByValue
{
    public class ValueTypeExample
    {
        public static void Run()
        {
            Console.WriteLine("--- Value Type: Pass By Value ---");
            int number = 10;
            Console.WriteLine($"Before method call: {number}");

            ModifyNumber(number);

            Console.WriteLine($"After method call: {number} (Original value remains unchanged)");
            Console.WriteLine();
        }

        private static void ModifyNumber(int num)
        {
            num = 99; // Modifies only the copy
            Console.WriteLine($"Inside method: {num}");
        }
    }
}
