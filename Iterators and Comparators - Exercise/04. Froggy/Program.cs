using System;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        static void Main()
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(stones);
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
