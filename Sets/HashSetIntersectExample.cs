using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets
{
    static class HashSetIntersectExample
    {
        static void Main(string[] args)
        {
            HashSet<string> bigCities = new HashSet<string>
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris"
            };

            string[] citiesInUK = {
                "Manchester",
                "Sheffield",
                "Ripon",
                "Truro"
                };

            Console.WriteLine("Using LINQ intersect method");
            var commonCities = bigCities.Intersect(citiesInUK);
            commonCities.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Using Intersect method of HashSet class");
            bigCities.IntersectWith(citiesInUK);

            bigCities.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
