//You own a fashion boutique and you receive a delivery once a month in a huge box, which is full of clothes.
//You have to arrange them in your store, so you take the box and start from the last piece of clothing
//on the top of the pile to the first one at the bottom.
//Use a stack for this purpose.
//Each piece of clothing has its value (an integer).
//You have to sum their values, while you take them out of the box.
//You will be given an integer representing the capacity of a rack.
//While the sum of the clothes is less than the capacity, keep summing them.
//If the sum becomes equal to the capacity
//you have to take a new rack for the next clothes if there are any left in the box.
//If it becomes greater than the capacity, don't add the piece of clothing to the current rack and take a new one.
//In the end, print how many racks you have used to hang all of the clothes.
//Input
//•	On the first line, you will be given a sequence of integers, representing the clothes in the box,
//separated by a single space
//•	On the second line, you will be given an integer, representing the capacity of a rack
//Output
//•	Print the number of racks, needed to hang all of the clothes from the box
//Constraints
//•	The values of the clothes will be integers in the range [0,20]
//•	There will never be more than 50 clothes in a box
//•	The capacity will be an integer in the range [0,20]
//•	None of the integers from the box will be greater than than the value of the capacity

using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] inputInfo = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int capacity = int.Parse(Console.ReadLine());
        Stack<int> box = new Stack<int>(inputInfo);
        
        int racksUsed = 0;
        int currentRackCapacity = 0;
        while (box.Count > 0)
        {
            if (currentRackCapacity - box.Peek() < 0)
            {
                racksUsed++;
                currentRackCapacity = capacity;
            }
            else
            {
                currentRackCapacity -= box.Pop();
            }
        }
        Console.WriteLine(racksUsed);
    }
}
