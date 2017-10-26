using System;

namespace Arrays
{
    static class ArrayEnumeration
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            Console.WriteLine($"Enumerating using foreach loop {Environment.NewLine}");

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine($"{Environment.NewLine}Enumerating using for loop {Environment.NewLine}");

            for (int index = 0; index < daysOfWeek.Length; index++)
            {
                Console.WriteLine(daysOfWeek[index]);
            }

            Console.WriteLine($"{Environment.NewLine}Enumerating 3 elements using for {Environment.NewLine}");

            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine(daysOfWeek[index]);
            }
        }
    }
}