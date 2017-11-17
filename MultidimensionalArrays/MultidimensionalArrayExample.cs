using System;

namespace MultidimensionalArrays
{
    static class MultidimensionalArrayExample
    {
        static void Main(string[] args)
        {
            float[,] temperatureGrid = new float[4,3];

            for(int x = 0; x < temperatureGrid.GetLength(0); x++)
            {
                for (int y =0; y < temperatureGrid.GetLength(1); y++)
                {
                    temperatureGrid[x,y] = x + 10 * y;
                }
            }

            for(int x = 0; x < temperatureGrid.GetLength(0); x++)
            {
                for (int y =0; y < temperatureGrid.GetLength(1); y++)
                {
                    Console.Write($"{temperatureGrid[x,y]}, ");
                }

                Console.WriteLine();
            }
        }
    }
}
