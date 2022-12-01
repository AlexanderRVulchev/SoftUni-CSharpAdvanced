using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    internal class Program
    {
        static void Main()
        {            
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int taskToKill = int.Parse(Console.ReadLine());

            while (true)
            {
                int task = tasks.Peek();
                int thread = threads.Peek();
                if (task == taskToKill) 
                    break;

                tasks.Pop();
                threads.Dequeue();

                if (thread < task)
                    tasks.Push(task);
            }
            Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToKill}");
            Console.WriteLine(String.Join(" ", threads));
        }
    }
}
