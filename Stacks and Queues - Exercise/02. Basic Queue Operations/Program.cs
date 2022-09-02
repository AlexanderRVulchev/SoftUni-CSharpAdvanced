//Play around with a queue.
//You will be given an integer N representing the number of elements to enqueue (add),
//an integer S representing the number of elements to dequeue (remove) from the queue,
//and finally an integer X, an element that you should look for in the queue.
//If it is, print true on the console.
//If it’s not printed the smallest element is currently present in the queue.
//If there are no elements in the sequence, print 0 on the console.

using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        var numsQueue = new Queue<int>();
        int[] inputQueueDequeueFind = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int enqueueCount = inputQueueDequeueFind[0];
        int dequeueCount = inputQueueDequeueFind[1];
        int findInt = inputQueueDequeueFind[2];

        int[] inputArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        for (int i = 0; i < enqueueCount; i++)
            numsQueue.Enqueue(inputArray[i]);

        for (int i = 0; i < dequeueCount; i++)
            numsQueue.Dequeue();

        if (numsQueue.Contains(findInt))
            Console.WriteLine("true");
        else if (numsQueue.Count == 0)
            Console.WriteLine("0");
        else
        {
            int minNumber = int.MaxValue;
            while (numsQueue.Count != 0)
            {
                if (numsQueue.Peek() < minNumber)
                    minNumber = numsQueue.Dequeue();
                else
                    numsQueue.Dequeue();
            }
            Console.WriteLine(minNumber);
        }
    }
}