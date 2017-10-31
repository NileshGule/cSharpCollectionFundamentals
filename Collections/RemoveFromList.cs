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

            // primeMinisters.ForEach(x => Console.WriteLine(x));

            void printList(List<string> list)
            {
                Console.WriteLine();
                Console.WriteLine($"List capacity = {list.Capacity}");
                Console.WriteLine($"List count = {list.Count}");
                primeMinisters.ForEach(x => Console.WriteLine(x));
            }

            printList(primeMinisters);

            Console.WriteLine();
            Console.WriteLine("Removing Rajiv Gandhi");

            primeMinisters.Remove("Rajiv Gandhi");

            printList(primeMinisters);
            bool isRemoved = primeMinisters.Remove("Rajiv Gandhi");

            Console.WriteLine($"Successfully removed element = {isRemoved}");
        }
    }
}
