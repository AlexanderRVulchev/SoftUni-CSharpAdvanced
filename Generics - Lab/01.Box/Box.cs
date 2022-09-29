using System;
using System.Collections.Generic;


namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> elements = new Stack<T>();

        public int Count { get { return elements.Count; } }

        public void Add(T element)
        {
            this.elements.Push(element);
        }

        public T Remove()
        {
            return this.elements.Pop();
        }
    }
}
