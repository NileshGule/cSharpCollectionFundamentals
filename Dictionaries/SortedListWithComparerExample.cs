using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    public static class SortedListWithComparerExample
    {
        public static void Main(string[] args)
        {
            SortedList<string, PrimeMinister> primeMinisters = new SortedList<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "JN", new PrimeMinister("Jawaharlal Nehru", 1947) },
                { "LS", new PrimeMinister("Lalbahadur Shastri", 1964) },
                { "IG", new PrimeMinister("Indira Gandhi", 1967) }
            };

            primeMinisters.Add("NM", new PrimeMinister("Narendra Modi", 2014));
            primeMinisters.Add("AB", new PrimeMinister("Atal Bihari Vajapeyi", 1998));

            foreach (var primeMinister in primeMinisters)
            {
                Console.WriteLine(primeMinister);
            }

            Console.WriteLine($"{Environment.NewLine}Searching with String comparer");
            Console.WriteLine(primeMinisters["ig"]);

            primeMinisters = new SortedList<string, PrimeMinister>(new UncasedStringComparer())
            {
                { "JN", new PrimeMinister("Jawaharlal Nehru", 1947) },
                { "LS", new PrimeMinister("Lalbahadur Shastri", 1964) },
                { "IG", new PrimeMinister("Indira Gandhi", 1967) }
            };

            Console.WriteLine($"{Environment.NewLine}Searching with custom comparer");
            Console.WriteLine(primeMinisters["ig"]);
        }
    }

    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y) => String.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
    }
}