using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    internal class Program
    {
        static void Main()
        {            
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            List<int> sets = new List<int>();

            while (hats.Any() && scarfs.Any())
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();
                if (hat > scarf)
                {
                    sets.Add(hat + scarf);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (hat < scarf)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    hats.Pop();
                    hats.Push(hat + 1);
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(String.Join(" ", sets));
        }
    }
}
