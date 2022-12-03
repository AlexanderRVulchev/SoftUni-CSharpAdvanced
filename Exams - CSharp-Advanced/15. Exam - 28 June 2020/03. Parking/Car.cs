using System;

namespace Parking
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string manufacturer, string model, int year)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Year = year;
        }

        public override string ToString()
            => $"{this.Manufacturer} {this.Model} ({this.Year})";
    }
}
