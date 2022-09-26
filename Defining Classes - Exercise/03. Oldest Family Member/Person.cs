using System;


namespace DefiningClasses
{
    public class Person
    {
        // Fields
        private string name;
        private int age;

        // Properties
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        // Constructors
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age) 
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }

        // Methods
        public override string ToString()        
            => $"{this.Name} {this.Age}";        
    }
}
