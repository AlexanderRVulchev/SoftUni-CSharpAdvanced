using System;


namespace _02._Wall_Destroyer
{
    class Vanko
    {
        public int RowIndex { get; set; }
        public int ColIndex { get; set; }

        public int RodsHit { get; set; }
        public bool IsElectrocuted { get; set; }

        public Vanko(int row, int col)
        {
            this.RowIndex = row;
            this.ColIndex = col;
            this.RodsHit = 0;
            this.IsElectrocuted = false;
        }

        public void Move(char[,] wall, string command)
        {
            int size = wall.GetLength(0);
            int newRowIndex = this.RowIndex;
            int newColIndex = this.ColIndex;
            switch (command)
            {
                case "up": newRowIndex--; break;
                case "down": newRowIndex++; break;
                case "left": newColIndex--; break;
                case "right": newColIndex++; break;
            }
            if (newRowIndex >= 0 && newRowIndex < size &&
                newColIndex >= 0 && newColIndex < size)
            {
                if (wall[newRowIndex, newColIndex] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");
                    this.RodsHit++;
                }
                else
                {
                    wall[this.RowIndex, this.ColIndex] = '*';
                    this.RowIndex = newRowIndex;
                    this.ColIndex = newColIndex;
                    if (wall[this.RowIndex, this.ColIndex] == '*')
                        Console.WriteLine($"The wall is already destroyed at position [{this.RowIndex}, {this.ColIndex}]!");
                    else if (wall[newRowIndex, newColIndex] == 'C')
                    {
                        this.IsElectrocuted = true;
                        wall[this.RowIndex, this.ColIndex] = 'E';
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] wall = ReadWallMatrixData(size);            
            (int vankoRow, int vankoCol) = GetVankoLocation(wall);
            Vanko vanko = new Vanko(vankoRow, vankoCol);

            string command;
            while ((command = Console.ReadLine()) != "End" && !vanko.IsElectrocuted)
            {
                vanko.Move(wall, command);
            }
            PrintResult(vanko, wall);
        }

        static char[,] ReadWallMatrixData(int size)
        {
            char[,] wall = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                    wall[row, col] = line[col];
            }
            return wall;
        }

        static (int vankoRow, int vankoCol) GetVankoLocation(char[,] wall)
        {
            for (int row = 0; row < wall.GetLength(0); row++)
                for (int col = 0; col < wall.GetLength(1); col++)
                    if (wall[row, col] == 'V')
                        return (row, col);
            return (0, 0);
        }

        private static int GetNumberOfHoles(char[,] wall)
        {
            int holes = 0;
            foreach (char ch in wall)
                if (ch == '*' || ch == 'V' || ch == 'E')
                    holes++;
            return holes;
        }

        static void PrintResult(Vanko vanko, char[,] wall)
        {
            if (wall[vanko.RowIndex, vanko.ColIndex] != 'E')
                wall[vanko.RowIndex, vanko.ColIndex] = 'V';
            int numberOfHoles = GetNumberOfHoles(wall);

            if (vanko.IsElectrocuted)
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {numberOfHoles} hole(s).");
            else
                Console.WriteLine($"Vanko managed to make {numberOfHoles} hole(s) and he hit only {vanko.RodsHit} rod(s).");

            for (int row = 0; row < wall.GetLength(0); row++)
            {
                for (int col = 0; col < wall.GetLength(1); col++)
                    Console.Write(wall[row, col]);
                Console.WriteLine();
            }
        }
    }
}