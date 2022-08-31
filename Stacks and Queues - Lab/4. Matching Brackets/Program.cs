//We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.
//Print the result back at the terminal.


using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        Stack<int> bracketsIndexes = new Stack<int>();
        for (int i = 0; i < expression.Length; i++)
        {
            char symbol = expression[i];
            if (symbol == '(')
                bracketsIndexes.Push(i);
            else if (symbol == ')')
            {
                int startIndex = bracketsIndexes.Pop();
                int length = i - startIndex + 1;
                Console.WriteLine(expression.Substring(startIndex, length));
            }
        }
    }
}