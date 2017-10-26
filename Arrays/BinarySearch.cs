using System;
using System.Linq;

namespace Arrays
{
    static class BinarySearch
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            void print(string[] inputArray, string message)
            {
                Console.WriteLine();
                Console.WriteLine(message);
                Array.ForEach(daysOfWeek, x => Console.WriteLine(x));    
            }

            print(daysOfWeek, "Initial days of week");
            
            Array.Sort(daysOfWeek);

            print(daysOfWeek, "Alphabetically sorted days of week");
                        
            int indexOfTuesday = Array.BinarySearch(daysOfWeek, "Tuesday");

            Console.WriteLine();
            Console.WriteLine($"Index of Tuesday = {indexOfTuesday} using Array.BinarySearch method. {Environment.NewLine}");

        }
    }
}