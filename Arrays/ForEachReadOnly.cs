using System;

namespace Arrays
{
    static class ForEachReadOnly
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            Console.WriteLine($"Enumerating using foreach loop {Environment.NewLine}");

            foreach (string day in daysOfWeek)
            {
                // foreach is readonly cannot assign new values
                // day = day + "s";
                Console.WriteLine(day);
            }

            for (int index = 0; index  < daysOfWeek.Length; index++)
            {
                string day = daysOfWeek[index] + "s";

                Console.WriteLine($"Modified day = {day}, original day = {daysOfWeek[index]}");
            }

            
            Console.WriteLine();

            for (int index = 0; index  < daysOfWeek.Length; index++)
            {
                // replace values
                daysOfWeek[index] = $"{daysOfWeek[index]}s";

                Console.WriteLine(daysOfWeek[index]);
            }

            
        }
    }
}
