//Given a sequence consisting of parentheses, determine whether the expression is balanced.
//A sequence of parentheses is balanced if every open parenthesis can be paired uniquely
//with a closing parenthesis that occurs after the former. Also, the interval between them must be balanced.
//You will be given three types of parentheses: (, {, and[.
//{[()]}
//    -This is a balanced parenthesis.
//{[(])}
//    -This is not a balanced parenthesis.
//Input
//•	Each input consists of a single line, the sequence of parentheses.
//Output
//•	For each test case, print on a new line "YES" if the parentheses are balanced.
//Otherwise, print "NO".Do not print the quotes.


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Stack<char> parentheses = new Stack<char>();
        string input = Console.ReadLine();
        bool isBalanced = true;
        Dictionary<char, char> parDefinitions = new Dictionary<char, char>()
            {
            { '}', '{'}, {')', '('}, {']', '['}
            };
        for (int i = 0; i < input.Length; i++)
        {
            char symbol = input[i];
            if (parDefinitions.Any(x => x.Value == symbol)) //if it's an opening bracket
            {
                parentheses.Push(symbol);
            }
            else if (parDefinitions.Any(x => x.Key == symbol)) // if it's a closing bracket
            {                
                if (parentheses.Count > 0 && parDefinitions[symbol] == parentheses.Peek())
                { // if the closing bracket matches the last opened one
                    parentheses.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }
        }
        if (parentheses.Count > 0)
            isBalanced = false;

        Console.WriteLine(isBalanced ? "YES" : "NO");
    }
}
