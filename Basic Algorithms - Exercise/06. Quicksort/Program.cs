//Sort an array of elements using the famous quicksort.

using System;
using System.Linq;

namespace _06._Quicksort
{
    internal class Program
    {
        public class Quick
        {
            public static void Sort<T>(T[] a) where T : IComparable<T>
            {
                Shuffle(a);
                Sort(a, 0, a.Length - 1);
            }

            private static void Sort<T>(T[] a, int lo, int hi) where T : IComparable<T>
            {
                if (lo >= hi)
                    return;

                int p = Partition(a, lo, hi);
                Sort(a, lo, p - 1);
                Sort(a, p + 1, hi);
            }

            private static int Partition<T>(T[] a, int lo, int hi) where T : IComparable<T>
            {
                if (lo >= hi)
                    return lo;

                int i = lo;
                int j = hi + 1;
                while (true)
                {
                    while (a[++i].CompareTo(a[lo]) < 0)
                        if (i == hi) break;

                    while (a[lo].CompareTo(a[--j]) < 0)
                        if (j == lo) break;

                    if (i >= j) break;
                    Swap(a, i, j);
                }
                Swap(a, lo, j);
                return j;
            }

            static void Swap<T>(T[] a, int i, int j)
            {
                T temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }

            private static void Shuffle<T>(T[] a) where T : IComparable<T>
            {
                Random random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    int r = i + random.Next(0, a.Length - i);
                    Swap(a, i, r);
                }
            }
        }

        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Quick.Sort<int>(arr);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
