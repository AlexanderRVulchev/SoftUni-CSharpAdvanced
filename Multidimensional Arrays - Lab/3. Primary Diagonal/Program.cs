//Create a program that finds the sum of matrix primary diagonal.

using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            int[] userLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < userLine.Length; col++)
            {
                matrix[row, col] = userLine[col];
            }
        }

        int sum = 0;
        for (int i = 0; i < size; i++)
            sum += matrix[i, i];
        Console.WriteLine(sum);
    }
}