using System;


namespace StreetRacing
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int HorsePower { get; set; }
        public double Weight { get; set; }

        public Car(string make, string model, string licensePlate, int horsePower, double weight)
        {
            this.Weight = weight;
            this.Make = make;
            this.Model = model;
            this.LicensePlate = licensePlate;
            this.HorsePower = horsePower;
        }

        public override string ToString()
            => $"Make: {this.Make}" + Environment.NewLine +
               $"Model: {this.Model}" + Environment.NewLine +
               $"License Plate: {this.LicensePlate}" + Environment.NewLine +
               $"Horse Power: {this.HorsePower}" + Environment.NewLine +
               $"Weight: {this.Weight}";
    }
}