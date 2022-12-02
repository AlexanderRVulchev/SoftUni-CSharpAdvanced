using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            int storedFlowers = 0;
            int wreaths = 0;

            while (lilies.Any() && roses.Any())
            {
                int currentLilies = lilies.Peek();
                int currentRoses = roses.Peek();
                int sum = currentLilies + currentRoses;
                if (sum > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                    continue;
                }
                else if (sum < 15) storedFlowers += sum;
                else wreaths++;

                lilies.Pop();
                roses.Dequeue();
            }
            wreaths += storedFlowers / 15;

            if (wreaths >= 5)
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            else
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
        }
    }
}
