//Create a program, which will take a list of names and print only the unique names in the list.

using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        HashSet<string> names = new HashSet<string>();
        int numberOfNames = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfNames; i++)
        {
            names.Add(Console.ReadLine());
        }
        Console.WriteLine(string.Join("\n", names));
    }
}
