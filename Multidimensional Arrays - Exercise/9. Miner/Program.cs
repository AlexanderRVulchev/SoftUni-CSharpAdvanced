//We get as input the size of the field in which our miner moves.
//The field is always a square.
//After that, we will receive the commands which represent the directions in which the miner should move.
//The miner starts from position – ‘s’. The commands will be: left, right, up, and down.
//If the miner has reached a side edge of the field and the next command indicates
//that he has to get out of the field,
//he must remain in his current position and ignore the current command.
//The possible characters that may appear on the screen are:
//•	* – a regular position on the field.
//•	e – the end of the route.
//•	c  - coal
//•	s - the place where the miner starts
//Each time when the miner finds coal, he collects it and replaces it with '*'.
//Keep track of the count of the collected coals.If the miner collects all of the coals in the field,
//the program stops and you have to print the following message:
//"You collected all coals! ({rowIndex}, {colIndex})".
//If the miner steps at 'e' the game is over (the program stops)
//and you have to print the following message: "Game over! ({rowIndex}, {colIndex})".
//If there are no more commands and none of the above cases had happened,
//you have to print the following message: "{remainingCoals} coals left. ({rowIndex}, {colIndex})".
//Input
//•	Field size – an integer number.
//•	Commands to move the miner – an array of strings separated by " ".
//•	The field: some of the following characters (*, e, c, s), separated by whitespace (" ");
//Output
//•	There are three types of output:
//o If all the coals have been collected, print the following output:
//"You collected all coals! ({rowIndex}, {colIndex})"
//o If you have reached the end, you have to stop moving and print the following line:
//"Game over! ({rowIndex}, {colIndex})"
//o If there are no more commands and none of the above cases had happened,
//you have to print the following message: "{totalCoals} coals left. ({rowIndex}, {colIndex})"


using System;
using System.Collections.Generic;
using System.Linq;

class Miner
{
    public int RowIndex { get; set; }
    public int ColIndex { get; set; }
    public int CoalsLeft { get; set; }
            
    public void Move(string command, int matrixSize)
    {
        if (command == "up" && this.RowIndex > 0)
            this.RowIndex--;
        else if (command == "down" && this.RowIndex < matrixSize - 1)
            this.RowIndex++;
        else if (command == "left" && this.ColIndex > 0)
            this.ColIndex--;
        else if (command == "right" && this.ColIndex < matrixSize - 1)
            this.ColIndex++;
    }
}

internal class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        Stack<string> commands = ReadCommands();
        char[,] field = GetFieldData(size);
        int[] startingPosition = GetCoordinatesOfTheMiner(field);

        Miner miner = new Miner();
        miner.CoalsLeft = GetTotalNumberOfCoals(field);
        miner.RowIndex = startingPosition[0];
        miner.ColIndex = startingPosition[1];
        int currentChar = 's';

        while (commands.Count > 0 &&
               miner.CoalsLeft > 0 &&
               currentChar != 'e')
        {
            string command = commands.Pop();
            miner.Move(command, size);
            currentChar = field[miner.RowIndex, miner.ColIndex];

            if (currentChar == 'c')
            {
                miner.CoalsLeft--;
                field[miner.RowIndex, miner.ColIndex] = '*';
            }
        }
        PrintOutput(miner, currentChar == 'e');
    }

    static Stack<string> ReadCommands()
    {
        Stack<string> commands = new Stack<string>();
        string[] line = Console.ReadLine().Split();
        for (int i = line.Length - 1; i >= 0; i--)
        {
            commands.Push(line[i]);
        }
        return commands;
    }

    static char[,] GetFieldData(int size)
    {
        char[,] field = new char[size, size];
        for (int row = 0; row < size; row++)
        {
            char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();
            for (int col = 0; col < size; col++)
            {
                field[row, col] = line[col];
            }
        }
        return field;
    }

    static int GetTotalNumberOfCoals(char[,] field)
    {
        int coals = 0;
        foreach (char c in field)
        {
            if (c == 'c') coals++;
        }        
        return coals;
    }

    static int[] GetCoordinatesOfTheMiner(char[,] field)
    {
        int[] coordinates = new int[2];
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                if (field[row, col] == 's')
                {
                    coordinates[0] = row;
                    coordinates[1] = col;
                    return coordinates;
                }
            }
        }
        return coordinates;
    }

    static void PrintOutput(Miner miner, bool minerReachedTheEnd)
    {
        if (miner.CoalsLeft == 0)
            Console.Write($"You collected all coals! ");
        else if (minerReachedTheEnd)
            Console.Write($"Game over! ");
        else
            Console.Write($"{miner.CoalsLeft} coals left. ");

        Console.WriteLine($"({miner.RowIndex}, {miner.ColIndex})");
    }
}