using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    public static class SortedListExample
    {
        public static void Main(string[] args)
        {
            SortedList<string, PrimeMinister> primeMinisters = new SortedList<string, PrimeMinister>
            {
                { "JN", new PrimeMinister("Jawaharlal Nehru", 1947) },
                { "LS", new PrimeMinister("Lalbahadur Shastri", 1964) },
                { "IG", new PrimeMinister("Indira Gandhi", 1967) }
            };

            primeMinisters.Add("NM", new PrimeMinister("Narendra Modi", 2014));
            primeMinisters.Add("AB", new PrimeMinister("Atal Bihari Vajapeyi", 1998));

            DictionaryUtils.PrintPrimeMinisters(primeMinisters);
        }
    }
}