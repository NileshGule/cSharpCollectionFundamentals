using System;
using System.Collections.Generic;


namespace Collections
{
    static class AddToList
    {
        static void Main(string[] args)
        {
            List<string> primeMinisters = new List<string> {
                "Narendra Modi",
                "Manmohan Singh",
                "Atal Bihari Vajpeyi",
                "Rajiv Gandhi",
                "Inder Kumar Gujaral",
                "H D Devegowda"
            };

            Console.WriteLine("Indian Prime Ministers:");

            foreach (string primeMinister in primeMinisters)
            {
                Console.WriteLine(primeMinister);
            }
        }
    }
}
