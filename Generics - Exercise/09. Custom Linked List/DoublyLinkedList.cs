using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> NextNode { get; set; }
            public Node<T> PreviousNode { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }

        private Node<T> head;

        private Node<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            Node<T> newHead = new Node<T>(element);

            if (Count == 0)
            {
                this.head = this.tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }

        public void AddLast(T element)
        {
            Node<T> newTail = new Node<T>(element);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T firstElement = head.Value;
            this.head = this.head.NextNode;
            if (this.head != null)
                this.head.PreviousNode = null;
            else
                this.tail = null;

            this.Count--;
            return firstElement;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T lastElement = tail.Value;
            this.tail = this.tail.PreviousNode;

            if (this.tail != null)
                this.tail.NextNode = null;
            else
                this.head = null;

            this.Count--;
            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            Node<T> current = this.head;

            while (current != null)
            {
                action(current.Value);
                current = current.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            Node<T> node = head;
            for (int i = 0; i < Count; i++)
            {
                array[i] = node.Value;
                node = node.NextNode;
            }
            return array;
        }
    }
}