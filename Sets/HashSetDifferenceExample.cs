using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets
{
    public class HashSetDifferenceExample
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
            
            Console.WriteLine($"Number of elements in big cities = {bigCities.Count} {Environment.NewLine}");
            bigCities.ToList().ForEach(x => Console.WriteLine(x));

            string[] citiesInUK = {
                "Manchester",
                "Sheffield",
                "Ripon",
                "Truro"
                };

            Console.WriteLine($"Number of elements in cities in Uk = {citiesInUK.Length} {Environment.NewLine}");
            citiesInUK.ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Using ExceptWith method");
            bigCities.ExceptWith(citiesInUK);
            
            Console.WriteLine($"Number of elements after Except = {bigCities.Count} {Environment.NewLine}");
            bigCities.ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}