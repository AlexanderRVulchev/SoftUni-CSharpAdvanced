using IteratorsAndComparators;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            int result = x.Title.CompareTo(y.Title);
            if (result == 0)
                result = y.Year.CompareTo(x.Year);
            return result;
        }
    }
}
