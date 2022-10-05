using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main()
        {
            HashSet<Person> hashPeople = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] info = Console.ReadLine().Split();
                hashPeople.Add(new Person(info[0], int.Parse(info[1])));
                sortedPeople.Add(new Person(info[0], int.Parse(info[1])));
            }
            Console.WriteLine(hashPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}
