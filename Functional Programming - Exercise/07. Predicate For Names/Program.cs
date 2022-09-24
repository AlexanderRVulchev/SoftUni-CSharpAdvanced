//Write a program that filters a list of names according to their length.
//On the first line, you will be given an integer n, representing a name's length.
//On the second line, you will be given some names as strings separated by space.
//Write a function that prints only the names whose length is less than or equal to n.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int maxLength = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split();
        Predicate<string> isValidLength = x
            => x.Length <= maxLength;
        Console.WriteLine(string.Join("\n", names
            .Where(x => isValidLength(x))));
    }
}