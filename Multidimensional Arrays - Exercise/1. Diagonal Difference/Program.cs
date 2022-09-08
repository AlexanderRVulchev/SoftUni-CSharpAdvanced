//Create a program that finds the difference between the sums of the square matrix diagonals (absolute value).

using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = GetMatrixData(size);
        int primarySum = 0;
        int secondarySum = 0;
        
        for (int i = 0; i < size; i++)
        {
            primarySum += matrix[i, i];
            secondarySum += matrix[i, size - i - 1];
        }
        Console.WriteLine(Math.Abs(primarySum - secondarySum));
    }

    private static int[,] GetMatrixData(int size)
    {
        int[,] matrix = new int[size, size];
        for (int row = 0; row < size; row++)
        {
            int[] userLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = userLine[col];
            }
        }
        return matrix;
    }
}
