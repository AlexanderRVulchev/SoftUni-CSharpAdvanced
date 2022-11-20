using System;

namespace _02._Pawn_Wars
{
    class Pawn
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public string Color { get; set; }

        public Pawn((int, int) coordinates, string color)
        {
            this.Row = coordinates.Item1;
            this.Col = coordinates.Item2;
            this.Color = color;
        }
    }

    internal class Program
    {
        static void Main()
        {
            char[,] board = GetInitialBoardData();
            Pawn white = new Pawn(GetPawnLocation(board, 'w'), "White");
            Pawn black = new Pawn(GetPawnLocation(board, 'b'), "Black");

            while (true)
            {
                // White turn
                if (black.Row == white.Row - 1 &&
                   (black.Col == white.Col - 1 ||
                    black.Col == white.Col + 1))
                {
                    white.Row = black.Row;
                    white.Col = black.Col;
                    PrintResult(white, false);
                    break;
                }
                else if (--white.Row == 0)
                {
                    PrintResult(white, true);
                    break;
                }

                // Black turn
                if (white.Row == black.Row + 1 &&
                   (white.Col == black.Col - 1 ||
                    white.Col == black.Col + 1))
                {
                    black.Row = white.Row;
                    black.Col = white.Col;
                    PrintResult(black, false);
                    break;
                }
                else if (++black.Row == 7)
                {
                    PrintResult(black, true);
                    break;
                }

            }
        }

        static char[,] GetInitialBoardData()
        {
            char[,] board = new char[8, 8];
            for (int row = 0; row < 8; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < 8; col++)
                    board[row, col] = line[col];
            }
            return board;
        }

        static (int, int) GetPawnLocation(char[,] board, char ch)
        {
            for (int row = 0; row < 8; row++)
                for (int col = 0; col < 8; col++)
                    if (board[row, col] == ch)
                        return (row, col);
            return (0, 0);
        }

        private static void PrintResult(Pawn winner, bool gotQueen)
        {
            string chessCoordinates = (char)('a' + winner.Col) + (8 - winner.Row).ToString();

            if (gotQueen)
                Console.WriteLine($"Game over! {winner.Color} pawn is promoted to a queen at {chessCoordinates}.");
            else
                Console.WriteLine($"Game over! {winner.Color} capture on {chessCoordinates}.");
        }
    }
}