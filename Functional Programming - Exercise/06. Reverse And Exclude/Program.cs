//Create a program that reverses a collection and
//removes elements that are divisible by a given integer n.
//Use predicates/functions.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Func<int, int, bool> isNotDivisible = (num, divider)
            => num % divider != 0;
        Func<int[], int, int[]> filterArray = (arr, divider)
            => arr.Where(x => isNotDivisible(x, divider)).Reverse().ToArray();
        Action<int[]> print = arr
            => Console.WriteLine(String.Join(" ", arr));

        int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int divider = int.Parse(Console.ReadLine());
        print(filterArray(nums, divider));               
    }
}