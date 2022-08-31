//Create a program that:
//•	Reads an array of integers and adds them to a queue
//•	Prints the even numbers separated by ", "


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> nums = new Queue<int>(input);
        List<int> evenNumbers = new List<int>();
        
        while (nums.Count != 0)
        {
            int currentNumber = nums.Dequeue();
            if (currentNumber % 2 == 0)
            {
                evenNumbers.Add(currentNumber);
            }
        }
        Console.WriteLine(String.Join(", ", evenNumbers));
    }
}