//Create a program that reads a collection of strings from the console
//and then prints them onto the console.
//Each name should be printed on a new line.Use Action<T>.

using System;


class Program
{
    static void Main()
    {
        Action<string[]> print =
            x => Console.WriteLine(string.Join("\n", x));

        string[] names = Console.ReadLine().Split();
        print(names);
    }
}