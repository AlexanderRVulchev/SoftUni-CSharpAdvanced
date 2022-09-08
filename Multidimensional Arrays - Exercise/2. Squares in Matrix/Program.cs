//Find the count of 2 x 2 squares of equal chars in a matrix.
//Input
//•	On the first line, you are given the integers rows and cols – the matrix’s dimensions
//•	Matrix characters come at the next rows lines (space separated)
//Output
//•	Print the number of all the squares matrixes you have found


using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int rows = input[0];
        int columns = input[1];        
        int equalsCount = 0;
        char[,] matrix = GetMatrixData(rows, columns);

        for (int row = 0; row < rows - 1; row++)
            for (int col = 0; col < columns - 1; col++)                            
                if (matrix[row, col] == matrix[row, col + 1] &&
                    matrix[row, col] == matrix[row + 1, col] &&
                    matrix[row, col] == matrix[row + 1, col + 1])
                {
                    equalsCount++;
                }
            
        Console.WriteLine(equalsCount);
    }

    private static char[,] GetMatrixData(int rows, int columns)
    {
        char[,] matrix = new char[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            char[] userLine = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = userLine[col];
            }
        }
        return matrix;
    }
}