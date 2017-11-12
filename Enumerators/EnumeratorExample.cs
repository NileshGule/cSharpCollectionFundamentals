using System;
using System.Collections.Generic;

namespace Enumerators
{
    static class EnumeratorExample
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

            DisplayItems(daysOfWeek);

            DisplayItems("Hello World");
        }

        static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using(IEnumerator<T> enumerator = collection.GetEnumerator())
            {
                bool hasMoreItems = enumerator.MoveNext();
                while(hasMoreItems)
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                    hasMoreItems = enumerator.MoveNext();
                }
            }
        }
    }
}
