using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    public static class SortedListExample
    {
        public static void Main(string[] args)
        {
            SortedList<string, PrimeMinister> primeMinisters = new SortedList<string, PrimeMinister>(DictionaryUtils.PrimeMinsters);
            
            primeMinisters.Add("NM", new PrimeMinister("Narendra Modi", 2014));
            primeMinisters.Add("AB", new PrimeMinister("Atal Bihari Vajapeyi", 1998));

            DictionaryUtils.PrintPrimeMinisters(primeMinisters);
        }
    }
}