//You are given an empty text. Your task is to implement 4 commands related to manipulating the text
//•	1 someString - appends someString to the end of the text
//•	2 count - erases the last count elements from the text
//•	3 index - returns the element at position index from the text
//•	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
//Input
//•	The first line contains n, the number of operations.
//•	Each of the following n lines contains the name of the operation followed by the command argument, if any, separated by space in the following format "CommandName Argument".
//Output
//•	For each operation of type 3 print a single line with the returned character of that operation.


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Stack<string> states = new Stack<string>();
        states.Push(string.Empty);
        int numberOfOperations = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfOperations; i++)
        {
            string input = Console.ReadLine();
            string command = input.Split().First();
            string item = input.Split().Last();
            switch (command)
            {
                case "1":
                    states.Push(states.Peek() + item);
                    break;
                case "2":
                    int count = int.Parse(item);
                    string newState = states.Peek().Remove(states.Peek().Length - count);
                    states.Push(newState);
                    break;
                case "3":
                    int index = int.Parse(item) - 1;
                    Console.WriteLine(states.Peek()[index]);
                    break;
                case "4":
                    states.Pop();
                    break;
            }
        }
    }
}