using System;
using System.Collections.Generic;

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
    }
}