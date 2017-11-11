using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets
{
    public class HashSetEqualsExample
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

            string[] citiesInUK = 
            {
                "Manchester",
                "Sheffield",
                "Ripon",
                "Truro"
            };

            Console.WriteLine($"Number of elements in cities in Uk = {citiesInUK.Length} {Environment.NewLine}");
            citiesInUK.ToList().ForEach(x => Console.WriteLine(x));

            HashSet<string> ukCities = new HashSet<string>
            {
                "Sheffield",
                "Manchester",
                "Truro",
                "Ripon"
            };

            Console.WriteLine($"{Environment.NewLine}UK cities ");
            ukCities.ToList().ForEach(x => Console.WriteLine(x));

            bool areEqual = bigCities.SetEquals(citiesInUK);
            Console.WriteLine($"Big cities and UK cities equals = {areEqual}");

            bool areEqualUK = ukCities.SetEquals(citiesInUK);
            Console.WriteLine($"Uk cities are equal to cities in UK = {areEqualUK}");

        }
    }
}