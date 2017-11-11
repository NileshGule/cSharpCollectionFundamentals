using System;
using System.Collections.ObjectModel;

namespace Dictionaries
{
    public static class KeyedCollectionExample
    {
        static void Main(string[] args)
        {
            var primeMinisters = new PrimeMinistersByYearDictionary
            {
                new PrimeMinister("Jawaharlal Nehru", 1947),
                new PrimeMinister("Lalbahadur Shastri", 1964),
                new PrimeMinister("Indira Gandhi", 1967)
            };

            foreach (var primeMinister in primeMinisters)
            {
                Console.WriteLine(primeMinister);
            }            
        }
    }

    class PrimeMinistersByYearDictionary : KeyedCollection<int, PrimeMinister>
    {
        protected override int GetKeyForItem(PrimeMinister item) => item.YearElected;
    }
}