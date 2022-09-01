//Reads an input consisting of a name and adds it to a queue until "End" is received.
//If you receive "Paid", print every customer name and empty the queue, otherwise,
//we receive a client and we have to add him to the queue.
//When we receive "End" we have to print the count of the remaining people in the queue in the format:
//"{count} people remaining.".

using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        string input;
        var names = new Queue<string>();
        while ((input = Console.ReadLine()) != "End")
        {
            if (input == "Paid")
            {
                while (names.Count != 0)
                {
                    Console.WriteLine(names.Dequeue());
                }
            }
            else
                names.Enqueue(input);
        }
        Console.WriteLine($"{names.Count} people remaining.");
    }
}
