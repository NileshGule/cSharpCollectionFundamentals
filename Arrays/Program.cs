using System;

namespace Arrays
{
    static class Program
    {
        static void Main(string[] args)
        {
            //C# 7 nested function
            void PrintElements(string[] array)
            {
                Array.ForEach(array, d => Console.WriteLine(d));
            }
            
            string[] daysOfWeek = ArrayUtils.DaysOfWeek;

            PrintElements(daysOfWeek);

            Console.WriteLine();
            Console.WriteLine("Replacing 6th element in the array");
            Console.WriteLine();

            // Replace element in the array
            daysOfWeek[5] = "PartyDay";

            PrintElements(daysOfWeek);
        }
    }
}
