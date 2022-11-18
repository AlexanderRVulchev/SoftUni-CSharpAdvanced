using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main()
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());
            Dictionary<string, int> productsBaked = new Dictionary<string, int>();

            while (water.Any() && flour.Any())
            {
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();
                double waterPercentage = currentWater / (currentWater + currentFlour) * 100;
                string bakedProduct;
                switch (waterPercentage)
                {                    
                    case 50: bakedProduct = "Croissant"; break;
                    case 40: bakedProduct = "Muffin"; break;
                    case 30: bakedProduct = "Baguette"; break;
                    case 20: bakedProduct = "Bagel"; break;
                    default:
                        bakedProduct = "Croissant";
                        flour.Push(currentFlour - currentWater);
                        break;
                }
                if (!productsBaked.ContainsKey(bakedProduct))
                    productsBaked.Add(bakedProduct, 0);
                productsBaked[bakedProduct]++;
            }

            foreach (var product in productsBaked.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                Console.WriteLine($"{product.Key}: {product.Value}");

            if (water.Any())
                Console.WriteLine($"Water left: " + string.Join(", ", water));
            else
                Console.WriteLine("Water left: None");

            if (flour.Any())
                Console.WriteLine($"Flour left: " + String.Join(", ", flour));
            else
                Console.WriteLine("Flour left: None");
        }
    }
}