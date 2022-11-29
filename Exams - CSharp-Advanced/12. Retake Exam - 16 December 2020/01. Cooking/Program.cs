using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<int, string> foods = GetFoodCombinations();
            var cookedProducts = new SortedDictionary<string, int>();
            foreach (var food in foods)
                cookedProducts.Add(food.Value, 0);

            while (liquids.Any() && ingredients.Any())
            {
                int liquid = liquids.Dequeue();
                int ingredient = ingredients.Pop();
                int sum = liquid + ingredient;
                if (foods.ContainsKey(sum))
                {
                    string food = foods[sum];                    
                    cookedProducts[food]++;
                }
                else
                    ingredients.Push(ingredient + 3);
            }
            PrintResult(cookedProducts, liquids, ingredients);
        }

        static Dictionary<int, string> GetFoodCombinations()
            => new Dictionary<int, string>()
            {
                { 25, "Bread" },
                { 50, "Cake" },
                { 75, "Pastry" },
                { 100, "Fruit Pie" }
            };

        static void PrintResult(SortedDictionary<string, int> cookedProducts, Queue<int> liquids, Stack<int> ingredients)
        {
            if (cookedProducts.Where(p => p.Value > 0).Count() == 4)
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
            else
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");

            if (!liquids.Any())
                Console.WriteLine("Liquids left: none");
            else
                Console.WriteLine($"Liquids left: " + String.Join(", ", liquids));

            if (!ingredients.Any())
                Console.WriteLine("Ingredients left: none");
            else
                Console.WriteLine($"Ingredients left: " + String.Join(", ", ingredients));

            foreach (var food in cookedProducts)
                Console.WriteLine($"{food.Key}: {food.Value}");
        }
    }
}
