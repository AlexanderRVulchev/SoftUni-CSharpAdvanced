using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Re_Volt
{
    internal class Program
    {
        class Player
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public bool HasWon { get; set; }

            public Player((int, int) coordinates)
            {
                this.Row = coordinates.Item1;
                this.Col = coordinates.Item2;
            }

            public void Move(char[,] field, string command)
            {
                int size = field.GetLength(0);
                if (field[this.Row, this.Col] != 'B')
                    field[this.Row, this.Col] = '-';

                int newRowIndex = this.Row;
                int newColIndex = this.Col;
                switch (command)
                {
                    case "up": newRowIndex--; break;
                    case "down": newRowIndex++; break;
                    case "left": newColIndex--; break;
                    case "right": newColIndex++; break;
                }

                if (newRowIndex < 0) newRowIndex = size - 1;
                if (newRowIndex == size) newRowIndex = 0;
                if (newColIndex < 0) newColIndex = size - 1;
                if (newColIndex == size) newColIndex = 0;

                char symbol = field[newRowIndex, newColIndex];
                if (symbol == 'T') return;
                else if (symbol == 'B')
                {
                    this.Row = newRowIndex;
                    this.Col = newColIndex;
                    Move(field, command);
                    return;
                }
                else if (symbol == 'F')
                    this.HasWon = true;

                this.Row = newRowIndex;
                this.Col = newColIndex;
            }
        }

        static void Main()
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int numberOfCommands = int.Parse(Console.ReadLine());
            char[,] field = GetFieldData(sizeOfField);
            Player player = new Player(GetPlayerCoordinates(field));

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                player.Move(field, command);
                if (player.HasWon) break;
            }
            PrintResult(player, field);
        }

        static char[,] GetFieldData(int size)
        {
            char[,] field = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                    field[row, col] = line[col];
            }
            return field;
        }

        static (int, int) GetPlayerCoordinates(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
                for (int col = 0; col < field.GetLength(1); col++)
                    if (field[row, col] == 'f')
                        return (row, col);
            return (0, 0);
        }

        static void PrintResult(Player player, char[,] field)
        {
            if (player.HasWon)
                Console.WriteLine("Player won!");
            else
                Console.WriteLine("Player lost!");

            field[player.Row, player.Col] = 'f';
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                    Console.Write(field[row, col]);
                Console.WriteLine();
            }
        }
    }
}