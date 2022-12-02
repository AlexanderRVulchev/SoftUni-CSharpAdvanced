using System;

namespace _02._Bee
{
    class Bee
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Pollinated { get; set; }
        public bool GotLost { get; set; }

        public Bee((int, int) coordinates)
        {
            this.Row = coordinates.Item1;
            this.Col = coordinates.Item2;
            this.Pollinated = 0;
            this.GotLost = false;
        }

        public void Move(string command, char[,] territory)
        {
            territory[this.Row, this.Col] = '.';
            switch (command)
            {
                case "up": this.Row--; break;
                case "down": this.Row++; break;
                case "left": this.Col--; break;
                case "right": this.Col++; break;
            }

            if (this.Row < 0 || this.Row >= territory.GetLength(0) ||
                this.Col < 0 || this.Col >= territory.GetLength(1))
            {
                this.GotLost = true;
                return;
            }

            char symbol = territory[this.Row, this.Col];
            if (symbol == 'f')
            {
                this.Pollinated++;
                territory[this.Row, this.Col] = '.';
            }
            else if (symbol == 'O') Move(command, territory);
        }
    }

    internal class Program
    {
        static void Main()
        {
            char[,] territory = GetBeeTerritory();
            Bee bee = new Bee(GetBeeCoordinates(territory));
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                bee.Move(input, territory);
                if (bee.GotLost) break;
            }
            PrintResult(bee, territory);
        }

        static char[,] GetBeeTerritory()
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

        static (int, int) GetBeeCoordinates(char[,] territory)
        {
            for (int row = 0; row < territory.GetLength(0); row++)
                for (int col = 0; col < territory.GetLength(1); col++)
                    if (territory[row, col] == 'B')
                        return (row, col);
            return (0, 0);
        }

        static void PrintResult(Bee bee, char[,] territory)
        {
            if (bee.GotLost)
                Console.WriteLine("The bee got lost!");
            else
                territory[bee.Row, bee.Col] = 'B';

            if (bee.Pollinated >= 5)
                Console.WriteLine($"Great job, the bee managed to pollinate {bee.Pollinated} flowers!");
            else
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - bee.Pollinated} flowers more");
                        
            for (int row = 0; row < territory.GetLength(0); row++)
            {
                for (int col = 0; col < territory.GetLength(1); col++)
                    Console.Write(territory[row, col]);
                Console.WriteLine();
            }
        }
    }
}