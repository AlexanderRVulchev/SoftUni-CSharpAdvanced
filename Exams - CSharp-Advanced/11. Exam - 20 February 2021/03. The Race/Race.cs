using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.data.Count; } }

        public Race(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Racer>();
        }

        public void Add(Racer Racer)
        {
            if (this.Count < this.Capacity)
                this.data.Add(Racer);
        }

        public bool Remove(string name)
            => this.data.Remove(this.data.Find(r => r.Name == name));

        public Racer GetOldestRacer()
            => this.data.OrderByDescending(r => r.Age).First();

        public Racer GetRacer(string name)
            => this.data.Find(r => r.Name == name);

        public Racer GetFastestRacer()
            => this.data.OrderByDescending(r => r.Car.Speed).First();

        public string Report()
            => $"Racers participating at {this.Name}:" +
               Environment.NewLine +
               String.Join(Environment.NewLine, this.data);
    }
}
