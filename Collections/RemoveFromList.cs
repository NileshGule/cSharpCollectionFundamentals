using System;
using System.Collections.Generic;


namespace Collections
{
    /// The program demonstrates collection capabilities using List class
    /// 2 modes of removal of items is demonstrated
    static class RemoveFromList
    {
        static void Main(string[] args)
        {
            const int INITIAL_LIST_CAPACITY = 3;
            
            List<string> primeMinisters = CollectionUtils.GetPrimeMinisters(INITIAL_LIST_CAPACITY);

            Console.WriteLine("Indian Prime Ministers:");

            CollectionUtils.PrintList(primeMinisters);

            Console.WriteLine();
            Console.WriteLine("Removing Rajiv Gandhi");

            primeMinisters.Remove("Rajiv Gandhi");

            CollectionUtils.PrintList(primeMinisters);
            bool isRemoved = primeMinisters.Remove("Rajiv Gandhi");

            Console.WriteLine($"Successfully removed element = {isRemoved}");

            Console.WriteLine("Using RemoveAt method");

            primeMinisters.RemoveAt(3);

            CollectionUtils.PrintList(primeMinisters);
        }
    }
}
