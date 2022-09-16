//Create a program that prints a number from a collection,
//which appears an even number of times in it.
//On the first line, you will be given n – the count of integers you will receive.
//On the next n lines, you will be receiving the numbers.
//It is guaranteed that only one of them appears an even number of times.
//Your task is to find that number and print it in the end. 

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<int, int> nums = new Dictionary<int, int>();
        int numberOfEntries = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfEntries; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (!nums.ContainsKey(currentNumber))
                nums.Add(currentNumber, 0);
            nums[currentNumber]++;
        }
        Console.WriteLine(nums.Where(x => x.Value % 2 == 0).Select(y => y.Key).First());
    }
}