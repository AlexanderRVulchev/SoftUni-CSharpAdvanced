using System;


namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            double fuelToUse = distance * FuelConsumptionPerKilometer;
            if (this.FuelAmount - fuelToUse < 0)
                Console.WriteLine("Insufficient fuel for the drive");
            else
            {
                this.FuelAmount -= fuelToUse;
                this.TravelledDistance += distance;
            }
        }

        public override string ToString()
        => $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
    }
}
