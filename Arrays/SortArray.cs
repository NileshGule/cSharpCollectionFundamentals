using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    static class SortArray
    {      
        static void Main(string[] args)
        {
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            Console.WriteLine("Sort using static Array.Sort method");

            Array.Sort(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            Console.WriteLine("Sort using String length comparer");

            Array.Sort(daysOfWeek, new StringLengthComparer());

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
            
        }   
    }

    class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y) => x.Length.CompareTo(y.Length);
    }
}