using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryOpenning
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Employee(string name, int age, string country)
        {
            this.Age = age;
            this.Country = country;
            this.Name = name;
        }

        public override string ToString()
            => $"Employee: {this.Name}, {this.Age} ({this.Country})";
    }
}
