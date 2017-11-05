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

            foreach(string book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
