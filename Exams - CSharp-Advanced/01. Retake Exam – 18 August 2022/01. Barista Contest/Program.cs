using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Barista_Contest
{
    internal class Program
    {
        static void Main()
        {
            var coffee = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            var milk = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Dictionary<int, string> drinkQuantities = GetDrinkQuantitiesInfo();
            Dictionary<string, int> drinksMade = new Dictionary<string, int>();

            while (coffee.Any() && milk.Any())
            {
                int currentCoffee = coffee.Dequeue();
                int currentMilk = milk.Pop();
                int sumValue = currentCoffee + currentMilk;
                if (drinkQuantities.ContainsKey(sumValue))
                {
                    string drinkName = drinkQuantities[sumValue];
                    if (!drinksMade.ContainsKey(drinkName))
                        drinksMade.Add(drinkName, 0);
                    drinksMade[drinkName]++;
                }
                else
                {
                    milk.Push(currentMilk - 5);
                }
            }
            PrintResult(drinksMade, coffee, milk);
        }

        static Dictionary<int, string> GetDrinkQuantitiesInfo()
         => new Dictionary<int, string>()
            {
                { 50, "Cortado" },
                { 75, "Espresso" },
                { 100, "Capuccino" },
                { 150, "Americano" },
                { 200, "Latte" }
            };


        private static void PrintResult(Dictionary<string, int> drinksMade, Queue<int> coffee, Stack<int> milk)
        {
            if (!coffee.Any() && !milk.Any())
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            else
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

            if (!coffee.Any())
                Console.WriteLine("Coffee left: none");
            else
                Console.WriteLine($"Coffee left: " + String.Join(", ", coffee));

            if (!milk.Any())
                Console.WriteLine("Milk left: none");
            else
                Console.WriteLine($"Milk left: " + String.Join(", ", milk));

            foreach (var drink in drinksMade.OrderBy(d => d.Value).ThenByDescending(d => d.Key))
                Console.WriteLine($"{drink.Key}: {drink.Value}");
        }
    }
}