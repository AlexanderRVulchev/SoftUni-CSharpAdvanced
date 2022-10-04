using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        public List<T> Items;

        public Stack()
        {
            this.Items = new List<T>();
        }

        public void Push(params T[] elements)
        {
            this.Items.AddRange(elements);
        }

        public T Pop()
        {
            if (this.Items.Count == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }
            else
            {
                T element = this.Items[this.Items.Count - 1];
                this.Items.RemoveAt(this.Items.Count - 1);
                return element;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Items.Count - 1; i >= 0; i--)
            {
                yield return this.Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
