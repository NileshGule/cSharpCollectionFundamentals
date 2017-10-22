using System;
using System.Linq;

namespace Arrays
{
    class ArrayCopy
    {
        static void Main(string[] args)
        {
            int[] squares = {1, 4, 9, 16, 25};;

            Console.WriteLine($"Size of array = {squares.Length}");

            int[] squaresCopy = new int[8];
            squares.CopyTo(squaresCopy, 2);

            foreach (int item in squaresCopy)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine($"Squares == SquaresCopy ? {squares == squaresCopy}");

            Console.WriteLine();

            Console.WriteLine("Copying using LINQ");
            int[] linqCopy = squares.ToArray();

            Console.WriteLine();

            Console.WriteLine($"Squares == LinqCopy ? {squares == linqCopy}");
        }
    }
}