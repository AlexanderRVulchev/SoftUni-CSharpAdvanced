using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private readonly List<Pet> data;

        public int Capacity { get; set; }
        public int Count { get { return this.data.Count; } }

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }

        public void Add(Pet pet)
        {
            if (this.Count < this.Capacity) this.data.Add(pet);
        }

        public bool Remove(string name)
            => this.data.Remove(this.data.Find(p => p.Name == name));

        public Pet GetPet(string name, string owner)
            => this.data.Find(p => p.Name == name && p.Owner == owner);

        public Pet GetOldestPet()
            => this.data.OrderByDescending(p => p.Age).FirstOrDefault();

        public string GetStatistics()
            => $"The clinic has the following patients:" + Environment.NewLine +
            string.Join(Environment.NewLine, this.data.Select(p => $"Pet {p.Name} with owner: {p.Owner}"));
    }
}
