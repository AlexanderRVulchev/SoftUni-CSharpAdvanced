//Create a program that reads one line of integers separated by ", ".
//Then prints the even numbers of that sequence sorted in increasing order.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(
            String.Join(", ",
            Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .OrderBy(x => x)
            ));
    }
}