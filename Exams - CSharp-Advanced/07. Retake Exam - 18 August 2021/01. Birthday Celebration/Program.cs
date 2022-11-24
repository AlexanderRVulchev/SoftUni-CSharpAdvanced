using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main()
        {
            var guests = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray().Reverse());
            var plates = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            int wastedFood = 0;

            while (guests.Any() && plates.Any())
            {
                int currentGuest = guests.Pop();
                int currentPlate = plates.Pop();
                currentGuest -= currentPlate;
                if (currentGuest <= 0)
                    wastedFood -= currentGuest;
                else
                    guests.Push(currentGuest);
            }

            if (plates.Any())
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            else
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
