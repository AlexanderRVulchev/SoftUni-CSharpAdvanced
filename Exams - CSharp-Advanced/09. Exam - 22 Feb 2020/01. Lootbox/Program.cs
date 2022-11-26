using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            int lootValue = 0;

            while (firstBox.Any() && secondBox.Any())
            {
                int itemFirst = firstBox.Peek();
                int itemSecond = secondBox.Pop();
                int sum = itemFirst + itemSecond;
                if (sum % 2 == 0)
                {
                    lootValue += sum;
                    firstBox.Dequeue();
                }
                else
                    firstBox.Enqueue(itemSecond);
            }

            if (!firstBox.Any())
                Console.WriteLine($"First lootbox is empty");
            else
                Console.WriteLine($"Second lootbox is empty");

            if (lootValue >= 100)
                Console.WriteLine($"Your loot was epic! Value: {lootValue}");
            else
                Console.WriteLine($"Your loot was poor... Value: {lootValue}");
        }
    }
}