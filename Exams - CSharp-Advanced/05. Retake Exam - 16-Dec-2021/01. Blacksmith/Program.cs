//First, you will be given a sequence representing steel.
//Afterward, you will be given another sequence representing carbon.
//You should start from the first steel and try to mix it with the last carbon.
//If the sum of their values is equal to any of the swords in the table below
//you should forge the sword corresponding to the value and remove both the steel and the carbon.
//Otherwise, remove only the steel,
//increase the value of the carbon by 5 and insert it back into the collection.
//You need to stop forging when you have no more steel or carbon left.
//Sword	Resources needed
//Gladius	70
//Shamshir	80
//Katana	90
//Sabre	110
//Broadsword	150

//Forge as many swords as possible.
//Input
//•	On the first line, you will receive the steel, separated by a single space (" "). 
//•	On the second line, you will receive the carbon, separated by a single space (" ").
//Output
//•	On the first line of output depending on the result:
//o If at least one sword was forged: "You have forged {totalNumberOfSwords} swords."
//o If no sword was forged: "You did not have enough resources to forge a sword."
//•	On the second line - print all steel you have left:
//o If there are no steel: "Steel left: none"
//o If there are steel: "Steel left: {steel1}, {steel2}, {steel3}, (…)"
//•	On the third line - print all carbon you have left:
//o If there are no carbon: "Carbon left: none"
//o If there are carbon: "Carbon left: {carbon1}, {carbon2}, {carbon3}, (…)"
//•	Then, you need to print only the swords that you manage to forge
//and how many of them, ordered alphabetically:
//o "Broadsword: {amount}"
//o "Sabre: {amount}"
//o "Katana: {amount}"
//o "Shamshir: {amount}"
//o "Gladius: {amount}"


using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main()
        {
            var steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<int, string> swordsCosts = GetSwordsCostsData();
            var craftedSwords = new SortedDictionary<string, int>();

            while (steel.Any() && carbon.Any())
            {
                int currentSteel = steel.Dequeue();
                int currentCarbon = carbon.Pop();
                int sumValues = currentCarbon + currentSteel;
                if (swordsCosts.ContainsKey(sumValues))
                {
                    string swordName = swordsCosts[sumValues];
                    if (!craftedSwords.ContainsKey(swordName))
                        craftedSwords.Add(swordName, 0);
                    craftedSwords[swordName]++;
                }
                else
                    carbon.Push(currentCarbon + 5);
            }
            PrintResult(craftedSwords, steel, carbon);
        }

        static Dictionary<int, string> GetSwordsCostsData()
            => new Dictionary<int, string>() {
                { 70, "Gladius"},
                { 80, "Shamshir" },
                { 90 , "Katana" },
                { 110, "Sabre" },
                { 150, "Broadsword" }
            };

        static void PrintResult(SortedDictionary<string, int> craftedSwords, Queue<int> steel, Stack<int> carbon)
        {
            if (craftedSwords.Any()) 
                Console.WriteLine($"You have forged {craftedSwords.Values.Sum()} swords.");
            else
                Console.WriteLine("You did not have enough resources to forge a sword.");

            if (steel.Any())
                Console.WriteLine($"Steel left: " + String.Join(", ", steel));
            else
                Console.WriteLine("Steel left: none");

            if (carbon.Any())
                Console.WriteLine($"Carbon left: " + String.Join(", ", carbon));
            else
                Console.WriteLine("Carbon left: none");

            foreach (var sword in craftedSwords)
                Console.WriteLine($"{sword.Key}: {sword.Value}");
        }
    }
}
