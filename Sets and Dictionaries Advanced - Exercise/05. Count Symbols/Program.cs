//Create a program that reads some text from the console
//and counts the occurrences of each character in it.
//Print the results in alphabetical (lexicographical) order.

using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        var dictSymbols = new SortedDictionary<char, int>();
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            char symbol = input[i];
            if (!dictSymbols.ContainsKey(symbol))
                dictSymbols.Add(symbol, 0);
            dictSymbols[symbol]++;
        }
        foreach (var kvp in dictSymbols)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}