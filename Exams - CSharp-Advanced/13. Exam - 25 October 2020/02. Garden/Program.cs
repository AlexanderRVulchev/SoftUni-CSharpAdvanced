using System;
using System.Linq;

namespace _02._Garden
{
    internal class Program
    {
        static void Main()
        {
            int[] matrixData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowsLength = matrixData[0];
            int colsLength = matrixData[1];
            int[,] garden = new int[rowsLength, colsLength];

            string input;
            while ((input = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int rowIndex = input.Split().Select(int.Parse).First();
                int colIndex = input.Split().Select(int.Parse).Last();

                if (rowIndex < 0 || rowIndex >= rowsLength ||
                    colIndex < 0 || colIndex >= colsLength)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                Bloom(garden, rowIndex, colIndex);
            }
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)                
                    Console.Write(garden[row, col] + " ");
                Console.WriteLine();                
            }
        }

        static void Bloom(int[,] garden, int rowIndex, int colIndex)
        {
            for (int i = 0; i < garden.GetLength(1); i++)
                garden[rowIndex, i]++;
            for (int i = 0; i < garden.GetLength(0); i++)
                garden[i, colIndex]++;
            garden[rowIndex, colIndex]--;
        }
    }
}
