using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets
{
    /// The class uses overloaded constructor of HashSet to provide the Comparer to use
    /// If the default constructor is used, Sheffield will be added twice to collection 
    static class HashSetExample
    {
        static void Main(string[] args)
        {
            HashSet<string> bigCities = new HashSet<string>
            (StringComparer.InvariantCultureIgnoreCase)
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris"
            };

            bool isAdded = bigCities.Add("Sheffield".ToUpper());
            Console.WriteLine($"Added Sheffield = {isAdded}");

            isAdded = bigCities.Add("Beijing".ToUpper());
            Console.WriteLine($"Added Beijing = {isAdded}");

            bigCities.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
