using System;


namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        private T boxValue;

        public T BoxValue { get { return boxValue; } set { boxValue = value; } }

        public Box(T entry)
        {
            boxValue = entry;
        }

        public override string ToString() =>        
        $"{this.BoxValue.GetType()}: {this.BoxValue}";        
    }
}
