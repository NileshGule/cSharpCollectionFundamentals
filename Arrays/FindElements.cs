using System;
using System.Linq;

namespace Arrays
{
    static class FindElements
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;
                        
            int indexOfTuesday = Array.IndexOf(daysOfWeek, "Tuesday");

            Console.WriteLine($"Index of Tuesday = {indexOfTuesday} using Array.IndexOf method. {Environment.NewLine}");

            int dayStartingWithW = Array.FindIndex(daysOfWeek, x => x.StartsWith('W'));

            Console.WriteLine($"Day of the week starting with W = {daysOfWeek[dayStartingWithW]}");

            string[] daysStartingWithS = Array.FindAll(daysOfWeek, x=>x.StartsWith('S')).ToArray();

            if(daysStartingWithS.Length > 0)
            {
                foreach (string day in daysStartingWithS)
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}