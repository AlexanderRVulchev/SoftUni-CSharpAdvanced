using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodString
{
    public class Box<T>
    {
        private T boxValue;

        public T BoxValue { get { return boxValue; } set { boxValue = value; } }

        public Box(T entry)
        {
            this.boxValue = entry;
        }

        public static int GetCountOfLargerElements(List<Box<T>> list, T item)
        {            
            Comparer<T> comparer = Comparer<T>.Default;            
            int result = list.Where(x => comparer.Compare(x.BoxValue, item) > 0).ToList().Count;
            return result;
        }
    }
}
