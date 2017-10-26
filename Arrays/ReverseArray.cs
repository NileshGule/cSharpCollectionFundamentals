using System;
using System.Linq;

namespace Arrays
{
    static class ReverseArray
    {      
        static void Main(string[] args)
        {
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            string[] originalDaysOfWeek = daysOfWeek.ToArray();

            Console.WriteLine("Reverse using static Array.Reverse method");

            Array.Reverse(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            Console.WriteLine("Reverse using static Array.Reverse method with start & stop index");

            Array.Reverse(daysOfWeek, 1, 4);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            Console.WriteLine("Reverse using extension method from LINQ");

            var linqReversed = originalDaysOfWeek.Reverse();

            foreach (string day in linqReversed)
            {
                Console.WriteLine(day);
            }
        }   
    }
}