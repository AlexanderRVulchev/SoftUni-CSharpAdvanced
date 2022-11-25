using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<int, string> listOfMeals = GetListOfMeals();
            SortedDictionary<string, int> cookedDishes = new SortedDictionary<string, int>();

            while (ingredients.Any() && freshness.Any())
            {
                int currentIngredient = ingredients.Dequeue();
                if (currentIngredient == 0) continue;

                int currentFreshness = freshness.Pop();                
                int product = currentIngredient * currentFreshness;
                if (listOfMeals.ContainsKey(product))
                {
                    string meal = listOfMeals[product];
                    if (!cookedDishes.ContainsKey(meal))
                        cookedDishes.Add(meal, 0);
                    cookedDishes[meal]++;
                }
                else
                    ingredients.Enqueue(currentIngredient + 5);
            }

            if (cookedDishes.Count >= 4)
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            else
                Console.WriteLine($"You were voted off. Better luck next year.");

            if (ingredients.Any())
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            if (cookedDishes.Count > 0)
                foreach (var dish in cookedDishes)
                    Console.WriteLine($" # {dish.Key} --> {dish.Value}");
        }

        static Dictionary<int, string> GetListOfMeals()
            => new Dictionary<int, string>()
            {
                { 150, "Dipping sauce" },
                { 250, "Green salad" },
                { 300, "Chocolate cake" },
                { 400,  "Lobster" }
            };
    }
}
