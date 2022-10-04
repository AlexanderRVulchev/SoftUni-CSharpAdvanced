using System;
using System.Collections.Generic;


namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private int currentIndex;

        public List<T> Elements;
        
        public ListyIterator(params T[] entries)
        {
            this.Elements = new List<T>(entries);
            this.currentIndex = 0;
        }

        public bool Move()
        {
            if (this.currentIndex < this.Elements.Count - 1)
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            return this.currentIndex < this.Elements.Count - 1;
        }

        public void Print()
        {
            if (this.Elements.Count != 0)
                Console.WriteLine(this.Elements[currentIndex]);
            else
                Console.WriteLine("Invalid Operation!");
        }
    }
}
