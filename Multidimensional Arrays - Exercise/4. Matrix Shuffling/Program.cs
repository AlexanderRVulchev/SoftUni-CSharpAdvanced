//Write a program that reads a string matrix from the console
//and performs certain operations with its elements.
//User input is provided in a similar way as in the problems above
//– first, you read the dimensions and then the data. 
//Your program should then receive commands in the format:
//"swap row1 col1 row2 col2" where row1, col1, row2, col2 are coordinates in the matrix.
//For a command to be valid, it should start with the "swap" keyword
//along with four valid coordinates (no more, no less).
//You should swap the values at the given coordinates (cell [row1, col1] with cell[row2, col2])
//and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
//If the command is not valid (doesn't contain the keyword "swap",
//has fewer or more coordinates entered or the given coordinates do not exist),
//print "Invalid input!" and move on to the next command.
//Your program should finish when the string "END" is entered.


using System;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        int[] userInput = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
        int rows = userInput[0];
        int cols = userInput[1];
        string[,] matrix = ReadMatrixEntryData(rows, cols);

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            Match validCommand = Regex.Match(input, @"\Aswap \d+[ ]+\d+[ ]+\d+[ ]+\d+\Z");
            if (validCommand.Success)
            {
                int[] indexes = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .Select(x => int.Parse(x))
                    .ToArray();
                if (!IndexesAreValid(indexes, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int row1 = indexes[0];
                int col1 = indexes[1];
                int row2 = indexes[2];
                int col2 = indexes[3];

                string swapValue = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = swapValue;
                PrintMatrix(matrix);
            }
            else
                Console.WriteLine("Invalid input!");
        }
    }

    static string[,] ReadMatrixEntryData(int rows, int cols)
    {
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            string[] ColData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
                matrix[row, col] = ColData[col];
        }
        return matrix;
    }

    static bool IndexesAreValid(int[] indexes, int rows, int cols)
         => indexes[0] >= 0 && indexes[0] < rows &&
            indexes[1] >= 0 && indexes[1] < cols &&
            indexes[2] >= 0 && indexes[2] < rows &&
            indexes[3] >= 0 && indexes[3] < cols;

    static void PrintMatrix(string[,] matrix)
    {
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