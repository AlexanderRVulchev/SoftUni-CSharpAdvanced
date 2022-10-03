using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class Library
    {
        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }
    }
}
