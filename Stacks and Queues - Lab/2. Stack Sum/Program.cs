//Create a program that:
//•	Reads an input of integer numbers and adds them to a stack
//•	Reads command until "end" is received
//•	Prints the sum of the remaining elements of the stack
//Input
//•	On the first line, you will receive an array of integers
//•	On the next lines, until the "end" command is given, you will receive commands –
//a single command and one or two numbers after the command, depending on what command you are given
//•	If the command is "add", you will always receive exactly two numbers after the
//command which you need to add to the stack
//•	If the command is "remove", you will always receive exactly one number after the
//command which represents the count of the numbers you need to remove from the stack.
//If there are not enough elements skip the command.
//Output
//•	When the command "end" is received, you need to print the sum of the remaining elements in the stack


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] initialNumsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> nums = new Stack<int>(initialNumsArray);       

        string input;
        while ((input = Console.ReadLine().ToLower()) != "end")
        {
            string[] cmd = input.Split();
            if (cmd[0] == "add")
            {
                nums.Push(int.Parse(cmd[1]));
                nums.Push(int.Parse(cmd[2]));
            }
            else if (cmd[0] == "remove" && nums.Count >= int.Parse(cmd[1]))
            {
                for (int i = 0; i < int.Parse(cmd[1]); i++)
                    nums.Pop();
            }
        }
        Console.WriteLine($"Sum: {nums.Sum()}");
    }
}