//Create a program that reads N, a number representing rows and cols of a matrix.
//On the next N lines, you will receive rows of the matrix.
//Each row consists of ASCII characters.
//After that, you will receive a symbol.
//Find the first occurrence of that symbol in the matrix and print its position in the format:
//"({row}, {col})".If there is no such symbol print an error message 
//"{symbol} does not occur in the matrix "

using System;


internal class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char[,] matrix = new char[size, size];
        for (int row = 0; row < size; row++)
        {
            string userLine = Console.ReadLine();
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = userLine[col];
            }
        }
        char targetSymbol = char.Parse(Console.ReadLine());
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (matrix[row, col] == targetSymbol)
                {
                    Console.WriteLine($"({row}, {col})");
                    return;
                }
            }
        }
        Console.WriteLine($"{targetSymbol} does not occur in the matrix");
    }
}