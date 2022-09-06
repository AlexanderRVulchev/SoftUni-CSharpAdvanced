//Create a program that reads a matrix from the console and prints the sum for each column.
//On the first line, you will get matrix rows.
//On the next rows lines, you will get elements for each column separated with a space. 

using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string rowColInfo = Console.ReadLine();
        int rows = rowColInfo.Split(", ").Select(int.Parse).First();
        int columns = rowColInfo.Split(", ").Select(int.Parse).Last();
        int[,] matrix = new int[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int num = 0; num < input.Length; num++)
            {
                matrix[row, num] = input[num];
            }
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int columnSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                columnSum += matrix[row, col];
            }
            Console.WriteLine(columnSum);
        }
    }
}