//Create a program that helps you decide what clothes to wear from your wardrobe.
//You will receive the clothes, which are currently in your wardrobe,
//sorted by their color in the following format:
//"{color} -> {item1},{item2},{item3}…"
//If you receive a certain color, which already exists in your wardrobe,
//just add the clothes to its records.
//You can also receive repeating items for a certain color and you have to keep their count.
//In the end, you will receive a color and a piece of clothing,
//which you will look for in the wardrobe, separated by a space in the following format:
//"{color} {clothing}"
//Your task is to print all the items and their count for each color in the following format: 
//"{color} clothes:
//* { item1}
//- { count}
//* { item2}
//- { count}
//* { item3}
//- { count}
//…
//* { itemN}
//- { count}
//"
//If you find the item you are looking for, you need to print "(found!)" next to it:
//"* {itemN} - {count} (found!)"
//Input
//•	On the first line, you will receive n - the number of lines of clothes, which you will receive.
//•	On the next n lines, you will receive the clothes in the format described above.
//Output
//•	Print the clothes from your wardrobe in the format described above 


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();
        int numberOfEntries = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfEntries; i++)
        {
            string line = Console.ReadLine();
            string color = line.Split(" -> ").First();
            string[] items = line.Split(" -> ").Last().Split(",").ToArray();

            if (!wardrobe.ContainsKey(color))
                wardrobe.Add(color, new Dictionary<string, int>());
            for (int j = 0; j < items.Length; j++)
            {
                if (!wardrobe[color].ContainsKey(items[j]))
                    wardrobe[color].Add(items[j], 0);
                wardrobe[color][items[j]]++;
            }
        }
        string[] input = Console.ReadLine().Split();
        string colorToFind = input[0];
        string itemToFind = input[1];

        foreach (var kvpColor in wardrobe)
        {
            Console.WriteLine($"{kvpColor.Key} clothes:");
            foreach (var kvpItem in kvpColor.Value)
            {
                Console.Write($"* {kvpItem.Key} - {kvpItem.Value}");
                if (colorToFind == kvpColor.Key && itemToFind == kvpItem.Key)
                    Console.Write(" (found!)");
                Console.WriteLine();
            }
        }
    }
}