using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
     class Book
    {
 
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year} - {string.Join(", ", this.Authors)}";
        }
    }
}
