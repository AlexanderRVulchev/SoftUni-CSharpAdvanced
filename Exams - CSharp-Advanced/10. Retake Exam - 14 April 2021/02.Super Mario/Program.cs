using System;

namespace _02.Super_Mario
{
    internal class Program
    {
        class Mario
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public int Lives { get; set; }
            public bool HasWon { get; set; }


            public Mario(int lives, (int, int) marioCoords)
            {
                this.Lives = lives;
                this.Row = marioCoords.Item1;
                this.Col = marioCoords.Item2;
                this.HasWon = false;
            }

            public void Move(char[][] maze)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                int spawnRow = int.Parse(tokens[1]);
                int spawnCol = int.Parse(tokens[2]);
                maze[spawnRow][spawnCol] = 'B';
                maze[this.Row][this.Col] = '-';

                this.Lives--;
                int newRowIndex = this.Row;
                int newColIndex = this.Col;

                switch (command)
                {
                    case "W": newRowIndex--; break;
                    case "S": newRowIndex++; break;
                    case "A": newColIndex--; break;
                    case "D": newColIndex++; break;
                }
                if (newRowIndex < 0 || newRowIndex == maze.Length ||
                    newColIndex < 0 || newColIndex == maze[0].Length)
                    return;

                this.Row = newRowIndex;
                this.Col = newColIndex;
                char symbol = maze[this.Row][this.Col];
                if (symbol == 'B')
                    this.Lives -= 2;
                else if (symbol == 'P')
                    this.HasWon = true;

                maze[newRowIndex][newColIndex] = '-';
            }
        }

        static void Main()
        {
            int lives = int.Parse(Console.ReadLine());
            char[][] maze = GetInitialMazeInfo();
            Mario mario = new Mario(lives, GetMarioCoordinates(maze));
            while (mario.Lives > 0 && !mario.HasWon)
            {
                mario.Move(maze);
            }
            PrintResult(mario, maze);
        }

        static char[][] GetInitialMazeInfo()
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] maze = new char[rows][];
            for (int row = 0; row < rows; row++)
                maze[row] = Console.ReadLine().ToCharArray();
            return maze;
        }

        static (int, int) GetMarioCoordinates(char[][] maze)
        {
            for (int row = 0; row < maze.Length; row++)
                for (int col = 0; col < maze[row].Length; col++)
                    if (maze[row][col] == 'M')
                        return (row, col);
            return (0, 0);
        }

        static void PrintResult(Mario mario, char[][] maze)
        {
            if (mario.HasWon)
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {mario.Lives}");
            else
            {
                Console.WriteLine($"Mario died at {mario.Row};{mario.Col}.");
                maze[mario.Row][mario.Col] = 'X';
            }

            for (int row = 0; row < maze.Length; row++)
                Console.WriteLine(String.Join("", maze[row]));
        }
    }
}
