using System;
using System.Collections.Generic;

namespace Dictionaries
{
    static class DictionaryKeyEqualityExample
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>(DictionaryUtils.PrimeMinsters, StringComparer.InvariantCultureIgnoreCase);
            
            Console.WriteLine(primeMinisters["ig"]);

            Console.WriteLine("Comparing using Custom comparer");
            
            var primeMinistersForCustomComparer = new Dictionary<string, PrimeMinister>(DictionaryUtils.PrimeMinsters, new UncasedStringEqualityComparer());
            
            Console.WriteLine(primeMinistersForCustomComparer["ig"]);
        }

        class UncasedStringEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y) => x.Equals(y, StringComparison.InvariantCultureIgnoreCase);

            public int GetHashCode(string obj) => obj.ToUpperInvariant().GetHashCode();
        }
    }
}
