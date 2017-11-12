using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerators
{
    public static class CustomEnumeratorExample
    {
        static void Main(string[] args)
        {
            AllDaysOfWeek daysOfWeek = new AllDaysOfWeek();

            foreach (var item in daysOfWeek)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class AllDaysOfWeek : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Calling generic Enumerator");
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}