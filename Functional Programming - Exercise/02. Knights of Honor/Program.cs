//Create a program that reads a collection of names as strings from the console,
//appends "Sir" in front of every name,
//and prints it back on the console. Use Action<T>.

using System;

class Program
{
    static void Main()
    {
        Action<string> print =
            x => Console.WriteLine("Sir " + x);

        string[] names = Console.ReadLine().Split();
        foreach (string name in names)
            print(name);
    }
}