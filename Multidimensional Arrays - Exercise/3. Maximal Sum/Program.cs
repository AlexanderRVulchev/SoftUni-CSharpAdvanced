//Create a program that reads a rectangular integer matrix of size N x M
//and finds in it the square 3 x 3 that has a maximal sum of its elements.
//Input
//•	On the first line, you will receive the rows N and columns M.
//On the next N lines, you will receive each row with its columns
//Output
//•	Print the elements of the 3 x 3 square as a matrix, along with their sum


using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string rowsAndCols = Console.ReadLine();
        int rows = rowsAndCols
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .First();
        int cols = rowsAndCols
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .Last();        
        int[,] matrix = ReadMatrixEntryData(rows, cols);
        int rowIndex = -1;
        int colIndex = -1;
        int maxSum = int.MinValue;
        for (int row = 0; row < rows - 2; row++)
            for (int col = 0; col < cols - 2; col++)
            {
                int sum3x3Square = GetSumOf3x3Square(row, col, matrix);
                if (sum3x3Square > maxSum)
                {
                    maxSum = sum3x3Square;
                    rowIndex = row;
                    colIndex = col;
                }
            }

        Console.WriteLine($"Sum = {maxSum}");
        for (int row = rowIndex; row < rowIndex + 3; row++)
        {
            for (int col = colIndex; col < colIndex + 3; col++)
                Console.Write(matrix[row, col] + " ");
            Console.WriteLine();
        }
    }

    static int[,] ReadMatrixEntryData(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] ColumnNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            for (int col = 0; col < cols; col++)
                matrix[row, col] = ColumnNumbers[col];
        }
        return matrix;
    }

    static int GetSumOf3x3Square(int row, int col, int[,] matrix)
    {
        int sum = 0;
        for (int squareRow = row; squareRow < row + 3; squareRow++)
        {
            for (int squareCol = col; squareCol < col + 3; squareCol++)
            {
                sum += matrix[squareRow, squareCol];
            }
        }
        return sum;
    }
}