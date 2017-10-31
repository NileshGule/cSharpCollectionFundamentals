using System;
using System.Collections.Generic;


namespace Collections
{
    static class AddToList
    {
        static void Main(string[] args)
        {
            List<string> dummyList = new List<string>();
            Console.WriteLine($"Initial Capacity of list : {dummyList.Capacity}");

            List<string> dummyList1 = new List<string>{"starting element"};

            Console.WriteLine($"Initial Capacity of list : {dummyList1.Capacity}");

            const int INITIAL_LIST_CAPACITY = 3;
            List<string> primeMinisters = new List<string>(INITIAL_LIST_CAPACITY) {
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

            void printList(List<string> list)
            {
                Console.WriteLine();
                Console.WriteLine($"List capacity = {list.Capacity}");
                Console.WriteLine($"List count = {list.Count}");
            }

            printList(primeMinisters);

            Console.WriteLine("Adding older Prime Ministers");

            primeMinisters.AddRange(new List<string> {"Indira Gandhi", "Lal Bahadur Shastri"});

            printList(primeMinisters);

            primeMinisters.AddRange(new List<string> {"Jawaharlal Nehru", "Morarji Desai", "Chndrashekar", "V P Singh"});

            printList(primeMinisters);
        }
    }
}
