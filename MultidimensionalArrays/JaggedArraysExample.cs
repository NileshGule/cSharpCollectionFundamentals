using System;

namespace MultidimensionalArrays
{
    static class JaggedArraysExample
    {
        static void Main(string[] args)
        {
            float[][] temperatureGrid = new float[4][];

            Console.WriteLine($"Rank / dimensions of array = {temperatureGrid.Rank}");

            for(int x = 0; x < 4; x++)
            {
                temperatureGrid[x] = new float[3];
                for (int y = 0; y < 3; y++)
                {
                    temperatureGrid[x][y] = x + 10 * y;
                }
            }

            for(int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write($"{temperatureGrid[x][y]}, ");
                }

                Console.WriteLine();
            }
        }
    }
}
