using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    class Beaver
    {
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
        public Stack<char> BranchesCollected { get; set; }
        public int BranchesLeft { get; set; }

        public Beaver(int row, int col, int branches)
        {
            this.ColIndex = col;
            this.RowIndex = row;
            this.BranchesCollected = new Stack<char>();
            this.BranchesLeft = branches;
        }

        public void Move(string command, char[,] pond)
        {
            int size = pond.GetLength(0);
            pond[this.RowIndex, this.ColIndex] = '-';
            int newRowIndex = this.RowIndex;
            int newColIndex = this.ColIndex;
            switch (command)
            {
                case "up": newRowIndex--; break;
                case "down": newRowIndex++; break;
                case "left": newColIndex--; break;
                case "right": newColIndex++; break;
            }
            if ((newRowIndex < 0 || newRowIndex >= size ||
                 newColIndex < 0 || newColIndex >= size))
            {
                if (this.BranchesCollected.Any())
                    this.BranchesCollected.Pop();
                return;
            }

            this.RowIndex = newRowIndex;
            this.ColIndex = newColIndex;
            char symbol = pond[this.RowIndex, this.ColIndex];
            pond[this.RowIndex, this.ColIndex] = '-';

            if (char.IsLower(symbol))
            {
                this.BranchesCollected.Push(symbol);
                this.BranchesLeft--;

            }
            else if (symbol == 'F')
                this.Swim(pond, command);
        }

        private void Swim(char[,] pond, string command)
        {
            int maxIndex = pond.GetLength(0) - 1;
            if (command == "up" && this.RowIndex == 0) command = "down";
            else if (command == "down" && this.RowIndex == maxIndex) command = "up";
            else if (command == "left" && this.ColIndex == 0) command = "right";
            else if (command == "right" && this.ColIndex == maxIndex) command = "left";

            switch (command)
            {
                case "up": this.RowIndex = 0; break;
                case "down": this.RowIndex = maxIndex; break;
                case "left": this.ColIndex = 0; break;
                case "right": this.ColIndex = maxIndex; break;
            }

            pond[this.RowIndex, this.ColIndex] = '-';
            char symbol = pond[this.RowIndex, this.ColIndex];
            if (char.IsLower(symbol))
            {
                this.BranchesCollected.Push(symbol);
                this.BranchesLeft--;

            }
            else if (symbol == 'F')
                this.Swim(pond, command);
        }
    }

    class Program
    {
        static void Main()
        {
            char[,] pond = ReadPondData(int.Parse(Console.ReadLine()));
            int totalBranches = GetTotalBranchesCount(pond);
            (int beaverRow, int beaverCol) = GetBeaverLocation(pond);
            Beaver beaver = new Beaver(beaverRow, beaverCol, totalBranches);

            string command;
            while ((command = Console.ReadLine()) != "end" && beaver.BranchesLeft > 0)
            {
                beaver.Move(command, pond);
            }

            PrintResult(pond, beaver);
        }

        static char[,] ReadPondData(int size)
        {
            char[,] pond = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray().Where(x => x != ' ').ToArray();
                for (int col = 0; col < line.Length; col++)
                    pond[row, col] = line[col];
            }
            return pond;
        }

        static int GetTotalBranchesCount(char[,] pond)
        {
            int totalBranches = 0;
            foreach (char c in pond)
                if (char.IsLower(c)) totalBranches++;
            return totalBranches;
        }

        static (int beaverRow, int beaverCol) GetBeaverLocation(char[,] pond)
        {
            for (int row = 0; row < pond.GetLength(0); row++)
                for (int col = 0; col < pond.GetLength(1); col++)
                    if (pond[row, col] == 'B')
                        return (row, col);
            return (0, 0);
        }

        static void PrintResult(char[,] pond, Beaver beaver)
        {
            pond[beaver.RowIndex, beaver.ColIndex] = 'B';

            if (beaver.BranchesLeft == 0)
                Console.WriteLine($"The Beaver successfully collect {beaver.BranchesCollected.Count()} wood branches: "
                    + String.Join(", ", beaver.BranchesCollected.ToArray().Reverse()) + ".");
            else
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {beaver.BranchesLeft} branches left.");

            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    Console.Write(pond[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}