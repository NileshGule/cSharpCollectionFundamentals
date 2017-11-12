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

            DisplayItemsWithNewLine("Enumerting items using explicit enumerator", () => DisplayItems(daysOfWeek));

            DisplayItemsWithNewLine("Enumeration works on strings as well", () => DisplayItems("Hello World"));
            
            DisplayItemsWithNewLine("Enumerating items using foreach loop", () => DisplayItems2(daysOfWeek));
                        
        }

        static void DisplayItemsWithNewLine(string message, Action functionToCall)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            functionToCall();
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

        static void DisplayItems2<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
