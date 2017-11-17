using System;

namespace MultidimensionalArrays
{
    static class MultidimensionalArrayExample
    {
        static void Main(string[] args)
        {
            float[,] temperatureGrid = new float[4,3];

            Console.WriteLine($"Rank / dimensions of array = {temperatureGrid.Rank}");

            for(int x = temperatureGrid.GetLowerBound(0); x <= temperatureGrid.GetUpperBound(0); x++)
            {
                for (int y = temperatureGrid.GetLowerBound(1); y <= temperatureGrid.GetUpperBound(1); y++)
                {
                    temperatureGrid[x,y] = x + 10 * y;
                }
            }

            for(int x = temperatureGrid.GetLowerBound(0); x <= temperatureGrid.GetUpperBound(0); x++)
            {
                for (int y = temperatureGrid.GetLowerBound(1); y <= temperatureGrid.GetUpperBound(1); y++)
                {
                    Console.Write($"{temperatureGrid[x,y]}, ");
                }

                Console.WriteLine();
            }
        }
    }
}
