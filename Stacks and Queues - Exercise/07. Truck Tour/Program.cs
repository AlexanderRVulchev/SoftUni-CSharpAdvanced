//Suppose there is a circle. There are N petrol pumps on that circle.
//Petrol pumps are numbered 0 to (N−1) (both inclusive).
//You have two pieces of information corresponding to each of the petrol pumps:
//(1) the amount of petrol that particular petrol pump will give, and
//(2) the distance from that petrol pump to the next petrol pump.
//Initially, you have a tank of infinite capacity carrying no petrol.
//You can start the tour at any of the petrol pumps.
//Calculate the first point from where the truck will be able to complete the circle.
//Consider that the truck will stop at each of the petrol pumps.
//The truck will move one kilometer for each liter of petrol.
//Input
//•	The first line will contain the value of N
//•	The next N lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give
//and the distance between that petrol pump and the next petrol pump
//Output
//•	An integer which will be the smallest index of the petrol pump from which we can start the tour
//Constraints
//•	1 ≤ N ≤ 1000001
//•	1 ≤ Amount of petrol, Distance ≤ 1000000000


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int numberOfPumps = int.Parse(Console.ReadLine());
        Queue<string> pumps = new Queue<string>();
        for (int i = 0; i < numberOfPumps; i++)
        {
            pumps.Enqueue(Console.ReadLine());
        }
        for (int index = 0; index < numberOfPumps; index++)
        {
            if (CanCompleteFullCircle(pumps))
            {
                Console.WriteLine(index);
                break;
            }
            pumps.Enqueue(pumps.Dequeue());
        }
    }

    private static bool CanCompleteFullCircle(Queue<string> pumps)
    {        
        int fuel = 0;
        bool canCompleteCirle = true;
        for (int i = 0; i < pumps.Count; i++)
        {
            int petrolAmount = int.Parse(pumps.Peek().Split().First());
            int distance = int.Parse(pumps.Peek().Split().Last());
            fuel += petrolAmount - distance;
            if (fuel < 0)
                canCompleteCirle = false;
            pumps.Enqueue(pumps.Dequeue());
        }
        return canCompleteCirle;
    }
}