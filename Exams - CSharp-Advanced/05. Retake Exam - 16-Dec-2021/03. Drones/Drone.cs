using System;

namespace Drones
{
    public class Drone
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Available { get; set; }

        public Drone(string name, string brand, int range)
        {
            this.Available = true;
            this.Name = name;
            this.Brand = brand;
            this.Range = range;
        }

        public override string ToString()
         => $"Drone: {this.Name}" + Environment.NewLine +
            $"Manufactured by: {this.Brand}" + Environment.NewLine +
            $"Range: {this.Range} kilometers";
    }
}
