//You will be given a square matrix of integers, each integer separated by a single space,
//and each row on a new line.Then on the last line of input, you will receive indexes -
//coordinates to several cells separated by a single space, in the following format:
//row1,column1 row2, column2  row3, column3… 
//On those cells there are bombs. You have to proceed with every bomb,
//one by one in the order they were given.
//When a bomb explodes deals damage equal to its integer value,
//to all the cells around it (in every direction and all diagonals).
//One bomb can't explode more than once and after it does, its value becomes 0.
//When a cell’s value reaches 0 or below, it dies. Dead cells can't explode.
//You must print the count of all alive cells and their sum. Afterward,
//print the matrix with all of its cells (including the dead ones). 
//Input
//•	On the first line, you are given the integer N – the size of the square matrix.
//•	The next N lines hold the values for every row – N numbers separated by a space.
//•	On the last line, you will receive the coordinates of the cells with the bombs
//in the format described above.
//Output
//•	On the first line you need to print the count of all alive cells in the format: 
//"Alive cells: {aliveCells}"
//•	On the second line you need to print the sum of all alive cells in the format: 
//"Sum: {sumOfCells}"
//•	At the end print the matrix. The cells must be separated by a single space.
//Constraints
//•	The size of the matrix will be between [0…1000].
//•	The bomb coordinates will always be in the matrix.
//•	The bomb’s values will always be greater than 0.
//•	The integers of the matrix will be in the range [1…10000]. 


using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = ReadInitialMatrixData(size);
        string[] bombs = Console.ReadLine().Split();
        for (int bombIndex = 0; bombIndex < bombs.Length; bombIndex++)
        {
            BombBoom(matrix, bombs[bombIndex]);
        }
        PrintResults(matrix);
    }

    static int[,] ReadInitialMatrixData(int size)
    {
        int[,] matrix = new int[size, size];
        for (int row = 0; row < size; row++)
        {
            int[] line = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = line[col];
            }
        }
        return matrix;
    }

    static void BombBoom(int[,] matrix, string coordinates)
    {
        int rowIndex = coordinates.Split(",").Select(x => int.Parse(x)).First();
        int colIndex = coordinates.Split(",").Select(x => int.Parse(x)).Last();
        if (matrix[rowIndex, colIndex] <= 0) return;

        int boomValue = matrix[rowIndex, colIndex];
        for (int row = rowIndex - 1; row <= rowIndex + 1; row++)
        {
            for (int col = colIndex - 1; col <= colIndex + 1; col++)
            {
                DealDamageToACell(matrix, row, col, boomValue);
            }
        }
    }

    static void DealDamageToACell(int[,] matrix, int targetRowIndex, int targetColIndex, int boomValue)
    {
        if (targetRowIndex >= 0 && targetRowIndex < matrix.GetLength(0) &&
            targetColIndex >= 0 && targetColIndex < matrix.GetLength(1) &&
            matrix[targetRowIndex, targetColIndex] > 0)
        {
            matrix[targetRowIndex, targetColIndex] -= boomValue;
        }
    }

    static void PrintResults(int[,] matrix)
    {
        int aliveCells = 0;
        int sumOfCells = 0;
        foreach (int number in matrix)
        {
            if (number > 0)
            {
                aliveCells++;
                sumOfCells += number;
            }
        }

        Console.WriteLine($"Alive cells: {aliveCells}");
        Console.WriteLine($"Sum: {sumOfCells}");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }
    }
}