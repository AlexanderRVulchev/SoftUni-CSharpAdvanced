using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Truffle_Hunter
{
    class Peter
    {
        public int Black { get; set; }
        public int Summer { get; set; }
        public int White { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            char[,] forest = ReadInitialForestData();
            Peter peter = new Peter();
            int eatenByBoar = 0;
            Queue<string> commands = ReadUserCommands();
            while (commands.Any())
            {
                string command = commands.Dequeue();
                if (command.Split().First() == "Collect") CollectTruffle(command, forest, peter);
                else WildBoarAttack(command, forest, ref eatenByBoar);
            }
            PrintResult(forest, peter, eatenByBoar);
        }

        static char[,] ReadInitialForestData()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] forest = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = string.Join("", Console.ReadLine().Split()).ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    forest[row, col] = line[col];
                }
            }
            return forest;
        }

        static Queue<string> ReadUserCommands()
        {
            Queue<string> commands = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "Stop the hunt")
                commands.Enqueue(input);
            return commands;
        }

        static void CollectTruffle(string command, char[,] forest, Peter peter)
        {
            int rowIndex = int.Parse(command.Split().Skip(1).First());
            int colIndex = int.Parse(command.Split().Last());
            char ch = forest[rowIndex, colIndex];
            if (ch == '-') return;
            switch (ch)
            {
                case 'B': peter.Black++; break;
                case 'S': peter.Summer++; break;
                case 'W': peter.White++; break;
            }
            forest[rowIndex, colIndex] = '-';
        }

        static void WildBoarAttack(string command, char[,] forest, ref int eatenByBoar)
        {
            int size = forest.GetLength(0);
            int rowIndex = int.Parse(command.Split().Skip(1).First());
            int colIndex = int.Parse(command.Split().Skip(2).First());
            string direction = command.Split().Last();
            while (rowIndex >= 0 && rowIndex < size &&
                   colIndex >= 0 && colIndex < size)
            {
                if ((new char[] { 'B', 'S', 'W' }).Contains(forest[rowIndex, colIndex]))
                {
                    eatenByBoar++;
                    forest[rowIndex, colIndex] = '-';
                }
                switch (direction)
                {
                    case "up": rowIndex -= 2; break;
                    case "down": rowIndex += 2; break;
                    case "left": colIndex -= 2; break;
                    case "right": colIndex += 2; break;
                }
            }
        }

        private static void PrintResult(char[,] forest, Peter peter, int eatenByBoar)
        {
            Console.WriteLine($"Peter manages to harvest {peter.Black} black, {peter.Summer} summer, and {peter.White} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatenByBoar} truffles.");

            for (int row = 0; row < forest.GetLength(0); row++)
            {
                for (int col = 0; col < forest.GetLength(1); col++)
                    Console.Write(forest[row, col] + " ");
                Console.WriteLine();
            }
        }
    }
}