using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private int position;

        public List<int> Stones;

        public Lake(int[] stones)
        {
            this.Stones = new List<int>(stones);
            this.position = 0;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Stones.Count; i++)
            {
                int current = this.Stones[position];
                if (this.position % 2 == 0) this.position += 2;
                else if (this.position % 2 == 1) this.position -= 2;

                if (this.position == this.Stones.Count)
                    this.position--;
                else if (this.position > this.Stones.Count)
                    this.position -= 3;

                yield return current;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
