using System;

namespace _02._The_Battle_of_The_Five_Armies
{
    class Army
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Armor { get; set; }
        public bool HasWon { get; set; }
        public (int, int) Mordor { get; set; }

        public Army((int, int) armyCoordinates, (int, int) mordorCoordinates, int armor)
        {
            this.Row = armyCoordinates.Item1;
            this.Col = armyCoordinates.Item2;
            this.Mordor = mordorCoordinates;
            this.Armor = armor;
            this.HasWon = false;
        }

        public void Move(string command, char[][] world)
        {
            this.Armor--;
            switch (command)
            {
                case "up":
                    if (this.Row - 1 >= 0) this.Row--; break;
                case "down":
                    if (this.Row + 1 < world.Length) this.Row++; break;
                case "left":
                    if (this.Col - 1 >= 0) this.Col--; break;
                case "right":
                    if (this.Col + 1 < world[0].Length) this.Col++; break;
            }
            char currentChar = world[this.Row][this.Col];
            world[this.Row][this.Col] = '-';
            if (currentChar == 'O')
            {
                this.Armor -= 2;

            }
            if (this.Row == this.Mordor.Item1 && this.Col == this.Mordor.Item2)
            {
                this.HasWon = true;
                return;
            }

            if (this.Armor <= 0)
                world[this.Row][this.Col] = 'X';
        }
    }

    internal class Program
    {
        static void Main()
        {
            int initialArmor = int.Parse(Console.ReadLine());
            char[][] world = GetInitialWorldData();
            Army army = new Army(GetCoordinates(world, 'A'), GetCoordinates(world, 'M'), initialArmor);
            world[army.Row][army.Col] = '-';
            while (army.Armor > 0 && !army.HasWon)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                int spawnRow = int.Parse(input[1]);
                int spawnCol = int.Parse(input[2]);
                world[spawnRow][spawnCol] = 'O';
                army.Move(command, world);
            }
            PrintResult(army, world);
        }

        static char[][] GetInitialWorldData()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            char[][] world = new char[numberOfRows][];
            for (int row = 0; row < numberOfRows; row++)
            {
                string line = Console.ReadLine();
                world[row] = line.ToCharArray();
            }
            return world;
        }

        static (int, int) GetCoordinates(char[][] world, char ch)
        {
            for (int row = 0; row < world.Length; row++)
                for (int col = 0; col < world[row].Length; col++)
                    if (world[row][col] == ch)
                        return (row, col);
            return (0, 0);
        }

        static void PrintResult(Army army, char[][] world)
        {
            if (army.HasWon)
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {army.Armor}");
            else
                Console.WriteLine($"The army was defeated at {army.Row};{army.Col}.");

            for (int row = 0; row < world.Length; row++)
                Console.WriteLine(String.Join("", world[row]));
        }
    }
}