using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Warships
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            Queue<string> commands = new Queue<string>(Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries));
            char[,] field = ReadInitalFieldData(size);
            int player1Ships = GetShipsCount(field, '<');
            int player2Ships = GetShipsCount(field, '>');

            while (commands.Any() && player1Ships > 0 && player2Ships > 0)
            {
                string command = commands.Dequeue();
                int rowIndex = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).First();
                int colIndex = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Last();

                if (!IsValidIndex(size, rowIndex, colIndex)) continue;

                char symbol = field[rowIndex, colIndex];
                switch (symbol)
                {
                    case '<':
                        player1Ships--;
                        field[rowIndex, colIndex] = 'X';
                        break;
                    case '>':
                        player2Ships--;
                        field[rowIndex, colIndex] = 'X';
                        break;
                    case '#':
                        for (int row = rowIndex - 1; row <= rowIndex + 1; row++)
                            for (int col = colIndex - 1; col <= colIndex + 1; col++)
                            {
                                if (!IsValidIndex(size, row, col)) continue;
                                if (field[row, col] == '<')
                                {
                                    player1Ships--;
                                    field[row, col] = 'X';
                                }
                                else if (field[row, col] == '>')
                                {
                                    player2Ships--;
                                    field[row, col] = 'X';
                                }
                            }
                        break;
                }
            }
            PrintResult(player1Ships, player2Ships, GetShipsCount(field, 'X'));
        }

        static int GetShipsCount(char[,] field, char ch)
        {
            int count = 0;
            for (int row = 0; row < field.GetLength(0); row++)
                for (int col = 0; col < field.GetLength(1); col++)
                    if (field[row, col] == ch)
                        count++;
            return count;
        }

        static char[,] ReadInitalFieldData(int size)
        {
            char[,] field = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                    field[row, col] = line[col];
            }
            return field;
        }

        static bool IsValidIndex(int size, int col, int row)
            => row >= 0 && row < size && col >= 0 && col < size;

        static void PrintResult(int player1Ships, int player2Ships, int destroyedShips)
        {
            if (player2Ships <= 0)
                Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
            else if (player1Ships <= 0)
                Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
            else
                Console.WriteLine($"It's a draw! Player One has {player1Ships} ships left. Player Two has {player2Ships} ships left.");
        }
    }
}
