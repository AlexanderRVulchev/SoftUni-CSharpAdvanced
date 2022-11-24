using System;
using System.Collections.Generic;
using System.Linq;


namespace StreetRacing
{
    public class Race
    {
        public List<Car> Participants { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count { get { return this.Participants.Count; } }

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.Participants = new List<Car>();
        }

        public void Add(Car car)
        {
            if (!this.Participants.Any(c => c.LicensePlate == car.LicensePlate) &&
                this.Count < this.Capacity &&
                this.MaxHorsePower >= car.HorsePower)
                this.Participants.Add(car);
        }

        public bool Remove(string licensePlate)
            => this.Participants.Remove(this.Participants.Find(c => c.LicensePlate.Equals(licensePlate)));

        public Car FindParticipant(string licensePlate)
            => this.Participants.Find(c => c.LicensePlate.Equals(licensePlate));

        public Car GetMostPowerfulCar()
            => this.Participants.OrderByDescending(c => c.HorsePower).FirstOrDefault();

        public string Report()
            => $"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})" +
               Environment.NewLine +
               string.Join(Environment.NewLine, this.Participants);
    }
}
