//Create a program that prints information about food shops in Sofia and the products they store.
//Until the "Revision" command is received, you will be receiving input in the format:
//"{shop}, {product}, {price}".
//Keep in mind that if you receive a shop you already have received,
//you must collect its product information.
//Your output must be ordered by shop name and must be in the format:
//"{shop}->
//Product: { product}, Price: { price}
//"
//Note: The price should not be rounded or formatted.


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var productInfo = new SortedDictionary<string, Dictionary<string, double>>();
        string input;
        while ((input = Console.ReadLine()) != "Revision")
        {
            string[] tokens = input.Split(", ");
            string shop = tokens[0];
            string product = tokens[1];
            double price = double.Parse(tokens[2]);

            if (!productInfo.ContainsKey(shop))
                productInfo.Add(shop, new Dictionary<string, double>());
            productInfo[shop].Add(product, price);
        }

        foreach (var shop in productInfo)
        {
            Console.WriteLine($"{shop.Key}->");
            Console.WriteLine(String.Join("\n", shop.Value.Select(x => $"Product: {x.Key}, Price: {x.Value}")));
        }
    }
}