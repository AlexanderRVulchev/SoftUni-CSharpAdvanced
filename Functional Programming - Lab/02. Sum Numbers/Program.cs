//Create a program that reads a line of integers separated by ", ".
//Print on two lines the count of numbers and their sum.

using System;
using System.Linq;

class Program
{
    static Action<int[]> output = x => Console.WriteLine($"{x.Count()}\n{x.Sum()}");

    static void Main()
    {
        output(Console.ReadLine()
              .Split(", ")
              .Select(int.Parse)
              .ToArray());
    }
}