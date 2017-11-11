using System;

namespace Arrays
{
    static class ArrayInitializer
    {
        static void Main(string[] args)
        {
            int[] x1 = new int[5];

            Console.WriteLine($"Size of array = {x1.Length}");

            // Explicit initialization with size specified
            int[] x5 = new int[5] {1, 2, 3, 4, 5};

            Console.WriteLine($"Size of array = {x5.Length}");

            // Compiler is intelligent to compute the size
            int[] x6 = {2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine($"Size of array = {x6.Length}");

            // Compiler once again computes the size of array
            int[] x7 = new int[] {1,2 , 3, 4, 6};
            Console.WriteLine($"Size of array = {x7.Length}");
        }
    }
}