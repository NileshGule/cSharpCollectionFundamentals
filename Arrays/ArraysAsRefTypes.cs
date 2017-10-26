using System;

namespace Arrays
{
    static class ArraysAsRefTypes
    {
        static void Main (string[] args)
        {
            int[] x1 = { 1 , 4, 9, 16 };

            var x2 = x1;

            x1[0] = 2;

            Console.WriteLine($"ReferenceEquals(x1, x2): {ReferenceEquals(x1, x2)}"); 

            int[] x3 = {1, 4, 9, 16};

            Console.WriteLine($"ReferenceEquals(x1, x3): {ReferenceEquals(x1, x3)}"); 

        }
    }
}