using System;
using System.Collections.Generic;

namespace Dictionaries
{
    static class DictionaryKeyEqualityExample
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "JN", new PrimeMinister("Jawaharlal Nehru", 1947) },
                { "LS", new PrimeMinister("Lalbahadur Shastri", 1964) },
                { "IG", new PrimeMinister("Indira Gandhi", 1967) }
            };

            Console.WriteLine(primeMinisters["ig"]);

            Console.WriteLine("Comparing using Custom comparer");
            
            var primeMinistersForCustomComparer = new Dictionary<string, PrimeMinister>(new UncasedStringEqualityComparer())
            {
                { "JN", new PrimeMinister("Jawaharlal Nehru", 1947) },
                { "LS", new PrimeMinister("Lalbahadur Shastri", 1964) },
                { "IG", new PrimeMinister("Indira Gandhi", 1967) }
            };

            Console.WriteLine(primeMinistersForCustomComparer["ig"]);
        }

        class UncasedStringEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y) => x.Equals(y, StringComparison.InvariantCultureIgnoreCase);

            public int GetHashCode(string obj) => obj.ToUpperInvariant().GetHashCode();
        }
    }
}
