using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Dictionaries
{
    public static class ReadOnlyDictionaryExample
    {
        static void Main(string[] args)
        {
            Dictionary<string, PrimeMinister> primeMinisters = DictionaryUtils.PrimeMinsters;

            ReadOnlyDictionary<string, PrimeMinister> unmodifieblePMs = new ReadOnlyDictionary<string, PrimeMinister>(primeMinisters);

            DictionaryUtils.PrintPrimeMinisters(primeMinisters);
        
        }
    }
}