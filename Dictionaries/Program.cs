﻿using System;
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
                Console.WriteLine(primeMinister.Value);
            }
        }
    }
}