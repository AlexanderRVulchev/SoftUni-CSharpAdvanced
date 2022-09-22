//Create a program that reads one line of double prices separated by ", ".
//Print the prices with added VAT for all of them.
//Format them to 2 signs after the decimal point.
//The order of the prices must be the same.
//VAT is equal to 20% of the price.


using System;
using System.Linq;

class Program
{
    static Func<string, string> addVat = x 
        => $"{double.Parse(x) * 1.2:f2}";

    static void Main()
    {
        Console.WriteLine(
            string.Join("\n",
            Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(addVat)
            ));
    }
}