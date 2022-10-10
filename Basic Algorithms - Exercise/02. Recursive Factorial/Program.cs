//Create a program that finds the factorial of a given number. Use recursion.

using System;

namespace _02._Recursive_Factorial
{
    public class Program
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }

        static long Factorial(long n)
        {
            if (n == 1) return 1;
            else return n * Factorial(n - 1);
        }
    }
}