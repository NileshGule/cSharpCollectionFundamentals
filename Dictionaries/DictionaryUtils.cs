using System;
using System.Collections.Generic;

namespace Dictionaries
{
    public static class DictionaryUtils
    {
        private static Dictionary<string, PrimeMinister> primeMinsters = new Dictionary<string, PrimeMinister>
        {
            { "JN", new PrimeMinister("Jawaharlal Nehru", 1947) },
            { "LS", new PrimeMinister("Lalbahadur Shastri", 1964) },
            { "IG", new PrimeMinister("Indira Gandhi", 1967) }
        };

        public static Dictionary<string, PrimeMinister> PrimeMinsters { get => primeMinsters; set => primeMinsters = value; }

        public static void PrintPrimeMinisters(IDictionary<string, PrimeMinister> primeMinisters)
        {
            foreach(var primeMinister in primeMinisters)
            {
                Console.WriteLine(primeMinister);
            }
        }
    }
}