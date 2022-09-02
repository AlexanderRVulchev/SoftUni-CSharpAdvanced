//Play around with a stack.
//You will be given an integer N representing the number of elements to push into the stack,
//an integer S representing the number of elements to pop from the stack,
//and finally an integer X, an element that you should look for in the stack.
//If it’s found, print "true" on the console. If it isn't,
//print the smallest element currently present in the stack.
//If there are no elements in the sequence, print 0 on the console.
//Input
//•	On the first line, you will be given N, S, and X, separated by a single space
//•	On the next line, you will be given N number of integers
//Output
//•	On a single line print either true if X is present in the stack,
//otherwise print the smallest element in the stack. If the stack is empty, print 0


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        var numsStack = new Stack<int>();
        int[] inputPushPopFind = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int pushCount = inputPushPopFind[0];
        int popCount = inputPushPopFind[1];
        int findInt = inputPushPopFind[2];

        int[] inputArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        for (int i = 0; i < pushCount; i++)
            numsStack.Push(inputArray[i]);

        for (int i = 0; i < popCount; i++)
            numsStack.Pop();

        if (numsStack.Contains(findInt))
            Console.WriteLine("true");
        else if (numsStack.Count == 0)
            Console.WriteLine("0");
        else
        {
            int minNumber = int.MaxValue;
            while (numsStack.Count != 0)
            {
                if (numsStack.Peek() < minNumber)
                    minNumber = numsStack.Pop();
                else
                    numsStack.Pop();
            }
            Console.WriteLine(minNumber);
        }
    }
}