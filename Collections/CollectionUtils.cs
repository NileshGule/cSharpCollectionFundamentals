using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Collections
{
    static class CollectionUtils
    {
        public static List<string> GetPrimeMinisters(int initialCapacity) => new List<string>(initialCapacity) {
                "Narendra Modi",
                "Manmohan Singh",
                "Atal Bihari Vajpeyi",
                "Rajiv Gandhi",
                "Inder Kumar Gujaral",
                "H D Devegowda"
            };

        public static void PrintList(List<string> list)
        {
            Console.WriteLine();
            Console.WriteLine($"List capacity = {list.Capacity}");
            Console.WriteLine($"List count = {list.Count}");
            list.ForEach(x => Console.WriteLine(x));
        }

    }
}