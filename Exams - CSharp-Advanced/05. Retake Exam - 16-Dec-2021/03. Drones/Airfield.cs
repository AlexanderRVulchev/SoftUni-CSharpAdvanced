using System;
using System.Collections.Generic;
using System.Linq;

namespace Drones
{
    public class Airfield
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public int Count { get { return Drones.Count; } }
        public List<Drone> Drones { get; set; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public string AddDrone(Drone drone)
        {
            if (drone.Name == string.Empty || drone.Brand == string.Empty ||
                drone.Name == null || drone.Brand == null ||
                drone.Range < 5 || drone.Range > 15)
                return "Invalid drone.";

            if (this.Count == Capacity)
                return "Airfield is full.";

            this.Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            Drone droneToRemove = this.Drones.Find(x => x.Name == name);
            return this.Drones.Remove(droneToRemove);
        }

        public int RemoveDroneByBrand(string brand)
        {
            return this.Drones.RemoveAll(d => d.Brand == brand);
        }

        public Drone FlyDrone(string name)
        {
            Drone droneToFly = this.Drones.Find(d => d.Name == name);
            if (droneToFly != null)
                droneToFly.Available = false;
            return droneToFly;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> dronesToFly = this.Drones.Where(d => d.Range >= range).ToList();
            foreach (Drone drone in dronesToFly)
                this.FlyDrone(drone.Name);

            return dronesToFly;
        }

        public string Report()
             => $"Drones available at {this.Name}:" +
                Environment.NewLine +
                String.Join(Environment.NewLine, this.Drones.Where(d => d.Available));
    }
}
