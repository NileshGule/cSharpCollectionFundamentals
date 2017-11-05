using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    static class StackExample
    {
        static void Main(string[] args)
        {
            Stack<string> books = new Stack<string>();
            books.Push("Building Evolutionary Architecture");
            books.Push("The Phoenix project");
            books.Push("Hit Refresh");
            books.Push("Continuous Delivery");

            PrintBooks(books);

            Console.WriteLine("Removing topmost book");
            books.Pop();

            PrintBooks(books);

            Console.WriteLine("Peeking at the without removing from stack");
            string topBook = books.Peek();

            Console.WriteLine($"Topmost book = {topBook}");
            PrintBooks(books);
        }

        private static void PrintBooks(Stack<string> books)
        {
            Console.WriteLine();

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();
        }
    }
}
