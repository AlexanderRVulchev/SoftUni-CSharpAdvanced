//Create a generic method that receives a list,
//containing any type of data and swaps the elements at two given indexes.
//Input
//•	On the first line, you will read n number of boxes of type string and add them to the list.
//•	On the next line, however, you will receive a swap command consisting of two indexes.
//Output
//•	Use the method you've created to swap the elements
//that correspond to the given indexes and print each element in the list.


using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    internal class StartUp
    {
        static void Main()
        {
            List<int> items = new List<int>();
            int numberOfItems = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfItems; i++)
            {
                items.Add(int.Parse(Console.ReadLine()));
            }
            string input = Console.ReadLine();
            int firstIndex = input.Split().Select(x => int.Parse(x)).First();
            int secondIndex = input.Split().Select(x => int.Parse(x)).Last();
            List<int> swappedList = Swap(items, firstIndex, secondIndex);
            foreach (var item in swappedList)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public static List<T> Swap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
            return items;
        }
    }
}
