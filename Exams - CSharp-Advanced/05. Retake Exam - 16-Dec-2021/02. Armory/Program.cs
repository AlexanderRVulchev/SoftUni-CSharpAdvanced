//You will be given an integer n for the size of the armory with a square shape.
//On the next n lines, you will receive the rows of the armory.
//The army officer will be placed in a random position, marked with the letter 'A'.
//On random positions, there will be swords, marked with a single digit (the price of the sword).
//There may also be mirrors, the count will be either 0 or 2 and they are marked with the letter - 'M'.
//All of the empty positions will be marked with '-'.
//Each turn, you will tell the army officer which direction he should move.
//Move commands will be: "up", "down", "left", "right".If the army officer moves to a sword,
//he buys the sword for a price equal to the digit there and the sword disappears.
//If the army officer moves to a mirror, he teleports on the position of the other mirror,
//and then both mirrors disappear. If you guide the army officer out of the armory,
//he leaves with the swords that he has bought. In advance, you negotiate with the king,
//that he'll buy at least 65 gold coins worth of blades.
//The program ends when the army officer buys blades for at least 65 gold coins,
//or you guide him out of the armory.
//Input
//•	On the first line, you are given the integer n – the size of the matrix (armory).
//•	The next n lines hold the values for every row.
//•	On each of the next lines, you will get a move command.
//Output
//•	On the first line:
//o If the army officer leaves the armory, print: "I do not need more swords!"
//o If the army officer fulfills the initial deal, print:
//"Very nice swords, I will come back for more!"
//•	On the second line print the profit you’ve made: "The king paid {amount} gold coins."
//•	At the end print the final state of the matrix (armory).


using System;

class Officer
{
    public int RowIndex { get; set; }
    public int ColIndex { get; set; }
    public int GoldSpent { get; set; }
    public bool HasLeftTheArmory { get; set; }

    public Officer(int row, int col)
    {
        this.RowIndex = row;
        this.ColIndex = col;
        this.GoldSpent = 0;
        this.HasLeftTheArmory = false;
    }

    public void Move(int matrixSize)
    {
        string command = Console.ReadLine();
        if (command == "up")
            this.RowIndex--;
        else if (command == "down")
            this.RowIndex++;
        else if (command == "left")
            this.ColIndex--;
        else if (command == "right")
            this.ColIndex++;

        if (this.RowIndex < 0 || this.RowIndex == matrixSize ||
            this.ColIndex < 0 || this.ColIndex == matrixSize)
            this.HasLeftTheArmory = true;
    }
}

internal class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char[,] armory = GetArmoryData(size);
        int[] startingPosition = GetCoordinatesOfTheOfficer(armory);
        Officer officer = new Officer(startingPosition[0], startingPosition[1]);

        while (officer.GoldSpent < 65)
        {
            officer.Move(size);
            if (officer.HasLeftTheArmory) break;

            char currentChar = armory[officer.RowIndex, officer.ColIndex];
            if (currentChar >= '0' && currentChar <= '9')
            {
                officer.GoldSpent += int.Parse(currentChar.ToString());
                armory[officer.RowIndex, officer.ColIndex] = '-';
            }
            else if (currentChar == 'M')
                TeleportToOtherMirror(officer, armory);
        }
        PrintOutput(officer, armory);
    }

    static char[,] GetArmoryData(int size)
    {
        char[,] armory = new char[size, size];
        for (int row = 0; row < size; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < size; col++)
            {
                armory[row, col] = line[col];
            }
        }
        return armory;
    }

    static int[] GetCoordinatesOfTheOfficer(char[,] armory)
    {
        int[] coordinates = new int[2];
        for (int row = 0; row < armory.GetLength(0); row++)
        {
            for (int col = 0; col < armory.GetLength(1); col++)
            {
                if (armory[row, col] == 'A')
                {
                    coordinates[0] = row;
                    coordinates[1] = col;
                    armory[row, col] = '-';
                    return coordinates;
                }
            }
        }
        return coordinates;
    }

    static void TeleportToOtherMirror(Officer officer, char[,] armory)
    {
        armory[officer.RowIndex, officer.ColIndex] = '-';
        for (int row = 0; row < armory.GetLength(0); row++)
            for (int col = 0; col < armory.GetLength(1); col++)
                if (armory[row, col] == 'M')
                {
                    officer.RowIndex = row;
                    officer.ColIndex = col;
                    armory[row, col] = '-';
                    return;
                }
    }

    static void PrintOutput(Officer officer, char[,] armory)
    {
        if (officer.HasLeftTheArmory)
        {
            Console.WriteLine("I do not need more swords!");
        }
        else
        {
            Console.WriteLine("Very nice swords, I will come back for more!");
            armory[officer.RowIndex, officer.ColIndex] = 'A';
        }
        Console.WriteLine($"The king paid {officer.GoldSpent} gold coins.");

        for (int row = 0; row < armory.GetLength(0); row++)
        {
            for (int col = 0; col < armory.GetLength(1); col++)
            {
                Console.Write(armory[row, col]);
            }
            Console.WriteLine();
        }
    }
}