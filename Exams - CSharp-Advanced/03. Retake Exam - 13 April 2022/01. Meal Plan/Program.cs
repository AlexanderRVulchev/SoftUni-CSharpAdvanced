
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> meals = new Queue<string>(Console.ReadLine().Split());
            Stack<int> calories = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            Dictionary<string, int> caloriesPerMeal = GetCaloriesPerMeal();
            int mealsEaten = 0;

            while (meals.Any() && calories.Any() && calories.Peek() > 0)
            {
                int dailyCalories = calories.Pop();
                string meal = meals.Dequeue();
                mealsEaten++;
                int currentMealCalories = caloriesPerMeal[meal];
                dailyCalories -= currentMealCalories;

                while (dailyCalories <= 0)
                {
                    if (!calories.Any()) break;
                    dailyCalories += calories.Pop();
                }
                calories.Push(dailyCalories);
            }
            PrintResult(meals, calories, mealsEaten);
        }

        static Dictionary<string, int> GetCaloriesPerMeal()
            => new Dictionary<string, int>()
            {
                { "salad", 350 },
                { "soup" , 490 },
                { "pasta", 680 },
                { "steak", 790 }
            };


        private static void PrintResult(Queue<string> meals, Stack<int> calories, int mealsEaten)
        {
            if (!meals.Any())
            {
                Console.WriteLine($"John had {mealsEaten} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealsEaten} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
