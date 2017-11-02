using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Collections
{
    static class ReadOnlyList
    {
        static void Main(string[] args)
        {
            const int INITIAL_LIST_CAPACITY = 3;
            
            IReadOnlyCollection<string> primeMinisters = CollectionUtils
                                                        .GetPrimeMinisters(INITIAL_LIST_CAPACITY)
                                                        .AsReadOnly();

            Console.WriteLine("Indian Prime Ministers:");
            
            CollectionUtils.PrintList(primeMinisters.ToList());
        }
    }
}