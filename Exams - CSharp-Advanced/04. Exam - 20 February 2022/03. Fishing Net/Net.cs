using System;
using System.Collections.Generic;
using System.Linq;


namespace FishingNet
{
    public class Net
    {
        private readonly List<Fish> fish;

        public List<Fish> Fish { get { return this.fish; } }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.fish.Count; } }

        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.fish = new List<Fish>();
        }

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) ||
                fish.Length <= 0 ||
                fish.Weight <= 0)
                return "Invalid fish.";
            if (this.Count == this.Capacity)
                return "Fishing net is full.";
            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
            => this.Fish.Remove(this.Fish.Find(f => f.Weight == weight));

        public Fish GetFish(string fishType)
            => this.Fish.Find(f => f.FishType == fishType);

        public Fish GetBiggestFish()
            => this.Fish.OrderByDescending(f => f.Length).First();

        public string Report()
            => $"Into the {this.Material}:" +
            Environment.NewLine +
            string.Join(Environment.NewLine, this.Fish.OrderByDescending(f => f.Length));
    }
}
