//Read a list of integers and print the largest 3 of them.
//If there are less than 3, print all of them.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] result = nums.OrderByDescending(x => x).Take(3).ToArray();
        Console.WriteLine(String.Join(" ", result));
    }
}