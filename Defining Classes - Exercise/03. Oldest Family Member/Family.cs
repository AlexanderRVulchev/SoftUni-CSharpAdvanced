using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        // Fields
        private List<Person> people;

        // Properties
        public List<Person> People { get { return people; } set { people = value; } }

        // Constructors
        public Family()
        {
            this.People = new List<Person>();
        }

        // Methods
        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember()
            => this.People.OrderByDescending(p => p.Age).First();
    }
}
