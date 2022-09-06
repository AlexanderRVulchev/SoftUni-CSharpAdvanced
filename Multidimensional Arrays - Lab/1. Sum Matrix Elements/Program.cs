//Write a program that reads a matrix from the console and prints:
//•	Count of rows
//•	Count of columns
//•	Sum of all matrix elements
//On the first line, you will get matrix sizes in format [rows, columns]


using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int rows = input.Split(", ").Select(int.Parse).First();
        int columns = input.Split(", ").Select(int.Parse).Last();
        int[,] matrix = new int[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            int[] userLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < userLine.Length; col++)
            {
                matrix[row, col] = userLine[col];
            }
        }
        int sum = 0;
        foreach (int number in matrix)
            sum += number;

        Console.WriteLine(rows);
        Console.WriteLine(columns);
        Console.WriteLine(sum);
    }
}