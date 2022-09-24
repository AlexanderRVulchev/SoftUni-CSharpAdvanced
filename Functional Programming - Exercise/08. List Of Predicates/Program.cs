//Find all numbers in the range 1...N that is divisible by the numbers of a given sequence. On the first line, you will be given an integer N – which is the end of the range. On the second line, you will be given a sequence of integers which are the dividers. Use predicates/functions.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int maxNumber = int.Parse(Console.ReadLine());
        int[] dividers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        Stack<int> result = new Stack<int>();
        Action<Stack<int>> print = x => Console.WriteLine(String.Join(" ", x.Reverse()));
        
        for (int i = 1; i <= maxNumber; i++)
        {
            Predicate<int> isDivisible = x => i % x == 0;
            result.Push(i);
            for (int divIndex = 0; divIndex < dividers.Length; divIndex++)
            {
                if (!isDivisible(dividers[divIndex]))
                {
                    result.Pop();
                    break;
                }
            }
        }
        print(result);
    }
}