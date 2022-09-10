//Create a program that populates, analyzes,
//and manipulates the elements of a matrix with an unequal length of its rows.
//First, you will receive an integer N equal to the number of rows in your matrix.
//On the next N lines, you will receive sequences of integers, separated by a single space.
//Each sequence is a row in the matrix.
//After populating the matrix, start analyzing it.
//If a row and the one below it have equal length,
//multiply each element in both of them by 2, otherwise - divide by 2.
//Then, you will receive commands. There are three possible commands:
//•	"Add {row} {column} {value}" - add { value}
//to the element at the given indexes, if they are valid
//•	"Subtract {row} {column} {value}" -
//subtract {value} from the element at the given indexes, if they are valid
//•	"End" - print the final state of the matrix (all elements separated by a single space) and stop the program
//Input
//•	On the first line, you will receive the number of rows of the matrix - integer N
//•	On the next N lines, you will receive each row - sequence of integers, separated by a single space
//•	{value} will always be an integer number
//•	Then you will be receiving commands until reading "End"
//Output
//•	The output should be printed on the console and it should consist of N lines
//•	Each line should contain a string representing the respective row of the final matrix,
//elements separated by a single space


using System;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        double[][] jaggedArray = GetInitialArrayValues();
        AnalyseJaggedArrayByRows(jaggedArray);

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            Match validInput = Regex.Match(input, @"\A(Add|Subtract) \d+ \d+ -?\d+\Z");
            //This regex pattern also guarantees non-negative indexes
            if (!validInput.Success) continue;

            string[] tokens = input.Split();
            string command = tokens[0];
            int rowIndex = int.Parse(tokens[1]);
            int columnIndex = int.Parse(tokens[2]);
            int value = int.Parse(tokens[3]);

            if (rowIndex >= jaggedArray.Length) continue;
            if (columnIndex >= jaggedArray[rowIndex].Length) continue;

            if (command == "Add")
                jaggedArray[rowIndex][columnIndex] += value;
            else if (command == "Subtract")
                jaggedArray[rowIndex][columnIndex] -= value;
        }
        PrintResult(jaggedArray);
    }

    static double[][] GetInitialArrayValues()
    {
        int rows = int.Parse(Console.ReadLine());
        double[][] jaggedArray = new double[rows][];
        for (int row = 0; row < rows; row++)
        {
            double[] line = Console.ReadLine().Split().Select(double.Parse).ToArray();
            jaggedArray[row] = line;
        }
        return jaggedArray;
    }

    static void AnalyseJaggedArrayByRows(double[][] jaggedArray)
    {
        for (int row = 0; row < jaggedArray.Length - 1; row++)
        {
            if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                ChangeTwoAdjacentRows(jaggedArray, row, "multiply");
            else
                ChangeTwoAdjacentRows(jaggedArray, row, "divide");
        }
    }

    static void ChangeTwoAdjacentRows(double[][] jaggedArray, int row, string action)
    {
        for (int currentRow = row; currentRow <= row + 1; currentRow++)
        {
            if (action == "multiply")
                jaggedArray[currentRow] = jaggedArray[currentRow].Select(x => x * 2).ToArray();
            else if (action == "divide")
                jaggedArray[currentRow] = jaggedArray[currentRow].Select(x => x / 2).ToArray();
        }
    }

    static void PrintResult(double[][] jaggedArray)
    {
        for (int row = 0; row < jaggedArray.Length; row++)
            Console.WriteLine(string.Join(" ", jaggedArray[row]));
    }
}