//Create a program that reads continents, countries and their cities,
//puts them in a nested dictionary and prints them.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var atlas = new Dictionary<string, Dictionary<string, List<string>>>();
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            if (!atlas.ContainsKey(continent))
                atlas.Add(continent, new Dictionary<string, List<string>>());
            if (!atlas[continent].ContainsKey(country))
                atlas[continent].Add(country, new List<string>());
            atlas[continent][country].Add(city);
        }

        foreach (var continent in atlas)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.Write($"{country.Key} -> ");
                Console.WriteLine(String.Join(", ", country.Value));
            }
        }
    }
}