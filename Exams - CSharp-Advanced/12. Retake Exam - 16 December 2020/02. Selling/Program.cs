using System;
using System.Linq;

namespace _02._Selling
{
    class Cook
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Money { get; set; }
        public bool IsOutside { get; set; }

        public Cook((int, int) coordinates)
        {
            this.Row = coordinates.Item1;
            this.Col = coordinates.Item2;
            this.Money = 0;
            this.IsOutside = false;
        }

        public void Move(char[,] bakery)
        {
            bakery[this.Row, this.Col] = '-';
            string command = Console.ReadLine();
            switch (command)
            {
                case "up": this.Row--; break;
                case "down": this.Row++; break;
                case "left": this.Col--; break;
                case "right": this.Col++; break;
            }
            if (this.Row < 0 || this.Row == bakery.GetLength(0) ||
                this.Col < 0 || this.Col == bakery.GetLength(1))
            {
                this.IsOutside = true;
                return;
            }
            char symbol = bakery[this.Row, this.Col];
            if (char.IsDigit(symbol))
            {
                this.Money += int.Parse(symbol.ToString());
                bakery[this.Row, this.Col] = '-';
            }
            else if (symbol == 'O')
                TeleportToTheOtherPillar(bakery);
        }

        public void TeleportToTheOtherPillar(char[,] bakery)
        {
            bakery[this.Row, this.Col] = '-';
            (int, int) pillarLocation = (0, 0);

            for (int row = 0; row < bakery.GetLength(0); row++)
                for (int col = 0; col < bakery.GetLength(1); col++)
                    if (bakery[row, col] == 'O')
                        pillarLocation = (row, col);

            this.Row = pillarLocation.Item1;
            this.Col = pillarLocation.Item2;
            bakery[this.Row, this.Col] = '-';
        }
    }

    public class Program
    {
        static void Main()
        {
            char[,] bakery = GetInitialBakeryInfo();
            Cook cook = new Cook(GetCookCoordinates(bakery));
            while (cook.Money < 50 && !cook.IsOutside)
            {
                cook.Move(bakery);
            }
            PrintResult(cook, bakery);
        }

        static char[,] GetInitialBakeryInfo()
        {
            int size = int.Parse(Console.ReadLine());
            char[,] bakery = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < line.Length; col++)
                    bakery[row, col] = line[col];
            }
            return bakery;
        }

        static (int, int) GetCookCoordinates(char[,] bakery)
        {
            for (int row = 0; row < bakery.GetLength(0); row++)
                for (int col = 0; col < bakery.GetLength(1); col++)
                    if (bakery[row, col] == 'S')
                        return (row, col);
            return (0, 0);
        }

        static void PrintResult(Cook cook, char[,] bakery)
        {
            if (cook.IsOutside)
                Console.WriteLine("Bad news, you are out of the bakery.");
            else
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
                bakery[cook.Row, cook.Col] = 'S';
            }
            Console.WriteLine($"Money: {cook.Money}");

            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                for (int col = 0; col < bakery.GetLength(1); col++)
                    Console.Write(bakery[row, col]);
                Console.WriteLine();
            }
        }
    }
}