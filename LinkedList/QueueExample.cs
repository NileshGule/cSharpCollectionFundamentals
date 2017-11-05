using System;
using System.Collections.Generic;

namespace LinkedList
{
    static class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("Get up");
            tasks.Enqueue("Brush");
            tasks.Enqueue("Bath");
            tasks.Enqueue("Breakfast");
            PrintTasks(tasks);

            string firstTask = tasks.Dequeue();
            Console.WriteLine($"First task dequed = {firstTask}");

            PrintTasks(tasks);

            firstTask = tasks.Peek();
            Console.WriteLine($"First task peeked without Dequeuing = {firstTask}");
            PrintTasks(tasks);

            Console.WriteLine(tasks.Count);
            tasks.TrimExcess();
            Console.WriteLine(tasks.Count);
        }

        private static void PrintTasks(Queue<string> tasks)
        {
            Console.WriteLine();

            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine();
        }
    }
}
