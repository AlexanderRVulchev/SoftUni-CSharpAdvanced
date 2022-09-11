//Browsing through GitHub, you come across an old JS Basics teamwork game.
//It is about very nasty bunnies that multiply extremely fast.
//There’s also a player that has to escape from their lair.
//You like the game, so you decide to port it to C# because that’s your language of choice.
//The last thing that is left is the algorithm that decides if the player will escape the lair or not.
//First, you will receive a line holding integers N and M,
//which represent the rows and columns in the lair.
//Then you receive N strings that can only consist of ".", "B", "P".
//The bunnies are marked with "B", the player is marked with "P",
//and everything else is free space, marked with a dot ".".
//They represent the initial state of the lair. There will be only one player.
//Then you will receive a string with commands such as LLRRUUDD –
//where each letter represents the next move of the player (Left, Right, Up, Down).
//After each step of the player, each of the bunnies spread to the up, down, left, and right
//(neighboring cells marked as "." changes their value to "B").
//If the player moves to a bunny cell or a bunny reaches the player, the player has died.
//If the player goes out of the lair without encountering a bunny, the player has won.
//When the player dies or wins, the game ends.
//All the activities for this turn continue (e.g. all the bunnies spread normally),
//but there are no more turns.
//There will be no stalemates where the moves of the player end before he dies or escapes.
//Finally, print the final state of the lair with every row on a separate line.
//On the last line, print either "dead: {row} {col}" or "won: {row} {col}".
//Row and col are the coordinates of the cell where the player has died
//or the last cell he has been in before escaping the lair.
//Input
//•	On the first line of input, the numbers N and M are received –
//the number of rows and columns in the lair
//•	On the next N lines, each row is received in the form of a string.
//The string will contain only ".", "B", "P". All strings will be the same length.
//There will be only one "P" for all the input
//•	On the last line, the directions are received in the form of a string,
//containing "R", "L", "U", "D"
//Output
//•	On the first N lines, print the final state of the bunny lair
//•	On the last line, print the outcome – "won:" or "dead:" + {row} { col}
//Constraints
//•	The dimensions of the lair are in the range [3…20]
//•	The directions string length is in the range [1…20]


using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
    public int RowIndex { get; set; }
    public int ColIndex { get; set; }
    public bool IsDead { get; set; }
    public bool HasEscaped { get; set; }
    public Queue<char> Commands { get; set; }

    public Player(int row, int col, Queue<char> commands)
    {
        this.Commands = new Queue<char>(commands);
        this.RowIndex = row;
        this.ColIndex = col;
        this.IsDead = false;
        this.HasEscaped = false;
    }

    public void Move(char[,] lair)
    {
        char command = this.Commands.Dequeue();
        int newRowIndex = this.RowIndex;
        int newColIndex = this.ColIndex;

        if (command == 'U') newRowIndex--;
        else if (command == 'D') newRowIndex++;
        else if (command == 'L') newColIndex--;
        else if (command == 'R') newColIndex++;

        if (newRowIndex < 0 || newRowIndex == lair.GetLength(0) ||
            newColIndex < 0 || newColIndex == lair.GetLength(1))
        {
            this.HasEscaped = true;
        }
        else
        {
            this.RowIndex = newRowIndex;
            this.ColIndex = newColIndex;
        }
    }
}

internal class Program
{
    static void Main()
    {
        char[,] lair = GetLairData();
        (int playerRow, int playerCol) = GetInitialPlayerCoordinates(lair);
        lair[playerRow, playerCol] = '.';
        var commands = new Queue<char>(Console.ReadLine().ToCharArray());
        Player player = new Player(playerRow, playerCol, commands);

        while (!player.HasEscaped && !player.IsDead)
        {
            player.Move(lair);
            PopulateBunnies(lair);
            if (lair[player.RowIndex, player.ColIndex] == 'B')
            {
                player.IsDead = true;
            }
        }
        PrintResult(player, lair);
    }

    static char[,] GetLairData()
    {
        int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int n = size[0];
        int m = size[1];
        char[,] lair = new char[n, m];
        for (int row = 0; row < n; row++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            for (int col = 0; col < m; col++)
            {
                lair[row, col] = line[col];
            }
        }
        return lair;
    }

    static (int, int) GetInitialPlayerCoordinates(char[,] lair)
    {
        for (int row = 0; row < lair.GetLength(0); row++)
            for (int col = 0; col < lair.GetLength(1); col++)
            {
                if (lair[row, col] == 'P')
                    return (row, col);
            }
        return (0, 0);
    }

    static void PopulateBunnies(char[,] lair)
    {
        for (int row = 0; row < lair.GetLength(0); row++)
            for (int col = 0; col < lair.GetLength(1); col++)
                if (lair[row, col] == 'B')
                {
                    MarkNewBunniesLocations(lair, row, col);
                }
        CreateNewBunniesAtMarkedLocations(lair);
    }

    static void MarkNewBunniesLocations(char[,] lair, int row, int col)
    {
        // Mark the coordinates of new bunny locations with 'N'
        if (row + 1 < lair.GetLength(0) && lair[row + 1, col] != 'B')
            lair[row + 1, col] = 'N';
        if (row - 1 >= 0 && lair[row - 1, col] != 'B')
            lair[row - 1, col] = 'N';
        if (col + 1 < lair.GetLength(1) && lair[row, col + 1] != 'B')
            lair[row, col + 1] = 'N';
        if (col - 1 >= 0 && lair[row, col - 1] != 'B')
            lair[row, col - 1] = 'N';
    }

    static void CreateNewBunniesAtMarkedLocations(char[,] lair)
    {
        // Replace the N's with B's
        for (int row = 0; row < lair.GetLength(0); row++)
            for (int col = 0; col < lair.GetLength(1); col++)
                if (lair[row, col] == 'N')
                {
                    lair[row, col] = 'B';
                }
    }

    static void PrintResult(Player player, char[,] lair)
    {
        for (int row = 0; row < lair.GetLength(0); row++)
        {
            for (int col = 0; col < lair.GetLength(1); col++)
            {
                Console.Write(lair[row, col]);
            }
            Console.WriteLine();
        }
        
        if (player.HasEscaped) Console.Write("won: ");
        else if (player.IsDead) Console.Write("dead: "); 
        Console.WriteLine($"{player.RowIndex} {player.ColIndex}");
    }
}