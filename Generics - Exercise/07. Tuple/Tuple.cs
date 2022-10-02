using System;


namespace Tuple
{
    public class Tuple<T1, T2>
    {
        private T1 first;
        private T2 second;

        public T1 First { get { return first; } set { first = value; } }
        public T2 Second { get { return second; } set { second = value; } }

        public Tuple(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        }

        public override string ToString() =>
            $"{this.first} -> {this.second}";        
    }
}