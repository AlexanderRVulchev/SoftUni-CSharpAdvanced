using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    internal class Program
    {
        static void Main()
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Dictionary<int, string> bombsDefinitions = GetBombDefinitions();
            SortedDictionary<string, int> createdBombs = new SortedDictionary<string, int>();
            foreach (var bomb in bombsDefinitions)
                createdBombs.Add(bomb.Value, 0);

            while (effects.Any() && casings.Any() && !check(createdBombs))
            {
                int effect = effects.Peek();
                int casing = casings.Peek();
                int sum = effect + casing;
                if (bombsDefinitions.ContainsKey(sum))
                {
                    string bombName = bombsDefinitions[sum];                    
                    createdBombs[bombName]++;
                    effects.Dequeue();
                    casings.Pop();
                }
                else
                    casings.Push(casings.Pop() - 5);
            }
            PrintResult(createdBombs, effects, casings);
        }

        static Dictionary<int, string> GetBombDefinitions()
            => new Dictionary<int, string>()
            {
                { 40, "Datura Bombs" },
                { 60, "Cherry Bombs"},
                { 120, "Smoke Decoy Bombs" }
            };

        static Predicate<SortedDictionary<string, int>> check = dict
            => dict.Where(y => y.Value >= 3).Count() == 3;

        static void PrintResult(SortedDictionary<string, int> createdBombs, Queue<int> effects, Stack<int> casings)
        {
            if (check(createdBombs))
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            else
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");

            if (effects.Any())
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            else
                Console.WriteLine("Bomb Effects: empty");

            if (casings.Any())
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");
            else
                Console.WriteLine("Bomb Casings: empty");

            foreach (var bomb in createdBombs)
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
        }
    }
}
