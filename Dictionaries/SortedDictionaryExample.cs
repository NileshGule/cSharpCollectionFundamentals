using System;
using System.Collections.Generic;

namespace Dictionaries
{
    public static class SortedDictionaryExample
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, PrimeMinister> primeMinisters = new SortedDictionary<string, PrimeMinister>(DictionaryUtils.PrimeMinsters);

            primeMinisters.Add("NM", new PrimeMinister("Narendra Modi", 2014));
            primeMinisters.Add("AB", new PrimeMinister("Atal Bihari Vajapeyi", 1998));

            Console.WriteLine("Collection using SortedDictionary");
            DictionaryUtils.PrintPrimeMinisters(primeMinisters);
        }
    }
}