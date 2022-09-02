//You have an empty sequence, and you will be given N queries.
//Each query is one of these three types:
//1 x – Push the element x into the stack.
//2 – Delete the element present at the top of the stack.
//3 – Print the maximum element in the stack.
//4 – Print the minimum element in the stack.
//After you go through all of the queries, print the stack in the following format:
//"{n}, {n1}, {n2} …, {nn}"
//Input
//•	The first line of input contains an integer, N
//•	The next N lines each contain an above-mentioned query. (It is guaranteed that each query is valid)
//Output
//•	For each type 3 or 4 queries, print the maximum/minimum element in the stack on a new line


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Stack<int> seq = new Stack<int>();
        int queries = int.Parse(Console.ReadLine());
        for (int i = 0; i < queries; i++)
        {
            int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            switch (cmd[0])
            {
                case 1:
                    seq.Push(cmd[1]); 
                    break;
                case 2:
                    if (seq.Count > 0)
                        seq.Pop(); 
                    break;                    
                case 3:
                    if (seq.Count > 0)
                        Console.WriteLine(seq.Max());
                    break;
                case 4:
                    if (seq.Count > 0)
                        Console.WriteLine(seq.Min());
                    break;
            }
        }
        Console.WriteLine(String.Join(", ", seq.ToArray()));
    }
}