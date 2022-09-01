//Hot potato is a game in which children form a circle and start passing a hot potato.
//The counting starts with the first kid.
//Every nth toss the child left with the potato leaves the game.
//When a kid leaves the game, it passes the potato along.
//This continues until there is only one kid left.
//Create a program that simulates the game of Hot Potato.
//Print every kid that is removed from the circle. In the end, print the kid that is left last.


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();
        var children = new Queue<string>(input);
        
        int turns = int.Parse(Console.ReadLine());
        while (children.Count > 1)
        {
            for (int i = 0; i < turns - 1; i++)
            {
                children.Enqueue(children.Dequeue());
            }
            Console.WriteLine($"Removed {children.Dequeue()}");
        }
        Console.WriteLine($"Last is {children.Dequeue()}");
    }
}
