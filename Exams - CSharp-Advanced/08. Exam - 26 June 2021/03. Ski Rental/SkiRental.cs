using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private readonly List<Ski> skis;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return skis.Count; } }

        public SkiRental(string name, int capacity)
        {
            this.skis = new List<Ski>();
            this.Capacity = capacity;
            this.Name = name;
        }


        public void Add(Ski ski)
        { if (this.skis.Count < this.Capacity) this.skis.Add(ski); }

        public bool Remove(string manufacturer, string model)
            => this.skis.Remove(this.skis.Find(s => s.Manufacturer == manufacturer && s.Model == model));

        public Ski GetNewestSki()
            => this.skis.OrderByDescending(s => s.Year).FirstOrDefault();

        public Ski GetSki(string manufacturer, string model)
            => this.skis.Find(s => s.Manufacturer == manufacturer && s.Model == model);
                
        public string GetStatistics()
                => $"The skis stored in {this.Name}:" + Environment.NewLine +
                   string.Join(Environment.NewLine, this.skis);
    }
}
