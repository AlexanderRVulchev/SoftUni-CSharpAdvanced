//Create a simple program that reads from the console a set of integers
//and prints back on the console the smallest number from the collection.
//Use Func<T, T>.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Func<int[], int> calcMin =
            x => x.Min();

        int[] nums = Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x))
            .ToArray();

        Console.WriteLine(calcMin(nums));
    }
}