using System;
using System.Collections.Generic;

namespace Dictionaries
{
    static class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            {
                { "JN", new PrimeMinister("Jawaharlal Nehru", 1947) },
                { "LS", new PrimeMinister("Lalbahadur Shastri", 1964) },
                { "IG", new PrimeMinister("Indira Gandhi", 1967) }
            };

            foreach (var primeMinister in primeMinisters)
            {
                Console.WriteLine($"Key : {primeMinister.Key}, Value : { primeMinister.Value }");
            }

            Console.WriteLine("Searching for Narendra Modi using TryGetValue method");

            PrimeMinister pmModi;

            bool found = primeMinisters.TryGetValue("NM", out pmModi);

            if(found)
            {
                Console.WriteLine("Modiji found");
            }
            else
            {
                Console.WriteLine("Modiji not found");
            }

            primeMinisters["AV"] = new PrimeMinister("Atal Bihari Vajpeyi", 1996);

            primeMinisters.Add("NM", new PrimeMinister("Narendra Modi", 2014));
            foreach (var primeMinister in primeMinisters)
            {
                Console.WriteLine($"Key : {primeMinister.Key}, Value : { primeMinister.Value }");
            }
        }
    }
}
