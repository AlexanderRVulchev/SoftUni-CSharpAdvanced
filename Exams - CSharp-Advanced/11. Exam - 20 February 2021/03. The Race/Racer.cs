using System;
using System.Collections.Generic;
using System.Text;

namespace TheRace
{
    public class Racer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Car Car { get; set; }

        public Racer(string name, int age, string country, Car car)
        {
            this.Car = car;
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public override string ToString()
            => $"Racer: {this.Name}, {this.Age} ({this.Country})";
    }
}
