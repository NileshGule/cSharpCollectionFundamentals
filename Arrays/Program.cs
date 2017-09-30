using System;

namespace Arrays
{
    class Program
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

            //C# 7 nested function
            void PrintElements(string[] array)
            {
                foreach (string day in array)
                {
                    Console.WriteLine(day);
                }
            }

            PrintElements(daysOfWeek);

            // Replace element in the array
            daysOfWeek[5] = "PartyDay";

            PrintElements(daysOfWeek);
        }
    }
}
