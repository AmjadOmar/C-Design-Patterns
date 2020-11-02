using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Iterator!");

            Console.WriteLine("=== Our Cars ===");
            CarRange carRange = new CarRange();
            PrintIterator(carRange.GetEnumerator());

            Console.WriteLine("=== Our Vans ===");
            VanRange vanRange = new VanRange();
            PrintIterator(vanRange.GetEnumerator());
        }

        private static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }
    }
}
