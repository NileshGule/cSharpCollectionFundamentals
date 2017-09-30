using System;

namespace Arrays
{
    class ArrayEnumeration
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

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
        }
    }
}