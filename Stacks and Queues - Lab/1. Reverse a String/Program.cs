//Create a program that:
//•	Reads an input string
//•	Reverses it using a Stack<T>
//•	Prints the result back at the terminal


using System;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> lettersStack = new Stack<char>();
        for (int i = 0; i < input.Length; i++)
        {
            lettersStack.Push(input[i]);
        }

        StringBuilder result = new StringBuilder();
        while(lettersStack.Count != 0)
        {
            result.Append(lettersStack.Pop());
        }
        Console.WriteLine(result);        
    }
}