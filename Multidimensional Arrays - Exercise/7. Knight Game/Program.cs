//Chess is the oldest game, but it is still popular these days.
//For this task, we will use only one chess piece – the Knight. 
//The knight moves to the nearest square but not on the same row, column, or diagonal.
//(This can be thought of as moving two squares horizontally, then one square vertically,
//or moving one square horizontally then two squares vertically— i.e. in an "L" pattern.) 
//The knight game is played on a board with dimensions N x N and a lot of chess knights 0 <= K <= N2. 
//You will receive a board with K for knights and '0' for empty cells.
//Your task is to remove a minimum of the knights, so there will be no knights left that can attack another knight. 
//Input
//On the first line, you will receive the N side of the board
//On the next N lines, you will receive strings with Ks and 0s.
//Output
//Print a single integer with the minimum number of knights that needs to be removed
//Constraints
//•	Size of the board will be 0 < N < 30
//•	Time limit: 0.3 sec.Memory limit: 16 MB.


using System;

internal class Program
{
    static void Main()
    {
        int boardSize = int.Parse(Console.ReadLine());
        char[,] board = ReadInitialBoardPositions(boardSize);
        int removedKnights = 0;

        //ALGORITHM EXPLANATION: A knight's "threat" value is equal to the number of other knights he "threatens", which means
        //the number of other knights on all possible squares within the reach of this knight's "L"-shaped movement pattern.
        //If a knight can reach 3 other knights, then he has a "threat" value of 3. A knight cannot have "threat" value above 8.
        //In order to remove a minimum number of knights, we must first remove all knights with "threat" value of 8, then 7,6,5...1.

        for (int threatLevel = 8; threatLevel > 0; threatLevel--)
            for (int row = 0; row < boardSize; row++)
                for (int col = 0; col < boardSize; col++)
                    if (board[row, col] == 'K')
                    {
                        int knightThreat = CalculateKnightThreat(row, col, board);
                        if (knightThreat == threatLevel)
                        {
                            board[row, col] = '0';
                            removedKnights++;
                        }
                    }
        Console.WriteLine(removedKnights);
    }

    static char[,] ReadInitialBoardPositions(int boardSize)
    {
        char[,] board = new char[boardSize, boardSize];
        for (int row = 0; row < boardSize; row++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            for (int col = 0; col < boardSize; col++)
                board[row, col] = line[col];
        }
        return board;
    }

    static int CalculateKnightThreat(int row, int col, char[,] board)
    {
        int knightThreat = 0;
        if (ThereIsAnotherKnightHere(row + 2, col - 1, board)) knightThreat++;
        if (ThereIsAnotherKnightHere(row + 2, col + 1, board)) knightThreat++;
        if (ThereIsAnotherKnightHere(row - 2, col - 1, board)) knightThreat++;
        if (ThereIsAnotherKnightHere(row - 2, col + 1, board)) knightThreat++;
        if (ThereIsAnotherKnightHere(row - 1, col + 2, board)) knightThreat++;
        if (ThereIsAnotherKnightHere(row + 1, col + 2, board)) knightThreat++;
        if (ThereIsAnotherKnightHere(row - 1, col - 2, board)) knightThreat++;
        if (ThereIsAnotherKnightHere(row + 1, col - 2, board)) knightThreat++;
        return knightThreat;
    }

    static bool ThereIsAnotherKnightHere(int rowIndex, int colIndex, char[,] board)
    {
        int size = board.GetLength(0);
        if (rowIndex < 0 || rowIndex >= size || colIndex < 0 || colIndex >= size)
            return false;
        if (board[rowIndex, colIndex] != 'K')
            return false;
        return true;
    }
}