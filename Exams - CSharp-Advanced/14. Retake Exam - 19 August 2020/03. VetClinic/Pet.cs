using System;


namespace VetClinic
{
    public class Pet
    {        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }

        public Pet(string name, int age, string owner)
        {
            this.Age = age;
            this.Owner = owner;
            this.Name = name;
        }

        public override string ToString()
            => $"Name: {this.Name} Age: {this.Age} Owner: {this.Owner}";
    }
}
