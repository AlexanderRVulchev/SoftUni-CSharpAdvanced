//You are walking in the park and you encounter a snake!
//You are terrified, and you start running zig-zag, so the snake starts following you. 
//You have a task to visualize the snake’s path in a square form.
//A snake is represented by a string.
//The isle is a rectangular matrix of size NxM.
//A snake starts going down from the top-left corner and slithers its way down.
//The first cell is filled with the first symbol of the snake,
//the second cell is filled with the second symbol, etc.
//The snake is as long as it takes to fill the stairs–
//if you reach the end of the string representing the snake, start again at the beginning.
//After you fill the matrix with the snake’s path, you should print it.
//Input
//•	The input data should be read from the console. It consists of exactly two lines
//•	On the first line, you’ll receive the dimensions of the stairs in the format:
//"N M", where N is the number of rows, and M is the number of columns.
//They’ll be separated by a single space
//•	On the second line, you’ll receive the string representing the snake
//Output
//•	The output should be printed on the console. It should consist of N lines
//•	Each line should contain a string representing the respective row of the matrix


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] rowsAndCols = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
        int rows = rowsAndCols[0];
        int cols = rowsAndCols[1];
        char[,] matrix = new char[rows, cols];
        Queue<char> snake = GetSnakeQueue();

        for (int row = 0; row < rows; row++)        
            FillInCurrentRow(matrix, snake, row);

        PrintResultMatrix(matrix);
    }

    static Queue<char> GetSnakeQueue()
    {
        char[] snakeChars = Console.ReadLine().ToCharArray();
        Queue<char> snakeQueue = new Queue<char>();
        for (int i = 0; i < snakeChars.Length; i++)
            snakeQueue.Enqueue(snakeChars[i]);
        return snakeQueue;
    }

    static void FillInCurrentRow(char[,] matrix, Queue<char> snake, int row)
    {
        for (int ch = 0; ch < matrix.GetLength(1); ch++)
        {
            char currentSymbol = snake.Dequeue();
            if (row % 2 == 0)
                matrix[row, ch] = currentSymbol;
            else
                matrix[row, matrix.GetLength(1) - ch - 1] = currentSymbol;
            snake.Enqueue(currentSymbol);
        }
    }

    private static void PrintResultMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}