//Create a program that keeps all the unique chemical elements.
//On the first line, you will be given a number n -
//the count of input lines that you are going to receive.
//On the next n lines, you will be receiving chemical compounds, separated by a single space.
//Your task is to print all the unique ones in ascending order:

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<string> elements = new SortedSet<string>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int line = 0; line < numberOfLines; line++)
        {
            string[] input = Console.ReadLine().Split();
            for (int element = 0; element < input.Length; element++)
            {
                elements.Add(input[element]);
            }
        }
        Console.WriteLine(string.Join(" ", elements));
    }
}