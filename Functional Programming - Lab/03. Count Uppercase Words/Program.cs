//Create a program that reads a line of text from the console.
//Print all the words that start with an uppercase letter in the same order you've received them in the text.

using System;
using System.Linq;

class Program
{
    static Func<string, bool> isUppercase = x
        => x[0] == x.ToUpper()[0];

    static void Main()
    {                
            Console.WriteLine(                
                String.Join("\n",
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(isUppercase)
                ));
    }
}