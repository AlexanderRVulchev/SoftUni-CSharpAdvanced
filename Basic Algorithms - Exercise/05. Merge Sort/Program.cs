//Sort an array of elements using the famous merge sort.

using System;
using System.Linq;

namespace _05._Merge_Sort
{
    public class Program
    {
        public class Mergesort<T> where T : IComparable
        {
            private static T[] aux;

            public static void Sort(T[] arr)
            {
                aux = new T[arr.Length];
                Sort(arr, 0, arr.Length - 1);
            }

            private static void Merge(T[] arr, int lo, int mid, int hi)
            {
                if (arr[mid].CompareTo(arr[mid + 1]) <= 0) return;

                for (int index = lo; index <= hi; index++)
                {
                    aux[index] = arr[index];
                }

                int i = lo;
                int j = mid + 1;
                for (int k = lo; k <= hi; k++)
                {
                    if (i > mid)
                        arr[k] = aux[j++];
                    else if (j > hi)
                        arr[k] = aux[i++];
                    else if (aux[i].CompareTo(aux[j]) < 0)
                        arr[k] = aux[i++];
                    else
                        arr[k] = aux[j++];
                }
            }

            private static void Sort(T[] arr, int lo, int hi)
            {
                if (lo >= hi)
                    return;

                int mid = lo + (hi - lo) / 2;
                Sort(arr, lo, mid);
                Sort(arr, mid + 1, hi);
                Merge(arr, lo, mid, hi);
            }
        }



        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Mergesort<int>.Sort(arr);
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}