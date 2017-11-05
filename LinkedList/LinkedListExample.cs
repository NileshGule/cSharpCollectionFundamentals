using System;
using System.Collections.Generic;

namespace LinkedList
{
    static class LinkedListExample
    {
        static void Main(string[] args)
        {
            LinkedList<string> indianPrimeMinisters = new LinkedList<string>();

            indianPrimeMinisters.AddLast("Jawaharlal Nehru");
            indianPrimeMinisters.AddLast("Lalbahadur Shastri");
            indianPrimeMinisters.AddLast("Indira Gandhi");
            indianPrimeMinisters.AddLast("Rajiv Gandhi");

            PrintPrimeMinisters(indianPrimeMinisters);
            
            Console.WriteLine("Adding prime minister after Indira Gandhi");

            LinkedListNode<string> indiraGandhiNode = indianPrimeMinisters.Find("Indira Gandhi");
            indianPrimeMinisters.AddAfter(indiraGandhiNode, "Morarji Desai");

            PrintPrimeMinisters(indianPrimeMinisters);

            Console.WriteLine("Removing Indira Gandhi");
            indianPrimeMinisters.Remove("Indira Gandhi");

            PrintPrimeMinisters(indianPrimeMinisters);

            Console.WriteLine("Adding Narendra Modi as the last PM of India");
            indianPrimeMinisters.AddLast("Narendra Modi");

            PrintPrimeMinisters(indianPrimeMinisters);

        }

        private static void PrintPrimeMinisters(LinkedList<string> indianPrimeMinisters)
        {
            Console.WriteLine();

            foreach (string primeminister in indianPrimeMinisters)
            {
                Console.WriteLine(primeminister);
            }

            Console.WriteLine();
        }
    }
}
