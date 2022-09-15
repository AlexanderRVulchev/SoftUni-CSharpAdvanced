//Create a program that prints a set of elements.
//On the first line, you will receive two numbers - n and m, which represent the lengths of two separate sets.
//On the next n + m lines, you will receive n numbers, which are the numbers in the first set,
//and m numbers, which are in the second set.
//Find all the unique elements that appear in both of them
//and print them in the order in which they appear in the first set - n.
//For example:
//Set with length n = 4: { 1, 3, 5, 7}
//Set with length m = 3: { 3, 4, 5}
//Set that contains all the elements that repeat in both sets -> {3, 5}


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> first = new HashSet<string>();
        HashSet<string> second = new HashSet<string>();
        int[] entries = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < entries[0]; i++)
        {
            first.Add(Console.ReadLine());
        }
        for (int i = 0; i < entries[1]; i++)
        {
            second.Add(Console.ReadLine());
        }
        first.IntersectWith(second);
        Console.WriteLine(string.Join(" ", first));
    }
}