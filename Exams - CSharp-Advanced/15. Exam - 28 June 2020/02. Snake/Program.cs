using System;

namespace _02._Snake
{
    class Snake
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Food { get; set; }
        public bool HasLeft { get; set; }

        public Snake((int, int) cordinates)
        {
            this.Row = cordinates.Item1;
            this.Col = cordinates.Item2;
            this.Food = 0;
            this.HasLeft = false;
        }

        public void Move(char[,] territory)
        {
            territory[this.Row, this.Col] = '.';
            string command = Console.ReadLine();
            switch (command)
            {
                case "up": this.Row--; break;
                case "down": this.Row++; break;
                case "left": this.Col--; break;
                case "right": this.Col++; break;
            }

            if (this.Row < 0 || this.Row == territory.GetLength(0) ||
                this.Col < 0 || this.Col == territory.GetLength(1))
            {
                this.HasLeft = true;
                return;
            }

            char symbol = territory[this.Row, this.Col];
            if (symbol == '*')
            {
                this.Food++;
                territory[this.Row, this.Col] = '.';
            }
            else if (symbol == 'B')
                TeleportToOtherBurrow(territory);
        }

        public void TeleportToOtherBurrow(char[,] territory)
        {
            territory[this.Row, this.Col] = '.';
            for (int row = 0; row < territory.GetLength(0); row++)
                for (int col = 0; col < territory.GetLength(1); col++)
                    if (territory[row, col] == 'B')
                    {
                        this.Row = row;
                        this.Col = col;
                    }
            territory[this.Row, this.Col] = '.';
        }
    }

    internal class Program
    {
        static void Main()
        {
            char[,] territory = GetInitialTerritoryData();
            Snake snake = new Snake(FindSnakeLocation(territory));
            while (!snake.HasLeft && snake.Food < 10)
            {
                snake.Move(territory);
            }
            PrintResult(snake, territory);
        }

        static char[,] GetInitialTerritoryData()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] territory = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                    territory[row, col] = line[col];
            }
            return territory;
        }

        static (int, int) FindSnakeLocation(char[,] territory)
        {
            for (int row = 0; row < territory.GetLength(0); row++)
                for (int col = 0; col < territory.GetLength(1); col++)
                    if (territory[row, col] == 'S')
                        return (row, col);
            return (0, 0);
        }

        static void PrintResult(Snake snake, char[,] territory)
        {
            if (snake.HasLeft)
                Console.WriteLine("Game over!");
            else
            {
                Console.WriteLine("You won! You fed the snake.");
                territory[snake.Row, snake.Col] = 'S';
            }
            Console.WriteLine($"Food eaten: {snake.Food}");
            for (int row = 0; row < territory.GetLength(0); row++)
            {
                for (int col = 0; col < territory.GetLength(1); col++)
                    Console.Write(territory[row, col]);
                Console.WriteLine();
            }
        }
    }
}