using System;
using System.Linq;

namespace _02.Survivor
{
    internal class Program
    {
        static void Main()
        {
            int playerScore = 0;
            int opponentScore = 0;

            int numberOfRows = int.Parse(Console.ReadLine());
            char[][] beach = new char[numberOfRows][];
            for (int i = 0; i < numberOfRows; i++)
                beach[i] = string.Join("", Console.ReadLine().Split()).ToCharArray();

            string input;
            while ((input = Console.ReadLine()) != "Gong")
            {
                if (input.Split().First() == "Find") PlayerFind(beach, input, ref playerScore);
                else OpponenFind(beach, input, ref opponentScore);
            }

            for (int row = 0; row < beach.Length; row++)
                Console.WriteLine(string.Join(" ", beach[row]));
            Console.WriteLine($"Collected tokens: {playerScore}");
            Console.WriteLine($"Opponent's tokens: {opponentScore}");           
        }

        static void PlayerFind(char[][] beach, string input, ref int playerScore)
        {
            int rowIndex = int.Parse(input.Split().Skip(1).First());
            int colIndex = int.Parse(input.Split().Last());
            if (!AreValidIndexes(rowIndex, colIndex, beach))
                return;
            if (beach[rowIndex][colIndex] == 'T')
            {
                beach[rowIndex][colIndex] = '-';
                playerScore++;
            }
        }

        static void OpponenFind(char[][] beach, string input, ref int opponentScore)
        {
            int rowIndex = int.Parse(input.Split().Skip(1).First());
            int colIndex = int.Parse(input.Split().Skip(2).First());
            string direction = input.Split().Last();
            if (!AreValidIndexes(rowIndex, colIndex, beach))
                return;

            if (beach[rowIndex][colIndex] == 'T')
            {
                beach[rowIndex][colIndex] = '-';
                opponentScore++;
            }

            for (int i = 0; i < 3; i++)
            {
                switch (direction)
                {
                    case "up": rowIndex--; break;
                    case "down": rowIndex++; break;
                    case "left": colIndex--; break;
                    case "right": colIndex++; break;
                }
                if (!AreValidIndexes(rowIndex, colIndex, beach)) 
                    continue;

                if (beach[rowIndex][colIndex] == 'T')
                {
                    beach[rowIndex][colIndex] = '-';
                    opponentScore++;
                }
            }
        }

        static bool AreValidIndexes(int row, int col, char[][] matrix)
            => row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length;
    }
}