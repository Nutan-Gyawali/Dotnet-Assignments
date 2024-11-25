using System;

namespace NetAssignments
{
    internal class Swap
    {
        public Swap()
        {
            int x = 5, y = 10;
            Console.WriteLine("\n");

            Console.WriteLine("Swapping two variables without using third temporary variable");
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");

           
            // Swapping logic
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"After Swap: x = {x}, y = {y}");
        }
    }
}
