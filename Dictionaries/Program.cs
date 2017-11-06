using System;
using System.Collections.Generic;

namespace Dictionaries
{
    static class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new List<PrimeMinister>
            {
                new PrimeMinister("Jawaharlal Nehru", 1947),
                new PrimeMinister("Lalbahadur Shastri", 1964),
                new PrimeMinister("Indira Gandhi", 1967)
            };

            primeMinisters.ForEach(x => Console.WriteLine(x));
        }
    }
}
