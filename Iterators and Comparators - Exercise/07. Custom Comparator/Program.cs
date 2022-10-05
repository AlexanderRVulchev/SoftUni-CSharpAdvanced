using System;
using System.Collections.Generic;
using System.Linq;


namespace CustomComparator
{
    public class NumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x % 2 == 0 && Math.Abs(y) % 2 == 1)
                return -1;
            if (Math.Abs(x) % 2 == 1 && y % 2 == 0)
                return 1;
            return x.CompareTo(y);
        }
    }

    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                              .Split()
                              .Select(x => int.Parse(x))
                              .ToArray();
            NumComparer comparer = new NumComparer();
            Array.Sort(inputArray, comparer);
            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}