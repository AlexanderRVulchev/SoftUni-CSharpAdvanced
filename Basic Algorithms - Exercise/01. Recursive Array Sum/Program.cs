//Create a program that sums all elements in an array. Use recursion.

using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    public class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(Sum(nums, 0));
        }

        static int Sum(int[] nums, int index)
        {
            if (index == nums.Length - 1)
                return nums[nums.Length - 1];
            else
                return nums[index] + Sum(nums, ++index);
        }
    }
}
