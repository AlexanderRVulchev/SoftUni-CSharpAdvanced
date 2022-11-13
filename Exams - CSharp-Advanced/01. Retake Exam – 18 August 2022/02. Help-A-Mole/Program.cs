using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Help_A_Mole
{
    class Mole
    {
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
        public int Points { get; set; }
        public bool HasWonTheGame { get { return this.Points >= 25; } }
        public Queue<string> Commands { get; set; }

        public Mole(int rowIndex, int colIndex, List<string> commands)
        {
            this.RowIndex = rowIndex;
            this.ColIndex = colIndex;
            this.Commands = new Queue<string>(commands);
            this.Points = 0;
        }

        public void Move(char[,] field)
        {
            string command = this.Commands.Dequeue();
            int newRowIndex = this.RowIndex;
            int newColIndex = this.ColIndex;
            int size = field.GetLength(0);
            switch (command)
            {
                case "up": newRowIndex--; break;
                case "down": newRowIndex++; break;
                case "left": newColIndex--; break;
                case "right": newColIndex++; break;
            }

            if (newRowIndex < 0 || newRowIndex == size ||
                newColIndex < 0 || newColIndex == size)
            {
                Console.WriteLine("Don't try to escape the playing field!");
            }
            else
            {
                this.RowIndex = newRowIndex;
                this.ColIndex = newColIndex;
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            char[,] field = GetInitialFieldData();
            (int moleRowIndex, int moleColIndex) = FindMoleLocation(field);
            List<string> commands = GetUserCommands();
            Mole mole = new Mole(moleRowIndex, moleColIndex, commands);

            while (mole.Commands.Any() && !mole.HasWonTheGame)
            {
                mole.Move(field);

                if (Char.IsDigit(field[mole.RowIndex, mole.ColIndex]))
                    mole.Points += int.Parse(field[mole.RowIndex, mole.ColIndex].ToString());
                else if (field[mole.RowIndex, mole.ColIndex] == 'S')
                    TeleportToTheOtherLocation(mole, field);

                field[mole.RowIndex, mole.ColIndex] = '-';

            }
            PrintResult(mole, field);
        }

        static char[,] GetInitialFieldData()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                Queue<char> line = new Queue<char>(Console.ReadLine().ToCharArray());
                for (int col = 0; col < size; col++)
                    field[row, col] = line.Dequeue();
            }
            return field;
        }

        static (int moleRowIndex, int moleColRowIndex) FindMoleLocation(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
                for (int col = 0; col < field.GetLength(1); col++)
                    if (field[row, col] == 'M')
                    {
                        field[row, col] = '-';
                        return (row, col);
                    }
            return (0, 0);
        }

        static List<string> GetUserCommands()
        {
            string input;
            List<string> commands = new List<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                commands.Add(input);
            }
            return commands;
        }

        static void TeleportToTheOtherLocation(Mole mole, char[,] field)
        {
            field[mole.RowIndex, mole.ColIndex] = '-';
            for (int row = 0; row < field.GetLength(0); row++)
                for (int col = 0; col < field.GetLength(1); col++)
                    if (field[row, col] == 'S')
                    {
                        mole.RowIndex = row;
                        mole.ColIndex = col;
                        mole.Points -= 3;
                        return;
                    }
        }

        static void PrintResult(Mole mole, char[,] field)
        {
            if (mole.HasWonTheGame)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {mole.Points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {mole.Points} points.");
            }

            field[mole.RowIndex, mole.ColIndex] = 'M';
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}