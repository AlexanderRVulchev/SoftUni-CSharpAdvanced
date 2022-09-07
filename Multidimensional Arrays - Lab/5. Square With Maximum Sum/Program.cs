//Create a program that reads a matrix from the console. Then find the biggest sum of the 2x2 submatrix and print it to the console.
//On the first line, you will get matrix sizes in format rows, columns.
//In the lines of One next row, you will get elements for each column separated with a comma.
//Print the biggest top-left square, which you find, and the sum of its elements.


using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int rowsCount = input.Split(", ").Select(int.Parse).First();
        int colsCount = input.Split(", ").Select(int.Parse).Last();
        int[,] matrix = new int[rowsCount, colsCount];
        for (int row = 0; row < rowsCount; row++)
        {
            int[] inputLine = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < colsCount; col++)
            {
                matrix[row, col] = inputLine[col];
            }
        }

        int maxSum = int.MinValue;
        int rowIndex = -1;
        int colIndex = -1;
        for (int row = 0; row < rowsCount - 1; row++)
        {
            for (int col = 0; col < colsCount - 1; col++)
            {
                int square2x2Sum = matrix[row, col]
                    + matrix[row, col + 1]
                    + matrix[row + 1, col] 
                    + matrix[row + 1, col + 1];

                if (square2x2Sum > maxSum)
                {
                    maxSum = square2x2Sum;
                    rowIndex = row;
                    colIndex = col;
                }
            }
        }

        Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]}");
        Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]}");
        Console.WriteLine(maxSum);
    }
}