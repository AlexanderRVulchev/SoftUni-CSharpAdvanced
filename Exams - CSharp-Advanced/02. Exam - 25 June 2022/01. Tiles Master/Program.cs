
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> white = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> grey = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<int, string> locationsByTileSums = GetLocationsByTileSums();
            Dictionary<string, int> craftedTiles = new Dictionary<string, int>();

            while (white.Any() && grey.Any())
            {
                int whiteTile = white.Pop();
                int greyTile = grey.Dequeue();
                if (whiteTile == greyTile)
                {
                    int largeTile = whiteTile + greyTile;
                    if (locationsByTileSums.ContainsKey(largeTile))
                    {
                        string location = locationsByTileSums[largeTile];
                        if (!craftedTiles.ContainsKey(location))
                            craftedTiles.Add(location, 0);
                        craftedTiles[location]++;
                    }
                    else
                    {
                        if (!craftedTiles.ContainsKey("Floor"))
                            craftedTiles.Add("Floor", 0);
                        craftedTiles["Floor"]++;
                    }
                }
                else
                {
                    white.Push(whiteTile / 2);
                    grey.Enqueue(greyTile);
                }
            }
            PrintResult(white, grey, craftedTiles);
        }

        static Dictionary<int, string> GetLocationsByTileSums()
        => new Dictionary<int, string>()
        {
            { 40, "Sink" },
            { 50, "Oven" },
            { 60, "Countertop"},
            { 70, "Wall" }
        };

        static void PrintResult(Stack<int> white, Queue<int> grey, Dictionary<string, int> craftedTiles)
        {
            if (!white.Any())
                Console.WriteLine("White tiles left: none");
            else
                Console.WriteLine($"White tiles left: " + String.Join(", ", white));
            if (!grey.Any())
                Console.WriteLine("Grey tiles left: none");
            else
                Console.WriteLine($"Grey tiles left: " + String.Join(", ", grey));                        
            foreach (var location in craftedTiles.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{location.Key}: {location.Value}");
            }
        }
    }
}
