using System;
using System.Linq;

namespace Arrays
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            Console.WriteLine("Initial days of week");
            Array.ForEach(daysOfWeek, x => Console.WriteLine(x));

            Array.Sort(daysOfWeek);

            Console.WriteLine();
            Console.WriteLine("Alphabetically sorted days of week");
            Array.ForEach(daysOfWeek, x => Console.WriteLine(x));
                        
            int indexOfTuesday = Array.BinarySearch(daysOfWeek, "Tuesday");

            Console.WriteLine();
            Console.WriteLine($"Index of Tuesday = {indexOfTuesday} using Array.BinarySearch method. {Environment.NewLine}");

        }
    }
}