//Create a program that counts in a given array of double values the number of occurrences of each value. 

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] sequence = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var occurences = new Dictionary<double, int>();
        foreach (var num in sequence)
        {
            if (!occurences.ContainsKey(num))
                occurences.Add(num, 0);
            occurences[num]++;
        }
        foreach (var occurence in occurences)
        {
            Console.WriteLine($"{occurence.Key} - {occurence.Value} times");
        }
    }
}