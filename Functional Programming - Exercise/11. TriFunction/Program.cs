//Create a program that traverses a collection of names and returns the first name,
//whose sum of characters is equal to or larger than a given number N,
//which will be given on the first line.
//Use a function that accepts another function as one of its parameters.
//Start by building a regular function to hold the basic logic of the program.
//Something along the lines of Func<string, int, bool>.
//Afterward, create your main function which should accept the first function as one of its parameters.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {        
        int threshold = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split().ToList();

        Func<string, int, bool> isValidName =
            (name, limit) => name.ToCharArray().Select(y => (int)y).Sum() >= limit;
        Func<List<string>, Func<string, int, bool>, string> findName =
            (names, isValidName) => names.Find(x => isValidName(x, threshold));

        string result = findName(names, isValidName);
        Console.WriteLine(result);
    }
}